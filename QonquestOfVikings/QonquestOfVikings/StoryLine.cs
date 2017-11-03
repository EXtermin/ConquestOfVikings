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
            Sound sound = new Sound();

            sound.StoryBackground();
            Console.WriteLine("Welkom {0}", player1.GetPlayerName());
            Thread.Sleep(1000);
            Console.WriteLine("\n \n \n The story begins...");
            Thread.Sleep(2000);
            Console.WriteLine("\n A lonely viking... travelling.. across lands... seas... searching...");
            Thread.Sleep(1500);
            Console.WriteLine("\n For a purpose... a purpose to live... and die for...");
            Thread.Sleep(2500);
            Console.WriteLine("\n But one day... when {0} was walking trough a street... in a town...", player1.GetPlayerName());
            Thread.Sleep(2000);
            Console.Clear();

            Battle();
            
        }
        public void Middle()
        {

        }

        public void Battle()
        {
            battle.battle();
        }
        
    }

    }

