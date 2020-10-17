using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_WF_Matrix
{
    public partial class Form1 : Form
    {
        int[,] matrix = new int[0, 0];
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;
        }

        private void MatrixInit()
        {
            matrix = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    }
                    catch(Exception)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatrixInit();

            int minRow = 0;
            int minCol = 0;
            int maxRow = 0;
            int maxCol = 0;
            int min = matrix[0, 0];
            int max = matrix[0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                        minRow = i; minCol = j;
                    }

                    if(matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        maxRow = i; maxCol = j;
                    }
                }
            }

            if (radioButton1.Checked)
            {
                dataGridView1.Rows[minRow].Cells[minCol].Style.BackColor = Color.White;
                dataGridView1.Rows[maxRow].Cells[maxCol].Style.BackColor = Color.LightGreen;
            }
            else if(radioButton2.Checked)
            {
                dataGridView1.Rows[maxRow].Cells[maxCol].Style.BackColor = Color.White;
                dataGridView1.Rows[minRow].Cells[minCol].Style.BackColor = Color.LightGreen;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown2.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            if(matrix.Length != 0)
            {
                ListBox1Init();
            }
            else if(matrix.Length == 0)
            {
                MatrixInit();
                ListBox1Init();
            }
            
        }

        private void ListBox1Init()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= 0)
                    {
                        if (!listBox1.Items.Contains(matrix[i, j]))
                            listBox1.Items.Add(matrix[i, j]);
                    }
                }
            }
        }
    }
}