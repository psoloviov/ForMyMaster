using System;
using System.Collections.Generic;

namespace Task_4
{
    public enum CardsValue
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

    public enum CardsColor
    {
        Diamonds = 1,
        Hearts = 2,
        Spades = 3,
        Clubs = 4
    }

    public class Cards
    {
        public static readonly List<Cards> CardsDeck = new List<Cards>();


        private CardsColor _cardsColor;
        private CardsValue _cardsValue;

        private Cards(CardsValue cardsValue, CardsColor cardsColor)
        {
            this._cardsColor = cardsColor;
            this._cardsValue = cardsValue;
        }

        /// <summary>
        /// mix deck randomly
        /// </summary>
        public static void MixDeck()
        {
            var random = new Random();
            for (var i = CardsDeck.Count - 1; i >= 1; i--)
            {
                var j = random.Next(i + 1);
                var temp = CardsDeck[j];
                CardsDeck[j] = CardsDeck[i];
                CardsDeck[i] = temp;
            }
        }

        /// <summary>
        /// create and fill deck
        /// </summary>
        public static void FillDeck()
        {
            for (var i = 6; i <= 14; i++)
            {
                for (var j = 1; j <= 4; j++)
                {
                    var tmp = new Cards((CardsValue) i, (CardsColor) j);
                    CardsDeck.Add(tmp);
                }
            }
        }
    }
}