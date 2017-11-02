using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    

    class StoryLine
    {
        Player player1;
        Battle battle;
        public StoryLine(Player player)
        {
            this.player1 = player;
            this.battle = new Battle(player1);
        }

        public void Begin()
        {
            
            int attack;

            Console.WriteLine(player1.GetPlayerName());
            Thread.Sleep(3000);
            Console.WriteLine("Welkom {0}", player1.GetPlayerName());
            Console.Clear();
            Console.WriteLine("\n \n \n The story begins...");
            Console.Clear();
            Console.WriteLine("A lonely viking... travelling.. across lands... seas... searching...");
            Console.WriteLine("");
            Console.WriteLine("For a purpose... a purpose to live... and die for...");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("But one day... when {0} was walking trough a street... in a town...", player1.GetPlayerName());

            Battle();
            
        }

        public void Battle()
        {
            battle.battle();
        }
        
    }

    }

