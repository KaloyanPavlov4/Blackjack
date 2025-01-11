using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class LoginForm : Form
    {
        private string resourceFolderPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources\\");
        SQLiteHelper dbHelper = new SQLiteHelper();
        string username = string.Empty;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = dbHelper.GetConnection())
            {
                try
                {
                    dbHelper.OpenConnection(connection);
                    if (radioButtonRegisterToggle.Checked)
                    {
                        CheckInputSize();
                        if (textBoxUsername.Text.Length >= 3 && textBoxPassword.Text.Length >= 3)
                        {
                            string query = "INSERT INTO Users (username, password, balance) " +
                                "VALUES (@username, @password, 500)";

                            SQLiteCommand command = new SQLiteCommand(query, connection);
                            command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                            command.Parameters.AddWithValue("@password", textBoxPassword.Text);

                            command.ExecuteNonQuery();

                            MenuWindow.loggedIn = true;
                            username = textBoxUsername.Text;
                            this.Close();
                            MenuWindow.loginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginDisabled.png");
                            MenuWindow.labelLoggedUser.Text = "Logged in: " + username;
                            MenuWindow.loggedUserName = username;

                        }
                    }
                    else
                    {
                        CheckInputSize();
                        using (SQLiteCommand command = new SQLiteCommand(connection))
                        {
                            string query = "SELECT COUNT(*) FROM Users WHERE username='" + textBoxUsername.Text + "' AND password='" + textBoxPassword.Text + "';";
                            command.CommandText = query;
                            object result = command.ExecuteScalar();
                            int resultCount = Convert.ToInt32(result);
                            if (resultCount == 0)
                            {
                                MessageBox.Show("Wrong username or password", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MenuWindow.loggedIn = true;
                                username = textBoxUsername.Text;
                                this.Close();
                                MenuWindow.loginButton.Image = Image.FromFile(resourceFolderPath + "buttonLoginDisabled.png");
                                MenuWindow.labelLoggedUser.Text = "Logged in: " + username;
                                MenuWindow.loggedUserName = username;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dbHelper.CloseConnection(connection);
                }
            }
           
            
        }

        private void CheckInputSize()
        {
            if (textBoxUsername.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxUsername, "Username must be atleast 3 characters long");
            }
            if (textBoxPassword.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxPassword, "Password must be atleast 3 characters long");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
