using System;
using System.Collections.Generic;
using System.Text;

namespace appdevcw
{
	internal abstract class Person
	{
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Role { get; set; } // cmt.Typo error
		public Person(string name, string phone, string email, string role)
		{
			Name = name;
			Phone = phone;
			Email = email;
			Role = role;
		}
	}
}
