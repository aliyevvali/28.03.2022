using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    interface IAccount
    {
        bool PasswordChecker(string password);

        void ShowInfo();
                
    }
}
