namespace Route_OOP_05;
public class DeliveryCenter
{
    #region fields
    private string? centerName;
    private Shipment[] shipments;
    #endregion

    #region constructors
    public DeliveryCenter()
    {
        shipments = new Shipment[20];
    }
    #endregion

    #region properties
    public string? CenterName
    {
        get
        {
            return centerName;
        }
        set
        {
            if (value != null && value != "" && value != " ")
            {
                centerName = value;
            }
        }
    }

     public Driver? AssignedDriver { get; set; }
    #endregion

    #region indexers
    public Shipment? this[int position]
    {
        get
        {
            if (position > 0 && position < 10)
            {
                return shipments[position];
            }
            return default;
        }

        set
        {
            if (position > 0 && position < 10)
            {
                shipments[position] = value!;
            }
        }
    }

    public Shipment? this[string tracingcode]
    {
        get
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i].TrackingCode == tracingcode)
                {
                    return shipments[i];
                }
            }
            return default;
        }
    }
    #endregion

    #region methods
    public bool AddShipment(Shipment newShipment)
    {
        for (int i = 0; i < 10; i++)
        {
            if (shipments[i].TrackingCode == null)
            {
                shipments[i] = newShipment;
                Console.WriteLine("Shipment added successfully.");
                return true;
            }
        }
        return false;
    }

    public bool RemoveShipment(string trackingCode) 
    {
        for (int i = 0; i < shipments.Length; i++)
        {
            if (shipments[i] != null && shipments[i].TrackingCode == trackingCode  )
            {
                for(int j = i; j < shipments.Length - 1; j++)
                {
                    shipments[j] = shipments[j + 1];
                }
                shipments[shipments.Length-1] = null!;
                return true;
            }
        }
        return false;
    }

    public void PrintAllShipments()
    {
        foreach (Shipment shipment in shipments)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
                Console.WriteLine("--------------------");
            }
        }
    }

    public void PrintTrackingStatus()
    {
        foreach (ITrackable t in shipments)
        {
            int i = 0;
            if (t != null)
            {
                Console.WriteLine($"Tracking Status{i}");
                Console.WriteLine(t.GetTrackingStatus());
                Console.WriteLine("==========================");
                i++;
            }
        }
    }

    public void PrintInsurance()
    {
        foreach (IInsurable i in shipments)
        {
            int j = 0;
            if (i != null)
            {
                Console.WriteLine($"insurance of shipment:{j}");
                Console.WriteLine(i.CalculateInsurance());
                Console.WriteLine("==========================");
                j++;
            }
        }
    }
    #endregion
}