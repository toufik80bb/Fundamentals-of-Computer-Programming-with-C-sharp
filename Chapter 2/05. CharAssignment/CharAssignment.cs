/* Declare a variable of type char and assign it as a value the character, which has Unicode code, 72
 * (use the Windows calculator in order to find hexadecimal representation of 72).*/

using System;

namespace CharAssignment
{
	class CharAssignment
	{
		static void Main()
		{
			// Hexadessimal representation of 72 is 48.
			char c = '\u0048';
			Console.WriteLine(c);
			Console.ReadLine();
		}
	}
}
