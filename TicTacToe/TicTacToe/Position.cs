using System;
namespace TicTacToe
{

    public class Position
    {
        private int row;
        private int column;

        public Position()
        {
        }

        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }

            
        }

        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }
    }
}
