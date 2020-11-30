
// Write a program, which compares correctly two real numbers with accuracy at least 0.000001

using System;

namespace ComparesCorrectly
{
    class ComparesCorrectly
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string m = Console.ReadLine();
            double firstNumber = double.Parse(m);
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            bool equal = Math.Abs(firstNumber - secondNumber) < 0.000001;
            if (equal == true)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }
    }
}
