using System;

namespace DataTypes
{
    class DataTypesClass
    {
        public static void ShowDataTypes()
        {
            // Value types
            int myInt = 42;
            double myDouble = 3.14;
            bool myBool = true;

            // Reference types
            string myString = "Hello, World!";
            object myObject = new object();

            Console.WriteLine($"Integer: {myInt}");
            Console.WriteLine($"Double: {myDouble}");
            Console.WriteLine($"Boolean: {myBool}");
            Console.WriteLine($"String: {myString}");
            Console.WriteLine($"Object: {myObject}");
        }
    }
}