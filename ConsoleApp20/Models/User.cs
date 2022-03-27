using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp20
{
    class User:IAccount
    {

        private static int _id;
        private string _password;
        public static int Id
        { 
            get
            {
                return _id;
            }
            
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value) == true) 
                {
                    _password = value;
                }
            }
        }

        public User(string email,string password)
        {
            Email = email;
            if (PasswordChecker(password)==true)
            {
                Password = password;
                _id++;
            }
            else
            {
                Console.WriteLine(email+" parolda sehvlik var!");
            }

        }        
        public bool PasswordChecker(string password)
        {
            
                Regex minCaracter = new Regex(@".{8,}");
                Regex oneUpperCaracter = new Regex(@"[A-Za-z]+");
                Regex minOneDigit = new Regex(@"[/d]");
                bool accountTrue = minCaracter.IsMatch(password) && oneUpperCaracter.IsMatch(password) && minOneDigit.IsMatch(password);
                return accountTrue;
            
            
            
        }

        public void ShowInfo()  
        {
            throw new NotImplementedException();
        }
    }
}
