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
            SavegameManager load = new SavegameManager();
            Console.WriteLine("Please enter your name:");

            string playerName = Console.ReadLine();
            Player player1 = new Player(playerName);

            StoryLine start = new StoryLine(player1);
            start.Begin();
            
            
            
            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();
        }
    }
}
