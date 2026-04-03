using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal class Teacher : Person
	{
		public int Salary;
		public string Subject1;
		public string Subject2;

		public Teacher(string name, string phone, string email, int salary, string s1, string s2)
			: base(name, phone, email, "Teacher")
		{
			Salary = salary;
			Subject1 = s1;
			Subject2 = s2;
		}
	}
}
