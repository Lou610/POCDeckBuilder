using CardShuffle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffle.Helpers
{
    public class Game
    {
        public Deck Deck { get; private set; }
        public List<Card> Hand { get; private set; } = new List<Card>();
        public List<Card> Graveyard { get; private set; } = new List<Card>();

        public Game()
        {
            Deck = new Deck();
            Deck.Shuffle();
            DrawInitialHand();
        }

        private void DrawInitialHand()
        {
            // Draw a predefined number of cards into the hand
            for (int i = 0; i < 5; i++)
            {
                Hand.Add(Deck.DrawCard());
            }
        }

        public void DrawNewHand()
        {


            // Assuming you draw a new hand of 5 cards
            Hand.Clear();
            for (int i = 0; i < 5; i++)
            {
                Hand.Add(Deck.DrawCard());
            }
        }


        public void RemoveCardFromHandAndSendToGraveyard(int cardIndex)
        {
            if (cardIndex >= 0 && cardIndex < Hand.Count)
            {
                Card cardToRemove = Hand[cardIndex];
                Hand.RemoveAt(cardIndex);
                Graveyard.Add(cardToRemove);
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid card index.");
            }
        }

        public void RemoveCardFromHand(Card card)
        {
            Hand.Remove(card);
            Graveyard.Add(card);
        }

        public void ReshuffleHand()
        {
            // Add remaining hand cards back to the deck
            foreach (var card in Hand)
            {
                Deck.Cards.Add(card);
            }
            Hand.Clear();
            Deck.Shuffle();

            // Draw new hand
            DrawNewHand();
        }
    }
}
