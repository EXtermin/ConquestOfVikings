using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Player : Mannequin
    {
        Random rnd1 = new Random();
        private string playerName;
        private int protection;

        public Player(string playerName) : base(100, 1, 1, 30, true)
        {
            this.playerName = playerName;
            this.protection = 0;
        }
        public void LevelUp()
        {
            if(GetExp() >= 100)
            {
                SetExp(0);
                SetLevel(GetLevel() + 1);
                SetBaseDamage(GetBaseDamage() + 0.3f);
                SetHealPower(GetHealPower() + 5);
                SetMaxMana(GetMaxMana() + 5);
                SetMana(GetMaxMana());
                SetMaxHealth(GetMaxHealth() + 10);
                SetHealth(GetMaxHealth());
            }
        }

        public void GainExp(int gain)
        {
            SetExp(GetExp() + gain);
        }
        public void Regen()
        {
            SetHealth(GetMaxHealth());
            SetMana(GetMaxMana());
        }
        public void LoadStats(string playerName, int level, int exp, float basedmg,int healpower, int health, int maxhealth, int mana, int maxmana, int gold )
        {
            SetPlayerName(playerName);
            SetLevel(level);
            SetExp(exp);
            SetBaseDamage(basedmg);
            SetHealPower(healpower);
            SetHealth(health);
            SetMaxHealth(maxhealth);
            SetMana(mana);
            SetMaxMana(maxmana);
            SetGold(gold);
        }
        protected void SetPlayerName(string playername)
        {
            this.playerName = playername;
        }
        public string GetPlayerName()
        {
            return playerName;
        }       
    }
}
