using System;
namespace TicTacToe
{
    public class Board
    {
        internal State[,] board = new State[3, 3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = State.undecided;
                }
            }
        }

        public State GetPositionState(Position position)
        {
            return board[position.Row, position.Column];
        }

        public void ChangePositionState(Position position, State play)
        {
            board[position.Row, position.Column] = play;
        }


    }
}
