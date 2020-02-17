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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            int xG = picGoblin.Location.X;
            int yG = picGoblin.Location.Y;
            if (picPlayer.Bounds.IntersectsWith(picGoblin.Bounds))
            {
                var myForm = new BattleScreen(picGoblin);
                myForm.Show();
            }
            if (picPlayer.Bounds.IntersectsWith(picGoblin2.Bounds))
            {
                var myForm = new BattleScreen(picGoblin2);
                myForm.Show();
            }

        }
    }
}
