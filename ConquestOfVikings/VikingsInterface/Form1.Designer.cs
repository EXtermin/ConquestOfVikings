namespace VikingsInterface
{
    partial class Form1
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
            this.picTown = new System.Windows.Forms.PictureBox();
            this.picGoblin2 = new System.Windows.Forms.PictureBox();
            this.picGoblin = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoblin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoblin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picTown
            // 
            this.picTown.BackColor = System.Drawing.Color.Blue;
            this.picTown.Location = new System.Drawing.Point(1199, 178);
            this.picTown.Name = "picTown";
            this.picTown.Size = new System.Drawing.Size(100, 190);
            this.picTown.TabIndex = 3;
            this.picTown.TabStop = false;
            // 
            // picGoblin2
            // 
            this.picGoblin2.BackColor = System.Drawing.Color.Red;
            this.picGoblin2.Image = global::VikingsInterface.Properties.Resources.HeavyGoblin;
            this.picGoblin2.Location = new System.Drawing.Point(25, 316);
            this.picGoblin2.Name = "picGoblin2";
            this.picGoblin2.Size = new System.Drawing.Size(378, 111);
            this.picGoblin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoblin2.TabIndex = 2;
            this.picGoblin2.TabStop = false;
            this.picGoblin2.UseWaitCursor = true;
            // 
            // picGoblin
            // 
            this.picGoblin.BackColor = System.Drawing.Color.Red;
            this.picGoblin.Image = global::VikingsInterface.Properties.Resources.BasicGoblin;
            this.picGoblin.Location = new System.Drawing.Point(25, 109);
            this.picGoblin.Name = "picGoblin";
            this.picGoblin.Size = new System.Drawing.Size(378, 111);
            this.picGoblin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoblin.TabIndex = 1;
            this.picGoblin.TabStop = false;
            this.picGoblin.UseWaitCursor = true;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.White;
            this.picPlayer.Image = global::VikingsInterface.Properties.Resources.Player;
            this.picPlayer.Location = new System.Drawing.Point(638, 230);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(106, 92);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1311, 742);
            this.Controls.Add(this.picTown);
            this.Controls.Add(this.picGoblin2);
            this.Controls.Add(this.picGoblin);
            this.Controls.Add(this.picPlayer);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoblin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoblin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picGoblin2;
        private System.Windows.Forms.PictureBox picGoblin;
        private System.Windows.Forms.PictureBox picTown;
    }
}

