using System;
using System.Collections.Generic;

namespace Task_4
{
    public class Cards
    {
        public static readonly List<Cards> CardsDeck = new List<Cards>();
        private CardsColor _cardsColor;
        public CardsValue CardsValue;

        private Cards(CardsValue cardsValue, CardsColor cardsColor)
        {
            this._cardsColor = cardsColor;
            this.CardsValue = cardsValue;
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
        public static void CreateAndFillDeck()
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