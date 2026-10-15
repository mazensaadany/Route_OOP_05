namespace Route_OOP_05;

public static class ShipmentExtensions 
{
    #region methods
    public static string GetSummary(this Shipment shipment)
    {
        string status= shipment.GetTrackingStatus();
        return $"{shipment.TrackingCode},{shipment.ShipmentType},{shipment.Weight},{status}";
    }

    public static bool IsDelivered(this Shipment shipment)
    {
        return string.Equals(shipment.TrackingStatus, "Delivered", StringComparison.OrdinalIgnoreCase);
    }
    #endregion
}
