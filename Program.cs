using System;

class Program {
    static void Main()
    {

        // int val = 0;
        // int val = int.Parse(Console.ReadLine());

        if (int.TryParse(Console.ReadLine() , out int val))
        {
            val += 10;
            Console.WriteLine(val);
        } else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        Console.WriteLine(val + 10);

       
    }
}