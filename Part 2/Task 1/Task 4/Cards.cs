using System;

namespace Task_4
{
    enum CardsNames
    {
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
        Ace = 14
    }

    enum CardsColor
    {
        Diamonds = 1,
        Hearts = 2,
        Spades = 3,
        Clubs = 4
    }

    public class Cards
    {
        private static Cards[] _cardDeck = new Cards[36];
        private static Random _random = new Random();

        private CardsColor _cardsColor;
        private CardsNames _cardsNames;

        private Cards(CardsNames cardsNames, CardsColor cardsColor)
        {
            this._cardsColor = cardsColor;
            this._cardsNames = cardsNames;
        }
        
        public static void MixDeck()
        {
            for (var i = _cardDeck.Length - 1; i >= 1; i--)
            {
                var j = _random.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = _cardDeck[j];
                _cardDeck[j] = _cardDeck[i];
                _cardDeck[i] = temp;
            }
        }
        

        public static void FillDeck()
        {
            var index = 0;
            for (var i = 6; i <= 14; i++)
            {
                for (var j = 1; j <= 4; j++)
                {
                    _cardDeck[index++] = new Cards((CardsNames)i,(CardsColor)j);
                }
            }
        }
    }
}