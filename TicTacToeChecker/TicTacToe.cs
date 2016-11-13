using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace TicTacToeChecker
{
    public class TicTacToe
    {
        /*
         * 0 = empty
         * 1 = X
         * 2 = O
         * 
         * -1 Not Solved
         *  1 X Won
         *  2 O won
         *  0 Draw
         */

        private const int Columns = 3;        

        public int IsSolved(int[,] board)
        {
            var result = 0;
            for (var i = 0; i < Columns; i++)
            {
                var isHorSol = IsHorSol(board, i);
                if (isHorSol > 0) return isHorSol;
                result = Math.Min(result, isHorSol);

                var isVertSol = IsVertSol(board, i);
                if (isVertSol > 0) return isVertSol;
                result = Math.Min(result, isVertSol);

                if (i <= 0 || i >= Columns) continue;

                var isDiag1Sol = IsDiag1Sol(board);
                if (isDiag1Sol > 0) return isDiag1Sol;
                result = Math.Min(result, isDiag1Sol);

                var isDiag2Sol = IsDiag2Sol(board);
                if (isDiag2Sol > 0) return isDiag2Sol;
                result = Math.Min(result, isDiag2Sol);
            }
            return result;
        }

        private static int IsHorSol(int[,] board, int position)
        {
            var line = new Collection<int>();
            for (int f = 0; f < Columns; f++)
            {
                line.Add(board[position, f]);
            }
            return CheckResults(line);
        }

        private static int IsVertSol(int[,] board, int position)
        {
            var line = new Collection<int>();
            for (int f = 0; f < Columns; f++)
            {
                line.Add(board[f, position]);
            }           
            return CheckResults(line);
        }

        private static int IsDiag1Sol(int[,] board)
        {           
            var line = new Collection<int>();
            for (int f = 0; f < Columns; f++)
            {
                line.Add(board[f, f]);
            }            
            return CheckResults(line);
        }

        private static int IsDiag2Sol(int[,] board)
        {
            var line = new Collection<int>();
            for (int f = 0; f < Columns; f++)
            {
                line.Add(board[f, Columns-1-f]);
            }
            return CheckResults(line);
        }

        private static int CheckResults(Collection<int> line)
        {
            if (line.Any(x => x == 0)) return -1;
            if (line.All(x => x == 1)) return 1;
            return line.All(x => x == 2) ? 2 : 0;
        }        
    }
}
