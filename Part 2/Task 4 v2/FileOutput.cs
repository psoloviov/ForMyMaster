using System;
using System.IO;

namespace Task_4_v2
{
    public class FileOutput
    {
        private const string Path = @"log.txt";

        public void CreateFile()
        {
            File.Create(Path).Close();
        }

        public void PrintTurn(Player player1, Player player2)
        {
            using (var stream = new StreamWriter(Path, true))
            {
                if (player1.Queue.Count != 0 && player2.Queue.Count != 0)
                {
                    var card1 = player1.Queue.Peek().Value
                                + " " + player1.Queue.Peek().Suit;
                    var card2 = player2.Queue.Peek().Value
                                + " " + player2.Queue.Peek().Suit;
                    
                    stream.WriteLine($"Turn {Game.TurnCount} ");
                    stream.WriteLine($"Cards: {card1} and {card2} ");
                }
                else
                {
                    stream.WriteLine($"# # # Game Finish! # # #");
                }
            }
        }

        public static void PrintPickUp(Player player)
        {
            using (var stream = new StreamWriter(Path, true))
            {
                stream.WriteLine($"Cards takes player {player.Name}");
                stream.WriteLine();
            }
        }

        public void PrintWinner(Player player)
        {
            using (var stream = new StreamWriter(Path, true))
                stream.WriteLine($"Player {player.Name} won! \n");
        }
    }
}