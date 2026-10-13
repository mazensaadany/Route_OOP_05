namespace Route_OOP_05;
public abstract class Shipment
{
    #region fields
    private string? trackingCode;
    private string? description;
    private decimal weight;
    private decimal deliveryFee;
    #endregion

    #region constructors

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

    public abstract decimal EstimatedCost { get; }
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

    public abstract void PrintShipment();

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
   
    //public Shipment CopyShipment()
    //{
        
    //}
    #endregion
}

