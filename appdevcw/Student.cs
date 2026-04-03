using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal class Student : Person
	{
		public List<string> Subjects;

		public Student(string name, string phone, string email, List<string> subjects)
			: base(name, phone, email, "Student")
		{
			Subjects = subjects;
		}
	}
}
