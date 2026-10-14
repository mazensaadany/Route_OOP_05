namespace Route_OOP_05;
internal class Program
{
    static void Main(string[] args)
    {
        #region theorical 1
        // a) the second object refer the same object as the first one,
        // so if we change the value of the first object, the second one will also change.

        //b) it does not, it creates new variable but we have one object in memory.

        //c) when we copy an object, we create a new object in memory with the same values as the original one,
        //but when we copy a reference, we just create a new variable that points to the same object in memory.
        #endregion

        #region theorical 2
        //a) shallow is copying the values of value type fields of an object to another object, while copying addresses of ref type fields

        //b) deep copying is creating a new object and copying all the values of the fields(ref,val) of the original object to the new object.

        //c)address is copied to the new object

        //d) new object is created in memory and the values of the fields are copied to the new object.

        //e)when we deal with object containing modifiable data
        #endregion

        #region theorical 3
        //a) static field: variable that is shared among all instances of a class, it is not tied to any specific instance. It is used to store data that is common to all instances of the class.
        //   instance field: variable belongs to a specific object, every obj gets his own copy of this variable

        //b) static method: a method that does not need an object to be called
        //   No, it can't access instance members directly

        //c) static constructor: constructor used to implement static members in class
        //   while excuting the is been called only one time(the first use of the class in the project), its called automatically and cant be called manually

        //d) static class: declared with the static keyword, it can only contain static members and cannot be instantiated.
        //   It is used to group related methods and properties that do not require an instance of the class to be used.
        #endregion

        #region theorical 4
        //a) extension method: is a method allows us to add new features to class and be called by any object 

        //b) "this" keyword 

        //c) it should be declared in a static class 

        //d) No, bc it's considered external method
        #endregion

        #region theorical 5
        //a) partial class: a class allowed to separate and write the code across multiple files using keyword "partial"

        //b) for organizatinal reasons , allow more than one developer to work on thier own methods
        //   for same class without contingency and separate the auto code that is done by code generators from dev code

        //c) partial method: a method declared and assigned in one file then being implemented in another for the same class

        //d) if the fun is "void" the complier removes the fun calls and declares as it never happened
        //   else a complier error happens
        #endregion
        //*************************************//

        #region practical 1
        StandardShipment ship01 = new StandardShipment()
        {
            TrackingCode = "sh01",
            Description = "phone"
        };
        Shipment ship02 = ship01;
        Shipment copiedShip = ship01.CopyShipment();

        Console.WriteLine("==========================================");
        Console.WriteLine("Object Copying");
        Console.WriteLine("==========================================");
        Console.WriteLine($"Original Shipment Code : {ship01.TrackingCode}");
        Console.WriteLine($"Assigned Shipment Code : {ship02.TrackingCode}");
        Console.WriteLine($"Copied Shipment Code   : {copiedShip.TrackingCode}");

        Console.WriteLine($"HashCode of original:{ship01.GetHashCode()}");
        Console.WriteLine($"HashCode of ref copy:{ship02.GetHashCode()}");
        Console.WriteLine($"HashCode of method copy:{copiedShip.GetHashCode()}");
        #endregion

        #region practical 2
        StandardShipment STship01 = new StandardShipment()
        {
            TrackingCode = "1",
            Destination = new DeliveryAddress("cairo","bahr",15 )
        };

        Shipment ShallowShip = STship01.ShallowCopy();

        Console.WriteLine($"Original Shipment Address : {STship01.Destination?.City}");
        Console.WriteLine($"Copied Shipment Address   : {ShallowShip.Destination?.City}");

        if (ShallowShip.Destination != null)
        {
            ShallowShip.Destination.City = "Giza";
        }
        Console.WriteLine("-----------------");
        Console.WriteLine($"New Copied Shipment Address : {ShallowShip.Destination?.City}");
        #endregion
        Console.WriteLine("======================================");
        #region practical 3
        Shipment shipment02 = new Shipment()
        {
            TrackingCode = "SH_512",
            Destination = new DeliveryAddress { City = "Cairo", Street = "Naser St", BuildingNumber = 10 }
        };

        Shipment DeepCopiedShip = shipment02.DeepCopy();

        Console.WriteLine($"Original Shipment Address : {shipment02.Destination?.City}");
        Console.WriteLine($"Copied Shipment Address   : {DeepCopiedShip.Destination?.City}");

        bool sameAddressObject = ReferenceEquals(shipment02.Destination, DeepCopiedShip.Destination);
        Console.WriteLine($"Same DeliveryAddress Object : {sameAddressObject}");

        DeepCopiedShip.Destination.City = "Giza";
        Console.WriteLine($"Original Shipment Address : {shipment02.Destination?.City}");
        Console.WriteLine($"Copied Shipment Address   : {DeepCopiedShip.Destination?.City}");

        bool sameAddressObject2 = ReferenceEquals(shipment02.Destination, DeepCopiedShip.Destination);
        Console.WriteLine($"Same DeliveryAddress Object : {sameAddressObject2}");
        #endregion
        Console.WriteLine("======================================");
        #region practical 4
        Shipment shipment_01 = new Shipment();
        StandardShipment shipment_02 = new StandardShipment();
        InternationalShipment shipment_03 = new InternationalShipment();

        Console.WriteLine($"Total Shipments Created : {Shipment.TotalShipmentsCreated}");
        #endregion
        Console.WriteLine("======================================");
        #region practical 6
        Console.WriteLine($"Total Shipments Created :{Shipment.GetTotalShipmentsCreated()}");
        #endregion
        Console.WriteLine("======================================");
        
    }
}
