using System;

namespace Task_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cards.CreateAndFillDeck();
            Cards.MixDeck();
            Players.DistributionCards();
            Output.CreateFile();
            GameLogic.TransferDeck(ref Players.Player1Deck, ref Players.Player2Deck);
            GameLogic.GameStart();

            Console.ReadKey();
        }
    }
}