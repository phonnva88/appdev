using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal class Admin : Person
	{
		public decimal Salary { get; set; }
		public EmploymentType EmploymentType { get; set; }
		public int WorkingHours { get; set; }

		public Admin(string name, string phone, string email, decimal salary, EmploymentType type, int hours)
			: base(name, phone, email, RoleType.Admin)
		{
			Salary = salary;
			EmploymentType = type;
			WorkingHours = hours;
		}
	}
}
