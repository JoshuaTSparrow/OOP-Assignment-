using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{

    public class Deck
    {
        private List<Card> cards;
        private Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public Card DrawCard()
        {
            int index = random.Next(cards.Count);
            Card card = cards[index];
            cards.RemoveAt(index);
            return card;
        }

        public bool HasCards()
        {
            return cards.Count > 0;
        }
    }
}

