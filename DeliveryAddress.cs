namespace Route_OOP_05;

public struct DeliveryAddress
{
    private string? city;
    private string? street;
    private int buildingNumber;

    public DeliveryAddress(string city,string street,int buildNum)
    {
        City = city;
        Street = street;
        BuildingNumber = buildNum;
    }

    public string GetfullAdress()
    {
        return $"City: {City}| Street: {Street}| Building: {BuildingNumber}";
    }


    public string? City { get; set; }

    public string? Street { get; set; }

    public int BuildingNumber 
    {
        get => buildingNumber;

        set
        {
                       if(value > 0)
                buildingNumber = value;
        }
    }
}