namespace VikingsInterface.Views
{
    partial class Town
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picShop = new System.Windows.Forms.PictureBox();
            this.picArena = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArena)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::VikingsInterface.Properties.Resources.Player;
            this.picPlayer.Location = new System.Drawing.Point(12, 143);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(106, 92);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // picShop
            // 
            this.picShop.BackColor = System.Drawing.Color.Yellow;
            this.picShop.Location = new System.Drawing.Point(229, 388);
            this.picShop.Name = "picShop";
            this.picShop.Size = new System.Drawing.Size(321, 50);
            this.picShop.TabIndex = 0;
            this.picShop.TabStop = false;
            // 
            // picArena
            // 
            this.picArena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.picArena.Location = new System.Drawing.Point(229, 12);
            this.picArena.Name = "picArena";
            this.picArena.Size = new System.Drawing.Size(321, 50);
            this.picArena.TabIndex = 2;
            this.picArena.TabStop = false;
            // 
            // Town
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.picArena);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picShop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Town";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Town";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShop;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picArena;
    }
}