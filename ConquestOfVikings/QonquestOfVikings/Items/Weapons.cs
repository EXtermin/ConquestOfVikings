using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings.Items
{
    class Weapons
    {
        Player player1;
        public Weapons(Player player)
        {
            this.player1 = player;
        }
        Random rnd = new Random();
        public int ironAxe;
        public bool torch;
        public void SetAttack()
        {
            this.ironAxe = rnd.Next(6,10);
        }
        public int GetAttack()
        {
            return this.ironAxe;
        }
        public bool GetIsTorch()
        {
            return this.torch;
        }
    }
}
