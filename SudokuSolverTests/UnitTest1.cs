using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuSolverTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
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
