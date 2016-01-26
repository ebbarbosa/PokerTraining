namespace PokerTraining.Domain
{
    public class Card
    {
        public Card(SuitEnum suit, RankEnum rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public SuitEnum Suit { get; private set; }

        public RankEnum Rank { get; private set; }

        public Value Value { get { return new Value(Suit, Rank);} }
        
    }

    public struct Value
    {
        private readonly SuitEnum _suit;
        private readonly RankEnum _rank;

        public Value(SuitEnum suit, RankEnum rank)
        {
            _suit = suit;
            _rank = rank;
        }
    }
}