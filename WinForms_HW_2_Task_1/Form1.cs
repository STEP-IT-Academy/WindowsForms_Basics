using System;
using System.Windows.Forms;

namespace HW_WF_2
{
    public partial class Form1 : Form
    {
        SingleArray array;
        ResultForm resultForm;
        AboutAuthor aboutAuthor;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 1;
            comboBox1.DataSource = new string[] { "Сумма", "Произведение" };
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            array = new SingleArray(dataGridView1.ColumnCount);
            for (int i = 0; i < array.Lenght; i++)
            {
                try
                {
                    array[i] = Convert.ToInt32(dataGridView1[i, 0].Value);
                }
                catch(Exception)
                {
                    dataGridView1[i, 0].Value = 0;
                }
                dataGridView1[i, 0].Value = array[i];
            }

            if(comboBox1.SelectedIndex == 0)
            {
                resultForm = new ResultForm(array, comboBox1.Text + " =", array.SumOfArrayElem());
                resultForm.ShowDialog();
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                resultForm = new ResultForm(array, comboBox1.Text + " =", array.MultiplicationOfArrayElem());
                resultForm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutAuthor = new AboutAuthor();
            aboutAuthor.ShowDialog();
        }
    }
}
