using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings.Items
{
    class HealthPotion
    {
        Player player1;
        public int lesserHeal = 20;
        public int greaterHeal = 25;

        public HealthPotion(Player player)
        {
            this.player1 = player;
        }

        public void SetLesserHealth()
        {
            int health = player1.GetHealth();
            player1.SetHealth(health + lesserHeal);
        }
        public int GetlesserHealth()
        {
            return this.lesserHeal;
        }

        public void SetHealth()
        {
            int health = player1.GetHealth();
            player1.SetHealth(health + greaterHeal);
        }
        public int GetGreaterHeal()
        {
            return this.greaterHeal;
        }


    }
}
