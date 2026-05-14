using System;

namespace BuiltInFunctions
{
    class BuiltInFunctionsClass
    {
        public static void ShowBuiltInFunctions()
        {
            //Math functions
            double number = 16;
            double sqrt = Math.Sqrt(number); // Square root
            double power = Math.Pow(2, 3); // Power function (2 raised to the power of 3)
            double absValue = Math.Abs(-5); // Absolute value
            double maxValue = Math.Max(10, 20); // Maximum of two numbers
            double minValue = Math.Min(10, 20); // Minimum of two numbers

            Console.WriteLine($"Square root of {number} is {sqrt}");
            Console.WriteLine($"2 raised to the power of 3 is {power}");
            Console.WriteLine($"Absolute value of -5 is {absValue}");
            Console.WriteLine($"Maximum of 10 and 20 is {maxValue}");
            Console.WriteLine($"Minimum of 10 and 20 is {minValue}");

            //Sizeof operator
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");

            //typeof operator
            Console.WriteLine($"Type of int: {typeof(int)}");

            //Convert class
            string strNumber = "123";
            int convertedNumber = Convert.ToInt32(strNumber); // Convert string to int
            Console.WriteLine($"Converted number from string: {convertedNumber}");

            //tryparse method
            string strNum = "176";
            if (int.TryParse(strNum , out int result)) {
                Console.WriteLine($"Successfully parsed '{strNum}' to {result}");
            }
            else
            {
                Console.WriteLine($"Failed to parse '{strNum}'");
            }


            //converting int/double/decimal to string
            int num = 42;
            Console.WriteLine($"Integer to string: {num.ToString()}");
            double d = 3.14;
            Console.WriteLine($"Double to string: {d.ToString()}");
            decimal dec = 123.45m;
            Console.WriteLine($"Decimal to string: {dec.ToString()}");


            //common Formats 
            //F2 - Fixed-point with 2 decimal places
            //N - Number with thousand separators   
            //C - Currency format
            //P - Percentage format

            int amount = 10000000;
            Console.WriteLine($"Amount in currency format: {amount:C} using toString : {amount.ToString("C")    }");
            Console.WriteLine($"Amount with thousand separators: {amount:N} using toString : {amount.ToString("N")}");



            //Random range for (int , double and decimal)
            Random random = new Random();
            int randomNumber = random.Next(1 , 100); // Generates a random number between 1 and 99
            Console.WriteLine($"Random number between 1 and 99: {randomNumber}");

            double randomDouble = random.NextDouble() * 100; // Generates a random double between 0.0 and 100.0
            Console.WriteLine($"Random double between 0.0 and 100.0: {randomDouble}");

            decimal randomDecimal = (decimal)random.NextDouble() * 100; // Generates a random decimal between 0.0 and 100.0
            Console.WriteLine($"Random decimal between 0.0 and 100.0: {randomDecimal}");


            //compareTo method 
            // if a = b -> 0, if a < b -> -1, if a > b -> 1
            int a = 10;
            int b = 20;
            int comparison = a.CompareTo(b);
            Console.WriteLine($"Comparison of {a} and {b}: {comparison}");


            //Equals method 
            bool isEqual = a.Equals(b);
            Console.WriteLine($"Are {a} and {b} equal? {isEqual}");



            //clamp method
            int value = 1500;
            int clampedValue = Math.Clamp(value, 0, 100); // value is clamped between 0 and 100 range
            Console.WriteLine($"Clamped value of {value}: {clampedValue}");
        }
    }
}