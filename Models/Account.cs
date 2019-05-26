using System;

namespace Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set;  }
        public string Email { get; set;  }
        public bool IsAdmin { get; set; }

        public Account()
        {

        }

        public Account(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public Account(int id, string username, string password, string email, bool isAdmin, int characterId)
        {
            ID = id;
            Username = username;
            Password = password;
            Email = email;
            IsAdmin = isAdmin;
        }
    }
}
