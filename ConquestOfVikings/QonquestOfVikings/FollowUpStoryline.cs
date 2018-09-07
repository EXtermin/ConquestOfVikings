using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class FollowUpStoryline
    {
        Player player1;
        Battle battle;
        public FollowUpStoryline(Player player)
        {
            this.player1 = player;
            this.battle = new Battle(player1);
           
        }
        public void FollowUpBegin()
        {
            Console.Clear();
            Console.WriteLine("\n You defeat the small goblin and decide to continue on your path.");
            Thread.Sleep(2500);
            Console.WriteLine("\n After walking for what seems like 30 minute's you find a enormous mountain. ");
            Thread.Sleep(2500);
            Console.WriteLine("\n As you walk along side the mountain you find the entrance to a cave.");
            Thread.Sleep(2500);
            Console.WriteLine("\n When you try to look inside of the cave you make out a weird black figure.");
            Thread.Sleep(2500);

            Console.WriteLine("\n What should I do? \n");
            Console.WriteLine("1) Head back to town. It doesn't look safe!");
            Console.WriteLine("2) Enter the cave. I can take it!");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                backToTown();
            }
            else if (choice == "2")
            {
                enterCave();
            }

        }

        public void backToTown()
        {
            Console.Clear();
            Console.WriteLine("\n You decide to head back to town. It's to risky to enter without a light source");
            Thread.Sleep(2500);

            StoryLine backTown = new StoryLine(player1);
            backTown.Middle();
        }

        public void enterCave()
        {
            Console.Clear();
            Console.WriteLine("\n You enter the cave and try to slash the black figure.");
            Thread.Sleep(2500);
            Console.WriteLine("\n But suprisingly you don't seem to hit anything.");
            Thread.Sleep(2500);
            Console.WriteLine("\n You try to follow the figure deeper into the cave ");
            Thread.Sleep(2500);
            Console.WriteLine("\n but you find hard to see without a light.");
            Thread.Sleep(2500);
            Console.WriteLine("\n You try to run at the figure but suddenly you feel like your falling.");
            Thread.Sleep(4000);

            Intro defeat = new Intro();
            defeat.Exit();

        }


        public void FollowUpMiddle()
        {
            
        }
         public void FollowUpEnd()
        {
            
        }
        public void Battle()
        {
            //Deze kan verandert worden ivm andere vijanden
            battle.battleBandit();
        }
    }
}
