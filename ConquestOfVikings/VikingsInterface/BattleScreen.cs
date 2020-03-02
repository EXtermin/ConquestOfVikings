using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VikingsInterface
{
    public partial class BattleScreen : Form
    {
        PictureBox enemy;
        Sound sound = new Sound();
        public BattleScreen(PictureBox enemy, int IdEnemy)
        {
            this.enemy = enemy;

            InitializeComponent();
            LoadEnemy(IdEnemy);
            //sound.BattleBackground();
            Battle(IdEnemy);



        }

        public void LoadEnemy(int IdEnemy)
        {
            picEnemy.Image = enemy.Image;
            
        }
        public void Battle(int IdEnemy)
        {
            if (IdEnemy == 1)
            {

            }
            else if (IdEnemy == 2)
            {

            }
            else if (IdEnemy == 3)
            {

            }
            else if (IdEnemy == 4)
            {

            }
        }



    }
}
