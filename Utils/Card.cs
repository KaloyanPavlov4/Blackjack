namespace Blackjack
{
    internal class Card
    {
        private CardNames nameOfCard;
        private int value;

        public int Value { get => value; set => this.value = value; }
        public CardNames NameOfCard { get => nameOfCard; set => nameOfCard = value; }

        public Card(CardNames name)
        {
            nameOfCard = name;
            value = Utils.BlackjackValues[name];
        }
    }
}