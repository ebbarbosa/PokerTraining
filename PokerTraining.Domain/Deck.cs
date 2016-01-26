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
            var cards = new List<Card>();
            foreach (var suit in Enum.GetValues(typeof(SuitEnum)))
            {
                foreach (ValueEnum value in Enum.GetValues(typeof(ValueEnum)))
                {
                    cards.Add(new Card((SuitEnum)suit, value));
                }
            }
            Cards = cards;
        }

        public void Shuffle()
        {
            Cards.Shuffle();
        }

        public List<Card> Cards { get; private set; }
    }
}
