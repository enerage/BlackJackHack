using BlackJackHack.Card.Ranks;
using BlackJackHack.Card.Suits;

namespace BlackJackHack.Card
{
    interface ICard
    {
        ISuit Suit { get; set; }
        IRank Rank { get; set; }
    }
}
