using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeChecker;

namespace TestTicTacToeChecker
{
    [TestClass]
    public class TestTicTacToeChecker
    {        
        private TicTacToe _tictactoe = new TicTacToe();


        [TestMethod]
        public void TestNotSolved()
        {
            int[,] board = { { 0, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(-1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestNotSolved2()
        {
            int[,] board = { { 2, 0, 2 }, { 2, 1, 1 }, { 1, 2, 1 } };
            Assert.AreEqual(-1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestDraw()
        {
            int[,] board = { { 2, 1, 1 }, { 1, 2, 2 }, { 1, 2, 1 } };
            Assert.AreEqual(0, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonLine1()
        {
            int[,] board = { { 1, 1, 1 }, { 0, 2, 0 }, { 2, 1, 2 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonCol1()
        {
            int[,] board = { { 1, 0, 0 }, { 1, 2, 0 }, { 1, 2, 0 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonLine2()
        {
            int[,] board ={ { 0, 2, 0 }, { 1, 1, 1 }, { 2, 1, 2 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonCol2()
        {
            int[,] board = { { 0, 1, 0 }, { 2, 1, 0 }, { 2, 1, 0 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonLine3()
        {
            int[,] board = { { 2, 1, 2 }, { 0, 2, 0 }, { 1, 1, 1 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonCol3()
        {
            int[,] board = { { 0, 0, 1 }, { 2, 0, 1 }, { 2, 0, 1 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonLine1()
        {
            int[,] board = { { 2, 2, 2 }, { 0, 1, 0 }, { 1, 2, 1 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonCol1()
        {
            int[,] board = { { 2, 0, 0 }, { 2, 1, 0 }, { 2, 1, 0 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonLine2()
        {
            int[,] board = { { 0, 1, 0 }, { 2, 2, 2 }, { 1, 2, 1 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonCol2()
        {
            int[,] board = { { 0, 2, 0 }, { 1, 2, 0 }, { 1, 2, 0 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonLine3()
        {
            int[,] board = { { 1, 2, 1 }, { 0, 1, 0 }, { 2, 2, 2 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonCol3()
        {
            int[,] board = { { 0, 0, 2 }, { 1, 0, 2 }, { 1, 0, 2 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonDiag1()
        {
            int[,] board = { { 1, 0, 2 }, { 0, 1, 2 }, { 0, 0, 1 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedXWonDiag2()
        {
            int[,] board = new int[,] { { 0, 0, 1 }, { 0, 1, 2 }, { 1, 0, 2 } };
            Assert.AreEqual(1, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonDiag1()
        {
            int[,] board = { { 2, 0, 1 }, { 0, 2, 1 }, { 0, 0, 2 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }

        [TestMethod]
        public void TestSolvedOWonDiag2()
        {
            int[,] board = { { 0, 0, 2 }, { 0, 2, 1 }, { 2, 0, 1 } };
            Assert.AreEqual(2, _tictactoe.IsSolved(board));
        }
    }
}
