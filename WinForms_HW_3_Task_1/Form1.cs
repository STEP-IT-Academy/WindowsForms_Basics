using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW_WF_2_T1
{
    public partial class Form1 : Form
    {
        List<Dog> dogs = new List<Dog>();
        BindingList<Dog> bindingList;
        BindingSource source;

        public Form1()
        {
            InitializeComponent();

            bindingList = new BindingList<Dog>(dogs);
            source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            dataGridView1.Font = new Font("Times New Roman", 12);
            dataGridView1.Columns[0].HeaderText = "Кличка";
            dataGridView1.Columns[1].HeaderText = "Владелец";
            dataGridView1.Columns[2].HeaderText = "Высота в холке";

            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.Filter = "Текстовые файлы|*.txt";
            saveFileDialog1.DefaultExt = ".txt";

            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Текстовые файлы|*.txt"; ;
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.FileName = "";

            timer1.Start();
            toolStripStatusLabel1.Text = "Капатков";
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = dogs.Where(d => d.Height > 25).Count().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dogs.Count > 0)
            {
                try
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fstream = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate);
                        using (StreamWriter writer = new StreamWriter(fstream, Encoding.Default))
                        {
                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {
                                writer.WriteLine(dataGridView1[0, i].Value + ";" + dataGridView1[1, i].Value + ";" + dataGridView1[2, i].Value);
                            }
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else MessageBox.Show("Ошибка! Список собак пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dogs.Clear();

                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                    {
                        string[] dataFromFile = null;
                        while (!reader.EndOfStream)
                        {
                            dataFromFile = reader.ReadLine().Split(';');
                            dogs.Add(new Dog(dataFromFile[0], dataFromFile[1], double.Parse(dataFromFile[2])));
                        }
                    }
                }

                bindingList = new BindingList<Dog>(dogs);
                source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            try
            {
                dogs.Add(new Dog(textBox2.Text, textBox3.Text, double.Parse(textBox4.Text)));

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                panel1.Visible = false;

                bindingList = new BindingList<Dog>(dogs);
                source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}