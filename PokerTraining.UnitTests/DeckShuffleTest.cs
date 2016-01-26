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
        private List<Card> _cards;
        private Deck _deck;

        [TestFixtureSetUp]
        public void Init()
        {
            _deck = new Deck();
            _deck.Reset();
            _cards = _deck.Cards;
        }

        [Test]
        public void a_deck_has_52_cards()
        {
            _cards.Should().Have.Count.EqualTo(52);

            _cards.FirstOrDefault().Rank.Should().Be.EqualTo(RankEnum.Ace);
            _cards.FirstOrDefault().Suit.Should().Be.EqualTo(SuitEnum.Hearts);
            _cards.FirstOrDefault().Value.Should().Be.EqualTo(new Value(SuitEnum.Hearts, RankEnum.Ace));

            _cards.LastOrDefault().Rank.Should().Be.EqualTo(RankEnum.King);
            _cards.LastOrDefault().Suit.Should().Be.EqualTo(SuitEnum.Clubs);
            _cards.LastOrDefault().Value.Should().Be.EqualTo(new Value(SuitEnum.Clubs, RankEnum.King));
        }

        [Test]
        public void b_deck_after_Shuffle_has_52_card_unordered()
        {
            _deck.Shuffle();
            _cards = _deck.Cards;

            _cards.FirstOrDefault().Value.Should().Not.Be.EqualTo( new Value(SuitEnum.Hearts, RankEnum.Ace));
            _cards.LastOrDefault().Value.Should().Not.Be.EqualTo(new Value(SuitEnum.Clubs, RankEnum.King));
        }

    }
}
