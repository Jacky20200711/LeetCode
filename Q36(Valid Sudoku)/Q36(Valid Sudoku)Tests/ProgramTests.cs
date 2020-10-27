using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q36_Valid_Sudoku_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Q36_Valid_Sudoku_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void IsValidSudokuTest()
        {
            Program testClass = new Program();

            char[][] board1 = 
            {
                new char[9]{ '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[9]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[9]{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[9]{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[9]{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[9]{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[9]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[9]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[9]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            char[][] board2 = 
            {
                new char[9]{ '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[9]{ '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[9]{ '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[9]{ '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[9]{ '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[9]{ '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[9]{ '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[9]{ '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[9]{ '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            char[][] board3 =
            {
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            char[][] board4 =
            {
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '1', '.', '1', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[9]{ '.', '.', '.', '.', '.', '.', '.', '.', '.' }
            };

            Assert.AreEqual(true, testClass.IsValidSudoku(board1));
            Assert.AreEqual(false, testClass.IsValidSudoku(board2));
            Assert.AreEqual(true, testClass.IsValidSudoku(board3));
            Assert.AreEqual(false, testClass.IsValidSudoku(board4));
        }
    }
}