namespace Task_4_v2
{
    public class Card
    {
        public CardValuesEnumeration Value { get; }

        public CardSuitsEnumeration Suit { get; }

        public Card(CardValuesEnumeration value, CardSuitsEnumeration suit)
        {
            Value = value;
            Suit = suit;
        }
    }
}