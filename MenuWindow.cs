using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class MenuWindow : Form
    {
        private string resourceFolderPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources\\");

        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Dock = DockStyle.Fill;
            gameWindow.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(gameWindow);
            gameWindow.Show();
        }
        private void pictureBoxPlayButton_MouseEnter(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxPlayButton.Image;
            pictureBoxPlayButton.Image = Image.FromFile(resourceFolderPath + "buttonPlayHover.png");
            oldImage.Dispose();
        }
        private void pictureBoxPlayButton_MouseLeave(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxPlayButton.Image;
            pictureBoxPlayButton.Image = Image.FromFile(resourceFolderPath + "buttonPlayNormal.png");
            oldImage.Dispose();
        }
        private void pictureBoxRulesButton_MouseEnter(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxRulesButton.Image;
            pictureBoxRulesButton.Image = Image.FromFile(resourceFolderPath + "buttonRulesHover.png");
            oldImage.Dispose();
        }
        private void pictureBoxRulesButton_MouseLeave(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxRulesButton.Image;
            pictureBoxRulesButton.Image = Image.FromFile(resourceFolderPath + "buttonRulesNormal.png");
            oldImage.Dispose();
        }
        private void pictureBoxLoginButton_MouseEnter(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxLoginButton.Image;
            pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginHover.png");
            oldImage.Dispose();
        }
        private void pictureBoxLoginButton_MouseLeave(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxLoginButton.Image;
            pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginNormal.png");
            oldImage.Dispose();
        }
        private void pictureBoxRulesButton_Click(object sender, EventArgs e)
        {
            RulesWindow ruleWindow = new RulesWindow();
            ruleWindow.Dock = DockStyle.Fill;
            ruleWindow.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(ruleWindow);
            ruleWindow.Show();
            this.Dispose();
        }
    }
}
