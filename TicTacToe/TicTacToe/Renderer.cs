using System;
namespace TicTacToe
{
    public static class Renderer
    {

        public static void PrintGame(Board currentState)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //optimise you silly duck
                    // fix up board
                    // add horizontal lines 
                    if (j == 0 || j == 1)
                    {
                        if (currentState.board[i, j] == State.O)
                            Console.Write(" O  |");

                        if (currentState.board[i, j] == State.X)
                            Console.Write(" X  |");

                        if (currentState.board[i, j] == State.undecided)
                            Console.Write("    |");
                    }

                    if (j == 2)
                    {
                        if (currentState.board[i, j] == State.O)
                            Console.Write(" O\n");

                        if (currentState.board[i, j] == State.X)
                            Console.Write(" X\n");

                        if (currentState.board[i, j] == State.undecided)
                            Console.WriteLine();
                    }

                }

                if (i != 2)
                    Console.WriteLine("--------------");
            }
        }

    }
}
