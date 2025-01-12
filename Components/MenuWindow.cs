using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Blackjack
{
    public partial class MenuWindow : Form
    {
        public static bool loggedIn;
        private string resourceFolderPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources\\");
        public static PictureBox loginButton;
        public static Label labelLoggedUser;
        public static string loggedUserName;

        public MenuWindow()
        {
            InitializeComponent();
            loginButton = pictureBoxLoginButton;
            labelLoggedUser = labelLoggedinUser;
            if (loggedIn == false)
            {
                labelLoggedUser.Text = "Not logged in";
            } else
            {
                labelLoggedUser.Text = "Logged in: " + loggedUserName;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginDisabled.png");
            }
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
            if (loggedIn == true)
            {
                pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginDisabled.png");
            }
            else
            {
                pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginHover.png");
            }
            oldImage.Dispose();
        }
        private void pictureBoxLoginButton_MouseLeave(object sender, EventArgs e)
        {
            Image oldImage = pictureBoxLoginButton.Image;
            if (loggedIn == true)
            {
                pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginDisabled.png");
            }
            else
            {
                pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginNormal.png");
            }
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

        private void pictureBoxLoginButton_Click(object sender, EventArgs e)
        {
            if (loggedIn == false)
            {
                LoginForm loginFormWindow = new LoginForm();
                loginFormWindow.Show();
            } else
            {
                loggedIn = false;
                loggedUserName = null;
                loginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginNormal.png");
                labelLoggedUser.Text = "Not logged in";
            }
        }
    }
}
