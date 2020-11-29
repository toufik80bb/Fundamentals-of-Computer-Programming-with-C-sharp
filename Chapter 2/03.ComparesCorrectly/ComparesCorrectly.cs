using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparesCorrectly
{
    class ComparesCorrectly
    {
        static void Main(string[] args)
        {
            /* private static bool AreEqualWithPrecision(decimal a, decimal b, decimal precision)
            {
                return Math.Abs(a - b) < precision;
            }*/
            
            
            try
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
            catch (Exception)
            {

                throw;
            }
            
            
        }

}
}
