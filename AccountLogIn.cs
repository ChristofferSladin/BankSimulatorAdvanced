using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulatorAdvanced
{
    internal class AccountLogIn
    {

        public void CreateAccount()
        {
            var accountAndPassword = new Dictionary<string, string>();

            Console.WriteLine("To use our services please create an account\n");

            Console.Write("User name: ");
            string userName = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();
            accountAndPassword.Add(userName, password);

            Console.Clear();

            bool run = true;
            while (run)
            {
                Console.WriteLine("\n---------------Please Log in---------------\n");

                Console.Write("User name: ");
                string checkUserName = Console.ReadLine();

                Console.Write("Password: ");
                string checkPassword = Console.ReadLine();

                if (userName == checkUserName && password == checkPassword)
                {
                    Console.Write("\n---------------Welcome to the Bank---------------\n");
                    var app = new Applications();
                    app.Run();

                    Console.Clear();
                    run = false;
                }

                else
                {
                    Console.WriteLine("-----------------------\n");
                    Console.WriteLine("Wrong User Name Or Password\nTry Again!");
                    
                }
            }

            

        }


    }
}
