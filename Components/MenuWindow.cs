using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class MenuWindow : Form
    {
        public static bool loggedIn;
        private string resourceFolderPath = MainForm.resourceFolderPath;
        public static PictureBox loginButton;
        public static string loggedUserName;

        public MenuWindow()
        {
            InitializeComponent();
            loginButton = pictureBoxLoginButton;
        }

        public void LogIn(string username)
        {
            loggedIn = true;
            loggedUserName = username;
            loginButton.Image = Image.FromFile(resourceFolderPath + "buttonLogoutNormal.png");
            labelLoggedinUser.Text = "Logged in: " + username;

            loginButton.MouseEnter += pictureBoxLogoutButton_MouseEnter;
            loginButton.MouseEnter -= pictureBoxLoginButton_MouseEnter;
            loginButton.MouseLeave += pictureBoxLogoutButton_MouseLeave;
            loginButton.MouseLeave -= pictureBoxLoginButton_MouseLeave;
        }

        public void LogOut()
        {
            loggedIn = false;
            loggedUserName = null;
            loginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginNormal.png");
            labelLoggedinUser.Text = "Not logged in";

            loginButton.MouseEnter -= pictureBoxLogoutButton_MouseEnter;
            loginButton.MouseEnter += pictureBoxLoginButton_MouseEnter;
            loginButton.MouseLeave -= pictureBoxLogoutButton_MouseLeave;
            loginButton.MouseLeave += pictureBoxLoginButton_MouseLeave;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (loggedIn)
            {
                pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLogoutNormal.png");
                labelLoggedinUser.Text = "Logged in: " + loggedUserName;
            }
            else
            {
                labelLoggedinUser.Text = "Not logged in";
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
            ChangePictureBoxImage(pictureBoxPlayButton, "buttonPlayHover");
        }
        private void pictureBoxPlayButton_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxPlayButton, "buttonPlayNormal");
        }
        private void pictureBoxRulesButton_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxRulesButton, "buttonRulesHover");
        }
        private void pictureBoxRulesButton_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxRulesButton, "buttonRulesNormal");
        }
        private void pictureBoxLoginButton_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxLoginButton, "buttonLoginHover");
        }

        private void pictureBoxLoginButton_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxLoginButton, "buttonLoginNormal");
        }

        private void pictureBoxLogoutButton_MouseEnter(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxLoginButton, "buttonLogoutHover");
        }

        private void pictureBoxLogoutButton_MouseLeave(object sender, EventArgs e)
        {
            ChangePictureBoxImage(pictureBoxLoginButton, "buttonLogoutNormal");
        }

        public void ChangePictureBoxImage(PictureBox pictureBox, string imageName)
        {
            Image oldImage = pictureBox.Image;
            pictureBox.Image = Image.FromFile(resourceFolderPath + imageName + ".png");
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
            Dispose();
        }

        private void pictureBoxLoginButton_Click(object sender, EventArgs e)
        {
            if (loggedIn == false)
            {
                LoginForm loginFormWindow = new LoginForm(this);
                loginFormWindow.Show();
            } else
            {
                LogOut();
            }
        }
    }
}
