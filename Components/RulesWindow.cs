using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class RulesWindow : Form
    {
        string resourceFolderPath = MainForm.resourceFolderPath;
        public RulesWindow()
        {
            InitializeComponent();
        }

        private void pictureBoxBackButton_MouseLeave(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxBackButton.Image;
            pictureBoxBackButton.Image = Image.FromFile(resourceFolderPath + "buttonBackNormal.png");
            oldImage.Dispose();
        }

        private void pictureBoxBackButton_MouseEnter(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxBackButton.Image;
            pictureBoxBackButton.Image = Image.FromFile(resourceFolderPath + "buttonBackHover.png");
            oldImage.Dispose();
        }

        private void pictureBoxBackButton_Click(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Dock = DockStyle.Fill;
            menuWindow.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(menuWindow);
            menuWindow.Show();
            this.Dispose();
        }
        bool isChecked = false;
        private void radioButtonLanguageToggle_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButtonLanguageToggle.Checked;
        }

        private void radioButtonLanguageToggle_Click(object sender, EventArgs e)
        {
            Image leftToggle = Image.FromFile(resourceFolderPath + "toggleButtonLeft.png");
            Image rightToggle = Image.FromFile(resourceFolderPath + "toggleButtonRight.png");
            if (radioButtonLanguageToggle.Checked && !isChecked)
            {
                radioButtonLanguageToggle.Checked = false;
                labelRulesBG.Visible = false;
                labelRulesEN.Visible = true;
                radioButtonLanguageToggle.BackgroundImage = leftToggle;
                rightToggle.Dispose();
            }
            else
            {
                radioButtonLanguageToggle.Checked = true;
                isChecked = false;
                labelRulesBG.Visible = true;
                labelRulesEN.Visible = false;
                radioButtonLanguageToggle.BackgroundImage = rightToggle;
                leftToggle.Dispose();
            }
        }
    }
}
