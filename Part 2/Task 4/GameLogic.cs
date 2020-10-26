﻿using System;
using System.Collections.Generic;
using static Task_4.CardsValue;

namespace Task_4
{
    public class GameLogic
    {
        private static Queue<Cards> _table = new Queue<Cards>();
        private static Queue<Cards> _player1Cards = new Queue<Cards>();

        private static Queue<Cards> _player2Cards = new Queue<Cards>();
        // private static Cards _player1Card = null;
        // private static Cards _player2Card = null;

        public static void TransferDeck(ref Queue<Cards> player1Deck, ref Queue<Cards> player2Deck)
        {
            _player1Cards = player1Deck;
            _player2Cards = player2Deck;
        }

        public static void GameStart()
        {
            var turn = new int();
            var game = true;
            while (game)
            {
                turn++;
                
            }
        }

        private static void Compare(Cards x, Cards y)
        {
            //if we have ACE and SIX, return SIX
            if (x.CardsValue == Ace && y.CardsValue == Six
                || x.CardsValue == Six && y.CardsValue == Ace)
            {
                if (x.CardsValue == Six)
                {
                    _player1Cards.Enqueue(x);
                    _player1Cards.Enqueue(y);
                    ClearTable(ref _player1Cards);
                }
                else
                {
                    _player2Cards.Enqueue(y);
                    _player2Cards.Enqueue(x);
                    ClearTable(ref _player2Cards);
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
                _player1Cards.Enqueue(x);
                _player1Cards.Enqueue(y);
                ClearTable(ref _player1Cards);
            }

            //player 1 give card player 2
            if (x.CardsValue < y.CardsValue)
            {
                _player2Cards.Enqueue(y);
                _player2Cards.Enqueue(x);
                ClearTable(ref _player2Cards);
            }
        }

        private static void CompareNext(Cards x, Cards y)
        {
            _table.Enqueue(x);
            _table.Enqueue(y);
            _table.Enqueue(_player1Cards.Dequeue());
            _table.Enqueue(_player2Cards.Dequeue());
            Compare(_player1Cards.Dequeue(), _player2Cards.Dequeue());
        }

        private static void ClearTable(ref Queue<Cards> player)
        {
            if (_table == null) return;
            foreach (var card in _table)
            {
                player.Enqueue(card);
            }
        }
    }
}