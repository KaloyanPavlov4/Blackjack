﻿namespace Blackjack
{
    partial class GameWindow
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
            this.pictureBoxDealer1 = new System.Windows.Forms.PictureBox();
            this.labelDealer = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.pictureBoxDealer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.standButton = new System.Windows.Forms.Button();
            this.hitMeButton = new System.Windows.Forms.Button();
            this.dealButton = new System.Windows.Forms.Button();
            this.pictureBoxPlayer3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealer5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealer4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDealer3 = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelDealerScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDealer1
            // 
            this.pictureBoxDealer1.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxDealer1.InitialImage = null;
            this.pictureBoxDealer1.Location = new System.Drawing.Point(167, 24);
            this.pictureBoxDealer1.Name = "pictureBoxDealer1";
            this.pictureBoxDealer1.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxDealer1.TabIndex = 27;
            this.pictureBoxDealer1.TabStop = false;
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.BackColor = System.Drawing.Color.Transparent;
            this.labelDealer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealer.ForeColor = System.Drawing.Color.White;
            this.labelDealer.Location = new System.Drawing.Point(89, 63);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(55, 21);
            this.labelDealer.TabIndex = 26;
            this.labelDealer.Text = "Dealer";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.ForeColor = System.Drawing.Color.White;
            this.labelPlayer.Location = new System.Drawing.Point(90, 172);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(53, 21);
            this.labelPlayer.TabIndex = 25;
            this.labelPlayer.Text = "Player";
            // 
            // pictureBoxDealer2
            // 
            this.pictureBoxDealer2.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxDealer2.Location = new System.Drawing.Point(257, 24);
            this.pictureBoxDealer2.Name = "pictureBoxDealer2";
            this.pictureBoxDealer2.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxDealer2.TabIndex = 24;
            this.pictureBoxDealer2.TabStop = false;
            // 
            // pictureBoxPlayer2
            // 
            this.pictureBoxPlayer2.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxPlayer2.Location = new System.Drawing.Point(257, 149);
            this.pictureBoxPlayer2.Name = "pictureBoxPlayer2";
            this.pictureBoxPlayer2.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxPlayer2.TabIndex = 23;
            this.pictureBoxPlayer2.TabStop = false;
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(167, 149);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxPlayer1.TabIndex = 22;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(257, 286);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 23);
            this.standButton.TabIndex = 21;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitMeButton
            // 
            this.hitMeButton.Location = new System.Drawing.Point(163, 286);
            this.hitMeButton.Name = "hitMeButton";
            this.hitMeButton.Size = new System.Drawing.Size(75, 23);
            this.hitMeButton.TabIndex = 20;
            this.hitMeButton.Text = "Hit";
            this.hitMeButton.UseVisualStyleBackColor = true;
            this.hitMeButton.Click += new System.EventHandler(this.hitMeButton_Click);
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(14, 247);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 19;
            this.dealButton.Text = "Start";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // pictureBoxPlayer3
            // 
            this.pictureBoxPlayer3.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxPlayer3.Location = new System.Drawing.Point(342, 149);
            this.pictureBoxPlayer3.Name = "pictureBoxPlayer3";
            this.pictureBoxPlayer3.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxPlayer3.TabIndex = 28;
            this.pictureBoxPlayer3.TabStop = false;
            this.pictureBoxPlayer3.Visible = false;
            // 
            // pictureBoxPlayer4
            // 
            this.pictureBoxPlayer4.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxPlayer4.Location = new System.Drawing.Point(427, 149);
            this.pictureBoxPlayer4.Name = "pictureBoxPlayer4";
            this.pictureBoxPlayer4.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxPlayer4.TabIndex = 29;
            this.pictureBoxPlayer4.TabStop = false;
            this.pictureBoxPlayer4.Visible = false;
            // 
            // pictureBoxPlayer5
            // 
            this.pictureBoxPlayer5.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxPlayer5.Location = new System.Drawing.Point(510, 149);
            this.pictureBoxPlayer5.Name = "pictureBoxPlayer5";
            this.pictureBoxPlayer5.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxPlayer5.TabIndex = 30;
            this.pictureBoxPlayer5.TabStop = false;
            this.pictureBoxPlayer5.Visible = false;
            // 
            // pictureBoxDealer5
            // 
            this.pictureBoxDealer5.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxDealer5.Location = new System.Drawing.Point(510, 24);
            this.pictureBoxDealer5.Name = "pictureBoxDealer5";
            this.pictureBoxDealer5.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxDealer5.TabIndex = 33;
            this.pictureBoxDealer5.TabStop = false;
            this.pictureBoxDealer5.Visible = false;
            // 
            // pictureBoxDealer4
            // 
            this.pictureBoxDealer4.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxDealer4.Location = new System.Drawing.Point(427, 24);
            this.pictureBoxDealer4.Name = "pictureBoxDealer4";
            this.pictureBoxDealer4.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxDealer4.TabIndex = 32;
            this.pictureBoxDealer4.TabStop = false;
            this.pictureBoxDealer4.Visible = false;
            // 
            // pictureBoxDealer3
            // 
            this.pictureBoxDealer3.Image = global::Blackjack.Properties.Resources.faceDownCard;
            this.pictureBoxDealer3.Location = new System.Drawing.Point(342, 24);
            this.pictureBoxDealer3.Name = "pictureBoxDealer3";
            this.pictureBoxDealer3.Size = new System.Drawing.Size(71, 96);
            this.pictureBoxDealer3.TabIndex = 31;
            this.pictureBoxDealer3.TabStop = false;
            this.pictureBoxDealer3.Visible = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.result.Location = new System.Drawing.Point(402, 286);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(96, 23);
            this.result.TabIndex = 34;
            this.result.Text = "ResultLable";
            this.result.Visible = false;
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerScore.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerScore.ForeColor = System.Drawing.Color.White;
            this.labelPlayerScore.Location = new System.Drawing.Point(91, 193);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(47, 16);
            this.labelPlayerScore.TabIndex = 35;
            this.labelPlayerScore.Text = "Score: ";
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.BackColor = System.Drawing.Color.Transparent;
            this.labelDealerScore.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealerScore.ForeColor = System.Drawing.Color.White;
            this.labelDealerScore.Location = new System.Drawing.Point(91, 84);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(47, 16);
            this.labelDealerScore.TabIndex = 36;
            this.labelDealerScore.Text = "Score: ";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pictureBoxDealer5);
            this.Controls.Add(this.pictureBoxDealer4);
            this.Controls.Add(this.pictureBoxDealer3);
            this.Controls.Add(this.pictureBoxPlayer5);
            this.Controls.Add(this.pictureBoxPlayer4);
            this.Controls.Add(this.pictureBoxPlayer3);
            this.Controls.Add(this.pictureBoxDealer1);
            this.Controls.Add(this.labelDealer);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.pictureBoxDealer2);
            this.Controls.Add(this.pictureBoxPlayer2);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitMeButton);
            this.Controls.Add(this.dealButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "GameWindow";
            this.Text = "Blackjack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDealer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDealer1;
        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.PictureBox pictureBoxDealer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.PictureBox pictureBoxPlayer3;
        private System.Windows.Forms.PictureBox pictureBoxPlayer5;
        private System.Windows.Forms.PictureBox pictureBoxDealer5;
        private System.Windows.Forms.PictureBox pictureBoxDealer4;
        private System.Windows.Forms.PictureBox pictureBoxDealer3;
        private System.Windows.Forms.PictureBox pictureBoxPlayer4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelDealerScore;
    }
}
