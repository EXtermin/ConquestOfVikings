using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VikingsInterface.Views;

namespace VikingsInterface
{
    public partial class Form1 : Form
    {
        //Sound sound = new Sound();
        public Form1()
        {
            InitializeComponent();
            //sound.StoryBackground();
            picGoblin.BackColor = Color.Transparent;
            picGoblin2.BackColor = Color.Transparent;
            picPlayer.BackColor = Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = picPlayer.Location.X;
            int y = picPlayer.Location.Y;
            if (e.KeyCode == Keys.W)
            {
                y -= 10;
                picPlayer.Location = new Point(x,y);
                CheckEdges(x, y);
            }
            if (e.KeyCode == Keys.D)
            {
                x += 10;
                picPlayer.Location = new Point(x, y);
                CheckEdges(x, y);

            }
            if (e.KeyCode == Keys.A)
            {
                x -= 10;
                picPlayer.Location = new Point(x, y);
                CheckEdges(x, y);
            }
            if (e.KeyCode == Keys.S)
            {
                y += 10;
                picPlayer.Location = new Point(x, y);
                CheckEdges(x, y);
            }
        }
        private void CheckEdges(int x, int y)
        {
            if (picPlayer.Bounds.IntersectsWith(picGoblin.Bounds))
            {
                var myForm = new BattleScreen(picGoblin, 1);
                myForm.Show();
            }
            else if (picPlayer.Bounds.IntersectsWith(picGoblin2.Bounds))
            {
                var myForm = new BattleScreen(picGoblin2, 2);
                myForm.Show();
                this.Hide();
            }
            else if (picPlayer.Bounds.IntersectsWith(picTown.Bounds))
            {
                var myForm = new Town();
                myForm.Show();
                this.Hide();
            }
        }
    }
}
