namespace Route_OOP_05;

public sealed class CompletedShipment : Shipment
{
    #region constructors
    public CompletedShipment() : base(string.Empty, string.Empty, 0m, 0m, default)
    {
    }

    public override decimal EstimatedCost => throw new NotImplementedException();

    public override void PrintShipment()
    {
        throw new NotImplementedException();
    }
    #endregion
}

