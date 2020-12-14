/*Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.”
 * (without the outer quotes). In one of the variables use quoted string and in the other do not use it.*/

using System;

namespace QuotedStrings
{
	class QuotedStrings
	{
		static void Main()
		{
			string notQuotedString = "the \"use\" of quotations causes difficulties.";
			string quotedString = @"the ""use"" of quotations causes difficulties.";

			Console.WriteLine(notQuotedString);
			Console.WriteLine(quotedString);
		}
	}
}
