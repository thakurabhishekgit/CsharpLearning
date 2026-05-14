using System;
using System.Collections.Generic;

namespace ListDemo.ListMethodsDemo
{
    class ListMethodsDemo
    {
        public static void ShowListMethods()
        {
            // ------------------------------------------------
            // Creating List
            // ------------------------------------------------

            List<int> numbers = new List<int>();


            // ------------------------------------------------
            // Add()
            // Adds single element
            // ------------------------------------------------

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            Console.WriteLine("After Add():");
            PrintList(numbers);


            // ------------------------------------------------
            // AddRange()
            // Adds multiple elements
            // ------------------------------------------------

            numbers.AddRange(new List<int> { 40, 50, 60 });

            Console.WriteLine("\nAfter AddRange():");
            PrintList(numbers);


            // ------------------------------------------------
            // Insert()
            // Insert at specific index
            // ------------------------------------------------

            numbers.Insert(1, 100);

            Console.WriteLine("\nAfter Insert():");
            PrintList(numbers);


            // ------------------------------------------------
            // InsertRange()
            // Insert multiple values
            // ------------------------------------------------

            numbers.InsertRange(2, new List<int> { 200, 300 });

            Console.WriteLine("\nAfter InsertRange():");
            PrintList(numbers);


            // ------------------------------------------------
            // Remove()
            // Removes first occurrence
            // ------------------------------------------------

            numbers.Remove(20);

            Console.WriteLine("\nAfter Remove():");
            PrintList(numbers);


            // ------------------------------------------------
            // RemoveAt()
            // Remove using index
            // ------------------------------------------------

            numbers.RemoveAt(0);

            Console.WriteLine("\nAfter RemoveAt():");
            PrintList(numbers);


            // ------------------------------------------------
            // RemoveRange()
            // Remove multiple elements
            // ------------------------------------------------

            numbers.RemoveRange(1, 2);

            Console.WriteLine("\nAfter RemoveRange():");
            PrintList(numbers);


            // ------------------------------------------------
            // Contains()
            // Check existence
            // ------------------------------------------------

            Console.WriteLine($"\nContains 50: {numbers.Contains(50)}");


            // ------------------------------------------------
            // IndexOf()
            // Find first occurrence index
            // ------------------------------------------------

            Console.WriteLine($"IndexOf 50: {numbers.IndexOf(50)}");


            // ------------------------------------------------
            // LastIndexOf()
            // Find last occurrence
            // ------------------------------------------------

            numbers.Add(50);

            Console.WriteLine($"LastIndexOf 50: {numbers.LastIndexOf(50)}");


            // ------------------------------------------------
            // Count
            // Total elements
            // ------------------------------------------------

            Console.WriteLine($"\nCount: {numbers.Count}");


            // ------------------------------------------------
            // Capacity
            // Internal storage size
            // ------------------------------------------------

            Console.WriteLine($"Capacity: {numbers.Capacity}");


            // ------------------------------------------------
            // Sort()
            // Sort ascending
            // ------------------------------------------------

            numbers.Sort();

            Console.WriteLine("\nAfter Sort():");
            PrintList(numbers);


            // ------------------------------------------------
            // Reverse()
            // Reverse list
            // ------------------------------------------------

            numbers.Reverse();

            Console.WriteLine("\nAfter Reverse():");
            PrintList(numbers);


            // ------------------------------------------------
            // Min() and Max()
            // Requires LINQ
            // ------------------------------------------------

            Console.WriteLine($"\nMaximum Value: {numbers.Max()}");
            Console.WriteLine($"Minimum Value: {numbers.Min()}");


            // ------------------------------------------------
            // Sum() and Average()
            // Requires LINQ
            // ------------------------------------------------

            Console.WriteLine($"Sum: {numbers.Sum()}");
            Console.WriteLine($"Average: {numbers.Average()}");


            // ------------------------------------------------
            // Find()
            // Finds first matching element
            // ------------------------------------------------

            int found = numbers.Find(x => x > 40);

            Console.WriteLine($"\nFirst number greater than 40: {found}");


            // ------------------------------------------------
            // FindAll()
            // Finds all matching elements
            // ------------------------------------------------

            List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);

            Console.WriteLine("\nEven Numbers:");
            PrintList(evenNumbers);


            // ------------------------------------------------
            // Exists()
            // Checks condition
            // ------------------------------------------------

            bool exists = numbers.Exists(x => x > 100);

            Console.WriteLine($"\nExists number > 100: {exists}");


            // ------------------------------------------------
            // ForEach()
            // Iterate list
            // ------------------------------------------------

            Console.WriteLine("\nUsing ForEach():");

            numbers.ForEach(x => Console.WriteLine(x));


            // ------------------------------------------------
            // ToArray()
            // Convert list to array
            // ------------------------------------------------

            int[] arr = numbers.ToArray();

            Console.WriteLine("\nConverted Array:");
            Console.WriteLine($"[{string.Join(",", arr)}]");


            // ------------------------------------------------
            // Clear()
            // Removes everything
            // ------------------------------------------------

            numbers.Clear();

            Console.WriteLine($"\nCount after Clear(): {numbers.Count}");
        }


        // ------------------------------------------------
        // Helper Method
        // ------------------------------------------------

        static void PrintList(List<int> list)
        {
            Console.WriteLine($"[{string.Join(",", list)}]");
        }
    }
}