using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Program
    {

        static void Main(string[] args)
        {
            Intro welcome = new Intro();
            int origWidth, width;
            int origHeight, height;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            width = origWidth + 50;
            height = origHeight + 2;
            Console.SetWindowSize(width, height);
            Console.WriteLine("{0} ---- {1}",Console.WindowWidth,
                                  Console.WindowHeight);
            Console.ReadKey(true);
            
            if (File.Exists("Savegame.dat"))
            {
                Console.WriteLine("Want to continue your last adventure?");
                Console.WriteLine("(y/n)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "yes")
                {
                    Sound sound = new Sound();
                    sound.StoryBackground();
                    Player player1 = new Player("test");
                    SavegameManager load = new SavegameManager();
                    load.load(player1);
                    StoryLine start = new StoryLine(player1);
                    Console.Clear();
                    Console.WriteLine("Do you want to see the intro again?");
                    Console.WriteLine("yes/no (y/n)");
                    string anwser = Console.ReadLine();
                    if(answer == "y" || answer == "yes")
                    {
                        welcome.loadIntro();
                        start.Middle();
                    }
                    else
                    {
                        start.Middle();

                    }
                }
                else
                {
                    welcome.loadIntro();
                    Console.WriteLine("\n \n Please enter your name:");
                    string playerName = Console.ReadLine();
                    Player player1 = new Player(playerName);
                    StoryLine start = new StoryLine(player1);
                    start.Begin();
                }
            }
            else
            {
                
                welcome.loadIntro();
                Console.WriteLine("\n \n Please enter your name:");
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
