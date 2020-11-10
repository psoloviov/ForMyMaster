using System.Collections.Generic;

namespace Task_4_v2
{
    public class Player
    {
        private static int _id;

        public string Name { get; set; }
        public Queue<Card> Queue { get; } = new Queue<Card>();

        public Player()
        {
            Name = "Player " + _id;
        }

        public Player(string name)
        {
            Name = name;
        }

        public void MakeTurn()
        {
            
        }

        public void TakeCard(Card card) 
        {
            Queue.Enqueue(card);
        }
    }
}