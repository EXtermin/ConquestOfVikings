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
            {
                Console.Clear();
                Console.WriteLine("\n As you walk out of town you are greeded by the town's guard. ");
                Thread.Sleep(2000);
                Console.WriteLine("\n You've known him for most of your life now. He was like the father you never had.");
                Thread.Sleep(2000);
                Console.WriteLine("\n Growing up alone wasn't easy for you but he always helped you along your way. His name was Asgier.");
                Thread.Sleep(2000);
                Console.WriteLine("\n As you walk by Asgier, you both node and you dissapear onto a path. You take the path north through a gaint forest.");
                Thread.Sleep(2000);
                Console.WriteLine("\n While you are going deeper into the forest you start hearing noises behind the tree's. \n \n ");

                Console.WriteLine("1) Look behind tree's");
                Console.WriteLine("2) Keep walking");

            }
            
       

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Thread.Sleep(2000);
                Console.WriteLine("\n  As you look behind the trees you see a small goblin running at you. He is ready to fight!");  // niet te ver van de town dus kan terug rennen en om guard's hulp vragen
                Thread.Sleep(3500);
                Console.Clear();
                Battle();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Thread.Sleep(2000);
                Console.WriteLine("\n  You shake the thought and continue walking. As you start to stop hearing the noises you step in something.\n");
                Thread.Sleep(2000);
                Console.WriteLine(" ....");
                Thread.Sleep(2000);
                Console.WriteLine(" ....");
                Thread.Sleep(2000);
                Console.WriteLine(" It's a trap! your foot is stuck in a bear trap but its to weak to hurt you. As you look around you get " +
                    "\n attacked by a bandit.");
                Thread.Sleep(3500);
                Console.Clear();
                Battle();
            }
               
               
            

        }

        public void Battle()
        {
            battle.battle();
        }
        
    }

    }

