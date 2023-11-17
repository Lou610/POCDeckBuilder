using CardShuffle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle.Helpers
{
    public class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck()
        {
            string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    Cards.Add(new Card { Suit = suit, Value = value });
                }
            }
        }


        public void Shuffle()
        {
            Random rand = new Random();
            int n = Cards.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                var temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }
        public Card DrawCard()
        {
            if (Cards.Count > 0)
            {
                Card card = Cards[0];
                Cards.RemoveAt(0);
                return card;
            }
            else
            {
                throw new InvalidOperationException("No cards left in the deck.");
            }
        }



    }
}
