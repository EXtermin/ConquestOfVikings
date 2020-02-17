using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikingsInterface
{
    class Shop
    {
        Player player1;
        public Shop(Player player)
        {
            this.player1 = player;
        }

        public void Transaction(string item, int price)
        {
            //StoryLine temp = new StoryLine(player1);
            int newGold = player1.GetGold() - price;
            player1.SetInventory(item);
            player1.SetGold(newGold);
            //temp.townShop();
        }
        // Lesser MP Potion, MP Potion, Lesser Health Potion, Health Potion, Chain armor, Iron armor, Iron Axe, Torch, 



    }
}

