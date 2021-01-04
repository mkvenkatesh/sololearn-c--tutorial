﻿using System;

namespace sololearn
{
    class Program
    {
        // Main method is the entry point for the program. All C# programs need
        // a Main method
        static void Main(string[] args)
        {

            // this is a comment
            /* Multi-line
            Comment */

            // explicit data type declaration. You can declare and assign values
            // in the same row or different rows.
            string name;

            // Writes the string argument in console and adds a new line
            Console.WriteLine("What is your name?");

            // Reads input from console as a string
            // name = Console.ReadLine();

            Console.WriteLine("What is your age?");

            // Convert.ToXXX converts string data type to other data types
            // int age = Convert.ToInt32(Console.ReadLine());

            // formatted output. 0, 1, 2 etc are positional arguments
            // Console.WriteLine("My name is {0} and I'm {1} years old.", name, age);

            /*
            Variables declared using the var keyword are called implicitly typed
            variables. Implicitly typed variables must be initialized with a
            value. 
            */
            var num = 20;
            Console.WriteLine("variable declared with implicit datatype statement var: {0}", num);

            /* 
            Constants store a value that cannot be changed from their initial
            assignment. To declare a constant, use the const modifier. Constants
            must be initialized with a value when declared.
            */
            const double PI = 3.14; 
            Console.WriteLine("The value of pi is a constant and it is: {0}", PI);

            /* Number operations */
            num += 20;
            Console.WriteLine(num);
            num -= 20;
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            
            /*
            Prefix increments the value, and then proceeds with the expression.
            Postfix evaluates the expression and then performs the incrementing. 
            */
            int y = num++;
            Console.WriteLine("num = {0}, y = {1}", num, y);
            y = ++num;
            Console.WriteLine("num = {0}, y = {1}", num, y);

            // if else
            if (y > 20) {
                Console.WriteLine("Y is greather than 20.");
            }
            else if (y == 20) {
                Console.WriteLine("Y is equal to 20.");
            }
            else {
                Console.WriteLine("Y is less than 20.");
            }

            // switch statement - The switch statement provides a more elegant
            // way to test a variable for equality against a list of values.
            // Each value is called a case, and the variable being switched on
            // is checked for each switch case. switch statement can include any
            // number of cases. However, no two case labels may contain the same
            // constant value. In a switch statement, the optional default case
            // is executed when none of the previous cases match. 
            int vara = 20;
            switch (vara) {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break; 
                default:
                    Console.WriteLine("Doesn't match any number.");
                    break;
            }

            // while statement
            while (vara > 0) {
                Console.WriteLine("Vara value is: {0}", vara);
                vara -= 5;

            }

            // for statement
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("For Loop Executed {0} Times.", i);
            }

            // do-while - executes at least once before checking the while
            // condition
            int j = 0;
            do {
                Console.WriteLine("In Do-While Loop: {0}", j);
                j++;
            } while (j < 5);
            
            // ?: operator - shorthand if-else statement (expr1) ? (expr2) :
            // (expr3) => if expr1 is true, evaluate expr2 else expr3
            Console.WriteLine((j == 5) ? "J is 5" : "J is not 5");        
            
            // calculator
            // while (true) {
            //     Console.Write("Enter the first number: "); 
            //     string x = Console.ReadLine();

            //     Console.Write("Enter the second number: ");
            //     string z = Console.ReadLine();

            //     if (x == "exit" || z == "exit") {
            //         break;
            //     }
                
            //     Console.WriteLine("The sum of {0} and {1} is: {2}", x, z, Convert.ToInt32(x) + Convert.ToInt32(z));
            // }

            // call a method
            int result = Sqrt(20);
            Console.WriteLine("Sqrt of 20 is: {0}", result);

            // call void method with no arguments
            sayHi();

            // call a method with optional parameter
            Console.WriteLine("Power of 3: {0}", Pow(3));
            Console.WriteLine("Power of 3 ^ 3: {0}", Pow(3, 3));

            // call a method with named arguments
            Console.WriteLine("Area of rectangle of height 10 and width 20 is: {0}", rectArea(w: 10, h: 20));

            // pass by reference
            int pbr = 10;
            Console.WriteLine("Value of pbr before pass by reference is: {0}", pbr);
            PassByRef(ref pbr);
            Console.WriteLine("Value of pbr after pass by reference is: {0}", pbr);

            // pass by output
            int a=1, b;
            GetValues(out a, out b);
            Console.WriteLine("A is {0} and B is {1}", a, b);

            // Method Overloading
            Print(20);
            Print(20.45);
            Print("Method overload - Value of a is: ", 31);

            // Call a method from another class
            Console.WriteLine("5! = {0}", Factorial.Fact(5));

            // Draw Pyramid
            DrawPyramid(10);

            // Instantiate an object of Person class
            Person p1 = new Person();            
            p1.age = 20;
            p1.name = "Venkatesh";
            p1.SetGender("Male");
            p1.SayHi();

            // object instantiated from a class with a constructor
            BankAccount v1 = new BankAccount("Venkatesh");
            Console.WriteLine("My balance is: " + v1.GetBalance());
            v1.Deposit(278.87);
            v1.Deposit(129.76);
            v1.Deposit(99.12);
            v1.Withdraw(39.87);
            v1.Withdraw(190.86);
            Console.WriteLine("{0}'s balance is: {1} ", v1.GetName(), v1.GetBalance());
            Console.WriteLine("Number of bank accounts: " + BankAccount.NumOfAccounts);
            Console.WriteLine();

            BankAccount v2 = new BankAccount();
            Console.WriteLine("My balance is: " + v2.GetBalance());
            v2.Ssn = "123-456-789";
            Console.WriteLine("v2 ssn number is: " + v2.Ssn);
            v2.Age = 20;
            Console.WriteLine("v2 age is: " + v2.Age);
            Console.WriteLine("{0}'s balance is: {1} ", v2.GetName(), v2.GetBalance());
            Console.WriteLine("Number of bank accounts: " + BankAccount.NumOfAccounts);
            Console.WriteLine();

            // Array declaration and initialization
            int[] myArray = new int[3] {10, 20, 30}; 
            myArray[1] = 20;
            myArray[0] = 10;
            
            string[] myarray0 = new string[] {"True", "False"};
            string[] myArray1 = {"True","False"};

            // foreach
            foreach (var val in myArray) {
                Console.WriteLine(val);
            }

            // multi-dimension array
            int[,] multiArray = new int[3, 4];
            multiArray[0, 0]= 20;
            multiArray[0, 1]= 10;

            int[,] multiArray1 = {{10, 20}, {30, 40}, {50, 60}};
            for (int k = 0; k < 3; k++) {
                for (int l = 0; l < 2; l++) {
                    Console.Write(multiArray1[k, l] + " ");
                }
                Console.WriteLine();
            }

            // jagged array - array of arrays
            int[][] jaggedArray = new int[][] {
                new int[] {1, 2, 3, 4, 5},
                new int[] {6, 7, 8, 9},
                new int[] {10, 11, 12}
            };

            Console.WriteLine("Jagged array[2, 2]: " + jaggedArray[2][2]);

            // Length and Rank properties of an array
            Console.WriteLine("Jagged Array Length: " + jaggedArray.Length);
            Console.WriteLine("Jagged Array Rank: " + jaggedArray.Rank);

            // call StringDemo method to demonostrate string properties and methods
            Strings.StringDemo();

            // static classes with static members
            Console.WriteLine("Value of PI is: " + Math.PI);
            Console.WriteLine("Value of 2^3 is: " + Math.Pow(2,3));
            Console.WriteLine("Does 'inter' == 'inter'?: " + String.Equals("inter", "inter"));
            Console.WriteLine("Current Time is: " + DateTime.Now);
            Console.WriteLine("Current Day is: " + DateTime.Today);

            // indexer declaration and usage on classes
            Clients c1 = new Clients();
            c1[0] = "inter";
            c1[1] = "codes";
            Console.WriteLine("\nClient class indexer operation: {0}\n", c1[1]);

            // Operator overloading
            Box b1 = new Box(20, 10);
            Box b2 = new Box(50, 20);
            var b3 = b1 + b2;
            Console.WriteLine(b3.Height);
            Console.WriteLine(b3.Width);
            Console.WriteLine();

            // class inheritance - dervied class can be extended from base
            // classes. Person is the base class and Male is a derived class.
            Male m1 = new Male("Venkatesh", 15, "Chef"); // name and age are members in Person class that is reused in Male class
            m1.name = "Venky";
            m1.SayHi(); // method in Person class
            m1.DisplayQualities(); // method in Male class                        

        }

        // A method that return an integer value and has one integer parameter
        static int Sqrt(int x) {
            return x * x;
        }

        // A method that doesn't return anything and doesn't accept arguments
        // i.e no parameters
        static void sayHi() {
            Console.WriteLine("Hello!");
        }

        // Optional paramters
        static int Pow(int x, int y = 2) {
            int result = 1;
            for (int i = 0; i < y; i++) {
                result *= x;
            }

            return result;
        }

        // demonstrate named arguments in a method
        static int rectArea(int h, int w) {
            return h * w;
        }

        // pass by reference
        static void PassByRef(ref int x) {
            x = 20;
        }

        // pass by output
        static void GetValues(out int a, out int b) {
            a = 10;
            b = 20;
        }

        // Method overloading
        static void Print(int a) {
            Console.WriteLine("Value of a is: " + a);
        }
        static void Print(double a) {
            Console.WriteLine("Value of a is: " + a);
        }
        static void Print(string label, int a) {
            Console.WriteLine(label + a);
        }

        // Draw Pyramid
        static void DrawPyramid(int height) {
            for (int i = 0; i < height; i++) {
                // print empty space
                for (int space = 0; space < (height - i - 1); space++) {
                    Console.Write(" ");
                }
                // print number of asterisk based on height
                for (int aster = 0; aster < (i + 1); aster++) {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}