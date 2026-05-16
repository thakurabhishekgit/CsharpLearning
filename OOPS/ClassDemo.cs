using System;
using System.ComponentModel.DataAnnotations;


namespace ClassDemoWithExamples.ClassDemo;

class ClassDemo
{
    public class User
    {
        
        public String Name {get; set;}  = string.Empty; // if no value is assigned then 
        // it will be empty string instead of null 
        //public string Id { get; private set; }
        
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


    class Payment
{
    public string Name { get; set; } = string.Empty;

    public double Amount { get; set; }

    public virtual void Pay() // virtual keyword is used to allow derived classes to override this method
    {
        Console.WriteLine("Generic payment processing");
    }
}

    class HDFC : Payment
{
    public override void Pay() // override keyword is used to provide a new implementation of the Pay method in the derived class
    {
        Console.WriteLine("HDFC payment gateway");
    }
}

    public static void Run()
    {
        User user1 = new User();
        user1.Name = "Abhishek";
        user1.Age = 25;

        Console.WriteLine($"User Name: {user1.Name}, Age: {user1.Age}");
    }
}