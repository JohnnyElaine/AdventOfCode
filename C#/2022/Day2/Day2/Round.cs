using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Round
    {
        /*
         * column = my move
         * row = opponents move
         * 
         * 
         *          Rock    Paper   Scissors
         * Rock     Draw    Win     Loss
         * Paper    Loss    Draw    Win
         * Scissors Win     Loss    Draw
         * 
         * The value of Rock/Paper/Scissors reflects the points one recieves when choosing the shape:
         * Rock = 1
         * Paper = 2
         * Scissors = 3
         * 
         * The intersection of my choice and the opponents choice is the points gained for:
         * Loss = 0
         * Draw = 3
         * Win = 6
         */

        private static int[,] winLossMatrix = new int[4, 4] {
            {0, 1, 2, 3},
            {1, 3, 6, 0},
            {2, 0, 3, 6},
            {3, 6, 0, 3}
            };

        private int opponentMove;
        private int myMove;
    

        public Round(int opponentMove, int myMove)
        {
            this.opponentMove = opponentMove;
            this.myMove = myMove;
        }

        public int eval()
        {
            return myMove + winLossMatrix[opponentMove, myMove];
        }

        public override string ToString()
        {
            return $"({opponentMove}, {myMove})";
        }


    }
}
