using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings.Items
{
    class Armor
    {
        Player player1;
        public int leatherArmor = 15;
        public int chainArmor =   30;

        public Armor(Player player)
        {
            this.player1 = player;
        }
        public void SetLeatherArmor()
        {
           int Maxhealth = player1.GetMaxHealth();
           player1.SetMaxHealth(Maxhealth + leatherArmor);
        }
        public int GetLeatherArmor()
        {
           return this.leatherArmor;
        }


        public void SetChainArmor()
        {
            int Maxhealth = player1.GetMaxHealth();
            player1.SetMaxHealth(Maxhealth + chainArmor);
        }
        public int GetChainArmor()
        {
            return this.chainArmor;
        }


        

    }
}
