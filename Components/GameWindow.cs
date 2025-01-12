﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class GameWindow : Form
    {
        private readonly string resourceFolderPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources\\");
        private CardNames[] singleDeck;
        private List<Card> fullDeck;
        private int nextCard = 0;
        private Player player;
        private Player dealer;
        private List<PictureBox> playerCards;
        private List<PictureBox> dealerCards;
        private readonly bool loggedIn = MenuWindow.loggedIn;
        private readonly string loggedUserName = MenuWindow.loggedUserName;
        private int balance = 500;
        private int bet;

        public GameWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singleDeck = (CardNames[])Enum.GetValues(typeof(CardNames));
            fullDeck = singleDeck.Concat(singleDeck).ToList().Select(card => new Card(card)).ToList();
            Shuffle(fullDeck);
            player = new Player();
            dealer = new Player();
            playerCards = new List<PictureBox> { pictureBoxPlayer1, pictureBoxPlayer2, pictureBoxPlayer3, pictureBoxPlayer4, pictureBoxPlayer5 };
            dealerCards = new List<PictureBox> { pictureBoxDealer1, pictureBoxDealer2, pictureBoxDealer3, pictureBoxDealer4, pictureBoxDealer5 };
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            
            SQLiteHelper dbHelper = new SQLiteHelper();
            if (!loggedIn)
            {
                labelLoggedinUser.Text = "Not loggedin: Guest mode";
                labelBalance.Text = "Balance: $" + balance;
            }
            else 
            {
                labelLoggedinUser.Text = "Logged in: " + loggedUserName;
                balance = GetBalance();
                labelBalance.Text = "Balance: $" + balance;
            }
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            if (textBoxBetAmount.Text.Length == 0)
            {
                errorProvider1.SetError(textBoxBetAmount, "Field cannot be empty");
            }
            else
            {
                if (Convert.ToInt32(textBoxBetAmount.Text) > balance)
                {
                    errorProvider1.SetError(textBoxBetAmount, "Not enough balance");
                }
                else
                {
                    bet = Convert.ToInt32(textBoxBetAmount.Text);
                    disableBackButton();
                    UpdateBalance(bet * -1);
                    errorProvider1.Clear();
                    textBoxBetAmount.ReadOnly = true;
                    resetGame();
                    if (nextCard > 65)
                    {
                        Shuffle(fullDeck);
                        nextCard = 0;
                    }
                    newHandDraw();
                    labelBalance.Text = "Balance: $" + balance;
                }
            }
        }

        private void hitMeButton_Click(object sender, EventArgs e)
        {
            Hit(player);
            playerCards[player.Hand.Count - 1].Image = Image.FromFile(resourceFolderPath + player.Hand[player.Hand.Count - 1].NameOfCard + ".png");
            playerCards[player.Hand.Count - 1].Visible = true;

            if (HasBusted(player))
            {
                dealerWin();
                return;
            }
            if (player.Hand.Count == 5) playerWin();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            while (dealer.Hand.Count < 5 && GetScore(dealer) < 17)
            {
                dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
                Hit(dealer);
                labelDealerScore.Text = "Score: " + GetScore(dealer);
                dealerCards[dealer.Hand.Count - 1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[dealer.Hand.Count - 1].NameOfCard + ".png");
                dealerCards[dealer.Hand.Count - 1].Visible = true;

            }
            checkResult();
        }

        private void newHandDraw()
        {
            dealerCards[1].Image = Image.FromFile(resourceFolderPath + "faceDownCard" + ".png");
            dealButton.Enabled = false;
            hitMeButton.Enabled = true;
            standButton.Enabled = true;
            Hit(dealer);
            labelDealerScore.Text = "Score: " + GetScore(dealer).ToString();
            Hit(dealer);
            dealerCards[0].Image = Image.FromFile(resourceFolderPath + dealer.Hand[0].NameOfCard + ".png");
            Hit(player);
            Hit(player);
            playerCards[0].Image = Image.FromFile(resourceFolderPath + player.Hand[0].NameOfCard + ".png");
            playerCards[1].Image = Image.FromFile(resourceFolderPath + player.Hand[1].NameOfCard + ".png");
            if (GetScore(dealer) == 21)
            {
                if (GetScore(player) == 21)
                {
                    draw();
                }
                else
                {
                    dealerWin();
                }
            }
            else if (GetScore(player) == 21)
            {
                playerWin();
            }
        }

        private void Hit(Player p)
        {
            p.addCard(fullDeck[nextCard]);
            nextCard++;
            labelPlayerScore.Text = "Score: " + GetScore(player).ToString();
        }

        private int GetScore(Player p)
        {
            int score = p.Hand.Select(card => card.Value).Sum();
            if (score <= 21 || !p.Hand.Where(card => card.Value == 11).Any())
            {
                return score;
            }

            int index = 0;
            while (score > 21 && index < p.Hand.Count)
            {
                if (p.Hand[index].Value == 11)
                {
                    p.Hand[index].Value = 1;
                    score = p.Hand.Select(card => card.Value).Sum();
                }
                index++;
            }
            return score;
        }

        private bool HasBusted(Player p)
        {
            return GetScore(p) > 21;
        }

        private void checkResult()
        {
            if (GetScore(dealer) > 21)
            {
                playerWin();
            }
            else if (GetScore(dealer) == GetScore(player))
            {
                draw();
            }
            else if (GetScore(dealer) > GetScore(player))
            {
                dealerWin();
            }
            else playerWin();
        }

        private void dealerWin()
        {
            endGame("You lose! -$" + textBoxBetAmount.Text);
            if (balance == 0)
            {
                MessageBox.Show("You suddenly remember you have 50 dollars in your back pocket!");
                UpdateBalance(50);
                labelBalance.Text = "Balance: $" + balance;
            }
        }

        private void playerWin()
        {
            UpdateBalance(bet * 2);
            endGame("You win! +$" + Convert.ToInt32(textBoxBetAmount.Text));
        }

        private void draw()
        {
            UpdateBalance(bet);
            endGame("Draw!");
        }

        private void endGame(string resultOfGame)
        {
            dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
            labelDealerScore.Text = "Score: " + GetScore(dealer);
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            result.Visible = true;
            result.Text = resultOfGame;
            textBoxBetAmount.ReadOnly = false;
            textBoxBetAmount.Text = "";
            labelBalance.Text = "Balance: $" + balance;
            enableBackButton();
        }

        private void resetGame()
        {
            player.clearHand();
            dealer.clearHand();
            result.Visible = false;
            for (int i = 2; i <= dealerCards.Count - 1; i++)
            {
                dealerCards[i].Visible = false;
                playerCards[i].Visible = false;
            }
        }

        private void UpdateBalance(int change)
        {
            if (loggedIn)
            {
                int newBalance = balance + change;
                SQLiteHelper dbHelper = new SQLiteHelper();
                using (SQLiteConnection connection = dbHelper.GetConnection())
                {
                    try
                    {
                        dbHelper.OpenConnection(connection);
                        string query = "UPDATE Users SET balance='" + newBalance + "' WHERE username='" + loggedUserName + "';";
                        SQLiteCommand command = new SQLiteCommand(connection);
                        command.CommandText = query;
                        command.ExecuteNonQuery();
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
            }else
            {
                balance = balance + change;
            }
            balance = GetBalance();
        }

        private int GetBalance()
        {
            if (loggedIn)
            {
                SQLiteHelper dbHelper = new SQLiteHelper();
                using (SQLiteConnection connection = dbHelper.GetConnection())
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT balance FROM Users WHERE username='" + loggedUserName + "';";
                        SQLiteCommand command = new SQLiteCommand(query, connection);

                        SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            balance = reader.GetInt32(0);
                        }
                        labelBalance.Text = "Balance: $" + balance;
                        return balance;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                    finally
                    {
                        dbHelper.CloseConnection(connection);
                    }
                }
            }
            return balance;
        }

        private void Shuffle(List<Card> list)
        {
            Random rng = new Random();
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (list[n], list[k]) = (list[k], list[n]);
            }
            nextCard = 0;
        }

        private void textBoxBetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxBackButton_Click(object sender, EventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Dock = DockStyle.Fill;
            menuWindow.TopLevel = false;
            MainForm.MainPanel.Controls.Clear();
            MainForm.MainPanel.Controls.Add(menuWindow);
            menuWindow.Show();
            Dispose();
        }

        private void disableBackButton()
        {
            MainForm.ChangePictureBoxImage(backButton, "buttonBackDisabled");
            backButton.Enabled = false;
        }

        private void enableBackButton()
        {
            MainForm.ChangePictureBoxImage(backButton, "buttonBackNormal");
            backButton.Enabled = true;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            if(backButton.Enabled)
            {
                MainForm.ChangePictureBoxImage(backButton, "buttonBackHover");
            }
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            if(backButton.Enabled)
            {
                MainForm.ChangePictureBoxImage(backButton, "buttonBackNormal");
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
