using System;

namespace ControlFlowDemo.ControlFlowExamples
{
    class ControlFlowExamples
    {
        public static void RunAllExamples()
        {
            ShowIfStatement();
            ShowIfElseStatement();
            ShowElseIfLadder();
            ShowNestedIf();
            ShowLogicalOperators();
            ShowTernaryOperator();
            ShowSwitchStatement();
            ShowModernSwitchExpression();
            ShowForLoop();
            ShowWhileLoop();
            ShowDoWhileLoop();
            ShowForeachLoop();
            ShowBreakStatement();
            ShowContinueStatement();
            ShowNestedLoops();
        }

        // --------------------------------------------------
        // Simple if Statement
        // --------------------------------------------------

        static void ShowIfStatement()
        {
            Console.WriteLine("===== IF STATEMENT =====");

            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // if-else Statement
        // --------------------------------------------------

        static void ShowIfElseStatement()
        {
            Console.WriteLine("===== IF ELSE STATEMENT =====");

            int marks = 40;

            if (marks >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // else-if Ladder
        // --------------------------------------------------

        static void ShowElseIfLadder()
        {
            Console.WriteLine("===== ELSE IF LADDER =====");

            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (score >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Nested if
        // --------------------------------------------------

        static void ShowNestedIf()
        {
            Console.WriteLine("===== NESTED IF =====");

            int age = 25;
            bool hasLicense = true;

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Can drive");
                }
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Logical Operators
        // --------------------------------------------------

        static void ShowLogicalOperators()
        {
            Console.WriteLine("===== LOGICAL OPERATORS =====");

            int age = 22;
            bool hasID = true;

            if (age >= 18 && hasID)
            {
                Console.WriteLine("Access granted using AND");
            }

            bool isAdmin = false;
            bool isManager = true;

            if (isAdmin || isManager)
            {
                Console.WriteLine("Access granted using OR");
            }

            bool isLoggedIn = false;

            if (!isLoggedIn)
            {
                Console.WriteLine("User not logged in using NOT");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Ternary Operator
        // --------------------------------------------------

        static void ShowTernaryOperator()
        {
            Console.WriteLine("===== TERNARY OPERATOR =====");

            int age = 17;

            string result = age >= 18 ? "Adult" : "Minor";

            Console.WriteLine(result);

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Switch Statement
        // --------------------------------------------------

        static void ShowSwitchStatement()
        {
            Console.WriteLine("===== SWITCH STATEMENT =====");

            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            Console.WriteLine();

            string role = "Admin";

            switch (role)
            {
                case "Admin":
                    Console.WriteLine("Full Access");
                    break;

                case "User":
                    Console.WriteLine("Limited Access");
                    break;

                default:
                    Console.WriteLine("Unknown Role");
                    break;
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Modern Switch Expression
        // --------------------------------------------------

        static void ShowModernSwitchExpression()
        {
            Console.WriteLine("===== MODERN SWITCH EXPRESSION =====");

            int number = 2;

            string result = number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                _ => "Unknown"
            };

            Console.WriteLine(result);

            Console.WriteLine();
        }

        // --------------------------------------------------
        // for Loop
        // --------------------------------------------------

        static void ShowForLoop()
        {
            Console.WriteLine("===== FOR LOOP =====");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Value of i: {i}");
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // while Loop
        // --------------------------------------------------

        static void ShowWhileLoop()
        {
            Console.WriteLine("===== WHILE LOOP =====");

            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine($"Value of i: {i}");

                i++;
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // do-while Loop
        // --------------------------------------------------

        static void ShowDoWhileLoop()
        {
            Console.WriteLine("===== DO WHILE LOOP =====");

            int i = 1;

            do
            {
                Console.WriteLine($"Value of i: {i}");

                i++;
            }
            while (i <= 5);

            Console.WriteLine();
        }

        // --------------------------------------------------
        // foreach Loop
        // --------------------------------------------------

        static void ShowForeachLoop()
        {
            Console.WriteLine("===== FOREACH LOOP =====");

            int[] numbers = { 10, 20, 30, 40 };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // break Statement
        // --------------------------------------------------

        static void ShowBreakStatement()
        {
            Console.WriteLine("===== BREAK STATEMENT =====");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // continue Statement
        // --------------------------------------------------

        static void ShowContinueStatement()
        {
            Console.WriteLine("===== CONTINUE STATEMENT =====");

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine();
        }

        // --------------------------------------------------
        // Nested Loops
        // --------------------------------------------------

        static void ShowNestedLoops()
        {
            Console.WriteLine("===== NESTED LOOPS =====");

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }

            Console.WriteLine();
        }
    }
}