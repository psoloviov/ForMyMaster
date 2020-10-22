using System.Collections.Generic;

namespace Task_4
{
    public class Players
    {
        private static List<Cards> _player1Deck = new List<Cards>();
        private static List<Cards> _player2Deck = new List<Cards>();

        public static void StartGame()
        {
            Cards.FillDeck();
            Cards.MixDeck();
            DistributionCards();
        }

        private static void DistributionCards()
        {
            for (var i = 0; i < Cards.CardsDeck.Count; i++)
            {
                if (i % 2 == 0)
                {
                    _player1Deck.Add(Cards.CardsDeck[i]);
                }
                else
                {
                    _player2Deck.Add(Cards.CardsDeck[i]);
                }
            }
        }
    }
}