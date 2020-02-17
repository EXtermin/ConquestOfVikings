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
        public BattleScreen(PictureBox enemy)
        {
            this.enemy = enemy;
            InitializeComponent();
            LoadEnemy();
        }

        public void LoadEnemy()
        {
            picEnemy.Image = enemy.Image;
        }


    }
}
