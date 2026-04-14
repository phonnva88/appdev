using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal class Teacher : Person
	{
		public decimal Salary { get; set; }
		public string Subject1 { get; set; }
		public string Subject2 { get; set; }

		public Teacher(string name, string phone, string email, decimal salary, string s1, string s2)
			: base(name, phone, email, RoleType.Teacher)
		{
			Salary = salary;
			Subject1 = s1;
			Subject2 = s2;
		}
	}
}
