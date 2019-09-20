using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace liigaasta
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int birthYear;
            Console.WriteLine("What year did you born");
            birthYear = Int32.Parse(Console.ReadLine());

            
            if (birthYear % 4 == 0)
            {
                Console.WriteLine($"{birthYear} was a Leap Year. ");
            }

            else
            {
                Console.WriteLine($"{birthYear} was NOT a Leap Year. ");
            }

            Console.ReadLine(); */

            //Ternary Operator - kui ainult kaks võimalust
            /*
            string answer = (birthYear % 4 == 0) ? "Leap Year" : "Not a Leap Year";
            Console.WriteLine(answer);
            Console.ReadLine(); */



            
            Console.WriteLine("Choose your poison: Whisky or wine? ");
            
            string yourDrink = Console.ReadLine();
            string choice =  yourDrink == "whisky" ? "Take your whisky" : "Here is your wine";
            Console.WriteLine(choice);
            Console.ReadLine();






        }
    }
}
