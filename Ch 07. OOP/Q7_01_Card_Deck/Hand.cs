using System.Collections.Generic;

namespace Chapter07.CardDeck
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();
        private BlackJackScoreCounter scoreCounter = new BlackJackScoreCounter();

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public int Score()
        {
            return scoreCounter.CountScore(cards);
        }

        public void Clear()
        {
            cards.Clear();
        }
    }
}
