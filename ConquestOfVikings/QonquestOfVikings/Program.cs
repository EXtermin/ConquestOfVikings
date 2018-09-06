using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
            width = origWidth + 40;
            height = origHeight + 2;
            Console.SetWindowSize(width, height);
            Console.WriteLine("W:{0} ---- H:{1}",Console.WindowWidth, Console.WindowHeight);
            
            if (File.Exists("Savegame.dat"))
            {
                Console.WriteLine("Want to continue your last adventure?");
                Console.WriteLine("(y/n <- if no you will start a new save...)");
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
                    Console.WriteLine("(yes/no) (y/n)");
                    string answer2 = Console.ReadLine();
                    if(answer2 == "y" || answer2 == "yes")
                    {
                        welcome.loadIntro();
                        start.Middle();
                    }
                    else if (answer2 == "n" || answer2 == "no")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
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
            Console.Clear();
            Console.WriteLine("\n Thanks for playing!");
            Thread.Sleep(2000);
            welcome.Exit();
            Thread.Sleep(1000);
            Console.WriteLine("\n Press any key to exit...");
            Console.ReadKey();
        }
    }
}
