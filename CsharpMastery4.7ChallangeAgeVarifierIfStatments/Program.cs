using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMastery4._7ChallangeAgeVarifierIfStatments
{
    class Program
    {
        static private int minimumAge = 21;
        static string _userAge;
        static int userAgeAsInt => int.Parse(_userAge);

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the club!");
            Console.WriteLine("How old are you?");
            _userAge = Console.ReadLine();
            

            if ( userAgeAsInt < minimumAge)
            {
                Console.WriteLine("You can't go in the club kiddo!");
            }
            else
            {
                Console.WriteLine("Come inside, first drink is free!");
            }
            Console.Read();

        }
    }
}
