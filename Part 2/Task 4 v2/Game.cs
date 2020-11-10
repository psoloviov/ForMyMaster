using System;
using System.Collections.Generic;
using static Task_4_v2.CardValuesEnumeration;

namespace Task_4_v2
{
    public class Game
    {
        public List<Player> Players { get; } = new List<Player>();
        public static int TurnCount { get; private set; }
        private static Queue<Card> _table = new Queue<Card>();

        public Game()
        {
            StartGame();
        }

        private void StartGame()
        {
            var deck = new Deck();
            deck.MixDeck();
            var player1 = new Player("Gleb");
            var player2 = new Player("Oleg");
            FillHand(player1, player2);
            GameLogic(player1, player2);
            Console.ReadKey();
        }

        private void GameLogic(Player player1, Player player2)
        {
            var gameOver = false;
            var output = new FileOutput();
            output.CreateFile();
            do
            {
                output.PrintTurn(player1, player2);

                if (player1.Queue.Count != 0)
                    if (player2.Queue.Count != 0)
                        CompareCards(player1, player2);
                    else
                    {
                        Console.WriteLine($"Game generate. Turns: {TurnCount}");
                        output.PrintWinner(player1);
                        gameOver = true;
                    }
                else
                {
                    Console.WriteLine($"Game generate. Turns: {TurnCount}");
                    output.PrintWinner(player2);
                    gameOver = true;
                }

                TurnCount++;
            } while (!gameOver && TurnCount != 5000);
        }

        private void FillHand(Player player1, Player player2)
        {
            for (var i = 0; i < Deck.List.Count; i++)
            {
                if (i % 2 == 0)
                {
                    player1.TakeCard(Deck.List[i]);
                }
                else
                {
                    player2.TakeCard(Deck.List[i]);
                }
            }
        }


        private void CompareCards(Player player1, Player player2)
        {
            var cardP1 = player1.Queue.Dequeue();
            var cardP2 = player2.Queue.Dequeue();

            //if we have ACE and SIX, return SIX
            if (cardP1.Value == Ace && cardP2.Value == Six
                || cardP1.Value == Six && cardP2.Value == Ace)
            {
                if (cardP1.Value == Six)
                {
                    player1.TakeCard(cardP1);
                    player1.TakeCard(cardP2);
                    FileOutput.PrintPickUp(player1);
                    ClearTable(ref player1);
                    return;
                }
                else
                {
                    player2.TakeCard(cardP1);
                    player2.TakeCard(cardP2);
                    FileOutput.PrintPickUp(player2);
                    ClearTable(ref player2);
                    return;
                }
            }

            //continue compare (skip one card)
            if (cardP1.Value == cardP2.Value)
            {
                _table.Enqueue(cardP1);
                _table.Enqueue(cardP2);
                CompareNext(player1, player2);
            }

            //player 2 give card player 1
            if (cardP1.Value > cardP2.Value)
            {
                player1.TakeCard(cardP1);
                player1.TakeCard(cardP2);
                FileOutput.PrintPickUp(player1);
                ClearTable(ref player1);
                return;
            }

            //player 1 give card player 2
            if (cardP1.Value < cardP2.Value)
            {
                player2.TakeCard(cardP1);
                player2.TakeCard(cardP2);
                FileOutput.PrintPickUp(player2);
                ClearTable(ref player2);
                return;
            }
        }

        private void CompareNext(Player player1, Player player2)
        {
            if (player1.Queue.Count != 0 && player2.Queue.Count != 0)
            {
                _table.Enqueue(player1.Queue.Dequeue());
                _table.Enqueue(player2.Queue.Dequeue());
            }
            else
            {
                if (player1.Queue.Count > player2.Queue.Count)
                {
                    ClearTable(ref player1);
                }
                else
                {
                    ClearTable(ref player2);
                }

                return;
            }

            if (player1.Queue.Count == 0 || player1.Queue.Count == 0) return;
            CompareCards(player1, player2);
        }

        private void NextTurn()
        {
        }

        private static void ClearTable(ref Player player)
        {
            if (_table == null) return;
            foreach (var card in _table)
            {
                player.Queue.Enqueue(card);
            }

            _table.Clear();
        }
    }
}