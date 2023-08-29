using System;
using System.Collections.Generic;

namespace GoodGame.Logic
{
    public class FieldSurface
    {
        public FieldSurface(int numberOfCards)
        {
            Cards = new List<Card>();
            for (int i = 0; i < numberOfCards; i++)
            {
                Card card = new Card();
                Cards.Add(card);
            }
            RemainingAttempts = 3;
        }
        public List<Card> Cards { get; }
        public int RemainingAttempts { get; set; }

        public void SelectCardsRandomized(int numberOfCards)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>(Cards);
            for (int i = 0;i < numberOfCards;i++) 
            {
                if (i >= cards.Count)
                {
                    throw new Exception($"Idiot. {i} ist größer als {cards.Count}");
                }
                int randomIndex = random.Next(cards.Count);
                Cards[randomIndex].IsSelected = true;
                cards.Remove(cards[randomIndex]);
            }
        }
    }
}
