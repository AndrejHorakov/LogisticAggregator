using LogisticAggregatorApp;
using LogisticAggregatorApp.Transport;

var providers = new Dictionary<TransportType, ITransportProvider>
{
    [TransportType.Air] = new AirProvider(),
    [TransportType.Train] = new TrainProvider(),
    [TransportType.Truck] = new TruckProvider()
};

var aggregator = new LogisticsAggregator(providers);
Console.WriteLine(aggregator.GetQuote(TransportType.Truck, 3010, 50));
