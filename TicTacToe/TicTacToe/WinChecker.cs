using System;
namespace TicTacToe
{
    public class WinChecker
    {
        public WinChecker()
        {
        }

        public static State Check(Board currentState)
        {

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (currentState.board[i,j] != State.undecided)
                    {
                        //vertical from top
                        if (i == 0)
                        {
                            if (currentState.board[i, j] == currentState.board[i + 1, j] && currentState.board[i, j] == currentState.board[i + 2, j])
                                return currentState.board[i,j];
                        }

                        //vertical from middle
                        if (i == 1)
                        {
                            if (currentState.board[i, j] == currentState.board[i - 1, j] && currentState.board[i, j] == currentState.board[i + 1, j])
                                return currentState.board[i,j];

                        }

                        //horizontal from left
                        if (j == 0)
                        {
                            if (currentState.board[i, j] == currentState.board[i, j + 1] && currentState.board[i, j] == currentState.board[i, j + 2])
                                return currentState.board[i, j];
                        }

                        //horizontal from middle
                        if (j == 1)
                        {
                            if (currentState.board[i, j] == currentState.board[i, j - 1] && currentState.board[i, j] == currentState.board[i, j + 1])
                                return currentState.board[i, j];
                        }

                        //diagonal from top left corner to bottom right corner
                        if (i == 0 && j == 0)
                        {
                            if (currentState.board[i, j] == currentState.board[i + 1, j + 1] && currentState.board[i, j] == currentState.board[i + 2, j + 2])
                                return currentState.board[i, j];
                        }

                        //diagonal from bottom left corner to top right corner
                        if (i == 2 && j == 0)
                        {
                            if (currentState.board[i, j] == currentState.board[i - 1, j + 1] && currentState.board[i, j] == currentState.board[i - 2, j + 2])
                                return currentState.board[i, j];
                        }
                    }
                }
            }

            return State.undecided;
               
        }

        public static bool IsDraw (Board currentState)
        {

            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (currentState.board[i, j] != State.undecided)
                        count++;
                }
            }

            if (count == 9 && Check(currentState) == State.undecided)
                return true;

            return false;

        }
    }
}
      
        
 
        
   

