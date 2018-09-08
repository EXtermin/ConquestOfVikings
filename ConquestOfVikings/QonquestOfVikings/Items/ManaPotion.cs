using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings.Items
{
    class ManaPotion
    {
        Player player1;
        public ManaPotion(Player player)
        {
            this.player1 = player;
        }
        public int lesserMana = 15;
        public int greaterMana = 20;

        public void SetLesserMana()
        {
            int mana = player1.GetMana();
            player1.SetMana(mana + lesserMana);
        }

        public int GetLesserMana()
        {
            return this.lesserMana;
        }
        public void SetGreatermana()
        {
            int mana = player1.GetMana();
            player1.SetMana(mana + greaterMana);
        }
        public int GetGreaterMana()
        {
            return this.greaterMana;
        }
    

    }
    

}

