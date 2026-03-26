using System;
using System.Collections.Generic;
using System.Linq;
using EFatura.Core.Application;
using EFatura.Core.Domain;

namespace EFatura.Core.Infrastructure
{
    public sealed class InMemoryInvoiceRepository : IInvoiceRepository
    {
        private readonly Dictionary<Guid, Invoice> _storage = new Dictionary<Guid, Invoice>();

        public Invoice GetById(Guid invoiceId)
        {
            Invoice invoice;
            return _storage.TryGetValue(invoiceId, out invoice) ? invoice : null;
        }

        public Invoice GetByExternalReference(string externalReference)
        {
            return _storage.Values.FirstOrDefault(x => x.ExternalReference == externalReference);
        }

        public void Save(Invoice invoice)
        {
            _storage[invoice.Id] = invoice;
        }
    }
}
