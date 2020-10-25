using System.Collections.Generic;

namespace Task_4
{
    public static class Players
    {
        public static Queue<Deck> Player1Deck = new Queue<Deck>();
        public static Queue<Deck> Player2Deck = new Queue<Deck>();
        
        
        public static void StartGame()
        {
            Deck.FillDeck();
            Deck.MixDeck();
            DistributionCards();
            GameLogic.GameStart(ref Player1Deck, ref Player2Deck);
        }

        private static void DistributionCards()
        {
            for (var i = 0; i < Deck.CardsDeck.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Player1Deck.Enqueue(Deck.CardsDeck[i]);
                    
                }
                else
                {
                    Player2Deck.Enqueue(Deck.CardsDeck[i]);
                }
            }
        }
    }
}