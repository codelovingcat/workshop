using System;
using EFatura.Core.Domain;

namespace EFatura.Core.Application
{
    public sealed class InvoiceWorkflowService
    {
        private readonly IInvoiceRepository _repository;
        private readonly IInvoiceProvider _provider;
        private readonly IUblTrXmlBuilder _xmlBuilder;
        private readonly IAuditTrail _audit;

        public InvoiceWorkflowService(IInvoiceRepository repository, IInvoiceProvider provider, IUblTrXmlBuilder xmlBuilder, IAuditTrail audit)
        {
            _repository = repository;
            _provider = provider;
            _xmlBuilder = xmlBuilder;
            _audit = audit;
        }

        public Invoice CreateDraft(string invoiceNumber, InvoiceType type, Party sender, Party receiver, InvoiceLine[] lines)
        {
            var invoice = new Invoice(Guid.NewGuid(), invoiceNumber, type, sender, receiver, lines);
            _repository.Save(invoice);
            _audit.Write(invoice.Id, "DraftCreated", invoice.InvoiceNumber);
            return invoice;
        }

        public void Approve(Guid invoiceId)
        {
            var invoice = RequireInvoice(invoiceId);
            invoice.Approve();
            _repository.Save(invoice);
            _audit.Write(invoice.Id, "Approved", invoice.InvoiceNumber);
        }

        public string Send(Guid invoiceId)
        {
            var invoice = RequireInvoice(invoiceId);
            if (!string.IsNullOrEmpty(invoice.ExternalReference))
            {
                return invoice.ExternalReference;
            }

            var xml = _xmlBuilder.Build(invoice);
            var externalReference = _provider.Send(invoice, xml);
            invoice.MarkSent(externalReference);
            _repository.Save(invoice);
            _audit.Write(invoice.Id, "Sent", externalReference);
            return externalReference;
        }

        public void MarkDelivery(Guid invoiceId, bool delivered)
        {
            var invoice = RequireInvoice(invoiceId);
            if (delivered)
            {
                invoice.MarkDelivered();
                _audit.Write(invoice.Id, "Delivered", invoice.ExternalReference);
            }
            else
            {
                invoice.Reject();
                _audit.Write(invoice.Id, "Rejected", invoice.ExternalReference);
            }

            _repository.Save(invoice);
        }

        private Invoice RequireInvoice(Guid invoiceId)
        {
            var invoice = _repository.GetById(invoiceId);
            if (invoice == null)
            {
                throw new InvalidOperationException("Invoice not found.");
            }

            return invoice;
        }
    }
}
