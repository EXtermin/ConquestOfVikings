using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class SavegameManager
    {

        public void save(Player player)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"Savegame.dat", false))
            {
                file.WriteLine(player.GetPlayerName());
                file.WriteLine(player.GetLevel());
                file.WriteLine(player.GetExp());
                file.WriteLine(player.GetBaseDamage());
                file.WriteLine(player.GetHealPower());
                file.WriteLine(player.GetHealth());
                file.WriteLine(player.GetMaxHealth());
                file.WriteLine(player.GetMana());
                file.WriteLine(player.GetMaxMana());
                //string[] temp = player.GetInventory();
                //for (int i = 0; i < temp.Length; i++)
                //{
                //    file.WriteLine(temp[i]);
                //}
            }
        }

        public void load(Player player1)
        {
            if(File.Exists("Savegame.dat"))
            {
                StreamReader reader = new StreamReader("Savegame.dat");
                string strAllFile = reader.ReadToEnd().Replace("\r\n", "\n").Replace("\n\r", "\n");
                string[] arrLines = strAllFile.Split(new char[] { '\n' });
                reader.Close();

                int level;
                int exp;
                float basedmg;
                int healpower;
                int health;
                int maxhealth;
                int mana;
                int maxmana;
                string playerName = arrLines[0];

                Int32.TryParse(arrLines[1], out level);
                Int32.TryParse(arrLines[2], out exp);
                float.TryParse(arrLines[3], out basedmg);
                Int32.TryParse(arrLines[4], out healpower);
                Int32.TryParse(arrLines[5], out health);
                Int32.TryParse(arrLines[6], out maxhealth);
                Int32.TryParse(arrLines[7], out mana);
                Int32.TryParse(arrLines[8], out maxmana);

                player1.LoadStats(playerName, level, exp, basedmg, healpower, health, maxhealth, mana, maxmana);
            }
        }
    }

}


     
    

