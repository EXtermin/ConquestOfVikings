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
                file.WriteLine(player.GetLevel());
                file.WriteLine(player.GetExp());
                file.WriteLine(player.GetBaseDamage());
                file.WriteLine(player.GetHealth());
                file.WriteLine(player.GetMaxHealth());
                file.WriteLine(player.GetMana());
                file.WriteLine(player.GetMaxMana());
            }
        }

        public void load(Player player1)
        {
            if(File.Exists("Savegame.dat"))
            {
                StreamReader reader = new StreamReader("Savegame.dat");
                string strAllFile = reader.ReadToEnd().Replace("\r\n", "\n").Replace("\n\r", "\n");
                string[] arrLines = strAllFile.Split(new char[] { '\n' });
                int level;
                int exp;
                int basedmg;
                int health;
                int maxhealth;
                int mana;
                int maxmana;


                Int32.TryParse(arrLines[0], out level);
                Int32.TryParse(arrLines[1], out exp);
                Int32.TryParse(arrLines[2], out basedmg);
                Int32.TryParse(arrLines[0], out health);
                Int32.TryParse(arrLines[0], out maxhealth);
                Int32.TryParse(arrLines[0], out mana);
                Int32.TryParse(arrLines[0], out maxmana);


                
                Console.ReadLine();


                player1.LoadStats( level, exp, basedmg, health, maxhealth, mana, maxmana);
            }
        }
    }

}


     
    

