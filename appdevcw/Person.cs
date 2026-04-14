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
		public RoleType Role { get; set; } // cmt.Typo error
		public Person(string name, string phone, string email, RoleType role)
		{
			Name = name;
			Phone = phone;
			Email = email;
			Role = role;
		}
	}
}
