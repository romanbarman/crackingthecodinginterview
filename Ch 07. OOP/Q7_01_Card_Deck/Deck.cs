using System;

namespace Chapter07.CardDeck
{
    public class Deck
    {
        private const int Size = 52;
        private Card[] cards = new Card[Size];
        private int currentIndex = 0;

        public Deck()
        {
            CreateCards();
        }

        public void Shuffle()
        {
            var n = cards.Length;
            var random = new Random();
            while (n > 1)
            {
                var k = random.Next(n--);
                var temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
        }

        public Card GetCard()
        {
            if (currentIndex == Size)
            {
                throw new Exception("The deck is empty");
            }    

            var card = cards[currentIndex];
            currentIndex++;

            return card;
        }

        public void RecreateDeck()
        {
            currentIndex = 0;
        }

        private void CreateCards()
        {
            var suites = (Suit[])Enum.GetValues(typeof(Suit));
            var values = (Value[])Enum.GetValues(typeof(Value));

            var i = 0;
            foreach (var suit in suites)
            {
                foreach (var value in values)
                {
                    cards[i] = new Card(suit, value);
                    i++;
                }
            }
        }
    }
}
