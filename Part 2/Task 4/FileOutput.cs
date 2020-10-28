using System.IO;
using static Task_4.GameLogic;

namespace Task_4
{
    public class Output
    {
        private const string Path = @"log.txt";

        public static void CreateFile()
        {
            File.Create(Path).Close();
        }

        public static void Turn()
        {
            using (var stream = new StreamWriter(Path, true))
            {
                if (Player1Cards.Count != 0 && Player2Cards.Count != 0)
                {
                    var card1 = Player1Cards.Peek().CardsValue
                                + " " + Player1Cards.Peek().CardsColor;
                    var card2 = Player2Cards.Peek().CardsValue
                                + " " + Player2Cards.Peek().CardsColor;
                    stream.WriteLine($" Turn {GameLogic.Turn} ");
                    stream.WriteLine($" Cards: {card1} and {card2} ");
                }
                else
                {
                    stream.WriteLine($" # # # Game Finish! # # # ");
                }
            }
        }

        public static void Winner(int player)
        {
            using (var stream = new StreamWriter(Path, true))
                stream.WriteLine($" Player {player} won! \n");
        }
    }
}