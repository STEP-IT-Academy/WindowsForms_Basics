using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_WF_1_ValueCalculations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TimerForm1_1.Start();
            TimerForm1_2.Start();
            Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("До новых встреч!", "Bye-bye", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TimerForm1_2_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("До новых встреч!", "Bye-bye");
            TimerForm1_2.Stop();
            Close();
        }

        private void TimerForm1_1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                textBox3.Text = (Math.Pow(Math.Pow(Math.Sin(x), 2) + 1, 3) - (Math.Sqrt(Math.Abs(y - 3)) / 3.01)).ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
        }
    }
}
