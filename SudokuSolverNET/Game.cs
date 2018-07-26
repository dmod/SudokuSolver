using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public class ASquare
    {
        public int Number { get; set; }
        public int[] PossibleNums { get; set; }
    }

    public class Game
    {

        public const int ROW_SIZE = 9;

        public Game()
        {
            // Default
        }

        public static int[,] SolveAPuzzle(int[,] puzzle)
        {
            ASquare[,] infoPuzzle = new ASquare[9, 9];

            for (int rowIndex = 0; rowIndex < ROW_SIZE; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ROW_SIZE; colIndex++)
                {
                    int puzzNum = puzzle[rowIndex, colIndex];
                    infoPuzzle[rowIndex, colIndex] = new ASquare() { Number = puzzNum };
                }
            }


            return null;
        }

        private static void RefreshConflictNumbers(ASquare[,] infoPuzzle)
        {
            for (int rowIndex = 0; rowIndex < ROW_SIZE; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ROW_SIZE; colIndex++)
                {
                    var thisSquare = infoPuzzle[rowIndex, colIndex];
                    if (thisSquare.Number == -1)
                    {
                        HashSet<int> conflictNumbers = GetConflictNumbers(infoPuzzle, rowIndex, colIndex);
                    }
                }
            }
        }

            private static HashSet<int> GetConflictNumbers(ASquare[,] infoPuzzle, int row, int col)
        {
            HashSet<int> conflictNumbers = new HashSet<int>();

            // First check the row
            for(int colIndex = 0; colIndex < 9; colIndex++)
            {
                if (col == colIndex) continue;
                int thisSquare = infoPuzzle[row, colIndex].Number;
                if (thisSquare != -1) conflictNumbers.Add(thisSquare);
            }

            // Then the column
            for (int rowIndex = 0; rowIndex < 9; rowIndex++)
            {
                if (row == rowIndex) continue;
                int thisSquare = infoPuzzle[rowIndex, col].Number;
                if (thisSquare != -1) conflictNumbers.Add(thisSquare);
            }

            // Then the containing square
            GetTopLeftOf3x3Square(row, col, out int topLeftRow, out int topLeftCol);

            for(int rowInsideSquareIndex = topLeftRow; rowInsideSquareIndex < topLeftRow + 3; rowInsideSquareIndex++)
            {
                for (int colInsideSquareIndex = topLeftCol; colInsideSquareIndex < topLeftCol + 3; colInsideSquareIndex++)
                {
                    if (rowInsideSquareIndex == row && colInsideSquareIndex == col) continue; // Skip over same square
                    int thisSquare = infoPuzzle[rowInsideSquareIndex, colInsideSquareIndex].Number;
                    if(thisSquare != -1) conflictNumbers.Add(thisSquare);
                }
            }

            return conflictNumbers;
        }

        public static void GetTopLeftOf3x3Square(int rowIn, int colIn, out int rowOut, out int colOut)
        {
            int rowsAwayFromTopLeft = rowIn % 3;
            int columnsAwayFromTopLeft = colIn % 3;
            rowOut = rowIn - rowsAwayFromTopLeft;
            colOut = colIn - columnsAwayFromTopLeft;
        }
    }
}
