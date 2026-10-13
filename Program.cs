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
        //a)

        //b)

        //c)

        //d)
        #endregion
    }
}
