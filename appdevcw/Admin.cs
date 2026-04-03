using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal class Admin : Person
	{
		public int Salary;
		public string EmploymentType;
		public int WorkingHours;

		public Admin(string name, string phone, string email, int salary, string type, int hours)
			: base(name, phone, email, "Admin")
		{
			Salary = salary;
			EmploymentType = type;
			WorkingHours = hours;
		}
	}
}
