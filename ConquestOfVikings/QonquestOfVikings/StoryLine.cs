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
            Console.Clear();
            Sound sound = new Sound();

            sound.StoryBackground();
            Console.WriteLine("Welkom {0}", player1.GetPlayerName());
            Thread.Sleep(2500);
            Console.WriteLine("\n \n \n The story begins...");
            Thread.Sleep(2500);
            Console.WriteLine("\n A lonely viking... travelling.. across lands... seas... searching...");
            Thread.Sleep(2500);
            Console.WriteLine("\n For a purpose... a purpose to live... and die for...");
            Thread.Sleep(2500);
            Console.WriteLine("\n But one day... when {0} was walking trough a street...", player1.GetPlayerName());
            Thread.Sleep(3000);
            Console.Clear();

            battleBandit();

        }
        public void MainTown()
        {
            Console.Clear();
            Console.WriteLine("Player name: {0}" , player1.GetPlayerName());
            Console.WriteLine("Health:      {0}/{1}", player1.GetHealth(), player1.GetMaxHealth());
            Console.WriteLine("Mana:        {0}/{1}",player1.GetMana(), player1.GetMaxMana());
            Console.WriteLine("Level:       {0}", player1.GetLevel());
            Console.WriteLine("-Inventory-");
            Console.WriteLine("Gold:        {0}", player1.GetGold());
            foreach(string item in player1.GetInventory())
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine("================================\n");
            Console.WriteLine("Where do you want to go next? \n");
            Console.WriteLine("1) Shop");
            Console.WriteLine("2) Arena");
            Console.WriteLine("3) Exit town");
            Console.WriteLine("4) Battle again");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                townShop();
            }
            else if (choice == "2")
            {
                townArena();
            }
            else if (choice == "3")
            {
                EndBeginning();
            }
            else if (choice == "4")
            {
                battleBandit();
            }


        }

        public void townArena()
        {
            Arena arenaStart = new Arena(player1);
            Console.Clear();
            Console.WriteLine("\n You decide you want train yourself for battle and went to the arena.");
            Thread.Sleep(2500);
            arenaStart.arenaChoose();

        }

        public void townShop()
        {
            Shop shop = new Shop(player1);
            Console.Clear();
            Console.WriteLine("\n You walk through the small town looking for the shop.");
            Thread.Sleep(2500);
            Console.WriteLine("\n You look up and see a big sign with 'SHOP' written on it.");
            Thread.Sleep(2500);
            Console.WriteLine("\n As you enter you are welcomed by the shop keeper. \n");

            Console.WriteLine("\n1) Lesser MP Potion            (030g)");
            Console.WriteLine("2) Greater MP Potion             (050g)");
            Console.WriteLine("3) Lesser Healt Potion           (020g)");
            Console.WriteLine("4) Greater Health Potion         (027g)");
            Console.WriteLine("5) Leather Armor                 (175g)");
            Console.WriteLine("6) Chain Armor                   (275g)");
            Console.WriteLine("7) Iron Axe                      (125g)");
            Console.WriteLine("8) Torch                         (070g)");
            Console.WriteLine("9) Exit                                ");
            Console.WriteLine("\n \n Your gold: {0} " , player1.GetGold());

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the lesser MP potion");
                
                if(player1.GetGold() == 30)
                {
                   shop.Transaction("Lesser MP Potion", 30);

                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Greater MP potion.");
                if (player1.GetGold() == 50)
                {
                    shop.Transaction("MP potion", 50);

                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Lesser Health Potion");
                if (player1.GetGold() == 20)
                {
                    shop.Transaction("Lesser Health Potion", 20);

                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Greater Health Potion.");
                if (player1.GetGold() == 27)
                {
                    shop.Transaction("Greater Health Potion", 27);

                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "5")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Leather Armor.");
                if (player1.GetGold() == 175)
                {
                    shop.Transaction("Leather Armor", 175);
                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "6")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Chain Armor.");
                if (player1.GetGold() == 275)
                {
                    shop.Transaction("Chain Armor", 275);
                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "7")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Iron Axe.");
                if (player1.GetGold() == 125)
                {
                    shop.Transaction("Iron Axe", 125);
                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if (choice == "8")
            {
                Console.Clear();
                Console.WriteLine("\n You decide to buy the Torch.");
                if(player1.GetGold() == 70)
                {
                    shop.Transaction("Torch", 70);
                }
                else
                {
                    Console.WriteLine("You don't have enough gold");
                    Thread.Sleep(2000);
                }
                townShop();
            }
            else if(choice == "9")
            {
                Console.Clear();
                Console.WriteLine("\n You left the shop and went back into town.");
                Thread.Sleep(2000);
                MainTown();
            }
        }   

        public void EndBeginning()
        {
            Console.Clear();
            Console.WriteLine("\n As you walk out of town you are greeted by the town's guard. ");
            Thread.Sleep(2000);
            Console.WriteLine("\n You've known him for most of your life now.");
            Thread.Sleep(2000);
            Console.WriteLine("\n Growing up alone wasn't easy for you but he always helped you getting back on your feet. His name is Asgier.");
            Thread.Sleep(2000);
            Console.WriteLine("\n As you walk by Asgier, you both nod and you disappear onto a path. You take the path north through a giant forest.");
            Thread.Sleep(2000);
            Console.WriteLine("\n While you are going deeper into the forest you start hearing noises behind the tree's. \n \n ");

            Console.WriteLine("1) Look behind the tree's");
            Console.WriteLine("2) Keep on walking");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Thread.Sleep(2000);
                Console.WriteLine("\n  As you look behind the trees you see a small goblin running at you. He is ready to fight!");  // niet te ver van de town dus kan terug rennen en om guard's hulp vragen
                Thread.Sleep(3500);
                Console.Clear();
                battle.battleGoblinForest();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Thread.Sleep(2000);
                Console.WriteLine("\n  You shake the thought and continue walking. As you start to stop hearing the noises you step in something.\n");
                Thread.Sleep(2000);
                Console.WriteLine("\n ....");
                Thread.Sleep(2000);
                Console.WriteLine("\n ....");
                Thread.Sleep(2000);
                Console.WriteLine("\n It's a trap! your foot is stuck in a bear trap but its to weak to hurt you. ");
                Thread.Sleep(2000);
                Console.WriteLine("As you look around you get attacked by a bandit!");
                Thread.Sleep(3500);
                Console.Clear();
                battleBandit();
            }


        }


        public void battleBandit()
        {
            battle.BattleBandit();
        }
        public void battleGoblin()
        {
            battle.battleGoblin();
        }
        
    }

    }

