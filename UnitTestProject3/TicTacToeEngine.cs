using System;
using System.Collections.Generic;

namespace UnitTestProject3
{
    internal class TicTacToeEngine
    {
        List<String> board = new List<String>();
        internal void takeTurn()
        {
            board[4] = "X";
        }

        internal object getValueOfField(int position)
        {
            return board[position];
        }

        internal void InitNewGame()
        {
            for (int i = 0; i < 9; i = i + 1)
            {
                board.Add("-");
            }
        }
    }
}