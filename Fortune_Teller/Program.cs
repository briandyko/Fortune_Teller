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
            Console.WriteLine("You are driving home from work after a busy, yet productive Friday. You are listening to some cool tunes, when all of a sudden the radio goes out. Then the engine turns off. You get out of your car and suddenly find yourself in a forest. You get out without much trouble, but approach a bridge. A troll comes from underneath and tells you this is his bridge, and the price to cross it is having your fortune read. Will you let him read your fortune?.");
            string invitation = Console.ReadLine().ToLower();

            //string answerInvitation = "yes";

            //    if (invitation == answerInvitation)
            {
                Console.WriteLine("What is your first name?");
                string fname = Console.ReadLine().ToLower();
            }

            //else
            //{
            //    Console.WriteLine("you have made a very bad choice, my friend, the trolls says before he eats you. game over.");
            //}


            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the number of your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV colors are, enter \"Help\".");
            string favColor = Console.ReadLine().ToLower();

            int numSiblings;

            if (favColor == "help")
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                string favColorPostHelp = Console.ReadLine().ToLower();
            }

            Console.WriteLine("What is the number of siblings that you have?");
            numSiblings = int.Parse(Console.ReadLine());


            //this is believe is the end of part 1, at least for now.

            Console.WriteLine("Here is your fortune, mortal!");
            int retireAge = age % 2;

            if (retireAge == 0)
            {
                Console.WriteLine("You will retire in 35 years.");
            }
            else
            {
                Console.WriteLine("You will retire in 4 years.");
            }

            if (numSiblings == 0)
            {
                Console.WriteLine("You will have a vacation home in Turks and Cacos, but mostly Cacos");
            }
            else if (numSiblings == 1)
            {
                Console.WriteLine("You will have a vacation home on Kelly's Island.");
            }
            else if (numSiblings == 2)
            {
                Console.WriteLine("You will have a vaction home on Jupiter");
            }
            else if (numSiblings == 3)
            {
                Console.WriteLine("You will have a vacation home in Maui");
            }
            else if (numSiblings > 3)
            {
                Console.WriteLine("You will have a vacation home in Phoenix");
            }
            else
                {
                Console.WriteLine("You will have a vacation in the eteranal fires of Hades!");
                }
           
            

               


       


        }
    }
}
