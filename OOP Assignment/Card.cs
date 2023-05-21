using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public class Card
    {
        public string Suit { get; } //Creates a suit and rank for the card
        public string Rank { get; }

        public Card(string suit, string rank)
        {
            Suit = suit; //Makes the suit and rank to be able to be read
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}"; //Returns the rank and suit to the program
        }
    }
}

