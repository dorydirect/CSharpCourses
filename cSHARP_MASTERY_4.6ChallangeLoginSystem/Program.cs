using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSHARP_MASTERY_4._6ChallangeLoginSystem
{
    class Program
    {
        //Varibles:
        static string _username;
        static string _password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        static void Register()
        {
            Console.WriteLine("Hello! Please Register to access your safe:");
            Console.WriteLine("Please enter your username: ");
            _username = Console.ReadLine();
            Console.WriteLine("Thanks!");
            Console.WriteLine("Please enter your password: ");
            _password = Console.ReadLine();
            Console.WriteLine("Registeration Completed");
            Console.WriteLine("--------------------------------");
        }
        static void Login()
        {
            Console.WriteLine("Enter Username: ");

            if (_username == Console.ReadLine())
            {
                Console.WriteLine("Enter Password: ");
                if (_password == Console.ReadLine())
                {
                    Console.WriteLine("Login Succesful");
                }
                else
                {
                    Console.WriteLine("Password is incorrect, Please try again.");
                    Login();
                }
            }
            else
            {
                Console.WriteLine("Username is incorrect, please try again. ");
                Login();
            }
        }
    }
}
