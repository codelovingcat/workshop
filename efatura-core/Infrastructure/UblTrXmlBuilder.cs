using System.Security;
using System.Text;
using EFatura.Core.Application;
using EFatura.Core.Domain;

namespace EFatura.Core.Infrastructure
{
    public sealed class UblTrXmlBuilder : IUblTrXmlBuilder
    {
        public string Build(Invoice invoice)
        {
            var tax = invoice.TaxSummary;
            var sb = new StringBuilder();
            sb.Append("<Invoice>");
            sb.AppendFormat("<InvoiceNumber>{0}</InvoiceNumber>", Escape(invoice.InvoiceNumber));
            sb.AppendFormat("<Type>{0}</Type>", invoice.InvoiceType);
            sb.AppendFormat("<SenderTaxNumber>{0}</SenderTaxNumber>", Escape(invoice.Sender.TaxNumber));
            sb.AppendFormat("<ReceiverTaxNumber>{0}</ReceiverTaxNumber>", Escape(invoice.Receiver.TaxNumber));
            sb.AppendFormat("<NetAmount>{0:0.00}</NetAmount>", tax.NetAmount);
            sb.AppendFormat("<VatAmount>{0:0.00}</VatAmount>", tax.VatAmount);
            sb.AppendFormat("<GrandTotal>{0:0.00}</GrandTotal>", tax.GrandTotal);
            sb.Append("</Invoice>");
            return sb.ToString();
        }

        private static string Escape(string value)
        {
            return SecurityElement.Escape(value ?? string.Empty) ?? string.Empty;
        }
    }
}
