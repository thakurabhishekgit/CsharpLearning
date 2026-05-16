using System;


namespace ClassDemoWithExamples.ClassDemo;

class ClassDemo
{
    public class User
    {
        public String Name {get; set;} //public string Id { get; private set; }
        
        public int Age {get; set;}

//         public int Age   This is used for custom validations 
        // {
        //     get
        //     {
        //         return _age;
        //     }

        //     set
        //     {
        //         if (value < 0)
        //         {
        //             throw new Exception("Invalid age");
        //         }

        //         _age = value;
        //     }

    }

    public static void Run()
    {
        User user1 = new User();
        user1.Name = "Abhishek";
        user1.Age = 25;

        Console.WriteLine($"User Name: {user1.Name}, Age: {user1.Age}");
    }
}