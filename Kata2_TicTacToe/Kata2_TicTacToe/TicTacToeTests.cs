using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata2_TicTacToe
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var game = new TicTacToe();
            var result = game.Play(1, 1, 'X');
            Assert.AreEqual(result, GameStatus.NobodyWins);
        }

        [TestMethod]
        public void InvalidPlayer()
        {
            var game = new TicTacToe();
            var result = game.Play(1, 1, 'z');
            Assert.AreEqual(result, GameStatus.InvalidPlayer);
        }

        [TestMethod]
        public void InvalidPosition()
        {
            var game = new TicTacToe();
            var result = game.Play(4, 1, 'X');
            Assert.AreEqual(result, GameStatus.InvalidPosition);
        }

        [TestMethod]
        public void FieldIsUsed()
        {
            var game = new TicTacToe();
            game.Play(1, 1, 'X');
            var result = game.Play(1, 1, '0');
            Assert.AreEqual(result, GameStatus.FieldIsUsed);
        }

        [TestMethod]
        public void FirstLineZeroWins()
        {
            //000
            //...
            //...
            var game = new TicTacToe();
            game.Play(1, 1, '0');
            game.Play(1, 2, '0');
            var result = game.Play(1, 3, '0');
            Assert.AreEqual(result, GameStatus.WinZero);
        }

        [TestMethod]
        public void FirstColumnXWins()
        {
            //X..
            //X..
            //X..
            var game = new TicTacToe();
            game.Play(1, 1, 'X');
            game.Play(2, 1, 'X');
            var result = game.Play(3, 1, 'X');
            Assert.AreEqual(result, GameStatus.WinX);
        }

        [TestMethod]
        public void Diagonal1ZeroWins()
        {
            //0..
            //.0.
            //..0
            var game = new TicTacToe();
            game.Play(1, 1, '0');
            game.Play(2, 2, '0');
            var result = game.Play(3, 3, '0');
            Assert.AreEqual(result, GameStatus.WinZero);
        }

        [TestMethod]
        public void Diagonal2XWins()
        {
            //..X
            //.X.
            //X..
            var game = new TicTacToe();
            game.Play(3, 1, 'X');
            game.Play(2, 2, 'X');
            var result = game.Play(1, 3, 'X');
            Assert.AreEqual(result, GameStatus.WinX);
        }

        [TestMethod]
        public void OnlyFirstWinnerX()
        {
            //000
            //XXX
            //...
            var game = new TicTacToe();
            game.Play(2, 1, 'X');
            game.Play(2, 2, 'X');
            game.Play(2, 3, 'X');
            game.Play(1, 1, '0');
            game.Play(1, 2, '0');
            var result = game.Play(1, 3, '0');
            Assert.AreEqual(result, GameStatus.WinX);
        }

    }


}
