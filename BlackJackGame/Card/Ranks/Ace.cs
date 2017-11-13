using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame.Card.Ranks
{
    public class Ace : IRank
    {
        public string Rank
        {
            get
            {
                return "Ace";
            }
        }
    }
}
