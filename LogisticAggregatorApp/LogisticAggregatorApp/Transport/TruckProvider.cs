namespace LogisticAggregatorApp.Transport;

public class TruckProvider : TransportBase
{
    public TruckProvider()
    {
        BaseRate = 25m;
        Speed = 110d;
    }
    public override (decimal, double) Calculate(double distance, double weight)
    {
        var currentSpeed = Speed;
        var hours = 0d;
        while (distance > 0)
        {
            if (distance < 500)
            {
                hours += distance / currentSpeed;
                break;
            }
            hours += 500 / currentSpeed;
            distance -= 500;
            currentSpeed = Math.Max(currentSpeed - 10, 40);
        }
        
        var cost = (decimal)hours * BaseRate;
        return (cost, hours);
    }
    
    public override string ToString()
    {
        return $"Дальнобойные, {base.ToString()}";
    }
}