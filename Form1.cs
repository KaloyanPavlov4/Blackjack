using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private CardNames[] singleDeck;
        private readonly List<Card> fullDeck;
        private int nextCard = 0;

        public Form1()
        {
            singleDeck = (CardNames[])Enum.GetValues(typeof(CardNames));
            fullDeck = singleDeck.Concat(singleDeck).ToList().Select(card => new Card(card)).ToList();
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
