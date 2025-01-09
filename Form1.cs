using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private string resourceFolderPath = Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "Resources\\");
        private CardNames[] singleDeck;
        private List<Card> fullDeck;
        private int nextCard = 0;
        private Player player;
        private Player dealer;
        private List<PictureBox> playerCards;
        private List<PictureBox> dealerCards;
        private bool handIsOver = false;

        public Form1()
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
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            if (handIsOver)
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
            if (nextCard > 65)
            {
                Shuffle(fullDeck);
                nextCard = 0;
            }
            newHandDraw();
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
            if (GetScore(p) > 21)
            {
                return true;
            }
            return false;
        }

        private void dealerWin()
        {
            dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
            labelDealerScore.Text = "Score: " + GetScore(dealer);
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            result.Visible = true;
            result.Text = "You lose!";
            handIsOver = true;
        }

        private void playerWin()
        {
            dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
            labelDealerScore.Text = "Score: " + GetScore(dealer);
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            result.Visible = true;
            result.Text = "You win!";
            handIsOver = true;
        }

        private void draw()
        {
            dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
            labelDealerScore.Text = "Score: " + GetScore(dealer);
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            result.Visible = true;
            result.Text = "Draw!";
            handIsOver = true;
        }

        private void checkResult()
        {
            if (GetScore(dealer) > 21)
            {
                playerWin();
            }
            else if (GetScore(dealer) > GetScore(player))
            {
                dealerWin();
            }
            else draw();
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

        private void hitMeButton_Click(object sender, EventArgs e)
        {
            Hit(player);
            playerCards[player.Hand.Count - 1].Image = Image.FromFile(resourceFolderPath + player.Hand[player.Hand.Count - 1].NameOfCard + ".png");
            playerCards[player.Hand.Count - 1].Visible = true;

            if (HasBusted(player)) {
                dealerWin();
                return;
             }
            if (player.Hand.Count == 5) playerWin();
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            while(dealer.Hand.Count < 5 && GetScore(dealer) < 17)
            {
                dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
                Hit(dealer);
                labelDealerScore.Text = "Score: " + GetScore(dealer);
                dealerCards[dealer.Hand.Count - 1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[dealer.Hand.Count - 1].NameOfCard + ".png");
                dealerCards[dealer.Hand.Count - 1].Visible = true;

            }
            checkResult();
        }

    }
}
