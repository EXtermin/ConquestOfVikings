using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Mannequin
    {
        private int health;
        private int maxHealth;
        private int level;
        private int exp;
        Random rnd = new Random();
        private float baseDamage;
        private int mana;
        private int maxMana;
        private bool isPlayer;

        protected Mannequin(int health, int level, float baseDamage, int mana, bool isPlayer, int exp = 0)
        {
            this.health = health;
            this.level = level;
            this.baseDamage = baseDamage;
            this.mana = mana;
            this.exp = exp;
            this.isPlayer = isPlayer;
            this.maxHealth = this.health;
            this.maxMana = this.mana;
        }

        public int GetAttackDamage(int attack)
        {
            int damage;
            rnd.Next();
            if (attack == 1)
            {
                int min = (int)(1 * baseDamage);
                int max = (int)(20 * baseDamage);
                damage = rnd.Next(min, max);
                if (isPlayer)
                    Console.WriteLine(" You used: Slash and did {0} damage", damage);
                else
                    Console.WriteLine(" The Bandit used: Slash and did {0} damage", damage);
                return damage;
            }
            else if (attack == 2)
            {
                if (mana > 3)
                {
                    int min = (int)(5 * baseDamage);
                    int max = (int)(25 * baseDamage);
                    mana -= 3;
                    damage = rnd.Next(min, max);
                    if (isPlayer)
                        Console.WriteLine(" You used: Stomp and did {0} damage", damage);
                    else
                        Console.WriteLine(" The Bandit used: Stomp and did {0} damage", damage);
                    return damage;
                }
                if(isPlayer)
                    Console.WriteLine("Not enough mana... Retry:");
                string choice = Console.ReadLine();
                Int32.TryParse(choice, out attack);
                return GetAttackDamage(attack);
            }
            else if (attack == 3)
            {
                if (mana > 6)
                {
                    SetHealth(GetHealth() + 30);
                    mana -= 6;
                    if (isPlayer)
                        Console.WriteLine(" You used: Heal");
                    else
                        Console.WriteLine(" The Bandit used: Heal");
                    return 0;
                }
                if (isPlayer)
                    Console.WriteLine("Not enough mana... Retry:");
                string choice = Console.ReadLine();
                Int32.TryParse(choice, out attack);
                return GetAttackDamage(attack);
            }
            else
            {
                if (isPlayer)
                    Console.WriteLine("Invalid Choice Retry:");
                string choice = Console.ReadLine();
                Int32.TryParse(choice, out attack);
                return GetAttackDamage(attack);
            }

        }

        public void Damage(int dmg)
        {
            this.health -= dmg;
        }

        public int GetExp()
        {
            return this.exp;
        }

        protected void SetExp(int exp)
        {
            this.exp = exp;
        }

        public int GetLevel()
        {
            return this.level;
        }

        protected void SetLevel(int level)
        {
            this.level = level;
        }

        public float GetBaseDamage()
        {
            return this.baseDamage;
        }

        protected void SetBaseDamage(float baseDamage)
        {
            this.baseDamage = baseDamage;
        }

        public int GetHealth()
        {
            return this.health;
        }

        protected void SetHealth(int health)
        {
            this.health = health;
        }

        public int GetMaxHealth()
        {
            return this.maxHealth;
        }

        protected void SetMaxHealth(int maxHealth)
        {
            this.maxHealth = maxHealth;
        }

        public int GetMana()
        {
            return this.mana;
        }

        protected void SetMana(int mana)
        {
            this.mana = mana;
        }

        public int GetMaxMana()
        {
            return this.maxMana;
        }

        protected void SetMaxMana(int maxMana)
        {
            this.maxMana = maxMana;
        }
    }
}
