using System;
using EFatura.Core.Domain;

namespace EFatura.Core.Application
{
    public interface IInvoiceRepository
    {
        Invoice GetById(Guid invoiceId);

        Invoice GetByExternalReference(string externalReference);

        void Save(Invoice invoice);
    }

    public interface IInvoiceProvider
    {
        string Send(Invoice invoice, string ublTrXml);
    }

    public interface IAuditTrail
    {
        void Write(Guid invoiceId, string action, string details);
    }

    public interface IUblTrXmlBuilder
    {
        string Build(Invoice invoice);
    }
}
