using System;
using System.Collections.Generic;
using System.Linq;

namespace EFatura.Core.Domain
{
    public sealed class Invoice
    {
        private readonly List<InvoiceLine> _lines;

        public Invoice(Guid id, string invoiceNumber, InvoiceType invoiceType, Party sender, Party receiver, IEnumerable<InvoiceLine> lines)
        {
            if (lines == null)
            {
                throw new ArgumentNullException(nameof(lines));
            }

            Id = id;
            InvoiceNumber = invoiceNumber;
            InvoiceType = invoiceType;
            Sender = sender;
            Receiver = receiver;
            _lines = new List<InvoiceLine>(lines);
            CreatedAtUtc = DateTime.UtcNow;
            Status = InvoiceStatus.Draft;
            ExternalReference = string.Empty;
        }

        public Guid Id { get; }

        public string InvoiceNumber { get; }

        public InvoiceType InvoiceType { get; }

        public Party Sender { get; }

        public Party Receiver { get; }

        public DateTime CreatedAtUtc { get; }

        public InvoiceStatus Status { get; private set; }

        public string ExternalReference { get; private set; }

        public IReadOnlyList<InvoiceLine> Lines => _lines;

        public TaxSummary TaxSummary => new TaxSummary(
            _lines.Sum(x => x.LineNetTotal),
            _lines.Sum(x => x.VatAmount),
            0);

        public void Approve()
        {
            EnsureStatus(InvoiceStatus.Draft);
            Status = InvoiceStatus.Approved;
        }

        public void MarkSent(string externalReference)
        {
            EnsureStatus(InvoiceStatus.Approved);
            ExternalReference = externalReference;
            Status = InvoiceStatus.Sent;
        }

        public void MarkDelivered()
        {
            EnsureStatus(InvoiceStatus.Sent);
            Status = InvoiceStatus.Delivered;
        }

        public void Reject()
        {
            if (Status != InvoiceStatus.Sent && Status != InvoiceStatus.Approved)
            {
                throw new InvalidOperationException("Only approved or sent invoices can be rejected.");
            }

            Status = InvoiceStatus.Rejected;
        }

        private void EnsureStatus(InvoiceStatus expected)
        {
            if (Status != expected)
            {
                throw new InvalidOperationException("Invalid invoice state transition.");
            }
        }
    }
}
