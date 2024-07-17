﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolySimulation.Tests
{
    public class WhenLandingOnMoneySquare
    {
        private Game _game;
        string[] _tokens;
        IList<Player> _players;
        int _numOfPlayers;

        public WhenLandingOnMoneySquare()
        {
            _game = new();
            _tokens = ["dog", "sport car", "iron", "battleship", "top hat", "thimble", "wheelbarrow", "cat"];
            _numOfPlayers = 8;
            _game.Setup(_numOfPlayers, _tokens);
            _game.PlayRounds(1);
            _players = _game.Players!;
        }

        [Fact]
        public void ShouldGet200WhenLandingOnGo()
        {
            Board board = new Board();
            Player player = new Player(board.Squares[37], "BLAH");
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            var originalAmount = player.CashAmount;
            
            //act
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount + 200);
        }


        [Fact]
        public void ShouldGet200WhenPassingGo()
        {
            Board board = new Board();
            Player player = new Player(board.Squares[37], "BLAH");
            Die die1 = new LoadedDie(2);
            Die die2 = new LoadedDie(2);
            var originalAmount = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount + 200);
        }

        [Fact]
        public void ShouldNotDoubleDipOnGo()
        {
            Board board = new Board();
            Player player = new Player(board.Squares[37], "BLAH");
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(2);
            var originalAmount = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount + 200);
        }

        [Fact]
        public void ShouldPay75OnLuxurySquare()
        {
            Board board = new Board();
            Player player = new Player(board.Squares[36], "BLAH");
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(1);
            var originalAmount = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount - 75);
        }

        [Fact]
        public void ShouldPay200OnIncomeTaxSquareWhenPlayerIsRich()
        {
            Board board = new Board();
            Player player = new Player(board.Squares[2], "BLAH");
            player.CashAmount = 3000;
            Die die1 = new LoadedDie(1);
            Die die2 = new LoadedDie(1);
            var originalAmount = player.CashAmount;

            //act
            player.TakeTurn(die1, die2);
            var newAmount = player.CashAmount;

            // assert
            Assert.Equal(newAmount, originalAmount - 200);
        }
    }
}
