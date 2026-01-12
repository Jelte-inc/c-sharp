namespace CheraasjeEpp.Models.ValueObjects
{
    public readonly struct Money
    {
        public decimal Amount { get; }

        public Money(decimal amount)
        {
            Amount = amount;
        }

        public override string ToString()
            => Amount.ToString("C");
    }

}
