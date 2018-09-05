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
            Console.WriteLine("\n But one day... when {0} was walking trough a street...", player1.GetPlayerName());
            Thread.Sleep(2000);
            Console.Clear();

            Battle();
            
        }
        public void Middle()
        {
            Console.WriteLine("Phew! {0} was that tough?",player1.GetPlayerName());
            Console.WriteLine("Well lets continue! Where do you want to go next? \n");

            Console.WriteLine("1) Shop");
            Console.WriteLine("2) Arena");
            Console.WriteLine("3) Exit town");
            Console.WriteLine("4) Battle again");

            string choice = Console.ReadLine();
            if(choice == "1")
            {

            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {
                EndBeginning();
            }
            else if (choice == "4")
            {
                Battle();
            }


        }

        public void EndBeginning()
        {
            Console.Clear();
            Console.WriteLine("As you walk out of town you are greeded by the town's guard. \n" +
                "You've known him for most of your life now. He was like a father you never had.");
        }

        public void Battle()
        {
            battle.battle();
        }
        
    }

    }

