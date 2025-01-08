using System;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
        }

        private void dealButton_Click(object sender, EventArgs e)
        {

        }
    }
}
