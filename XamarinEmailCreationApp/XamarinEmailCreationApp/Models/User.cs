﻿namespace XamarinEmailCreationApp
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        { }

        public User(string name, string email, string password) 
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public User(string email, string password) : this("", email, password)
        { }
    }
}
