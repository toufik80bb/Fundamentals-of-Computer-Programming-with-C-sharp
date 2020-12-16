/* A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic
 – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables
 needed to maintain the information for an employee by using the appropriate data types and attribute names.*/

using System;

namespace MarketingFirmEmployees
{
	class MarketingFirmEmployees
	{
		static void Main()
		{
			Console.WriteLine("Enter the first name: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Enter the last name: ");
			string lastName = Console.ReadLine();
			Console.WriteLine("Enter the age");
			byte age = byte.Parse(Console.ReadLine());
			Console.WriteLine("Enter the gender 'm' or 'f'");
			char gender = char.Parse(Console.ReadLine());
			Console.WriteLine("Enter the unique employee number");
			uint uniqueEmployeeNumber = uint.Parse(Console.ReadLine());
			while (!(uniqueEmployeeNumber <= 27569999 && uniqueEmployeeNumber >= 27560000 ))
			{
				Console.WriteLine("The unique employee number must be between 27560000 and 27569999");
				Console.WriteLine("Enter the unique employee number");
				uniqueEmployeeNumber = uint.Parse(Console.ReadLine());
			}
			Console.WriteLine("first name:   " + firstName);
			Console.WriteLine("Last name:    " + lastName);
			Console.WriteLine("Age:   " + age);
			Console.WriteLine("Gender:    " + gender);
			Console.WriteLine("unique Employee Number:   " + uniqueEmployeeNumber);
		}
	}
}
