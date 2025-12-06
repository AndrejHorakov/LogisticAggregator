using LogisticAggregatorApp.Transport;

namespace LogisticAggregatorApp;

public class LogisticsAggregator
{
    private readonly Dictionary<TransportType, ITransportProvider> _providers;
    private readonly List<string> _history;
    
    public LogisticsAggregator(Dictionary<TransportType, ITransportProvider>  providers)
    {
        _providers = providers;
        _history = new List<string>();
    }

    public (decimal, double) GetQuote(TransportType type, double distance, double weight)
    {
        var (cost, hours) = _providers[type].Calculate(distance, weight);
        var historyRecord = $"{_providers[type]}, время: {hours}, стоимость: {cost}";
        _history.Add(historyRecord);
        return (cost, hours);
    }
}