namespace LogisticAggregatorApp.Transport;

public class TrainProvider : TransportBase
{
    private readonly decimal _fixPriceLoad;
    public TrainProvider(decimal fixPriceLoad = 100m)
    {
        _fixPriceLoad = fixPriceLoad;
        BaseRate = 30m;
        Speed = 200d;
    }

    public override (decimal, double) Calculate(double distance, double weight)
    {
        var hours = distance / Speed;
        var cost = _fixPriceLoad + BaseRate * (decimal)hours;
        return (cost, hours);
    }
    
    public override string ToString()
    {
        return $"Ж/Д перевозки, {base.ToString()}";
    }
}