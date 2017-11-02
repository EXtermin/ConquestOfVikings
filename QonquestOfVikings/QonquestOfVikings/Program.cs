using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Program
    {

        static void Main(string[] args)
        {
            


            Console.WriteLine("Did you already play this before?");
            Console.WriteLine("(y/n)");

            string answer = Console.ReadLine();


            if(answer == "y" || answer == "yes")
            {
                SavegameManager load = new SavegameManager();
                load.load();
            }
            else
            {
                Console.WriteLine("Please enter your name:");

                string playerName = Console.ReadLine();
                Player player1 = new Player(playerName);

                StoryLine start = new StoryLine(player1);
                start.Begin();
            }


            Console.WriteLine("\n Thanks for playing!");
            Console.ReadKey();
        }
    }
}
