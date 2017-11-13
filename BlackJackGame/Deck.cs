using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackGame.Card.Ranks;
using BlackJackGame.Card.Suits;
using BlackJackGame.Card;

namespace BlackJackGame
{
    public class Deck
    {
        public IList<Card.Card> Cards { get; private set; }

        public Deck()
        {
            this.Cards = GenerateDeck();
        }

        private IList<Card.Card> GenerateDeck()
        {

            var ranksNameSpace = typeof(IRank).Namespace;
            var suitsNameSpace = typeof(ISuit).Namespace;

            var deck = new List<Card.Card>();
            var ranks = Enum.GetValues(typeof(Ranks));
            var suits = Enum.GetValues(typeof(Suits));
            var assembly = typeof(IRank).Assembly;

            foreach (var rank in ranks)
            {
                var rankType = assembly.GetType(ranksNameSpace + "." + rank.ToString());
                var rankInstance = (IRank)Activator.CreateInstance(rankType);

                foreach (var suit in suits)
                {
                    var suitType = assembly.GetType(suitsNameSpace + "." + suit.ToString());
                    var suitInstance = (ISuit)Activator.CreateInstance(suitType);

                    var card = new Card.Card(suitInstance, rankInstance);
                    deck.Add(card);
                }
            }

            return deck;
        }

        public void Shuffle()
        {
            var rng = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card.Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }

    }
}
