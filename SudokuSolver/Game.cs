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

        public void Populate()
        {
            int[,] puzz = new int[ROW_SIZE, ROW_SIZE];

            int[,] array5 = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            };

            for (int rowIndex = 0; rowIndex < ROW_SIZE; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ROW_SIZE; colIndex++)
                {

                }
            }
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

            for (int rowIndex = 0; rowIndex < ROW_SIZE; rowIndex++)
            {
                for (int colIndex = 0; colIndex < ROW_SIZE; colIndex++)
                {
                    var thisSquare = infoPuzzle[rowIndex, colIndex];
                    if (thisSquare.Number == -1)
                    {
                        var conflictNumbers = GetConflictNumbers(infoPuzzle, rowIndex, colIndex);
                    }
                }
            }
            return null;
        }

        private static object GetConflictNumbers(ASquare[,] infoPuzzle, int row, int col)
        {
            List<int> conflictNumbers = new List<int>();

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
            int columnsAwayFromTopLeft = col % 3;

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
