using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Task 1
            Console.WriteLine("Hello, World!");

            //Task 2
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            */

            /*
            //Task 3           
            Console.Write("Enter First Number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter First Number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Addition : " + (number1 + number2));
            Console.WriteLine("Subtraction : " + (number1 - number2));
            Console.WriteLine("Multiplication : " + (number1 * number2));
            Console.WriteLine("Division : " + (number1 / number2));
            Console.WriteLine("Modulus : " + (number1 % number2));
            */

            /*
            //Task 4
            Console.WriteLine("Enter a number");
            int evenOrOdd = int.Parse(Console.ReadLine());  

            if(evenOrOdd % 2 == 0)
            {
                Console.WriteLine($"The entered number {evenOrOdd} is even");
            }
            else
            {
                Console.WriteLine($"The entered number {evenOrOdd} is odd");
            }
            */

            /*
            //Task 5
            Console.WriteLine("Numbers From 1 to 10");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */


            /*
            //Task 6            
            int[] arraynumbers = new int[5];
            Console.WriteLine("Enter 5 numbers");

            for(int i = 0; i < arraynumbers.Length; i++)
            {
                arraynumbers[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            foreach(int i in arraynumbers)
            {
                total += i;
            }

            Console.WriteLine("Total of arrays:" +  total);

            double average = (double)total/ arraynumbers.Length;
            Console.WriteLine("Average of the arrays: " +  average);
            */

            /*
            //Task 7
            Console.WriteLine("Enter positive number");
            int number = int.Parse(Console.ReadLine());

            
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative");
            }
            else
            {
                long factotialNumber = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is {factotialNumber}");
            }
            */

            //Task 8

            int age = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }

            try
            {
                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }
                else if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }




            Console.ReadKey();

        }


        static long CalculateFactorial(int positiveNumber)
        {
            if (positiveNumber == 0)
            {
                return 1;
            }
            else
            {
                return positiveNumber * CalculateFactorial(positiveNumber - 1);
            }
        }
    }
}
