namespace EFatura.Core.Domain
{
    public sealed class TaxSummary
    {
        public TaxSummary(decimal netAmount, decimal vatAmount, decimal withholdingAmount)
        {
            NetAmount = netAmount;
            VatAmount = vatAmount;
            WithholdingAmount = withholdingAmount;
        }

        public decimal NetAmount { get; }

        public decimal VatAmount { get; }

        public decimal WithholdingAmount { get; }

        public decimal GrandTotal => NetAmount + VatAmount - WithholdingAmount;
    }
}
