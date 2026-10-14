namespace Route_OOP_05;

public class StandardShipment : Shipment, IInsurable, ITrackable
{
    #region constructors
    public StandardShipment(): base(string.Empty, string.Empty, 0m, 0m, default!)
    {
    }

    public StandardShipment(string track, string desc, decimal w8, decimal fee, DeliveryAddress Dest) : base(track, desc, w8, fee, Dest)
    {
    }
    #endregion

    #region properties
    public override decimal EstimatedCost
    {
        get 
        {
            return DeliveryFee + (Weight * 5);
        }
    }
    #endregion

    #region methods
    public override void PrintShipment()
    {
        Console.WriteLine("Standard Shipment Details:");
        Console.WriteLine($"Destination is :{Destination}");
        Console.WriteLine($"Tracking code : {TrackingCode}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Weight : {Weight}");
        Console.WriteLine($"Delivery Fee : {DeliveryFee}");
        Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        Console.WriteLine("================================");
    }

    public string GetTrackingStatus()
    {
        return "Shipment 'SH01' is ready";
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.05m; // 5% of the estimated cost
    }
    #endregion
}

