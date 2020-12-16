/*Declare two variables of type int. Assign to them values 5 and 10 respectively.Exchange(swap) their values and print them.*/

using System;


namespace ValueExchange
{
	class ValueExchange
	{
		static void Main()
		{
			int a = 5;
			int b = 10;
			int c = b;
			b = a;
			b = c;
			Console.WriteLine("a =  " + a + "    " + "b =  " + b);
		}
	}
}
