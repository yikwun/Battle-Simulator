namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnSpecialAttack = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTitleHP1 = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.lblTitleHP2 = new System.Windows.Forms.Label();
            this.lblHPEnemy = new System.Windows.Forms.Label();
            this.lblHPUser = new System.Windows.Forms.Label();
            this.lblMPUser = new System.Windows.Forms.Label();
            this.lblMPEnemy = new System.Windows.Forms.Label();
            this.lblTitleMP1 = new System.Windows.Forms.Label();
            this.lblTitleMP2 = new System.Windows.Forms.Label();
            this.lblHealCounterUser = new System.Windows.Forms.Label();
            this.lblHealUser = new System.Windows.Forms.Label();
            this.lblHealCounterEnemy = new System.Windows.Forms.Label();
            this.lblHealEnemy = new System.Windows.Forms.Label();
            this.lblUserActions2 = new System.Windows.Forms.Label();
            this.lblEnemyActions2 = new System.Windows.Forms.Label();
            this.lblEnemyActions1 = new System.Windows.Forms.Label();
            this.lblUserActions1 = new System.Windows.Forms.Label();
            this.lblEnemyOutline = new System.Windows.Forms.Label();
            this.picHPUser = new System.Windows.Forms.PictureBox();
            this.picMPUser = new System.Windows.Forms.PictureBox();
            this.picHPEnemy = new System.Windows.Forms.PictureBox();
            this.picMPEnemy = new System.Windows.Forms.PictureBox();
            this.lblUserOutline = new System.Windows.Forms.Label();
            this.picMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHPUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHPEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.White;
            this.btnAttack.Location = new System.Drawing.Point(32, 236);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(140, 45);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnSpecialAttack
            // 
            this.btnSpecialAttack.BackColor = System.Drawing.Color.White;
            this.btnSpecialAttack.Location = new System.Drawing.Point(198, 236);
            this.btnSpecialAttack.Name = "btnSpecialAttack";
            this.btnSpecialAttack.Size = new System.Drawing.Size(140, 45);
            this.btnSpecialAttack.TabIndex = 4;
            this.btnSpecialAttack.Text = "Special Attack";
            this.btnSpecialAttack.UseVisualStyleBackColor = false;
            this.btnSpecialAttack.Click += new System.EventHandler(this.btnSpecialAttack_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.BackColor = System.Drawing.Color.White;
            this.btnHeal.Location = new System.Drawing.Point(32, 283);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(140, 45);
            this.btnHeal.TabIndex = 5;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = false;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(198, 283);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 45);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(170, 124);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(46, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Agumon";
            // 
            // lblTitleHP1
            // 
            this.lblTitleHP1.AutoSize = true;
            this.lblTitleHP1.BackColor = System.Drawing.Color.White;
            this.lblTitleHP1.Location = new System.Drawing.Point(170, 137);
            this.lblTitleHP1.Name = "lblTitleHP1";
            this.lblTitleHP1.Size = new System.Drawing.Size(22, 13);
            this.lblTitleHP1.TabIndex = 8;
            this.lblTitleHP1.Text = "HP";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.BackColor = System.Drawing.Color.White;
            this.lblEnemyName.Location = new System.Drawing.Point(283, 8);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(39, 13);
            this.lblEnemyName.TabIndex = 9;
            this.lblEnemyName.Text = "Blissey";
            // 
            // lblTitleHP2
            // 
            this.lblTitleHP2.AutoSize = true;
            this.lblTitleHP2.BackColor = System.Drawing.Color.White;
            this.lblTitleHP2.Location = new System.Drawing.Point(283, 19);
            this.lblTitleHP2.Name = "lblTitleHP2";
            this.lblTitleHP2.Size = new System.Drawing.Size(22, 13);
            this.lblTitleHP2.TabIndex = 10;
            this.lblTitleHP2.Text = "HP";
            // 
            // lblHPEnemy
            // 
            this.lblHPEnemy.AutoSize = true;
            this.lblHPEnemy.BackColor = System.Drawing.Color.White;
            this.lblHPEnemy.Location = new System.Drawing.Point(311, 19);
            this.lblHPEnemy.Name = "lblHPEnemy";
            this.lblHPEnemy.Size = new System.Drawing.Size(25, 13);
            this.lblHPEnemy.TabIndex = 11;
            this.lblHPEnemy.Text = "100";
            // 
            // lblHPUser
            // 
            this.lblHPUser.AutoSize = true;
            this.lblHPUser.BackColor = System.Drawing.Color.White;
            this.lblHPUser.Location = new System.Drawing.Point(198, 138);
            this.lblHPUser.Name = "lblHPUser";
            this.lblHPUser.Size = new System.Drawing.Size(25, 13);
            this.lblHPUser.TabIndex = 12;
            this.lblHPUser.Text = "100";
            // 
            // lblMPUser
            // 
            this.lblMPUser.AutoSize = true;
            this.lblMPUser.BackColor = System.Drawing.Color.White;
            this.lblMPUser.Location = new System.Drawing.Point(198, 173);
            this.lblMPUser.Name = "lblMPUser";
            this.lblMPUser.Size = new System.Drawing.Size(19, 13);
            this.lblMPUser.TabIndex = 13;
            this.lblMPUser.Text = "20";
            // 
            // lblMPEnemy
            // 
            this.lblMPEnemy.AutoSize = true;
            this.lblMPEnemy.BackColor = System.Drawing.Color.White;
            this.lblMPEnemy.Location = new System.Drawing.Point(311, 57);
            this.lblMPEnemy.Name = "lblMPEnemy";
            this.lblMPEnemy.Size = new System.Drawing.Size(19, 13);
            this.lblMPEnemy.TabIndex = 14;
            this.lblMPEnemy.Text = "20";
            // 
            // lblTitleMP1
            // 
            this.lblTitleMP1.AutoSize = true;
            this.lblTitleMP1.BackColor = System.Drawing.Color.White;
            this.lblTitleMP1.Location = new System.Drawing.Point(170, 173);
            this.lblTitleMP1.Name = "lblTitleMP1";
            this.lblTitleMP1.Size = new System.Drawing.Size(23, 13);
            this.lblTitleMP1.TabIndex = 15;
            this.lblTitleMP1.Text = "MP";
            // 
            // lblTitleMP2
            // 
            this.lblTitleMP2.AutoSize = true;
            this.lblTitleMP2.BackColor = System.Drawing.Color.White;
            this.lblTitleMP2.Location = new System.Drawing.Point(283, 57);
            this.lblTitleMP2.Name = "lblTitleMP2";
            this.lblTitleMP2.Size = new System.Drawing.Size(23, 13);
            this.lblTitleMP2.TabIndex = 16;
            this.lblTitleMP2.Text = "MP";
            // 
            // lblHealCounterUser
            // 
            this.lblHealCounterUser.AutoSize = true;
            this.lblHealCounterUser.BackColor = System.Drawing.Color.White;
            this.lblHealCounterUser.Location = new System.Drawing.Point(251, 173);
            this.lblHealCounterUser.Name = "lblHealCounterUser";
            this.lblHealCounterUser.Size = new System.Drawing.Size(55, 13);
            this.lblHealCounterUser.TabIndex = 17;
            this.lblHealCounterUser.Text = "Heals Left";
            // 
            // lblHealUser
            // 
            this.lblHealUser.AutoSize = true;
            this.lblHealUser.BackColor = System.Drawing.Color.White;
            this.lblHealUser.Location = new System.Drawing.Point(251, 186);
            this.lblHealUser.Name = "lblHealUser";
            this.lblHealUser.Size = new System.Drawing.Size(13, 13);
            this.lblHealUser.TabIndex = 18;
            this.lblHealUser.Text = "3";
            // 
            // lblHealCounterEnemy
            // 
            this.lblHealCounterEnemy.AutoSize = true;
            this.lblHealCounterEnemy.BackColor = System.Drawing.Color.White;
            this.lblHealCounterEnemy.Location = new System.Drawing.Point(362, 57);
            this.lblHealCounterEnemy.Name = "lblHealCounterEnemy";
            this.lblHealCounterEnemy.Size = new System.Drawing.Size(55, 13);
            this.lblHealCounterEnemy.TabIndex = 19;
            this.lblHealCounterEnemy.Text = "Heals Left";
            // 
            // lblHealEnemy
            // 
            this.lblHealEnemy.AutoSize = true;
            this.lblHealEnemy.BackColor = System.Drawing.Color.White;
            this.lblHealEnemy.Location = new System.Drawing.Point(362, 70);
            this.lblHealEnemy.Name = "lblHealEnemy";
            this.lblHealEnemy.Size = new System.Drawing.Size(13, 13);
            this.lblHealEnemy.TabIndex = 20;
            this.lblHealEnemy.Text = "3";
            // 
            // lblUserActions2
            // 
            this.lblUserActions2.BackColor = System.Drawing.Color.Azure;
            this.lblUserActions2.Location = new System.Drawing.Point(385, 251);
            this.lblUserActions2.Name = "lblUserActions2";
            this.lblUserActions2.Size = new System.Drawing.Size(171, 37);
            this.lblUserActions2.TabIndex = 21;
            // 
            // lblEnemyActions2
            // 
            this.lblEnemyActions2.BackColor = System.Drawing.Color.Azure;
            this.lblEnemyActions2.Location = new System.Drawing.Point(385, 291);
            this.lblEnemyActions2.Name = "lblEnemyActions2";
            this.lblEnemyActions2.Size = new System.Drawing.Size(171, 37);
            this.lblEnemyActions2.TabIndex = 22;
            // 
            // lblEnemyActions1
            // 
            this.lblEnemyActions1.BackColor = System.Drawing.Color.Azure;
            this.lblEnemyActions1.Location = new System.Drawing.Point(385, 277);
            this.lblEnemyActions1.Name = "lblEnemyActions1";
            this.lblEnemyActions1.Size = new System.Drawing.Size(171, 14);
            this.lblEnemyActions1.TabIndex = 23;
            // 
            // lblUserActions1
            // 
            this.lblUserActions1.BackColor = System.Drawing.Color.Azure;
            this.lblUserActions1.Location = new System.Drawing.Point(385, 239);
            this.lblUserActions1.Name = "lblUserActions1";
            this.lblUserActions1.Size = new System.Drawing.Size(171, 14);
            this.lblUserActions1.TabIndex = 24;
            // 
            // lblEnemyOutline
            // 
            this.lblEnemyOutline.BackColor = System.Drawing.Color.White;
            this.lblEnemyOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyOutline.Location = new System.Drawing.Point(277, 6);
            this.lblEnemyOutline.Name = "lblEnemyOutline";
            this.lblEnemyOutline.Size = new System.Drawing.Size(154, 92);
            this.lblEnemyOutline.TabIndex = 25;
            // 
            // picHPUser
            // 
            this.picHPUser.BackColor = System.Drawing.Color.Lime;
            this.picHPUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHPUser.Location = new System.Drawing.Point(174, 151);
            this.picHPUser.MaximumSize = new System.Drawing.Size(145, 19);
            this.picHPUser.MinimumSize = new System.Drawing.Size(2, 19);
            this.picHPUser.Name = "picHPUser";
            this.picHPUser.Size = new System.Drawing.Size(100, 19);
            this.picHPUser.TabIndex = 28;
            this.picHPUser.TabStop = false;
            // 
            // picMPUser
            // 
            this.picMPUser.BackColor = System.Drawing.Color.Blue;
            this.picMPUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMPUser.Location = new System.Drawing.Point(173, 189);
            this.picMPUser.MaximumSize = new System.Drawing.Size(70, 19);
            this.picMPUser.MinimumSize = new System.Drawing.Size(2, 19);
            this.picMPUser.Name = "picMPUser";
            this.picMPUser.Size = new System.Drawing.Size(20, 19);
            this.picMPUser.TabIndex = 29;
            this.picMPUser.TabStop = false;
            // 
            // picHPEnemy
            // 
            this.picHPEnemy.BackColor = System.Drawing.Color.Lime;
            this.picHPEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHPEnemy.Location = new System.Drawing.Point(284, 35);
            this.picHPEnemy.MaximumSize = new System.Drawing.Size(145, 19);
            this.picHPEnemy.MinimumSize = new System.Drawing.Size(2, 19);
            this.picHPEnemy.Name = "picHPEnemy";
            this.picHPEnemy.Size = new System.Drawing.Size(100, 19);
            this.picHPEnemy.TabIndex = 30;
            this.picHPEnemy.TabStop = false;
            // 
            // picMPEnemy
            // 
            this.picMPEnemy.BackColor = System.Drawing.Color.Blue;
            this.picMPEnemy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMPEnemy.Location = new System.Drawing.Point(286, 73);
            this.picMPEnemy.MaximumSize = new System.Drawing.Size(70, 19);
            this.picMPEnemy.MinimumSize = new System.Drawing.Size(2, 19);
            this.picMPEnemy.Name = "picMPEnemy";
            this.picMPEnemy.Size = new System.Drawing.Size(20, 19);
            this.picMPEnemy.TabIndex = 31;
            this.picMPEnemy.TabStop = false;
            // 
            // lblUserOutline
            // 
            this.lblUserOutline.BackColor = System.Drawing.Color.White;
            this.lblUserOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserOutline.Location = new System.Drawing.Point(167, 122);
            this.lblUserOutline.Name = "lblUserOutline";
            this.lblUserOutline.Size = new System.Drawing.Size(154, 92);
            this.lblUserOutline.TabIndex = 26;
            // 
            // picMenu
            // 
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(0, 228);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(602, 108);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 32;
            this.picMenu.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 337);
            this.Controls.Add(this.lblEnemyName);
            this.Controls.Add(this.picMPEnemy);
            this.Controls.Add(this.picHPEnemy);
            this.Controls.Add(this.picMPUser);
            this.Controls.Add(this.picHPUser);
            this.Controls.Add(this.lblUserActions1);
            this.Controls.Add(this.lblEnemyActions1);
            this.Controls.Add(this.lblEnemyActions2);
            this.Controls.Add(this.lblUserActions2);
            this.Controls.Add(this.lblHealEnemy);
            this.Controls.Add(this.lblHealCounterEnemy);
            this.Controls.Add(this.lblHealUser);
            this.Controls.Add(this.lblHealCounterUser);
            this.Controls.Add(this.lblTitleMP2);
            this.Controls.Add(this.lblTitleMP1);
            this.Controls.Add(this.lblMPEnemy);
            this.Controls.Add(this.lblMPUser);
            this.Controls.Add(this.lblHPUser);
            this.Controls.Add(this.lblHPEnemy);
            this.Controls.Add(this.lblTitleHP2);
            this.Controls.Add(this.lblTitleHP1);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnSpecialAttack);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblEnemyOutline);
            this.Controls.Add(this.lblUserOutline);
            this.Controls.Add(this.picMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.picHPUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHPEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMPEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnSpecialAttack;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTitleHP1;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label lblTitleHP2;
        private System.Windows.Forms.Label lblHPEnemy;
        private System.Windows.Forms.Label lblHPUser;
        private System.Windows.Forms.Label lblMPUser;
        private System.Windows.Forms.Label lblMPEnemy;
        private System.Windows.Forms.Label lblTitleMP1;
        private System.Windows.Forms.Label lblTitleMP2;
        private System.Windows.Forms.Label lblHealCounterUser;
        private System.Windows.Forms.Label lblHealUser;
        private System.Windows.Forms.Label lblHealCounterEnemy;
        private System.Windows.Forms.Label lblHealEnemy;
        private System.Windows.Forms.Label lblUserActions2;
        private System.Windows.Forms.Label lblEnemyActions2;
        private System.Windows.Forms.Label lblEnemyActions1;
        private System.Windows.Forms.Label lblUserActions1;
        private System.Windows.Forms.Label lblEnemyOutline;
        private System.Windows.Forms.PictureBox picHPUser;
        private System.Windows.Forms.PictureBox picMPUser;
        private System.Windows.Forms.PictureBox picHPEnemy;
        private System.Windows.Forms.PictureBox picMPEnemy;
        private System.Windows.Forms.Label lblUserOutline;
        private System.Windows.Forms.PictureBox picMenu;
    }
}

