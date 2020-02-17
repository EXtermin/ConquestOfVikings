using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VikingsInterface.Views
{
    public partial class Arena : Form
    {
        public Arena()
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
                picPlayer.Location = new Point(x, y);
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
        public void CheckEdges(int x, int y)
        {

        }
    }
}
