// using System;

// namespace KeywordDemo
// {
//     class User
//     {
//         // readonly field
//         readonly int userId;

//         // constructor assignment allowed
//         public User(int id)
//         {
//             userId = id;
//         }

//         public void ShowUser()
//         {
//             Console.WriteLine($"Readonly User ID: {userId}");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // ------------------------------------------------
//             // var
//             // ------------------------------------------------

//             var age = 22;

//             Console.WriteLine($"var age: {age}");
//             Console.WriteLine($"Type of age: {age.GetType()}");

//             // age = "Hello"; // ERROR


//             // ------------------------------------------------
//             // const
//             // ------------------------------------------------

//             const double PI = 3.14159;

//             Console.WriteLine($"Const PI value: {PI}");

//             // PI = 5; // ERROR


//             // ------------------------------------------------
//             // readonly
//             // ------------------------------------------------

//             User user = new User(101);

//             user.ShowUser();


//             // ------------------------------------------------
//             // dynamic
//             // ------------------------------------------------

//             dynamic data = 100;

//             Console.WriteLine($"Dynamic int value: {data}");

//             data = "Hello World";

//             Console.WriteLine($"Dynamic string value: {data}");

//             data = true;

//             Console.WriteLine($"Dynamic bool value: {data}");


//             // ------------------------------------------------
//             // var vs dynamic
//             // ------------------------------------------------

//             var number = 10;

//             Console.WriteLine($"Var number: {number}");

//             dynamic value = 20;

//             value = "Changed to string";

//             Console.WriteLine($"Dynamic changed value: {value}");
//         }
//     }
// }


using System;

namespace KeywordsDemo.KeywordsDemoClass
{
    class KeywordsDemoClass
    {
        // ------------------------------------------------
        // readonly field
        // Can only be assigned once
        // ------------------------------------------------

        public static readonly int userId = 101;

        public static void ShowKeywords()
        {
            // ------------------------------------------------
            // var
            // ------------------------------------------------

            var age = 22;

            Console.WriteLine($"Var age: {age}");
            Console.WriteLine($"Type of age: {age.GetType()}");



            // ------------------------------------------------
            // const
            // ------------------------------------------------

            const double PI = 3.14159;

            Console.WriteLine($"Const PI value: {PI}");



            // ------------------------------------------------
            // readonly
            // ------------------------------------------------

            Console.WriteLine($"Readonly User ID: {userId}");



            // ------------------------------------------------
            // dynamic
            // ------------------------------------------------

            dynamic data = 100;

            Console.WriteLine($"Dynamic int value: {data}");

            data = "Hello World";

            Console.WriteLine($"Dynamic string value: {data}");

            data = true;

            Console.WriteLine($"Dynamic bool value: {data}");



            // ------------------------------------------------
            // var vs dynamic
            // ------------------------------------------------

            var number = 10;

            Console.WriteLine($"Var number: {number}");

            dynamic value = 20;

            value = "Changed to string";

            Console.WriteLine($"Dynamic changed value: {value}");
        }
    }
}