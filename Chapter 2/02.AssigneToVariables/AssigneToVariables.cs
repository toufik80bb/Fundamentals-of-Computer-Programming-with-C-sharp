 /* Which of the following values can be assigned to variables of type float, double and decimal:
    5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467 ? */
using System;


namespace AssigneToVariables
{
    class AssigneToVariables
    {
        static void Main()
        {
            float first = 5;
            float second = -5.01f;
            double third = 34.567839023;
            float fourth = 12.345f; 
            float fifth = 8923.1234857f;
            decimal sixth = 3456.091124875956542151256683467m;

            Console.WriteLine(first + " -> " + first.GetTypeCode());
            Console.WriteLine(second + " -> " + second.GetTypeCode());
            Console.WriteLine(third + " -> " + third.GetTypeCode());
            Console.WriteLine(fourth + " -> " + fourth.GetTypeCode());
            Console.WriteLine(fifth + " -> " + fifth.GetTypeCode());
            Console.WriteLine(sixth + " -> " + sixth.GetTypeCode());
        }
    }
}
