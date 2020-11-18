using System;


namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age.");
            int actualAge = int.Parse(Console.ReadLine());
            DateTime dateTime = DateTime.Now.AddYears(10);
            int newAge = actualAge + 10;
            Console.WriteLine("At the date " + dateTime + " your age will be :  " + newAge + " years old. " );
        }
    }
}
