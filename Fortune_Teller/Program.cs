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
            Console.WriteLine("Congrats, you just made it out of the Forest of Horrors!!! You approach the \n bridge that leads back to Civilization, but alas, a troll comes and blocks \n your safe passage. The price you must pay is having your fortune told!");
           
            //string invitation = Console.ReadLine().ToLower();

            //string answerInvitation = "yes";

            //    if (invitation == answerInvitation)
            
                Console.WriteLine("What is your first name?");
                string fname = Console.ReadLine();
         

            //else
            //{
            //    Console.WriteLine("you have made a very bad choice, my friend, the trolls says before he eats you. game over.");
            //}


            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the number of your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV colors are, enter \"Help\".");
            string favColor = Console.ReadLine().ToLower();

            if (favColor == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                string favColorPostHelp = Console.ReadLine().ToLower();
            }

            int numSiblings;

            Console.WriteLine("What is the number of siblings that you have?");
            numSiblings = int.Parse(Console.ReadLine());


            //this is believe is the end of part 1, at least for now.

            Console.WriteLine("Here is your fortune, mortal!");
            int retireAge = age % 2;
            string workYearsLeft;

            if (retireAge == 0)
            {
                workYearsLeft = "35 years";
            }
            else
            {
                workYearsLeft = "4 years";
            }

            string vacation;
            if (numSiblings == 0)
            {
                vacation = "the Bermuda Triangle";
            }
            else if (numSiblings == 1)
            {
                vacation = "Kelly's Island.";
            }
            else if (numSiblings == 2)
            {
                vacation = "Jupiter's core";
            }
            else if (numSiblings == 3)
            {
                vacation = "Maui";
            }
            else if (numSiblings > 3)
            {
                vacation = "Phoenix";
            }
            else
                {
                vacation = "the eteranal fires of Hades";
                }

            // favorite color part

            string transpo = "";

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

            //birth number section

            int salary;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                salary = 123123;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                salary = 678678;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                salary = 105;
            }
            else
            {
                salary = 0;
            }

            // part 3 begins below!

            Console.WriteLine(fname + " " + lname + " will retire in " + workYearsLeft + " with " + "$"+salary + " in the bank, a vacation home \n in " + vacation + " and a " + transpo + ".");
         
     
        }
    }
}
