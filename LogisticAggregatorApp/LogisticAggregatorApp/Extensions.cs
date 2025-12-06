using LogisticAggregatorApp.Transport;

namespace LogisticAggregatorApp;

public static class Extensions
{
    public static DateTime CalculateArrival(this ITransportProvider provider, double hours)
    {
        return DateTime.Now.AddHours(hours);
    }
}