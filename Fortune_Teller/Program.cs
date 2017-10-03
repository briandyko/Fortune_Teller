using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Congrats, you just made it out of the Forest of Horrors!!! You approach the \n bridge that leads back to Civilization, but alas, a boil-infested troll comes \n and blocks your safe passage. The price you must pay is having your fortune \n told!\n");
            
            Console.WriteLine("(The boils are making this troll weak, though, and if you would rather run away from this hideous monstrosity at any point, simply type \"quit\".)\n");

            Console.WriteLine("He asks you through his rotten teeth,\"What is your first name?\"");
            string fname = Console.ReadLine();

            if (fname.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("The troll sneers at you as he asks, \"What is your last name?\"");
            string lname = Console.ReadLine();

            if (lname.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("\"Nice name,\" he begrudgingly admits, \"But what is your age?\"");
            string age = (Console.ReadLine());
           
            if (age.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("\"Okay, okay...But the real question is what is the number of your birth month?\"");
            string birthMonth = (Console.ReadLine());

            if(birthMonth.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            Console.WriteLine("\"If you say so...Even more importantly, though, what is your favorite ROYGBIV \n color? And If you do not know what ROYGBIV colors are, enter \"Help\" for a list of them,\" he says ever so sinisterly.");
            string favColor = Console.ReadLine().ToLower();

            if (favColor == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.WriteLine("\"Now answer! What is your favorite ROYGBIV color?\"");
                string favColorPostHelp = Console.ReadLine().ToLower();
            }
            else if (favColor.ToLower() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            string numSiblings;
            Console.WriteLine("\"Finally, human, what is the number of siblings that you have?\"");
            numSiblings = (Console.ReadLine());

            if (numSiblings == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }

            // this is the end of part 1.

            Console.WriteLine("\n\"Here is your fortune, puny mortal!\"\n");
            // (to be displayed just before the fortune is read.)

            // age/# of years before retirement part

            int testRetireAge = Convert.ToInt32(age);
            int retireAge = testRetireAge % 2;
            string workYearsLeft;

            if (retireAge == 0)
            {
                workYearsLeft = "35 years";
            }
            else
            {
                workYearsLeft = "4 years";
            }

            // number of siblings/vacation home part

            int testNumSiblings = Convert.ToInt32(numSiblings);
            string vacation;

            if (testNumSiblings == 0)
            {
                vacation = "the Bermuda Triangle";
            }
            else if (testNumSiblings == 1)
            {
                vacation = "Wichita, Kansas";
            }
            else if (testNumSiblings == 2)
            {
                vacation = "Jupiter's core";
            }
            else if (testNumSiblings == 3)
            {
                vacation = "the International Space Station";
            }
            else if (testNumSiblings > 3)
            {
                vacation = "Middle Earth";
            }
            else
                {
                vacation = "the eternal fires of Hades";
                }

            // favorite color/mode of transportation part

            string transpo="".ToLower();

            if (favColor == "red")
            {
                transpo = "hovercraft";
            }
            else if (favColor == "orange")
            {
                transpo = "spaceship";
            }
            else if (favColor == "yellow")
            {
                transpo = "rickshaw";
            }
            else if (favColor == "green")
            {
                transpo = "dunebuggy";
            }
            else if (favColor == "blue")
            {
                transpo = "monster truck";
            }
            else if (favColor == "indigo")
            {
                transpo = "particle transporter";
            }
            else if (favColor == "violet")
            {
                transpo = "wheelbarrow";
            }
            else
            {
                transpo = "tricycle straight from The Shining";
            }

            // birth month number/amount of money in bank section

            int testBirthMonth = Convert.ToInt32(birthMonth);
            int salary;

            if (testBirthMonth >= 1 && testBirthMonth <= 4)
            {
                salary = 123123;
            }
            else if (testBirthMonth >= 5 && testBirthMonth <= 8)
            {
                salary = 67867838;
            }
            else if (testBirthMonth >= 9 && testBirthMonth <= 12)
            {
                salary = 105;
            }
            else
            {
                salary = 0;
            }

            // part 3 begins below!

            Console.WriteLine(fname + " " + lname + " will retire in " + workYearsLeft + " with " + "$"+salary + " in the bank, a vacation \n home in " + vacation + " and a " + transpo + ".");
         
        }
    }
}
