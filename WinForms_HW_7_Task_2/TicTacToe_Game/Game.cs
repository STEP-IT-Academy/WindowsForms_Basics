using System.Collections.Generic;
using System.Linq;

namespace WindowsForms_TicTacToe.TicTacToe_Game
{
    public class Game
    {
        private readonly FileWorker fileWorker = new FileWorker();
        private readonly Form1 form1;
        private bool winGame;
        private const string easyLevelName = "Низкий";
        private const string meduimLevelName = "Средний";
        private const string hardLevelName = "Высокий";

        internal List<PlayerInfo> Players { get; private set; } = new List<PlayerInfo>();

        public static readonly char computer = 'O';
        public static readonly char human = 'X';
        public Player HUMAN;
        public Player COMPUTER;
        public MyButton[,] board;
        public MyButton computerMove;
        public List<string> nicknames = new List<string>();

        public Game(Form1 form1)
        {
            this.form1 = form1;
            this.form1.InitializeBoard(ref board);

            HUMAN = new Player(true, this, form1);
            COMPUTER = new Player(false, this, form1);

            fileWorker.ReadFromXMLFile(Players);
        }

        public void StartGame(string levelOfDifficulty)
        {
            winGame = false;

            switch (levelOfDifficulty)
            {
                case easyLevelName: COMPUTER.GetEasyComputerMove(); break;
                case meduimLevelName: COMPUTER.GetMediumComputerMove(); break;
                case hardLevelName: COMPUTER.GetHardComputerMove(); break;
            }

            if (IsGameOver() && winGame)
            {
                if (HasWon(computer))
                {
                    form1.WinInfo(computer, ref board);
                }
                else if (HasWon(human))
                {
                    form1.WinInfo(human, ref board);
                }
                else
                {
                    form1.WinInfo('D', ref board);
                }
            }
        }

        public bool PlaceMove(MyButton cell, char player)
        {
            if (!board[cell.X, cell.Y].IsEmpty)
            {
                return false;
            }

            board[cell.X, cell.Y].Symbol = player;
            board[cell.X, cell.Y].IsEmpty = false;

            return true;
        }

        public bool IsGameOver()
        {
            if (HasWon_2(computer) || HasWon_2(human) || GetEmptyCells().Count == 0)
            {
                winGame = true;
                return true;
            }
            return false;
        }

        public List<MyButton> GetEmptyCells()
        {
            List<MyButton> emptyCells = new List<MyButton>();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j].IsEmpty)
                    {
                        emptyCells.Add(board[i, j]);
                    }
                }
            }

            return emptyCells;
        }

        public bool HasWon(char player)
        {
            if ((board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0].Symbol == player) ||
                board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2].Symbol == player)
            {
                return true;
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                if ((board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0].Symbol == player) ||
               board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i].Symbol == player)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasWon_2(char player)
        {
            if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0].Symbol == player)
            {
                form1.AddWinCells(board[0, 0]);
                form1.AddWinCells(board[1, 1]);
                form1.AddWinCells(board[2, 2]);
                return true;
            }

            if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0] && board[0, 2].Symbol == player)
            {
                form1.AddWinCells(board[0, 2]);
                form1.AddWinCells(board[1, 1]);
                form1.AddWinCells(board[2, 0]);
                return true;
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {

                if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2] && board[i, 0].Symbol == player)
                {
                    form1.AddWinCells(board[i, 0]);
                    form1.AddWinCells(board[i, 1]);
                    form1.AddWinCells(board[i, 2]);
                    return true;
                }

                if (board[0, i] == board[1, i] && board[0, i] == board[2, i] && board[0, i].Symbol == player)
                {
                    form1.AddWinCells(board[0, i]);
                    form1.AddWinCells(board[1, i]);
                    form1.AddWinCells(board[2, i]);
                    return true;
                }
            }

            return false;
        }

        public MyButton CloseToWin(MyButton[,] board)
        {
            if (!board[0, 0].IsEmpty && !board[0, 1].IsEmpty && board[0, 1].Symbol == 'X' && board[0, 2].IsEmpty)
            {
                return board[0, 2];
            }

            if (!board[0, 0].IsEmpty && !board[2, 0].IsEmpty && board[2, 0].Symbol == 'X' && board[1, 0].IsEmpty)
            {
                return board[1, 0];
            }

            if (!board[0, 0].IsEmpty && !board[0, 2].IsEmpty && board[0, 2].Symbol == 'X' && board[0, 1].IsEmpty)
            {
                return board[0, 1];
            }

            if (!board[2, 0].IsEmpty && !board[2, 2].IsEmpty && board[2, 2].Symbol == 'X' && board[2, 1].IsEmpty)
            {
                return board[2, 1];
            }

            return null;
        }

        public bool CheckForUniqNickname(string nickname)
        {
            int tmp = Players.OrderBy(p => p.Nickname).Select(p => p.Nickname).ToList().BinarySearch(nickname);
            return tmp >= 0 ? false : true;
        }

        public void SaveToFile(string nickname, string levelOfDifficulty, string gameResult)
        {
            Players.Add(new PlayerInfo { Nickname = nickname, GameLevel = levelOfDifficulty, GameResult = gameResult });
            fileWorker.SaveToXMLFile(Players);
        }
    }
}