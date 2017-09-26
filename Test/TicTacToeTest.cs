using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using spil;

namespace Test
{
    [TestClass]
    public class TicTacToeTest {
        [TestMethod]
        public void TicTacToeCanStart()
        {
            throw new Exception();
        }
        [TestMethod]
        public void TicTacToeCanPlace()
        {
            throw new Exception();
        }
        [TestMethod]
        public void TicTacToeCanNotReplace()
        {
            throw new Exception();
        }
        [TestClass]
        public class GameWinnerServiceTests
        {
            private char[,] GameBoard;

            //[TestMethod]
            //public void NeitherPlayerHasThreeInARow()
            //{
            //    const char expected = ' ';
            //    var actual = TicTacToe.Validate(GameBoard);
            //    Assert.AreEqual(expected, actual);
            //}

            [TestMethod]
            public void PlayerWithAllSpacesInTopRowIsWinner()
            {
                GameBoard = new char[3, 3] 
                {
                {'X', 'X', 'X'},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };

                Assert.AreEqual('X', TicTacToe.Validate(GameBoard));
            }

            //[testmethod]
            //public void playerwithallspacesinsecondrowiswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //        {' ', ' ', ' '},
            //        {'x', 'x', 'x'},
            //        {' ', ' ', ' '}
            //    };

            //    assert.areequal('x', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerwithallspacesinthirdrowiswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {' ', ' ', ' '},
            //    {' ', ' ', ' '},
            //    {'x', 'x', 'x'},
            //};
            //    assert.areequal('x', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerwithallspacesinfirstcolumniswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {'x', ' ', ' '},
            //    {'x', ' ', ' '},
            //    {'x', ' ', ' '},
            //};

            //    assert.areequal('x', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerwithallspacesinsecondcolumniswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {' ', 'x', ' '},
            //    {' ', 'x', ' '},
            //    {' ', 'x', ' '},
            //};

            //    assert.areequal('x', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerwithallspacesinthirdcolumniswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {' ', ' ', 'x'},
            //    {' ', ' ', 'x'},
            //    {' ', ' ', 'x'},
            //};

            //    assert.areequal('x', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerwiththreeinarowdiagonallydownandtorightiswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {'x', ' ', ' '},
            //    {' ', 'x', ' '},
            //    {' ', ' ', 'x'},
            //};

            //    assert.areequal('x', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerwiththreeinarowdiagonallydownandtoleftiswinner()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {' ', ' ', 'x'},
            //    {' ', 'x', ' '},
            //    {'x', ' ', ' '},
            //};

            //    var actual = tictactoe.validate(gameboard);
            //    assert.areequal('x', actual);
            //}

            //[testmethod]
            //public void noonewins()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {' ', ' ', ' '},
            //    {' ', 'x', 'x'},
            //    {'x', ' ', ' '},
            //};

            //    assert.areequal(' ', tictactoe.validate(gameboard));

            //    gameboard = new char[3, 3]
            //{
            //    {'x', ' ', 'x'},
            //    {' ', 'x', ' '},
            //    {' ', ' ', ' '},
            //};

            //    assert.areequal(' ', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerowinstoprow()
            //{

            //    gameboard = new char[3, 3]
            //{
            //    {'o', 'o', 'o'},
            //    {' ', ' ', ' '},
            //    {' ', ' ', ' '},
            //};

            //    assert.areequal('o', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerowinscolumntwo()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {' ', 'o', ' '},
            //    {' ', 'o', ' '},
            //    {' ', 'o', ' '},
            //};

            //    assert.areequal('o', tictactoe.validate(gameboard));
            //}

            //[testmethod]
            //public void playerowinsdiagonally()
            //{
            //    gameboard = new char[3, 3]
            //{
            //    {'o', ' ', ' '},
            //    {' ', 'o', ' '},
            //    {' ', ' ', 'o'},
            //};

            //    assert.areequal('o', tictactoe.validate(gameboard));
            }
        }
    }
}
