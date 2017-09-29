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
            string age = Console.ReadLine().ToLower();

            Console.WriteLine("What is the number of your birth month?");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIB color? If you do not know what ROYGBIV colors are, enter \"Help\".");
            string favColor = Console.ReadLine();

            if (favColor=="Help")
                {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
            }
            else
            {
                Console.WriteLine("What is the number of siblings that you have?");
                string numSiblings = Console.ReadLine();

     //this is believe is the end of part 1, at least for now.
            }
        }
    }
}
