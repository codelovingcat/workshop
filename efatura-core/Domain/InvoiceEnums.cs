namespace EFatura.Core.Domain
{
    public enum InvoiceType
    {
        EInvoice = 1,
        EArchive = 2
    }

    public enum InvoiceStatus
    {
        Draft = 1,
        Approved = 2,
        Sent = 3,
        Delivered = 4,
        Rejected = 5
    }
}
