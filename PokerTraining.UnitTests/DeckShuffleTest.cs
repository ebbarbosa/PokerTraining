using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PokerTraining.Domain;
using SharpTestsEx;

namespace PokerTraining.UnitTests
{

    [TestFixture]
    public class DeckShuffleTest
    {
        [Test]
        public void deck_after_Shuffle_has_52_card_unordered()
        {

            var deck = new Deck();

            var cards = deck.Cards;
            cards.Should().Have.Count.EqualTo(52);

            cards.FirstOrDefault().Value.Should().Be.EqualTo(ValueEnum.Ace);
            cards.FirstOrDefault().Suit.Should().Be.EqualTo(SuitEnum.Hearts);

            cards.LastOrDefault().Value.Should().Be.EqualTo(ValueEnum.King);
            cards.LastOrDefault().Suit.Should().Be.EqualTo(SuitEnum.Clubs);

            deck.Shuffle();

            cards.FirstOrDefault().Value.Should().Not.Be.EqualTo(ValueEnum.Ace);
            cards.LastOrDefault().Value.Should().Not.Be.EqualTo(ValueEnum.King);

        }

    }
}
