using System;

namespace Learning.NumericUtilities
{
    class NumericUtilitiesDemo
    {
        public static void Run()
        {
            ShowMathFunctions();
            ShowTypeInformation();
            ShowConversions();
            ShowFormatting();
            ShowRandomExamples();
            ShowComparisons();
            ShowSpecialFloatingValues();
            ShowClampExample();
            ShowOverflowExample();
        }

        // --------------------------------------------------
        // Math Functions
        // --------------------------------------------------

        private static void ShowMathFunctions()
        {
            Console.WriteLine("===== Math Functions =====\n");

            double number = 16;

            var sqrt = Math.Sqrt(number);
            var power = Math.Pow(2, 3);
            var absInt = Math.Abs(-5);
            var absDouble = Math.Abs(-5.75);
            var max = Math.Max(10, 20);
            var min = Math.Min(10, 20);

            Console.WriteLine($"Square root of {number}: {sqrt}");
            Console.WriteLine($"2 power 3: {power}");
            Console.WriteLine($"Absolute int value: {absInt}");
            Console.WriteLine($"Absolute double value: {absDouble}");
            Console.WriteLine($"Maximum value: {max}");
            Console.WriteLine($"Minimum value: {min}");

            Console.WriteLine();

            Console.WriteLine($"Round(3.14159, 2): {Math.Round(3.14159, 2)}");
            Console.WriteLine($"Floor(3.9): {Math.Floor(3.9)}");
            Console.WriteLine($"Ceiling(3.1): {Math.Ceiling(3.1)}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Type Information
        // --------------------------------------------------

        private static void ShowTypeInformation()
        {
            Console.WriteLine("===== Type Information =====\n");

            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of decimal: {sizeof(decimal)} bytes");

            Console.WriteLine();

            Console.WriteLine($"Type of int: {typeof(int)}");
            Console.WriteLine($"Type of double: {typeof(double)}");

            Console.WriteLine();

            Console.WriteLine($"int MaxValue: {int.MaxValue}");
            Console.WriteLine($"int MinValue: {int.MinValue}");

            Console.WriteLine();

            Console.WriteLine($"double MaxValue: {double.MaxValue}");
            Console.WriteLine($"double MinValue: {double.MinValue}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Conversion Methods
        // --------------------------------------------------

        private static void ShowConversions()
        {
            Console.WriteLine("===== Conversion Methods =====\n");

            string strNumber = "123";

            int convertedNumber = Convert.ToInt32(strNumber);

            Console.WriteLine($"Converted using Convert.ToInt32(): {convertedNumber}");

            int parsedNumber = int.Parse("456");

            Console.WriteLine($"Parsed using int.Parse(): {parsedNumber}");

            string validInput = "176";

            if (int.TryParse(validInput, out int result))
            {
                Console.WriteLine($"Successfully parsed '{validInput}' to {result}");
            }
            else
            {
                Console.WriteLine($"Failed to parse '{validInput}'");
            }

            string invalidInput = "abc";

            bool success = int.TryParse(invalidInput, out int failedResult);

            Console.WriteLine($"TryParse success for '{invalidInput}': {success}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Formatting Examples
        // --------------------------------------------------

        private static void ShowFormatting()
        {
            Console.WriteLine("===== Formatting =====\n");

            int number = 1000000;

            Console.WriteLine($"Currency format: {number:C}");
            Console.WriteLine($"Number format: {number:N}");

            double pi = 3.1415926535;

            Console.WriteLine($"Fixed-point (F2): {pi:F2}");
            Console.WriteLine($"Scientific notation (E): {pi:E}");

            double percentage = 0.85;

            Console.WriteLine($"Percentage format: {percentage:P}");

            Console.WriteLine();

            int intValue = 42;
            double doubleValue = 3.14;
            decimal decimalValue = 123.45m;

            Console.WriteLine($"Integer to string: {intValue.ToString()}");
            Console.WriteLine($"Double to string: {doubleValue.ToString()}");
            Console.WriteLine($"Decimal to string: {decimalValue.ToString()}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Random Examples
        // --------------------------------------------------

        private static void ShowRandomExamples()
        {
            Console.WriteLine("===== Random Examples =====\n");

            Random random = new Random();

            int randomInt = random.Next(1, 101);

            Console.WriteLine($"Random integer (1-100): {randomInt}");

            double randomDouble = random.NextDouble() * 100;

            Console.WriteLine($"Random double: {randomDouble:F2}");

            decimal randomDecimal = (decimal)random.NextDouble() * 100;

            Console.WriteLine($"Random decimal: {randomDecimal:F2}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Comparison Methods
        // --------------------------------------------------

        private static void ShowComparisons()
        {
            Console.WriteLine("===== Comparison Methods =====\n");

            int a = 10;
            int b = 20;

            int comparison = a.CompareTo(b);

            Console.WriteLine($"CompareTo result: {comparison}");

            // < 0  -> smaller
            // 0    -> equal
            // > 0  -> greater

            bool isEqual = a.Equals(b);

            Console.WriteLine($"Are values equal? {isEqual}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Special Floating Values
        // --------------------------------------------------

        private static void ShowSpecialFloatingValues()
        {
            Console.WriteLine("===== Special Floating Values =====\n");

            double nan = 0.0 / 0.0;

            Console.WriteLine($"Is NaN: {double.IsNaN(nan)}");

            double infinity = 1.0 / 0.0;

            Console.WriteLine($"Is Infinity: {double.IsInfinity(infinity)}");
            Console.WriteLine($"Is Positive Infinity: {double.IsPositiveInfinity(infinity)}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Clamp Example
        // --------------------------------------------------

        private static void ShowClampExample()
        {
            Console.WriteLine("===== Clamp Example =====\n");

            int value = 1500;

            int clampedValue = Math.Clamp(value, 0, 100);

            Console.WriteLine($"Original value: {value}");
            Console.WriteLine($"Clamped value: {clampedValue}");

            Console.WriteLine("\n");
        }

        // --------------------------------------------------
        // Overflow Example
        // --------------------------------------------------

        private static void ShowOverflowExample()
        {
            Console.WriteLine("===== Overflow Example =====\n");

            try
            {
                checked
                {
                    int max = int.MaxValue;

                    Console.WriteLine($"Before overflow: {max}");

                    max++;

                    Console.WriteLine($"After overflow: {max}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow Exception: {ex.Message}");
            }

            Console.WriteLine("\n");
        }
    }
}