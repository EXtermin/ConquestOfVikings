namespace VikingsInterface.Views
{
    partial class Shop
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
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picMerchant = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Red;
            this.picExit.Location = new System.Drawing.Point(447, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(100, 50);
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            // 
            // picMerchant
            // 
            this.picMerchant.BackColor = System.Drawing.Color.Lime;
            this.picMerchant.Location = new System.Drawing.Point(318, 335);
            this.picMerchant.Name = "picMerchant";
            this.picMerchant.Size = new System.Drawing.Size(100, 50);
            this.picMerchant.TabIndex = 2;
            this.picMerchant.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.White;
            this.picPlayer.Image = global::VikingsInterface.Properties.Resources.Player;
            this.picPlayer.Location = new System.Drawing.Point(312, 12);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(106, 92);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picMerchant);
            this.Controls.Add(this.picPlayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shop";
            this.Text = "Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMerchant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picMerchant;
        private System.Windows.Forms.PictureBox picExit;
    }
}