using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMastery_4._10_ShortIfStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Condition ? first_expression : second expression;
            // Condition has to be true or false
            // The condition operator is right - associative
            // The expression a ? b: c? d : e
            // is evaluted as a ? b : (c ?d : e),
            // not as (a? b : c) ? d: e,
            //The conditional operator cannot be overloaded.


            //Regular If statement format: 
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 0)
            {
                stateOfMatter = "Solid";
            }
            else
            {
                stateOfMatter = "Liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            temperature += 30;


            // in short:
            stateOfMatter = temperature < 0 ? "Solid" : "Liquid";
            Console.WriteLine("State of matter is: {0}", stateOfMatter);
            

            //Challange - Adding the state for gas when temperture is 100 or above degrees
            temperature += 200;
            stateOfMatter = temperature > 100 ? "Gas" : temperature < 0 ? "Solid" : "Liquid";
            Console.WriteLine("State of matter(new format)is : {0}", stateOfMatter + " you AN AWESOME DEVELOPER!");
            Console.ReadKey();
        }
    }
}
