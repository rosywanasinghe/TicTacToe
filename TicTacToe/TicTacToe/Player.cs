using System;
namespace TicTacToe
{
    public class Player
    {
        public Player()
        {
        }

        public static Position GetPosition(Board currentBoard)
        {
            string play;
            do
            {
                play = Console.ReadLine();
            } while (String.Equals(play, "LT") == false && String.Equals(play, "LM") == false && String.Equals(play, "LB") == false && String.Equals(play, "MT") == false && String.Equals(play, "MM") == false && String.Equals(play, "MB") == false && String.Equals(play, "RT") == false && String.Equals(play, "RM") == false && String.Equals(play, "RB") == false);

            Position currentPosition = new Position();

            if (String.Equals(play,"LT"))
            {
                currentPosition.Row = 0;
                currentPosition.Column = 0;
            }
            else if (String.Equals(play, "LM"))
            {
                currentPosition.Row = 1;
                currentPosition.Column = 0;
            }
            else if (String.Equals(play, "LB"))
            {
                currentPosition.Row = 2;
                currentPosition.Column = 0;
            }
            else if (String.Equals(play, "MT"))
            {
                currentPosition.Row = 0;
                currentPosition.Column = 1;
            }
            else if (String.Equals(play, "MM"))
            {
                currentPosition.Row = 1;
                currentPosition.Column = 1;
            }
            else if (String.Equals(play, "MB"))
            {
                currentPosition.Row = 2;
                currentPosition.Column = 1;
            }
            else if (String.Equals(play, "RT"))
            {
                currentPosition.Row = 0;
                currentPosition.Column = 2;
            }
            else if (String.Equals(play, "RM"))
            {
                currentPosition.Row = 1;
                currentPosition.Column = 2;
            }
            else if (String.Equals(play, "RB"))
            {
                currentPosition.Row = 2;
                currentPosition.Column = 2;
            }

            return currentPosition;
        }
    }
}
