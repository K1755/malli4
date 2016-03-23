/* 
 * Copyright (C) 2016 PTM
 * 
 * Object Oriented Programming Course Example File.
 * 
 * Created: 17/01/2016 
 * Authors: Pasi Manninen
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            // stack for cards
            List<Card> cards = new List<Card>();
            // create cards
            string[] suits = { "heart", "diamond", "spade", "club" };
            foreach (string suit in suits)
            {
                for (int i = 1; i <= 52; i++)
                {
                    cards.Add(new Card { Suit = suit, Number = i });
                }
            }
            Console.WriteLine("Added cards:");
            // print added cards
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }

            // shuffle
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int i1 = random.Next(cards.Count);
                int i2 = random.Next(cards.Count);

                Card card = cards.ElementAt(i1);
                cards[i1] = cards.ElementAt(i2);
                cards[i2] = card;
            }
            Console.WriteLine("Shuffled cards:");
            // print shuffled cards
            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}
