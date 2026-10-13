namespace Route_OOP_05;

public class PriorityInternationalShipment : InternationalShipment
{
    #region constructors
    public PriorityInternationalShipment() : base(string.Empty, string.Empty, 0m, 0m, default, string.Empty, 0m)
    {
    }
    #endregion

    #region methods
    public sealed override void GenerateCustomsReport()
    {
        base.GenerateCustomsReport();
    }
    #endregion
}

