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
        var result = _providers[type].Calculate(distance, weight);
        var historyRecord = $"{_providers[type]}, время: {result.Item2}, стоимость: {result.Item1}";
        _history.Add(historyRecord);
        return result;
    }
}