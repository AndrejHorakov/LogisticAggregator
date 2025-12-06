namespace LogisticAggregatorApp.Transport;

public interface ITransportProvider
{
    (decimal, double) Calculate(double distance, double weight);
}