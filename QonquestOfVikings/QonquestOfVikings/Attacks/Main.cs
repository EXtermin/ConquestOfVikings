using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings.Attacks
{
    class Main
    {
        string attackName;
        int minBaseDamage;
        int maxBaseDamage;
        int manaCost;
        bool isHeal;
        Random rnd;
        Utils.ConsoleControl cc;

        public Main(string attackName, int minBaseDamage, int maxBaseDamage, int manaCost, bool isHeal)
        {
            this.attackName = attackName;
            this.minBaseDamage = minBaseDamage;
            this.maxBaseDamage = maxBaseDamage;
            this.manaCost = manaCost;
            this.isHeal = isHeal;
            this.rnd = new Random();
            this.cc = new Utils.ConsoleControl();
        }

        public int UseAttack(Player user)
        {
            if(user.GetMana() >= manaCost)
            {
                int minDamage = (int)(minBaseDamage * user.GetBaseDamage());
                int maxDamage = (int)(maxBaseDamage * user.GetBaseDamage());
                int damage = rnd.Next(minDamage, maxDamage);

                if (user.GetIsPlayer())
                {
                    if (isHeal)
                        cc.AttackUse("You used: {0}", this.attackName, true);
                    else
                        cc.AttackUse("You used: {0} and did {1} damage", this.attackName, false, damage);
                }
                else
                {
                    if (isHeal)
                        cc.AttackUse("The enemy used: {0}", this.attackName, true);
                    else
                        cc.AttackUse("The enemy: {0} and did {1} damage", this.attackName, false, damage);
                }
                return damage;
            }
            else
            {
                if (user.GetIsPlayer())
                    cc.WriteLine("Not enough mana...");
                return -1;
            }
        }
    }
}
