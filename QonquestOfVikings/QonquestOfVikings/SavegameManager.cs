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

        public void load(Player player)
        {
            if(File.Exists("Savegame.dat"))
            {
                StreamReader reader = new StreamReader("Savegame.dat");
                string strAllFile = reader.ReadToEnd().Replace("\r\n", "\n").Replace("\n\r", "\n");
                string[] arrLines = strAllFile.Split(new char[] { '\n' });
                int health;


                Int32.TryParse(arrLines[0], out health);

                Console.WriteLine(health);
                Console.ReadLine();


                player.LoadStats();
            }
        }
    }

}


     
    

