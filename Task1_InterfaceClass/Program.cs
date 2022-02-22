using System;

namespace Task1_InterfaceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fullname daxil edin");
            string fullname= Console.ReadLine();

            Console.WriteLine("Emaili daxil edin");
            string email = Console.ReadLine();

       

            Console.WriteLine("Sifreni daxil edin");
            string password = Console.ReadLine(); 
            
            User user = new User(email,password);

         Console.WriteLine(user.PasswordChecker(password));
           Console.WriteLine( user.ShowInfo(fullname,email));
           
       

        }
    }
}
