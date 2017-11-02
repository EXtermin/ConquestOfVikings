using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Enemy : Mannequin
    {
        Random rnd;
        public Enemy(int health, int level, int mana, float baseDamage = 1) : base(health, level, baseDamage, mana, false)
        {
            rnd = new Random();  
        }

        public int GetAttack()
        {
            if (GetHealth() > 20)
                return rnd.Next(1, 3);
            else
                return rnd.Next(1, 4);
        }
    }
}
