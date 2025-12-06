namespace LogisticAggregatorApp.Transport;

public class AirProvider : TransportBase
{
    public AirProvider()
    {
        BaseRate = 100m;
        Speed = 400d;
    }
    public override (decimal, double) Calculate(double distance, double weight)
    {
        var hours = distance / Speed;
        var cost = BaseRate * (decimal)hours;
        if (weight > 50)
            cost *= 1.2m;
        return (cost, hours);
    }

    public override string ToString()
    {
        return $"Аэроперевозки, {base.ToString()}";
    }
}