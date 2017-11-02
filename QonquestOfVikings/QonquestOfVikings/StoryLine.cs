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
            
            Console.WriteLine("Welkom {0}", player1.GetPlayerName());
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\n \n \n The story begins...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n A lonely viking... travelling.. across lands... seas... searching...");
            Thread.Sleep(500);
            Console.WriteLine("\n For a purpose... a purpose to live... and die for...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("But one day... when {0} was walking trough a street... in a town...", player1.GetPlayerName());
            Thread.Sleep(3000);
            Battle();
            
        }

        public void Battle()
        {
            battle.battle();
        }
        
    }

    }

