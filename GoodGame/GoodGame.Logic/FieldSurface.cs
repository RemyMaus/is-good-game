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
    }
}
