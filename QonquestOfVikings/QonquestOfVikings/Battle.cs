using QonquestOfVikings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Battle
    {
        Player player1;
        Enemy bandit;
        SavegameManager savegame;
        public Battle(Player player)
        {
            this.player1 = player;
            this.savegame = new SavegameManager();
        }

        public void GenerateEnemy()
        {
            Random lvlEnemy = new Random();
            if(player1.GetLevel() > 0 && player1.GetLevel() < 5)
            {
                int level = lvlEnemy.Next(1, 3);
                int mana = 30;
                int health = 100;
                for(int i = 1; i < level; i++)
                {
                    mana += 5;
                    health += 10;
                }
                bandit = new Enemy(health, level, mana);
            }
            else
            {
                int playerLevel = player1.GetLevel();
                int levelMarge = lvlEnemy.Next(-2, 8);
                int mana = 30;
                int health = 100;
                float baseMarge = 0.3f;
                float baseDamage = 1;
                int enemyLevel = playerLevel + levelMarge;

                for(int i = 1; i < enemyLevel; i++)
                {
                    baseDamage = baseDamage * baseMarge;
                    mana += 5;
                    health += 10;
                }         
                bandit = new Enemy(health, enemyLevel, mana);
            }
        }

        public void battle()
        {
            Sound sound = new Sound();
            sound.BattleBackground();
            Console.WriteLine("\n {0} got suddenly attacked!", player1.GetPlayerName());
            Thread.Sleep(3000);

            int plyattack;
            int plydamage;
            int enmdamage;

            GenerateEnemy();
            do
            {
                
                Console.WriteLine("\n {0} (Level: {1}) has: {2} HP - {3} MP", player1.GetPlayerName(), player1.GetLevel(), player1.GetHealth(), player1.GetMana());
                Console.WriteLine("\n The bandit (Level: {0}) has: {1} HP - {2} MP", bandit.GetLevel(), bandit.GetHealth(), bandit.GetMana());
                Console.WriteLine("\n");
                Console.WriteLine("Choose an attack:");
                Console.WriteLine("1. " + player1.GetAttack1().GetAttackName());
                Console.WriteLine("2. " + player1.GetAttack2().GetAttackName());
                Console.WriteLine("3. " + player1.GetAttack3().GetAttackName());


                string choise = Console.ReadLine();
                Int32.TryParse(choise, out plyattack);

                plydamage = player1.Attacks(plyattack, player1);
                bandit.Damage(plydamage);

                if (bandit.GetHealth() <= 0)
                {
                    break;
                }

                enmdamage = bandit.GetAttack();
                player1.Damage(enmdamage);
                

                Console.WriteLine("\n");
                if (player1.GetHealth() <= 0)
                {
                    break;
                }

                Thread.Sleep(1200);
                Console.Clear();

            } while (!(bandit.GetHealth() <= 0));
            sound.StoryBackground();
            if (bandit.GetHealth() <= 0)
            {
                
                Random rnd = new Random();
                Console.WriteLine("The bandit died yay! C:");
                player1.GainExp(rnd.Next(10, 70));
                player1.LevelUp();
                Console.WriteLine("Your current level is: {0}", player1.GetLevel());
                Console.WriteLine("Your current EXP is: {0}/100 EXP", player1.GetExp());

                Console.WriteLine("\n Do you want to play again?");
                Console.WriteLine("(y/n)");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "yes")
                {
                    player1.Regen();
                    savegame.save(player1);
                    Console.Clear();
                    battle();
                }
                else
                {
                    Console.WriteLine("\n \n oh... thats fine! have an awesome day! bai!");
                }
            }
            else
            {
                sound.Defeat();
                Console.WriteLine("oh nuuu you died at level {0}", player1.GetLevel());
            }
        }
    }
}
