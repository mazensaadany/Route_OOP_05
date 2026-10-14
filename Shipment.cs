namespace Route_OOP_05;
public class Shipment
{
    #region fields
    private string? trackingCode;
    private string? description;
    private decimal weight;
    private decimal deliveryFee;
    #endregion

    #region constructors
    public Shipment()
    {
        TrackingCode = null;
        Description = "unKnown";
        Weight = 1;
        DeliveryFee = 50;
        Destination = new DeliveryAddress();
    }

    public Shipment(string track)
    {
        TrackingCode = track;
        Description = "unKnown";
        Weight = 1;
        DeliveryFee = 50;
        Destination= new DeliveryAddress();
    }

    public Shipment(string track, string desc, decimal w8, decimal fee, DeliveryAddress Dest)
    {
        TrackingCode = track;
        Description = desc;
        Weight = fee;
        DeliveryFee = fee;
        Destination= Dest;
    }
    #endregion

    #region properties

    public DeliveryAddress? Destination { get; set; }

    public string? TrackingCode
    {
        get
        {
            return trackingCode;
        }

        set
        {
            if (value != null && value != "" && value != " ")
            {
                trackingCode = value;
            }
        }
    }

    public string Description
    {
        get
        {
            return description!;
        }

        set 
        {
            if (value != null && value != "" && value != " ")
            {
                 description = value;
            }
        }
    }

    public decimal Weight
    {
        get 
        {
            return weight;
        }
        set 
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }
           
    public decimal DeliveryFee
    {
        get
        {
            return deliveryFee;
        }
        set 
        {
            if (value>0)
            {
                deliveryFee = value; 
            }
 
        }
    }

    public virtual decimal EstimatedCost { get; }
    #endregion

    #region methods
    public decimal UpdateDeliveryFee(int newFee)
    {
        if (newFee > 0)
        {
            DeliveryFee = newFee;
        }

        return DeliveryFee;
    }

    public virtual void PrintShipment()
    {
        Console.WriteLine($"Destination is :{Destination}");
        Console.WriteLine($"Tracking code : {TrackingCode}");
        Console.WriteLine($"Description : {Description}");
        Console.WriteLine($"Weight : {Weight}");
        Console.WriteLine($"Delivery Fee : {DeliveryFee}");
        Console.WriteLine($"Estimated Cost : {EstimatedCost}");
        Console.WriteLine("================================");
    }

    public void Weight_update(decimal newWeight)
    {
        if (newWeight > 0)
        {
            Weight = newWeight;
        }
    }

    public void Weight_update(decimal newWeight,decimal extraPack)
    {
        if (newWeight > 0 && extraPack > 0)
        {
            Weight = newWeight + extraPack;
        }
    }

    public Shipment CopyShipment()
    {
        return new Shipment
        {
            TrackingCode=this.TrackingCode,
            Description =this.Description,
            Weight =this.Weight,
        };
    }

    public Shipment ShallowCopy() => (Shipment)this.MemberwiseClone();

    public Shipment DeepCopy()
    {
        Shipment CopiedShipment = (Shipment)this.MemberwiseClone();
        if (this.Destination != null)
        {
            CopiedShipment.Destination = new DeliveryAddress
            {
                City = this.Destination.City,
                Street = this.Destination.Street,
                BuildingNumber = this.Destination.BuildingNumber
            };
        }
        return CopiedShipment;
    }
    #endregion
}

