using System;
using System.Collections.Generic;
using System.Text;
using Task1_InterfaceClass.Interfaces;

namespace Task1_InterfaceClass
{
    class User : IAccount
    {

        public string Fullname;
        public string Email;
        public string Password;

   
        public bool PasswordChecker(string password)
        {
 


            while (true) {

                if (password.Length >= 8)
                {
                    bool checkUpper = false;
                    bool checkLower = false;
                    bool checkDigit = false;

                    foreach (char item in password)
                    {
                        if (char.IsUpper(item))
                        {
                            checkUpper = true;
                        }
                        else if (char.IsLower(item))
                        {
                            checkLower = true;
                        }
                        else if (char.IsDigit(item))
                        {
                            checkDigit = true;
                        }

                        if (checkUpper && checkLower == true && checkDigit)
                        {
                            Password = password;
                            return true;





                        }





                    }
                    if (!checkDigit || !checkLower || !checkUpper)
                    {
                        return false;
                      
                      

                    }
                }
                else
                {
                    return false;
                  
                }




            }

           
        }

        public string ShowInfo(string fullname,string email)
        {
            Fullname = fullname;
            Password = email;
            return $"Fullname:{Fullname}\nEmail:{Email}";
          
        }
        public User(string email, string sifre)
        {
            Email = email;
            Password = sifre;
        }
    }
}
