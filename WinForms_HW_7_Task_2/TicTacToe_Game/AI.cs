using System;
using System.Collections.Generic;

namespace WindowsForms_TicTacToe.TicTacToe_Game
{
    public class AI
    {
        private readonly Game board;

        public AI() { }

        public AI(Game board) => this.board = board;

        public MyButton MakeEasyMove(MyButton[,] board, List<MyButton> emptyCells)
        {
            Random random = new Random();

            if (emptyCells.Count > 1)
            {
                int randomNum = random.Next(0, emptyCells.Count);
                return emptyCells[randomNum];
            }

            return emptyCells[0];
        }

        public MyButton MakeMediumMove(MyButton[,] board, List<MyButton> emptyCells)
        {

            if (board[1, 1].IsEmpty)
            {
                return board[1, 1];
            }

            if (this.board.GetEmptyCells().Count == 1)
            {
                return emptyCells[0];
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                if ((board[0, i] == board[1, i] || board[2, i] == board[1, i]) && !board[1, i].IsEmpty && board[1, i].Symbol == 'X')
                {
                    if (board[0, i].Symbol == 'X' && board[2, i].IsEmpty)
                    {
                        return board[2, i];
                    }

                    if (board[2, i].Symbol == 'X' && board[0, i].IsEmpty)
                    {
                        return board[0, i];
                    }
                }

                if ((board[i, 0] == board[i, 1] || board[i, 1] == board[i, 2]) && !board[i, 1].IsEmpty && board[i, 1].Symbol == 'X')
                {
                    if (board[i, 0].Symbol == 'X' && board[i, 2].IsEmpty)
                    {
                        return board[i, 2];
                    }

                    if (board[i, 2].Symbol == 'X' && board[i, 0].IsEmpty && board[i, 1].Symbol == 'X')
                    {
                        return board[i, 0];
                    }
                }
            }

            return emptyCells[0];
        }

        public int MakeHardMove(int depth, char turn)
        {
            if (board.HasWon(Game.computer))
            {
                return 1;
            }

            if (board.HasWon(Game.human))
            {
                return -1;
            }

            List<MyButton> countOfEmtyCells = board.GetEmptyCells();

            if (countOfEmtyCells.Count == 0)
            {
                return 0;
            }

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < countOfEmtyCells.Count; i++)
            {
                MyButton cell = countOfEmtyCells[i];

                if (turn == Game.computer)
                {
                    board.PlaceMove(cell, Game.computer);

                    int currentScore = MakeHardMove(depth + 1, Game.human);
                    max = Math.Max(currentScore, max);

                    if (currentScore >= 0 && depth == 0)
                    {
                        board.computerMove = cell;
                    }

                    if (currentScore == 1)
                    {
                        board.board[cell.X, cell.Y].IsEmpty = true;
                        board.board[cell.X, cell.Y].Symbol = ' ';
                        break;
                    }

                    if (i == countOfEmtyCells.Count - 1 && max < 0 && depth == 0)
                    {
                        board.computerMove = cell;
                    }
                }
                else if (turn == Game.human)
                {
                    board.PlaceMove(cell, Game.human);
                    int currentScore = MakeHardMove(depth + 1, Game.computer);
                    min = Math.Min(currentScore, min);

                    if (min == -1)
                    {
                        board.board[cell.X, cell.Y].IsEmpty = true;
                        board.board[cell.X, cell.Y].Symbol = ' ';
                        break;
                    }
                }
                board.board[cell.X, cell.Y].IsEmpty = true;
                board.board[cell.X, cell.Y].Symbol = ' ';
            }
            return turn == Game.computer ? max : min;
        }
    }
}