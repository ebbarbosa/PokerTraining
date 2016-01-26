using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokerTraining.Domain
{
    public class Deck
    {
        public Deck()
        {
            Reset();
        }

        public void Shuffle()
        {
            Cards.Shuffle();
        }

        public List<Card> Cards { get; private set; }

        public void Reset()
        {
            var cards = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(SuitEnum)))
            {
                foreach (RankEnum value in Enum.GetValues(typeof(RankEnum)))
                {
                    cards.Add(new Card((SuitEnum)suit, value));
                }
            }
            Cards = cards;
        }
    }
}
