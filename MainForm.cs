using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class MainForm : Form
    {
        public static Panel MainPanel;
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
    }
}
