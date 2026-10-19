using System;
using System.Collections.Generic;
using System.Text;

namespace hw8
{
    internal class User
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error: Id");
                }
                else
                {
                    _id = value;
                }
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 30)
                {
                    Console.WriteLine("Error: Name");
                }
                else
                {
                    _name = value;
                }
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 30)
                {
                    Console.WriteLine("Error: Surname");
                }
                else
                {
                    _surname = value;
                }
            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Error: Age");
                }
                else
                {
                    _age = value;
                }
            }
        }

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4 || value.Length > 20)
                {
                    Console.WriteLine("Error: Username");
                }
                else
                {
                    _username = value;
                }
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                {
                    Console.WriteLine("Error: Email");
                }
                else
                {
                    _email = value;
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 8)
                {
                    Console.WriteLine("Error: Password");
                }
                else
                {
                    _password = value;
                }
            }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.StartsWith("+995") || value.Length != 13)
                {
                    Console.WriteLine("Error: Phone");
                }
                else
                {
                    _phone = value;
                }
            }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (value > DateTime.Today)
                {
                    Console.WriteLine("Error: BirthDate");
                }
                else
                {
                    _birthDate = value;
                }
            }
        }

        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Balance");
                }
                else
                {
                    _balance = value;
                }
            }
        }
    }
}
