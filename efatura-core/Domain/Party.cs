namespace EFatura.Core.Domain
{
    public sealed class Party
    {
        public Party(string name, string taxNumber)
        {
            Name = name;
            TaxNumber = taxNumber;
        }

        public string Name { get; }

        public string TaxNumber { get; }
    }
}
