﻿using System;
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
            if (File.Exists("Savegame.dat"))
            {
                Console.WriteLine("Want to continue your last adventure?");
                Console.WriteLine("(y/n)");
                string answer = Console.ReadLine();
                if (answer == "y" || answer == "yes")
                {
                    Player player1 = new Player("test");
                    SavegameManager load = new SavegameManager();
                    load.load(player1);
                    StoryLine start = new StoryLine(player1);
                    start.Middle();
                }
                else
                {
                    Console.WriteLine("Please enter your name:");
                    string playerName = Console.ReadLine();
                    Player player1 = new Player(playerName);
                    StoryLine start = new StoryLine(player1);
                    start.Begin();
                }
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
