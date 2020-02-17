using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Arena
    {
        Player player1;
        SavegameManager savegame;
        public Arena(Player player)
        {
            this.player1 = player;
            this.savegame = new SavegameManager();
        }
        public void arenaChoose()
        {
            Battle enemy = new Battle(player1);
            StoryLine back = new StoryLine(player1);
            Console.WriteLine("Choose 1 or 2");
            string choice = Console.ReadLine();
            if( choice == "1")
            {
                enemy.battleGoblinArena();
            }
            else if (choice == "2")
            {
                enemy.battleBanditArena();
            }
            else
            {
               back.MainTown();
            }

        }

    }
}
