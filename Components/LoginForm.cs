using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class LoginForm : Form
    {
        private readonly SQLiteHelper dbHelper = new SQLiteHelper();
        private bool isChecked = false;
        private readonly MenuWindow menuWindow = null;

        public LoginForm(MenuWindow menu)
        {
            InitializeComponent();
            menuWindow = menu;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = dbHelper.GetConnection())
            {
                try
                {
                    dbHelper.OpenConnection(connection);
                    //Ако бутонът за създаване на нов потребител е избран, добавя нов потребител с баланс 500
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
                        }
                        else
                        {
                            return;
                        }
                    }
                    //Ако не е, се опитва да извлече потребител с въведените данни
                    else
                    {
                        CheckInputSize();
                        using (SQLiteCommand command = new SQLiteCommand(connection))
                        {
                            string query = "SELECT COUNT(*) FROM Users WHERE username='" + textBoxUsername.Text + "' AND password='" + textBoxPassword.Text + "';";
                            command.CommandText = query;
                            object result = command.ExecuteScalar();
                            int resultCount = Convert.ToInt32(result);
                            //Ако няма такъв, уведомява потребителя
                            if (resultCount == 0)
                            {
                                MessageBox.Show("Wrong username or password", "!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    menuWindow.LogIn(textBoxUsername.Text);
                    Close();
                }
                catch (Exception ex)
                {
                    //При възникване грешка при добавянето на нов потребител, защото вече съществува такъв със същото име
                    if (ex.GetHashCode().ToString() == "33420276")
                    {
                        MessageBox.Show("User already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //При възникване на други грешки с базата данни
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                finally
                {
                    dbHelper.CloseConnection(connection);
                }
            }
           
            
        }

        //Проверява че името и паролата трябва да са поне 3 символа
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

        private void radioButtonRegisterToggle_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = radioButtonRegisterToggle.Checked;
        }

        private void radioButtonRegisterToggle_Click(object sender, EventArgs e)
        {
            if (radioButtonRegisterToggle.Checked && !isChecked)
            {
                radioButtonRegisterToggle.Checked = false;
            }
            else
            {
                radioButtonRegisterToggle.Checked = true;
                isChecked = false;
            }
        }
    }
}
