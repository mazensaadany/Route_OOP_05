namespace Route_OOP_05;
public class ExpressShipment:Shipment, IInsurable, ITrackable
{

    private decimal extraFee;

    #region constructors
    public ExpressShipment(): base(string.Empty, string.Empty, 0m, 0m, default)
    {
    }

    public ExpressShipment(string track, string desc, decimal w8, decimal fee, DeliveryAddress Dest,decimal exFee) : base(track, desc,w8,fee,Dest)
    {
        ExtraFee = exFee;
    }
    #endregion

    #region properties
    public decimal ExtraFee 
    {
        get
        {
            ExtraFee = extraFee;
            return ExtraFee;
        }

        set
        {
            if(value >= 0) 
                ExtraFee = value;
        }
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5)+ExtraFee; }

    }

    public override string ShipmentType => "Express";
    #endregion

    #region methods
    public override void PrintShipment()
    {
        Console.WriteLine("Express Shipment Details:");
        Console.WriteLine($"Destination is :{Destination}");
        Console.WriteLine($"Tracking code : {TrackingCode}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Weight : {Weight}");
        Console.WriteLine($"Delivery Fee : {DeliveryFee}");
        Console.WriteLine($"Extra Fee: {ExtraFee:C}");
        Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        Console.WriteLine("================================");
    }

    public string GetTrackingStatus()
    {
        return "Shipment 'SH02' is out for delivering";
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.08m; // 8% of the estimated cost
    }
    #endregion
}