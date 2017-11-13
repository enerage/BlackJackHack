using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJackGame;

namespace BlackJackConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //var newGame = new NewGame(new Deck());
            var deck = new Deck();

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("Shuffle");
            deck.Shuffle();
            Console.WriteLine("-------------");

            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card);
            }

        }
    }
}
