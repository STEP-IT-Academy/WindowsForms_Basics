using System;
using System.Windows.Forms;

namespace HW_WF_3_T2
{
    public partial class Form1 : Form
    {
        double[,] matrix;
        ResultForm resultForm;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = (int)numericUpDown2.Value;
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int countOfPosValues = 0;
            matrix = new double[dataGridView1.RowCount, dataGridView1.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        dataGridView1.Rows[i].Cells[j].ToolTipText = "Элемент матрицы";

                        if (matrix[i, j] >= 0) 
                            countOfPosValues++;
                    }
                    catch(Exception)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            if (!checkBox1.Checked)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if((double)dataGridView1.Rows[i].Cells[j].Value < 0)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = countOfPosValues;
                        }
                    }
                }
            }
            else if(checkBox1.Checked)
            {
                resultForm = new ResultForm(matrix, ChangeNegValuesOnPosCount(matrix, countOfPosValues));
                resultForm.ShowDialog();
            }
        }

        private double[,] ChangeNegValuesOnPosCount(double[,] sourceMatrix, int countOfPosValue)
        {
            double[,] tmpMatrix = new double[sourceMatrix.GetLength(0), sourceMatrix.GetLength(1)];
            for (int i = 0; i < sourceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sourceMatrix.GetLength(1); j++)
                {
                    tmpMatrix[i, j] = sourceMatrix[i, j];

                    if (tmpMatrix[i, j] < 0)
                        tmpMatrix[i, j] = countOfPosValue;
                }
            }

            return tmpMatrix;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown2.Value;
        }
    }
}