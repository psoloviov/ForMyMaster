using System;
using System.Collections.Generic;
using static Task_4.CardsValue;

namespace Task_4
{
    public class GameLogic
    {
        private static Queue<Cards> _table = new Queue<Cards>();
        public static Queue<Cards> Player1Cards = new Queue<Cards>();
        public static Queue<Cards> Player2Cards = new Queue<Cards>();
        
        public static int Turn = new int();

        public static void TransferDeck(ref Queue<Cards> player1Deck, ref Queue<Cards> player2Deck)
        {
            Player1Cards = player1Deck;
            Player2Cards = player2Deck;
        }

        public static void GameStart()
        {
            var game = true;
            while (game && Turn != 5000)
            {
                Turn++;
                Output.Turn();
                if (Player1Cards.Count != 0)
                    if (Player2Cards.Count != 0)
                        Compare(Player1Cards.Dequeue(), Player2Cards.Dequeue());

                    else
                    {
                        Console.WriteLine($"Game generate. Turns: {Turn}");
                        game = false;
                    }
                else
                {
                    Console.WriteLine($"Game generate. Turns: {Turn}");
                    game = false;
                }
            }
            Player1Cards.Clear();
            Player2Cards.Clear();
        }

        private static void Compare(Cards x, Cards y)
        {
            //if we have ACE and SIX, return SIX
            if (x.CardsValue == Ace && y.CardsValue == Six
                || x.CardsValue == Six && y.CardsValue == Ace)
            {
                if (x.CardsValue == Six)
                {
                    Player1Cards.Enqueue(x);
                    Player1Cards.Enqueue(y);
                    ClearTable(ref Player1Cards);
                    Output.Winner(1);
                    return;
                }
                else
                {
                    Player2Cards.Enqueue(y);
                    Player2Cards.Enqueue(x);
                    ClearTable(ref Player2Cards);
                    Output.Winner(2);
                    return;
                }
            }

            //continue compare (skip one card)
            if (x.CardsValue == y.CardsValue)
            {
                CompareNext(x, y);
            }

            //player 2 give card player 1
            if (x.CardsValue > y.CardsValue)
            {
                Player1Cards.Enqueue(x);
                Player1Cards.Enqueue(y);
                ClearTable(ref Player1Cards);
                Output.Winner(1);
            }

            //player 1 give card player 2
            if (x.CardsValue < y.CardsValue)
            {
                Player2Cards.Enqueue(y);
                Player2Cards.Enqueue(x);
                ClearTable(ref Player2Cards);
                Output.Winner(2);
            }
        }

        private static void CompareNext(Cards x, Cards y)
        {
            _table.Enqueue(x);
            _table.Enqueue(y);
            if (Player1Cards.Count != 0 && Player2Cards.Count != 0)
            {
                _table.Enqueue(Player1Cards.Dequeue());
                _table.Enqueue(Player2Cards.Dequeue());
            }
            else
            {
                if (Player1Cards.Count > Player2Cards.Count)
                {
                    ClearTable(ref Player1Cards);
                }
                else
                {
                    ClearTable(ref Player2Cards);
                }

                return;
            }

            if (Player1Cards.Count == 0 || Player2Cards.Count == 0) return;
            Compare(Player1Cards.Dequeue(), Player2Cards.Dequeue());
        }

        private static void ClearTable(ref Queue<Cards> player)
        {
            if (_table == null) return;
            foreach (var card in _table)
            {
                player.Enqueue(card);
            }

            _table.Clear();
        }
    }
}