namespace Route_OOP_05;
public class InternationalShipment:Shipment, IInsurable, ITrackable
{
    #region fields
    private string? destinationCountry;
    private decimal customsFee;
    #endregion

    #region constructors
    public InternationalShipment(string track, string desc, decimal w8, decimal fee, DeliveryAddress Dest,string destCountry,decimal customsFee) : base(track, desc,w8,fee,Dest)
    {
        DestinationCountry = destCountry;
        CustomsFee = customsFee;
    }

    public InternationalShipment(): base(string.Empty, string.Empty, 0m, 0m, default!)
    {
    }
    #endregion

    #region properties
    public string? DestinationCountry 
    {
        get=> destinationCountry;

        set
        {
             if(!string.IsNullOrWhiteSpace(value))
                destinationCountry = value;
        }
    }

    public decimal CustomsFee
    {
        get=> customsFee;

        set
        {
            if(value >= 0)
            customsFee = value;
        }
    }

    public override decimal EstimatedCost
    {
        get { return DeliveryFee + (Weight * 5) + CustomsFee; }
    }
    #endregion

    #region methods
    public override void PrintShipment()
    {
        Console.WriteLine("International Shipment Details:");
        Console.WriteLine($"Destination Country: {DestinationCountry}");
        Console.WriteLine($"Destination is :{Destination}");
        Console.WriteLine($"Tracking code : {TrackingCode}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Weight : {Weight}");
        Console.WriteLine($"Delivery Fee : {DeliveryFee}");
        Console.WriteLine($"Customs Fee: {CustomsFee:C}");
        Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        Console.WriteLine("================================");
    }

    public virtual void GenerateCustomsReport()
    {
        Console.WriteLine("Customs Report:");
    }

    public string GetTrackingStatus()
    {
        return "Shipment 'SH03' has been delivered";
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.12m; // 12% of the estimated cost
    }
    #endregion
}

