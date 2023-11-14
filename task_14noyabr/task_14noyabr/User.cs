using System;
using System.Drawing;
using System.Security.Cryptography;

namespace task_14noyabr
{
    public class User : Account
    {
        private string password;

        private static int _id = 1;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }

        public string Password
        {
            get => password;
            set
            {
                if (PasswordChecker(value))
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                }
            }
        }
        public User(int id, string fullname, string email)
        {
            Fullname = fullname;
            Email = email;
            Id = _id;
            _id++;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Fullname: {Fullname}, Email: {Email}");
        }
    }
}
