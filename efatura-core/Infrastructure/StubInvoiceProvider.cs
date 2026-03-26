using System;
using EFatura.Core.Application;
using EFatura.Core.Domain;

namespace EFatura.Core.Infrastructure
{
    public sealed class StubInvoiceProvider : IInvoiceProvider
    {
        public string Send(Invoice invoice, string ublTrXml)
        {
            return string.Format("GIB-{0}", invoice.Id.ToString("N").Substring(0, 12).ToUpperInvariant());
        }
    }
}
