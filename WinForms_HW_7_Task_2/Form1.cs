using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsForms_TicTacToe.TicTacToe_Game;

namespace WindowsForms_TicTacToe
{
    public partial class Form1 : Form
    {
        private BindingSource source = new BindingSource();
        private BindingList<PlayerInfo> bindingList;
        private readonly List<MyButton> winCells = new List<MyButton>();
        private readonly Game game;
        private MyButton[,] gameBoard;
        private string levelOfDifficulty;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            myButton1.X = 0;
            myButton1.Y = 0;
            myButton2.X = 0;
            myButton2.Y = 1;
            myButton3.X = 0;
            myButton3.Y = 2;

            myButton4.X = 1;
            myButton4.Y = 0;
            myButton5.X = 1;
            myButton5.Y = 1;
            myButton6.X = 1;
            myButton6.Y = 2;

            myButton7.X = 2;
            myButton7.Y = 0;
            myButton8.X = 2;
            myButton8.Y = 1;
            myButton9.X = 2;
            myButton9.Y = 2;

            game = new Game(this);
            ReBinding();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[0].HeaderText = "Игрок";
            dataGridView1.Columns[1].HeaderText = "Уровень сложности";
            dataGridView1.Columns[2].HeaderText = "Результат игры";

            var query = game.Players.GroupBy(p => p.GameResult).Select(p => new { GameResult = p.Key, Count = (double)p.Count() / game.Players.Count * 100 });

            chart1.DataSource = query;
            chart1.Series[0].XValueMember = "GameResult";
            chart1.Series[0].YValueMembers = "Count";
        }

        public void InitializeBoard(ref MyButton[,] board)
        {
            board = new MyButton[3, 3]
            {
                {myButton1, myButton2, myButton3 }, {myButton4, myButton5, myButton6 }, {myButton7, myButton8, myButton9 }
            };

            gameBoard = board;
        }

        public void WinInfo(char player, ref MyButton[,] board)
        {
            try
            {
                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                switch (player)
                {
                    case 'O':
                        {
                            game.SaveToFile(textBox1.Text, levelOfDifficulty, "Поражение");
                            ReBinding();

                            for (int i = 0; i < winCells.Count; i++)
                            {
                                pictureBox.Image = Image.FromFile("27p0.gif");
                                winCells[i].ImageAlign = ContentAlignment.MiddleCenter;
                                winCells[i].Image = pictureBox.Image;
                            }

                            MessageBox.Show("Вы проиграли!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    case 'X':
                        {
                            game.SaveToFile(textBox1.Text, levelOfDifficulty, "Победа");
                            ReBinding();

                            for (int i = 0; i < winCells.Count; i++)
                            {
                                pictureBox.Image = Image.FromFile("tenor.gif");
                                winCells[i].ImageAlign = ContentAlignment.MiddleCenter;
                                winCells[i].Image = pictureBox.Image;
                            }

                            MessageBox.Show("Вы победили!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    case 'D':
                        {
                            game.SaveToFile(textBox1.Text, levelOfDifficulty, "Ничья");
                            ReBinding();
                            MessageBox.Show("Ничья!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }

                statusStrip1.BackgroundImage = imageList1.Images[2];
                menuStrip1.BackgroundImage = imageList1.Images[2];
                winCells.Clear();
                ClearBoard(board);
                gameBoard = board;
                panel1.Visible = false;
                panel2.Visible = false;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void AddWinCells(MyButton cell) => winCells.Add(cell);

        public void SetImgForCell(MyButton cell) => cell.Image = imageList1.Images[1];

        private void ReBinding()
        {
            chart1.DataBind();
            bindingList = new BindingList<PlayerInfo>(game.Players);
            source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void играToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBoard(gameBoard);
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void ClearBoard(MyButton[,] gameBoard)
        {
            foreach (MyButton cell in gameBoard)
            {
                cell.Image = null;
                cell.IsEmpty = true;
                cell.Symbol = ' ';
            }
        }

        private void myButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton1.IsEmpty)
                {
                    myButton1.Symbol = 'X';
                    myButton1.IsEmpty = false;
                    myButton1.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton2.IsEmpty)
                {
                    myButton2.Symbol = 'X';
                    myButton2.IsEmpty = false;
                    myButton2.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton3.IsEmpty)
                {
                    myButton3.Symbol = 'X';
                    myButton3.IsEmpty = false;
                    myButton3.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton4.IsEmpty)
                {
                    myButton4.Symbol = 'X';
                    myButton4.IsEmpty = false;
                    myButton4.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton5.IsEmpty)
                {
                    myButton5.Symbol = 'X';
                    myButton5.IsEmpty = false;
                    myButton5.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton6.IsEmpty)
                {
                    myButton6.Symbol = 'X';
                    myButton6.IsEmpty = false;
                    myButton6.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void myButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton7.IsEmpty)
                {
                    myButton7.Symbol = 'X';
                    myButton7.IsEmpty = false;
                    myButton7.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton8.IsEmpty)
                {
                    myButton8.Symbol = 'X';
                    myButton8.IsEmpty = false;
                    myButton8.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void myButton9_Click(object sender, EventArgs e)
        {
            try
            {
                if (myButton9.IsEmpty)
                {
                    myButton9.Symbol = 'X';
                    myButton9.IsEmpty = false;
                    myButton9.Image = imageList1.Images[0];
                    game.StartGame(levelOfDifficulty);
                }
                else
                {
                    MessageBox.Show("Выбранная клетка занята!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() != null && textBox1.Text.Length > 0)
                {
                    if(!game.CheckForUniqNickname(textBox1.Text))
                    {
                        textBox1.BackColor = Color.Red;
                        MessageBox.Show("Выбранный Вами никнейм уже существует. Введите другой.", "Уведомелние", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    textBox1.BackColor = Color.White;
                    menuStrip1.BackgroundImage = imageList1.Images[5];
                    statusStrip1.BackgroundImage = imageList1.Images[5];
                    toolStripStatusLabel1.BackColor = Color.FromArgb(2, 0, 86);
                    panel1.Dock = DockStyle.Fill;
                    panel2.Visible = false;
                    panel1.Visible = true;
                    levelOfDifficulty = comboBox1.SelectedItem.ToString();

                    if (radioButton2.Checked)
                    {
                        game.StartGame(levelOfDifficulty);
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе данных. Повоторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void результатыИгрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.BackgroundImage = imageList1.Images[2];
            menuStrip1.BackgroundImage = imageList1.Images[2];

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e) => toolStripStatusLabel1.Text = DateTime.Now.ToString();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}