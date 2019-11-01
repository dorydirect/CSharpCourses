using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpMastery4._8_Switchs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch statments format in integers
            int minAge = 21;
            
            switch (minAge)
            {
                case 5:
                    Console.WriteLine("You are too young!");
                    break;
                case 21:
                    Console.WriteLine("You are exactly in the right age! Come in");
                    break;
                default:
                    Console.WriteLine("I am not sure what is your age!");
                    break;


            }
            //Switch statments format in strings

            string _name = "Dor";

            switch (_name)
            {
                case "Dor":
                        Console.WriteLine("Name is Dor");
                        break;
                default:
                        Console.WriteLine("Name is not Dor");
                        break;
            }

            Console.Read();
        }
    }
}
