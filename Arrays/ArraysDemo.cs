using System;
using System.Collections.Generic;



namespace ArraysDemo.Arr
{
    class Arr
    {
        // Array declaration
        // int[] arr = new int[5];
        // int[] arr = { 1, 2, 3, 4, 5 };

        // Array initialization
        // arr[0] = 1;
        // Array access
        // int firstElement = arr[0];   

        //get input from user and store in array 
        //for example 1 2 4 5 3 2 is user input and store in array and print the array
        //input: 1 2 4 5 3 2 in a single line and store in array and print the array

        public static void TakeArrayInput()
        {
            Console.WriteLine("Enter numbers separated by space:");

            // Example Input:
            // 2 2 1 2 3 2

            string input = Console.ReadLine();

            // Split input using space
            string[] values = input.Split(' ');

            // Create integer array
            int[] numbers = new int[values.Length];

            // Convert string values to integers
            for (int i = 0; i < values.Length; i++)
            {
                numbers[i] = int.Parse(values[i]);
            }

            Console.WriteLine("\nArray Elements:");

            // Print array
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

              string result = "[" + string.Join(",", numbers) + "]";

            Console.WriteLine(result);
        }


        

        public static void ListMethods()
        {
            List<int> nums = new List<int>();
            // List<int> nums = new List<int>() { 1, 2, 3 };
            nums.Add(1);
            nums.Add(2);    
            nums.Add(3);
                nums.Add(4);
                nums.Add(5);

            PrintList(nums);


            






        }

        static void PrintList(List<int> list)
        {
            Console.WriteLine($"[{string.Join(",", list)}]");
        }

        

        
    }
}