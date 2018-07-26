using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuSolverTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEasy1()
        {
            int[,] unsolved = new int[,]
            {
                { 2, 8, 0, 0, 9, 0, 0, 1, 7 },
                { 3, 0, 0, 6, 0, 7, 0, 0, 2 },
                { 0, 0, 9, 0, 0, 0, 5, 0, 0 },
                { 0, 7, 0, 4, 0, 6, 0, 9, 0 },
                { 9, 0, 0, 0, 0, 0, 0, 0, 6 },
                { 0, 1, 0, 7, 0, 9, 0, 8, 0 },
                { 0, 0, 5, 0, 0, 0, 8, 0, 0 },
                { 8, 0, 0, 1, 0, 5, 0, 0, 4 },
                { 4, 3, 0, 0, 2, 0, 0, 7, 5 },
            };

            int[,] solved = new int[,]
            {
                { 2, 8, 4, 5, 9, 3, 6, 1, 7 },
                { 3, 5, 1, 6, 8, 7, 9, 4, 2 },
                { 7, 6, 9, 2, 4, 1, 5, 3, 8 },
                { 5, 7, 8, 4, 3, 6, 2, 9, 1 },
                { 9, 4, 3, 8, 1, 2, 7, 5, 6 },
                { 6, 1, 2, 7, 5, 9, 4, 8, 3 },
                { 1, 2, 5, 3, 7, 4, 8, 6, 9 },
                { 8, 9, 7, 1, 6, 5, 3, 2, 4 },
                { 4, 3, 6, 9, 2, 8, 1, 7, 5 },
            };

            Assert.AreEqual(solved, SudokuSolver.Game.SolveAPuzzle(unsolved));
        }

        [TestMethod]
        public void TestTopLeftLogic()
        {
            SudokuSolver.Game.GetTopLeftOf3x3Square(0, 0, out int rowOut, out int colOut);
            Assert.AreEqual(0, rowOut);
            Assert.AreEqual(0, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(0, 1, out rowOut, out colOut);
            Assert.AreEqual(0, rowOut);
            Assert.AreEqual(0, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(1, 0, out rowOut, out colOut);
            Assert.AreEqual(0, rowOut);
            Assert.AreEqual(0, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(1, 1, out rowOut, out colOut);
            Assert.AreEqual(0, rowOut);
            Assert.AreEqual(0, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(2, 2, out rowOut, out colOut);
            Assert.AreEqual(0, rowOut);
            Assert.AreEqual(0, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(1, 2, out rowOut, out colOut);
            Assert.AreEqual(0, rowOut);
            Assert.AreEqual(0, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(5, 5, out rowOut, out colOut);
            Assert.AreEqual(3, rowOut);
            Assert.AreEqual(3, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(7, 8, out rowOut, out colOut);
            Assert.AreEqual(6, rowOut);
            Assert.AreEqual(6, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(8, 8, out rowOut, out colOut);
            Assert.AreEqual(6, rowOut);
            Assert.AreEqual(6, colOut);

            SudokuSolver.Game.GetTopLeftOf3x3Square(7, 7, out rowOut, out colOut);
            Assert.AreEqual(6, rowOut);
            Assert.AreEqual(6, colOut);
        }
    }
}
