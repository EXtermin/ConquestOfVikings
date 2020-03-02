namespace VikingsInterface
{
    partial class BattleScreen
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
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttack1 = new System.Windows.Forms.Button();
            this.btnAttack2 = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.HealthBarPlayer = new System.Windows.Forms.ProgressBar();
            this.HealthBarEnemy = new System.Windows.Forms.ProgressBar();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblBattleP = new System.Windows.Forms.Label();
            this.lblBattleE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picEnemy
            // 
            this.picEnemy.Image = global::VikingsInterface.Properties.Resources.BasicGoblin;
            this.picEnemy.Location = new System.Drawing.Point(12, 158);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(473, 139);
            this.picEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemy.TabIndex = 0;
            this.picEnemy.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VikingsInterface.Properties.Resources.Player;
            this.pictureBox1.Location = new System.Drawing.Point(537, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAttack1
            // 
            this.btnAttack1.Location = new System.Drawing.Point(495, 459);
            this.btnAttack1.Name = "btnAttack1";
            this.btnAttack1.Size = new System.Drawing.Size(133, 80);
            this.btnAttack1.TabIndex = 2;
            this.btnAttack1.Text = "Slash";
            this.btnAttack1.UseVisualStyleBackColor = true;
            // 
            // btnAttack2
            // 
            this.btnAttack2.Location = new System.Drawing.Point(356, 459);
            this.btnAttack2.Name = "btnAttack2";
            this.btnAttack2.Size = new System.Drawing.Size(133, 80);
            this.btnAttack2.TabIndex = 3;
            this.btnAttack2.Text = "Kick";
            this.btnAttack2.UseVisualStyleBackColor = true;
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(634, 459);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(133, 80);
            this.btnHeal.TabIndex = 4;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            // 
            // HealthBarPlayer
            // 
            this.HealthBarPlayer.Location = new System.Drawing.Point(537, 133);
            this.HealthBarPlayer.Name = "HealthBarPlayer";
            this.HealthBarPlayer.Size = new System.Drawing.Size(133, 23);
            this.HealthBarPlayer.TabIndex = 5;
            // 
            // HealthBarEnemy
            // 
            this.HealthBarEnemy.Location = new System.Drawing.Point(12, 129);
            this.HealthBarEnemy.Name = "HealthBarEnemy";
            this.HealthBarEnemy.Size = new System.Drawing.Size(133, 23);
            this.HealthBarEnemy.TabIndex = 6;
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(30, 309);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(110, 21);
            this.lblEnemy.TabIndex = 7;
            this.lblEnemy.Text = "EnemyName";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(550, 309);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(85, 17);
            this.lblPlayer.TabIndex = 8;
            this.lblPlayer.Text = "PlayerName";
            // 
            // lblBattleP
            // 
            this.lblBattleP.AutoSize = true;
            this.lblBattleP.Location = new System.Drawing.Point(550, 352);
            this.lblBattleP.Name = "lblBattleP";
            this.lblBattleP.Size = new System.Drawing.Size(53, 17);
            this.lblBattleP.TabIndex = 9;
            this.lblBattleP.Text = "BattleP";
            // 
            // lblBattleE
            // 
            this.lblBattleE.AutoSize = true;
            this.lblBattleE.Location = new System.Drawing.Point(30, 352);
            this.lblBattleE.Name = "lblBattleE";
            this.lblBattleE.Size = new System.Drawing.Size(53, 17);
            this.lblBattleE.TabIndex = 10;
            this.lblBattleE.Text = "BattleE";
            // 
            // BattleScreen
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(779, 551);
            this.ControlBox = false;
            this.Controls.Add(this.lblBattleE);
            this.Controls.Add(this.lblBattleP);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.HealthBarEnemy);
            this.Controls.Add(this.HealthBarPlayer);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnAttack2);
            this.Controls.Add(this.btnAttack1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picEnemy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BattleScreen";
            this.Text = "BattleScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAttack1;
        private System.Windows.Forms.Button btnAttack2;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.ProgressBar HealthBarPlayer;
        private System.Windows.Forms.ProgressBar HealthBarEnemy;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblBattleP;
        private System.Windows.Forms.Label lblBattleE;
    }
}