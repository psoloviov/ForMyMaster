using System;
using System.Collections.Generic;

namespace Task_4_v2
{
    public class Deck
    {
        public List<Card> List { get; }


        public Deck()
        {
            for (var i = 6; i <= 14; i++)
            {
                for (var j = 1; j <= 4; j++)
                {
                    var tmp = new Card((CardValuesEnumeration) i, (CardSuitsEnumeration) j);
                    List.Add(tmp);
                }
            }

            Console.WriteLine(List[2].Value);
            Console.WriteLine(List[2].Suit);
        }

        private void MixDeck(Deck deck)
        {
            var random = new Random();
            for (var i = List.Count - 1; i >= 1; i--)
            {
                var j = random.Next(i + 1);
                var temp = List[j];
                List[j] = List[i];
                List[i] = temp;
            }
        }
    }
}