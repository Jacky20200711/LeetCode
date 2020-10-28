using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q37_Sudoku_Solver_;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Q37_Sudoku_Solver_.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SolveSudokuTest()
        {
            Program testClass = new Program();

            char[][] Sudoku =
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

            char[][] Answer =
            {
                new char[9]{ '5', '3', '4', '6', '7', '8', '9', '1', '2' },
                new char[9]{ '6', '7', '2', '1', '9', '5', '3', '4', '8' },
                new char[9]{ '1', '9', '8', '3', '4', '2', '5', '6', '7' },
                new char[9]{ '8', '5', '9', '7', '6', '1', '4', '2', '3' },
                new char[9]{ '4', '2', '6', '8', '5', '3', '7', '9', '1' },
                new char[9]{ '7', '1', '3', '9', '2', '4', '8', '5', '6' },
                new char[9]{ '9', '6', '1', '5', '3', '7', '2', '8', '4' },
                new char[9]{ '2', '8', '7', '4', '1', '9', '6', '3', '5' },
                new char[9]{ '3', '4', '5', '2', '8', '6', '1', '7', '9' }
            };

            testClass.SolveSudoku(Sudoku);

            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(Sudoku[i][j] != Answer[i][j])
                    {
                        Assert.Fail();
                    }
                }
            }
        }
    }
}