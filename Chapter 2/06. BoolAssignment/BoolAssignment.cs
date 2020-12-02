
//Declare a variable isMale of type bool and assign a value to it depending on your gender.

using System;

namespace BoolAssignment
{
	class BoolAssignment
	{
		static void Main()
		{
			Console.WriteLine("Enter your gender please! Male or Female. ");
			string gender = Console.ReadLine();
			bool isMale;
			if (gender == "Male")
			{
				isMale = true;
			}
			else
			{
				isMale = false;
			}

			Console.WriteLine("So you are a {0}.", isMale ? "Man" : "Woman");
		}
	}
}
