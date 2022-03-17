using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AccessModifier
{
    class User
    {
        private string _username;
        public string Name
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length == 6)
                {
                    _username = value;
                    return;
                }
                else
                {
                    Console.WriteLine("Username is incorrect!");
                }
            }
        }
        private string _password;
        public string Pass {
            get
            {
                return _password;
            }
            set
            {
                Regex regex = new Regex("[0-9]{7}[A-Z]{1}");

                if (value.Length>=1 && regex.IsMatch(value))
                {
                    _password = value;
                    
                }
                else
                {
                    Console.WriteLine("Girisiniz qadagandir");
                }
                

            }
        }

        public User(string username, string password)
        {
            Name = username;
            Pass = password;
        }
        public void UserAdmin()
        {
            Console.WriteLine("Istifadeci adinizi daxil edin");
            Name = Console.ReadLine();
            Console.WriteLine("Parolunuzu daxil edin");
            Pass = Console.ReadLine();
        }
    }
}
