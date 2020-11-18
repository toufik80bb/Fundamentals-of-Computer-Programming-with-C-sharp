using System;


namespace PrintSequance
{
    class PrintSequance
    {
        static void Main()
        {
            int number = 2;
            bool sign = true;
            for (int i = 1; i < 100; i++)
            {
                if (sign == true)
                {
                    Console.WriteLine(number);
                    number++;
                    sign = false;
                }
                else
                {
                    number *= (-1);
                    Console.WriteLine(number);
                    number *= (-1);
                    number++;
                    sign = true;

                }
            }
        }
    }
}
