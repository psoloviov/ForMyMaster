using System.Collections.Generic;

namespace Task_4
{
    public static class Players
    {
        public static List<Cards> Player1Deck = new List<Cards>();
        public static List<Cards> Player2Deck = new List<Cards>();
        
        
        public static void StartGame()
        {
            Cards.FillDeck();
            Cards.MixDeck();
            DistributionCards();
            GameLogic.GameStart(ref Player1Deck, ref Player2Deck);
        }

        private static void DistributionCards()
        {
            for (var i = 0; i < Cards.CardsDeck.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Player1Deck.Add(Cards.CardsDeck[i]);
                }
                else
                {
                    Player2Deck.Add(Cards.CardsDeck[i]);
                }
            }
        }
    }
}