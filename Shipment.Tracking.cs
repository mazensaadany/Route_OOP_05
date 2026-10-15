namespace Route_OOP_05;

public partial class Shipment
{
    #region fields
    private string? trackingCode;
    #endregion

    #region properties
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
    public string TrackingStatus { get; set; }
    #endregion

    #region methods
    public string GetTrackingStatus()
    {
        return string.IsNullOrWhiteSpace(TrackingStatus) ? "Unknown" : TrackingStatus;
    }

    partial void OnTrackingStatusChanged(string newStatus)
    {
        Console.WriteLine($"Tracking status changed to: {newStatus}");
    }

    public void UpdateTrackingStatus(string newStatus)
    {
        if (!string.IsNullOrWhiteSpace(newStatus))
        {
            TrackingStatus = newStatus;

            OnTrackingStatusChanged(newStatus);
        }
    }
    #endregion
}
