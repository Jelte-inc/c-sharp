using cheraasje_epp.Models.ValueObjects;

public class PriceRange
{
    public Money Min { get; }
    public Money Max { get; }

    public PriceRange(Money min, Money max)
    {
        Min = min;
        Max = max;
    }

    public PriceRange(decimal min, decimal max)
        : this(new Money(min), new Money(max))
    {
    }

    public override string ToString()
        => $"{Min.Amount:N0} - {Max.Amount:N0}";

    public string ToFilterLabel()
    {
        return $"{Min.Amount / 1000:0}k–{Max.Amount / 1000:0}k";
    }
}