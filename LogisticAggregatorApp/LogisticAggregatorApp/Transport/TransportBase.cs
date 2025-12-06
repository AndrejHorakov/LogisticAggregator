namespace LogisticAggregatorApp.Transport;

public abstract class TransportBase: ITransportProvider
{
    protected decimal BaseRate { get; init; }
    protected double Speed { get; init; }
    public virtual (decimal, double) Calculate(double distance, double weight)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Скорость: {Speed}";
    }
}