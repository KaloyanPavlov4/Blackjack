namespace Blackjack
{
    partial class MenuWindow
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
            this.pictureBoxPlayButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenuTitle = new System.Windows.Forms.PictureBox();
            this.pictureBoxRulesButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoginButton = new System.Windows.Forms.PictureBox();
            this.labelLoggedinUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRulesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlayButton
            // 
            this.pictureBoxPlayButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayButton.Image = global::Blackjack.Properties.Resources.buttonPlayNormal;
            this.pictureBoxPlayButton.Location = new System.Drawing.Point(277, 255);
            this.pictureBoxPlayButton.Name = "pictureBoxPlayButton";
            this.pictureBoxPlayButton.Size = new System.Drawing.Size(143, 60);
            this.pictureBoxPlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayButton.TabIndex = 0;
            this.pictureBoxPlayButton.TabStop = false;
            this.pictureBoxPlayButton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxPlayButton.MouseEnter += new System.EventHandler(this.pictureBoxPlayButton_MouseEnter);
            this.pictureBoxPlayButton.MouseLeave += new System.EventHandler(this.pictureBoxPlayButton_MouseLeave);
            // 
            // pictureBoxMenuTitle
            // 
            this.pictureBoxMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMenuTitle.Image = global::Blackjack.Properties.Resources.menuTitleText;
            this.pictureBoxMenuTitle.Location = new System.Drawing.Point(116, -2);
            this.pictureBoxMenuTitle.Name = "pictureBoxMenuTitle";
            this.pictureBoxMenuTitle.Size = new System.Drawing.Size(470, 241);
            this.pictureBoxMenuTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenuTitle.TabIndex = 1;
            this.pictureBoxMenuTitle.TabStop = false;
            // 
            // pictureBoxRulesButton
            // 
            this.pictureBoxRulesButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRulesButton.Image = global::Blackjack.Properties.Resources.buttonRulesNormal;
            this.pictureBoxRulesButton.Location = new System.Drawing.Point(277, 387);
            this.pictureBoxRulesButton.Name = "pictureBoxRulesButton";
            this.pictureBoxRulesButton.Size = new System.Drawing.Size(143, 60);
            this.pictureBoxRulesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRulesButton.TabIndex = 2;
            this.pictureBoxRulesButton.TabStop = false;
            this.pictureBoxRulesButton.Click += new System.EventHandler(this.pictureBoxRulesButton_Click);
            this.pictureBoxRulesButton.MouseEnter += new System.EventHandler(this.pictureBoxRulesButton_MouseEnter);
            this.pictureBoxRulesButton.MouseLeave += new System.EventHandler(this.pictureBoxRulesButton_MouseLeave);
            // 
            // pictureBoxLoginButton
            // 
            this.pictureBoxLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoginButton.Image = global::Blackjack.Properties.Resources.buttonLoginNormal;
            this.pictureBoxLoginButton.Location = new System.Drawing.Point(277, 321);
            this.pictureBoxLoginButton.Name = "pictureBoxLoginButton";
            this.pictureBoxLoginButton.Size = new System.Drawing.Size(143, 60);
            this.pictureBoxLoginButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginButton.TabIndex = 3;
            this.pictureBoxLoginButton.TabStop = false;
            this.pictureBoxLoginButton.Click += new System.EventHandler(this.pictureBoxLoginButton_Click);
            this.pictureBoxLoginButton.MouseEnter += new System.EventHandler(this.pictureBoxLoginButton_MouseEnter);
            this.pictureBoxLoginButton.MouseLeave += new System.EventHandler(this.pictureBoxLoginButton_MouseLeave);
            // 
            // labelLoggedinUser
            // 
            this.labelLoggedinUser.AutoSize = true;
            this.labelLoggedinUser.BackColor = System.Drawing.Color.Transparent;
            this.labelLoggedinUser.ForeColor = System.Drawing.Color.Silver;
            this.labelLoggedinUser.Location = new System.Drawing.Point(9, 9);
            this.labelLoggedinUser.Name = "labelLoggedinUser";
            this.labelLoggedinUser.Size = new System.Drawing.Size(95, 13);
            this.labelLoggedinUser.TabIndex = 4;
            this.labelLoggedinUser.Text = "labelLoggedinUser";
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.labelLoggedinUser);
            this.Controls.Add(this.pictureBoxLoginButton);
            this.Controls.Add(this.pictureBoxRulesButton);
            this.Controls.Add(this.pictureBoxMenuTitle);
            this.Controls.Add(this.pictureBoxPlayButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "MenuWindow";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRulesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlayButton;
        private System.Windows.Forms.PictureBox pictureBoxMenuTitle;
        private System.Windows.Forms.PictureBox pictureBoxRulesButton;
        private System.Windows.Forms.PictureBox pictureBoxLoginButton;
        private System.Windows.Forms.Label labelLoggedinUser;
    }
}