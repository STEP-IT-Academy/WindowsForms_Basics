using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Testing.Models;

namespace WindowsFormsApp_MultiplicationTable
{
    public partial class Form1 : Form
    {
        private readonly Test test;
        private readonly MyLabel[] labels;
        private int index;

        public Form1()
        {
            InitializeComponent();
            test = Test.Get();
            numericUpDown1.Value = test.TestTime;
            test.Generator = new RandomGenerator(test.MinNumber, test.MaxNumber);

            labels = new MyLabel[5]
            {
                myLabel1, myLabel2, myLabel3, myLabel4, myLabel5
            };
        }

        // Ок в настройке
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                test.TestTime = (int)numericUpDown1.Value;
                test.QuestionCountExam = (int)numericUpDown2.Value;
                test.MinNumber = (int)numericUpDown3.Value;
                test.MaxNumber = (int)numericUpDown4.Value;
                test.Generator = new RandomGenerator(test.MinNumber, test.MaxNumber);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Отмена в настройке
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        // Ок для тренировки
        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                label6.Text = test.CheckAnswerTest(textBox1.Text);
                label6.Refresh();
                Thread.Sleep(1000);
                label6.Text = "";
                textBox1.Text = "";
                textBox1.Focus();

                if (test.State == TestState.Run)
                {
                    label5.Text = test.GetQuestion();
                }

                if (test.State == TestState.Stop)
                {
                    button4_Click(this, null);
                }
            }
        }

        // Завершить тест
        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            test.Stop();
            chart1.Series[0].Points.Clear();
            label5.Text = "";
            label6.Text = test.Result();

            chart1.Visible = true;
            chart1.Series[0].Points.AddY(test.QuestionCount - test.CorrectAnswerCount);
            chart1.Series[0].Points[0].Color = Color.Red;
            chart1.Series[0].Points[0].LegendText = "Неправильные ответы";
            chart1.Series[0].Points.AddY(test.CorrectAnswerCount);
            chart1.Series[0].Points[1].LegendText = "Правильные ответы";
            chart1.Series[0].Points[1].Color = Color.Blue;

            textBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            test.DiscardCountOfQuestions();
        }

        private void экзаменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test.DiscardCountOfQuestions();
            richTextBox2.Visible = false;
            тренировкаToolStripMenuItem.Enabled = false;
            настройкаToolStripMenuItem.Enabled = false;
            помощьToolStripMenuItem.Enabled = false;

            index = 0;
            test.TestTime = 10;
            textBox2.Enabled = true;
            button5.Enabled = true;

            groupBox3.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            textBox2.Text = "";
            richTextBox1.Clear();
            richTextBox1.Visible = false;

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].BackColor = Color.White;
            }

            test.Mode = TestMode.Exam;
            test.Run();
            label9.Text = test.GetQuestion();
        }

        private void тренировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label6.Visible = true;
            chart1.Series[0].Points.Clear();

            textBox1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

            test.Mode = TestMode.Training;
            test.Run();
            label5.Text = test.GetQuestion();
            label6.Text = "";
        }

        private void настройкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            chart1.Visible = false;
            label6.Visible = false;
        }

        // Ок в экзамене
        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length > 0)
            {
                if (test.CheckAnswerExam(textBox2.Text))
                {
                    labels[index].BackColor = Color.Green;
                }
                else
                {
                    labels[index].BackColor = Color.Red;
                }

                if (test.State == TestState.Run)
                {
                    if (index == test.QuestionCountExam - 1)
                    {
                        richTextBox1.Visible = true;
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                        richTextBox1.SelectedText = "Экзамен сдан!";

                        button5.Enabled = false;
                        textBox2.Enabled = false;
                        тренировкаToolStripMenuItem.Enabled = true;
                        настройкаToolStripMenuItem.Enabled = true;
                        помощьToolStripMenuItem.Enabled = true;
                        test.DiscardCountOfQuestions();
                        return;
                    }

                    label9.Text = test.GetQuestion();
                    textBox2.Text = "";
                    textBox2.Focus();
                    index++;
                }
                else if (test.State == TestState.Stop)
                {
                    richTextBox1.Visible = true;
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    richTextBox1.SelectedText = "Экзамен не сдан!";

                    button5.Enabled = false;
                    textBox2.Enabled = false;
                    тренировкаToolStripMenuItem.Enabled = true;
                    настройкаToolStripMenuItem.Enabled = true;
                    помощьToolStripMenuItem.Enabled = true;
                    test.DiscardCountOfQuestions();
                }
            }
        }

        private void поТекущемуВопросуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (test.State == TestState.Run)
            {
                panel1.Visible = true;
                richTextBox2.Visible = true;
                richTextBox2.Text = test.GetCorrectAnswer();
            }

        }

        private void всяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (test.State == TestState.Run)
            {
                panel1.Visible = true;
                richTextBox2.Visible = true;
                richTextBox2.Lines = test.GetHelp().ToArray();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}