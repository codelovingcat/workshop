using System;

namespace EFatura.Core.Domain
{
    public sealed class InvoiceLine
    {
        public InvoiceLine(string description, decimal quantity, decimal unitPrice, decimal vatRate)
        {
            if (quantity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity));
            }

            if (unitPrice < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(unitPrice));
            }

            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            VatRate = vatRate;
        }

        public string Description { get; }

        public decimal Quantity { get; }

        public decimal UnitPrice { get; }

        public decimal VatRate { get; }

        public decimal LineNetTotal => Quantity * UnitPrice;

        public decimal VatAmount => LineNetTotal * VatRate;
    }
}
