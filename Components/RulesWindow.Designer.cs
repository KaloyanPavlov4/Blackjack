namespace Blackjack
{
    partial class RulesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesWindow));
            this.pictureBoxBackButton = new System.Windows.Forms.PictureBox();
            this.labelRulesEN = new System.Windows.Forms.Label();
            this.radioButtonLanguageToggle = new System.Windows.Forms.RadioButton();
            this.labelRulesBG = new System.Windows.Forms.Label();
            this.pictureBoxLanguage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBackButton
            // 
            this.pictureBoxBackButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackButton.Image = global::Blackjack.Properties.Resources.buttonBackNormal;
            this.pictureBoxBackButton.Location = new System.Drawing.Point(275, 381);
            this.pictureBoxBackButton.Name = "pictureBoxBackButton";
            this.pictureBoxBackButton.Size = new System.Drawing.Size(143, 60);
            this.pictureBoxBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackButton.TabIndex = 0;
            this.pictureBoxBackButton.TabStop = false;
            this.pictureBoxBackButton.Click += new System.EventHandler(this.pictureBoxBackButton_Click);
            this.pictureBoxBackButton.MouseEnter += new System.EventHandler(this.pictureBoxBackButton_MouseEnter);
            this.pictureBoxBackButton.MouseLeave += new System.EventHandler(this.pictureBoxBackButton_MouseLeave);
            // 
            // labelRulesEN
            // 
            this.labelRulesEN.BackColor = System.Drawing.Color.Transparent;
            this.labelRulesEN.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRulesEN.ForeColor = System.Drawing.Color.White;
            this.labelRulesEN.Location = new System.Drawing.Point(12, 9);
            this.labelRulesEN.Name = "labelRulesEN";
            this.labelRulesEN.Size = new System.Drawing.Size(676, 369);
            this.labelRulesEN.TabIndex = 1;
            this.labelRulesEN.Text = resources.GetString("labelRulesEN.Text");
            // 
            // radioButtonLanguageToggle
            // 
            this.radioButtonLanguageToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLanguageToggle.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLanguageToggle.BackgroundImage = global::Blackjack.Properties.Resources.toggleButtonLeft;
            this.radioButtonLanguageToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonLanguageToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonLanguageToggle.ForeColor = System.Drawing.Color.Transparent;
            this.radioButtonLanguageToggle.Location = new System.Drawing.Point(17, 420);
            this.radioButtonLanguageToggle.Name = "radioButtonLanguageToggle";
            this.radioButtonLanguageToggle.Size = new System.Drawing.Size(100, 25);
            this.radioButtonLanguageToggle.TabIndex = 2;
            this.radioButtonLanguageToggle.UseVisualStyleBackColor = false;
            this.radioButtonLanguageToggle.CheckedChanged += new System.EventHandler(this.radioButtonLanguageToggle_CheckedChanged);
            this.radioButtonLanguageToggle.Click += new System.EventHandler(this.radioButtonLanguageToggle_Click);
            // 
            // labelRulesBG
            // 
            this.labelRulesBG.BackColor = System.Drawing.Color.Transparent;
            this.labelRulesBG.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRulesBG.ForeColor = System.Drawing.Color.White;
            this.labelRulesBG.Location = new System.Drawing.Point(12, 9);
            this.labelRulesBG.Name = "labelRulesBG";
            this.labelRulesBG.Size = new System.Drawing.Size(676, 369);
            this.labelRulesBG.TabIndex = 3;
            this.labelRulesBG.Text = resources.GetString("labelRulesBG.Text");
            this.labelRulesBG.Visible = false;
            // 
            // pictureBoxLanguage
            // 
            this.pictureBoxLanguage.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLanguage.Image = global::Blackjack.Properties.Resources.round_flag_selection_button_badge_600nw_2257737117_removebg_preview;
            this.pictureBoxLanguage.Location = new System.Drawing.Point(17, 364);
            this.pictureBoxLanguage.Name = "pictureBoxLanguage";
            this.pictureBoxLanguage.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLanguage.TabIndex = 4;
            this.pictureBoxLanguage.TabStop = false;
            // 
            // RulesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pictureBoxLanguage);
            this.Controls.Add(this.labelRulesBG);
            this.Controls.Add(this.radioButtonLanguageToggle);
            this.Controls.Add(this.labelRulesEN);
            this.Controls.Add(this.pictureBoxBackButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "RulesWindow";
            this.Text = "RulesWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLanguage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBackButton;
        private System.Windows.Forms.Label labelRulesEN;
        private System.Windows.Forms.RadioButton radioButtonLanguageToggle;
        private System.Windows.Forms.Label labelRulesBG;
        private System.Windows.Forms.PictureBox pictureBoxLanguage;
    }
}