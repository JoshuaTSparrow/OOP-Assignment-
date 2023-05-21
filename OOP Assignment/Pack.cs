using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{

    public class Deck
    {
        private List<Card> cards; //Creates a list for the cards and make the random class
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };                                               //Cretes the suits and ranks
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank)); //Creates a new card for every one in the deck
                }
            }
        }

        public Card DrawCard()
        {
            int index = random.Next(cards.Count); //Draws the card and removes it from the deck
            Card card = cards[index]; 
            cards.RemoveAt(index);
            return card;
        }

        public bool HasCards()
        {
            return cards.Count > 0; //Returns card count 
        }
    }
}

