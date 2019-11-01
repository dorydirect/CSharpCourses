using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSHARP_MASTERY_4._2ChallangeIfStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            string _userInputTemperture = Console.ReadLine();
            int temperture = int.Parse(_userInputTemperture);

            if (temperture == 10)
            {
                Console.WriteLine("It's 10 degrees... a bit chilly");
            }
            else if (temperture < 10)
            {
                Console.WriteLine("It's less 10 than degrees... It's Very cold man!");
            }
            else 
            {
                Console.WriteLine("It's more than 10 degrees... Feels warm!");
            }
            Console.ReadLine();
        }
    }
}
