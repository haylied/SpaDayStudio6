using System;
namespace SpaDay6.Models
{
	public class User
	{
		public string? Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

		public User(string email, string password)
		{
			Username = Email;
			Email = email;
			Password = password;
		}

	}
}

