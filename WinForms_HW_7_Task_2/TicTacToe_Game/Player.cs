using System.Collections.Generic;

namespace WindowsForms_TicTacToe.TicTacToe_Game
{
    public struct PlayerInfo
    {
        public string Nickname { get; set; }

        public string GameLevel { get; set; }

        public string GameResult { get; set; }
    }

    public class Player
    {
        private readonly AI ai;
        private readonly Game board;
        private readonly Form1 form1;
        private readonly bool human;

        public Player() { }

        public Player(bool human, Game board, Form1 form1)
        {
            this.form1 = form1;
            Marker = human ? 'X' : 'O';
            this.human = human;
            this.board = board;
            ai = new AI(this.board);
        }

        public char Marker { get; set; }

        public void GetHardComputerMove()
        {
            ai.MakeHardMove(0, Marker);
            board.PlaceMove(board.computerMove, Game.computer);
            form1.SetImgForCell(board.computerMove);
        }

        public void GetMediumComputerMove()
        {
            if (!board.IsGameOver())
            {
                List<MyButton> emptyCells = board.GetEmptyCells();
                MyButton cell = ai.MakeMediumMove(board.board, emptyCells);
                board.PlaceMove(cell, Game.computer);
                form1.SetImgForCell(cell);
            }
        }

        public void GetEasyComputerMove()
        {
            if (!board.IsGameOver())
            {
                List<MyButton> emptyCells = board.GetEmptyCells();
                MyButton cell = ai.MakeEasyMove(board.board, emptyCells);
                board.PlaceMove(cell, Game.computer);
                form1.SetImgForCell(cell);
            }
        }
    }
}