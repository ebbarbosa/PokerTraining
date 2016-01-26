namespace PokerTraining.Domain
{
    public class Card
    {
        public Card(SuitEnum suit, ValueEnum value)
        {
            Suit = suit;
            Value = value;
        }

        public SuitEnum Suit { get; private set; }

        public ValueEnum Value { get; private set; }
    }
}