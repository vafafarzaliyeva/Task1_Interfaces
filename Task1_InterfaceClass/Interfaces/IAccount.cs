using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_InterfaceClass.Interfaces
{
    interface IAccount
    {

        bool PasswordChecker(string password);

        string ShowInfo(string fullname, string email);
    }
}
