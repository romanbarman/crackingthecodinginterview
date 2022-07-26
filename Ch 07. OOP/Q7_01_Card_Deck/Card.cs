namespace Chapter07.CardDeck
{
    public class Card
    {
        public Suit Suit { get; }
        public Value Value { get; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Suit} {Value}";
        }
    }
}
