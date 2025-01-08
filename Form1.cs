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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singleDeck = (CardNames[])Enum.GetValues(typeof(CardNames));
            fullDeck = singleDeck.Concat(singleDeck).ToList().Select(card => new Card(card)).ToList();
            player = new Player();
            dealer = new Player();
            playerCards = new List<PictureBox> { pictureBoxPlayer1, pictureBoxPlayer2, pictureBoxPlayer3, pictureBoxPlayer4, pictureBoxPlayer5 };
            dealerCards = new List<PictureBox> { pictureBoxDealer1, pictureBoxDealer2, pictureBoxDealer3, pictureBoxDealer4, pictureBoxDealer5 };
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            dealButton.Enabled = false;
            Hit(dealer);
            Hit(dealer);
            dealerCards[0].Image = Image.FromFile(resourceFolderPath + dealer.Hand[0].NameOfCard + ".png");
            Hit(player);
            Hit(player);
            playerCards[0].Image = Image.FromFile(resourceFolderPath + player.Hand[0].NameOfCard + ".png");
            playerCards[1].Image = Image.FromFile(resourceFolderPath + player.Hand[1].NameOfCard + ".png");
            if(GetScore(dealer) == 21)
            {
                if(GetScore(player) == 21)
                {
                    //Implement draw
                }else
                {
                    dealerWin();
                }
            }else if(GetScore(player) == 21)
            {
                dealerCards[1].Image = Image.FromFile(resourceFolderPath + dealer.Hand[1].NameOfCard + ".png");
                playerWin();
            }
        }

        private void Hit(Player p)
        {
            p.addCard(fullDeck[nextCard]);
            nextCard++;
        }

        private void PrintCard(Player p)
        {
            foreach (Card card in p.Hand)
            {
                Console.Write(card.NameOfCard + " ");
            }
            Console.Write(GetScore(p));
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
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            result.Text = "You lose!";
        }

        private void playerWin()
        {
            hitMeButton.Enabled = false;
            standButton.Enabled = false;
            dealButton.Enabled = true;
            result.Text = "You win!";
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
    }
}
