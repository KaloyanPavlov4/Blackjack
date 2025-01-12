using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
        public static string resourceFolderPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources\\");
        public MainForm()
        {
            InitializeComponent();
            MainPanel = panel1;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MenuWindow menuForm = new MenuWindow();
            menuForm.Dock = DockStyle.Fill;
            menuForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(menuForm);
            menuForm.Show();
        }

        public static void ChangePictureBoxImage(PictureBox pictureBox, string imageName)
        {
            Image oldImage = pictureBox.Image;
            pictureBox.Image = Image.FromFile(resourceFolderPath + imageName + ".png");
            oldImage.Dispose();
        }
    }
}
