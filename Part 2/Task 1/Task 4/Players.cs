using System.Collections.Generic;

namespace Task_4
{
    public static class Players
    {
        public static Queue<Cards> Player1Deck = new Queue<Cards>();
        public static Queue<Cards> Player2Deck = new Queue<Cards>();

        public static void DistributionCards()
        {
            for (var i = 0; i < Cards.CardsDeck.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Player1Deck.Enqueue(Cards.CardsDeck[i]);
                    
                }
                else
                {
                    Player2Deck.Enqueue(Cards.CardsDeck[i]);
                }
            }
        }
    }
}