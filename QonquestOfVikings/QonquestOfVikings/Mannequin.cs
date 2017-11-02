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
        private Attacks.Main attack1;
        private Attacks.Main attack2;
        private Attacks.Main attack3;

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
            this.attack1 = new Attacks.Slash();
            this.attack2 = new Attacks.Kick();
            this.attack3 = new Attacks.Heal();
        }

        public int GetAttackDamage(int attack, Mannequin user)
        {
            rnd.Next();
            if (attack == 1)
            {
                return attack1.UseAttack(user);
            }
            else if (attack == 2)
            {
                int dmg = attack2.UseAttack(user);
                if(dmg == -1)
                {
                    string choice = Console.ReadLine();
                    Int32.TryParse(choice, out attack);
                    return GetAttackDamage(attack, user);
                }
                return dmg;
            }
            else if (attack == 3)
            {
                int dmg = attack3.UseAttack(user);
                if (dmg == -1)
                {
                    string choice = Console.ReadLine();
                    Int32.TryParse(choice, out attack);
                    return GetAttackDamage(attack, user);
                }
                return dmg;
            }
            else
            {
                if (isPlayer)
                    Console.WriteLine("Invalid Choice Retry:");
                string choice = Console.ReadLine();
                Int32.TryParse(choice, out attack);
                return GetAttackDamage(attack, user);
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

        public void SetMana(int mana)
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

        public bool GetIsPlayer()
        {
            return this.isPlayer;
        }

        public Attacks.Main GetAttack1()
        {
            return this.attack1;
        }
        public Attacks.Main GetAttack2()
        {
            return this.attack2;
        }
        public Attacks.Main GetAttack3()
        {
            return this.attack3;
        }
    }
}
