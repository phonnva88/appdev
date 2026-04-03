using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal class Person
	{
		public string Name;
		public string Phone;
		public string Email;
		public string Role;

		public Person(string name, string phone, string email, string role)
		{
			Name = name;
			Phone = phone;
			Email = email;
			Role = role;
		}
	}
}
