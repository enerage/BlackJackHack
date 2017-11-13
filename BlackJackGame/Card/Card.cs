using BlackJackGame.Card.Ranks;
using BlackJackGame.Card.Suits;

namespace BlackJackGame.Card
{
    public class Card
    {
        ISuit Suit { get; set; }
        IRank Rank { get; set; }

        public Card(ISuit suit, IRank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", this.Rank.Rank, this.Suit.Suit);
        }
    }
}
