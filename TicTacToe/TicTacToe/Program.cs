using System;

namespace TicTacToe
{
    public enum State { O, X, undecided };

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe! Player 1 will play crosses, and Player 2 will play noughts.");

            Board GameBoard = new Board();

            Renderer.PrintGame(GameBoard);

            int currentMove = 1;

            while (WinChecker.Check(GameBoard) == State.undecided && WinChecker.IsDraw(GameBoard) == false)
            { 
                if (currentMove%2 == 1)
                {
                    Console.WriteLine("Player 1's turn: ");
                }
                else if (currentMove%2 == 0)
                {
                    Console.WriteLine("Player 2's turn: ");
                }

                Position currentPosition = new Position();
                currentPosition = Player.GetPosition(GameBoard);

                while (GameBoard.board[currentPosition.Row, currentPosition.Column] != State.undecided)
                {
                    Console.WriteLine("Pick a valid move ya cheekster");
                    currentPosition = Player.GetPosition(GameBoard);
                }              

                if (currentMove%2 == 1)
                {
                    GameBoard.ChangePositionState(currentPosition, State.X);
                }
                else if (currentMove%2 == 0)
                {
                    GameBoard.ChangePositionState(currentPosition, State.O);
                }
                
                Renderer.PrintGame(GameBoard);

                if (WinChecker.Check(GameBoard) == State.X)
                {
                    Console.WriteLine("Player 1 wins!");
                    return;
                }
                else if (WinChecker.Check(GameBoard) == State.O)
                {
                    Console.WriteLine("Player 2 wins!");
                    return;
                }
                else if (WinChecker.IsDraw(GameBoard) == true)
                {
                    Console.WriteLine("It's a draw!");
                    return;
                }

                currentMove++;
            }
        }
    }
}
