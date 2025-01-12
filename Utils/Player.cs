using System.Collections.Generic;

namespace Blackjack
{
    internal class Player
    {
        private List<Card> hand;
        private bool hasStanded;
        private bool busted;

        public bool HasStanded { get => hasStanded; set => hasStanded = value; }
        internal List<Card> Hand { get => hand; set => hand = value; }
        public bool Busted { get => busted; set => busted = value; }

        public Player()
        {
            hand = new List<Card>();
            hasStanded = false;
        }

        public void addCard(Card card)
        {
            hand.Add(card);
        }

        public void clearHand()
        {
            hand.Clear();
        }
    }
}
