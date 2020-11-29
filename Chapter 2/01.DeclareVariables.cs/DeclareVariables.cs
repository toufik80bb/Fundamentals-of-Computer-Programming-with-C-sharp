/*
* Declare several variables by selecting for each one of them the most appropriate of the types
* sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values:
* 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789
*/
using System;
namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort first = 52130;
            short second = -115;
            int third = 4825932;
            sbyte fourth = 97;
            short fifth = -10000;
            short sixth = -20000;
            byte seventh = 224;
            int  eight = 970700000;
            sbyte ninth = 112;
            sbyte tenth = -44;
            int eleventh = -1000000;
            short twelfth = 1990;
            long thirteenth = 123456789123456789;

            Console.WriteLine(first + " -> " + first.GetTypeCode());
            Console.WriteLine(second + " -> " + second.GetTypeCode());
            Console.WriteLine(third + " -> " + third.GetTypeCode());
            Console.WriteLine(fourth + " -> " + fourth.GetTypeCode());
            Console.WriteLine(fifth + " -> " + fifth.GetTypeCode());
            Console.WriteLine(sixth + " -> " + sixth.GetTypeCode());
            Console.WriteLine(seventh + " -> " + seventh.GetTypeCode());
            Console.WriteLine(eight + " -> " + eight.GetTypeCode()); 
            Console.WriteLine(ninth + " -> " + ninth.GetTypeCode());
            Console.WriteLine(tenth + " -> " + tenth.GetTypeCode());
            Console.WriteLine(eleventh + " -> " + eleventh.GetTypeCode());
            Console.WriteLine(twelfth + " -> " + twelfth.GetTypeCode());
            Console.WriteLine(thirteenth + " -> " + thirteenth.GetTypeCode());


        }
    }
}
