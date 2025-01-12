using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class MenuWindow : Form
    {
        private readonly string resourceFolderPath = MainForm.resourceFolderPath;
        public static bool loggedIn;
        public static string loggedUserName;

        public MenuWindow()
        {
            InitializeComponent();
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

        public void LogIn(string username)
        {
            loggedIn = true;
            loggedUserName = username;
            pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLogoutNormal.png");
            labelLoggedinUser.Text = "Logged in: " + username;

            //Променя снимките на бутона да са за изход от акаунта
            pictureBoxLoginButton.MouseEnter -= pictureBoxLoginButton_MouseEnter;
            pictureBoxLoginButton.MouseEnter += pictureBoxLogoutButton_MouseEnter;
            pictureBoxLoginButton.MouseLeave -= pictureBoxLoginButton_MouseLeave;
            pictureBoxLoginButton.MouseLeave += pictureBoxLogoutButton_MouseLeave;
        }

        public void LogOut()
        {
            loggedIn = false;
            loggedUserName = null;
            pictureBoxLoginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginNormal.png");
            labelLoggedinUser.Text = "Not logged in";

            //Променя снимките на бутона да са за вход
            pictureBoxLoginButton.MouseEnter -= pictureBoxLogoutButton_MouseEnter;
            pictureBoxLoginButton.MouseEnter += pictureBoxLoginButton_MouseEnter;
            pictureBoxLoginButton.MouseLeave -= pictureBoxLogoutButton_MouseLeave;
            pictureBoxLoginButton.MouseLeave += pictureBoxLoginButton_MouseLeave;
        }

        private void pictureBoxPlayButton_Click(object sender, EventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Dock = DockStyle.Fill;
            gameWindow.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(gameWindow);
            gameWindow.Show();
            Dispose();
        }

        private void pictureBoxLoginButton_Click(object sender, EventArgs e)
        {
            if (loggedIn == false)
            {
                LoginForm loginFormWindow = new LoginForm(this);
                loginFormWindow.Show();
            }
            else
            {
                LogOut();
            }
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

        /*
         * Методи за снимките на бутоните
         * Снимката на бутона се променя при слагане на мишката върху него и се връща при махане на мишката
         */
        private void pictureBoxPlayButton_MouseEnter(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxPlayButton, "buttonPlayHover");
        }
        private void pictureBoxPlayButton_MouseLeave(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxPlayButton, "buttonPlayNormal");
        }
        private void pictureBoxRulesButton_MouseEnter(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxRulesButton, "buttonRulesHover");
        }
        private void pictureBoxRulesButton_MouseLeave(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxRulesButton, "buttonRulesNormal");
        }
        private void pictureBoxLoginButton_MouseEnter(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxLoginButton, "buttonLoginHover");
        }

        private void pictureBoxLoginButton_MouseLeave(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxLoginButton, "buttonLoginNormal");
        }

        private void pictureBoxLogoutButton_MouseEnter(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxLoginButton, "buttonLogoutHover");
        }

        private void pictureBoxLogoutButton_MouseLeave(object sender, EventArgs e)
        {
            MainForm.ChangePictureBoxImage(pictureBoxLoginButton, "buttonLogoutNormal");
        }
    }
}
