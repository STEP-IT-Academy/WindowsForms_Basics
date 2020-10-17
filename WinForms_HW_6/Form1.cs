using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HW_WF_6
{
    public partial class Form1 : Form
    {
        // Шаг изменений аргумента
        double xStep;

        // Начальное значение аргумента
        double xBegin;

        // Конечное значение аргумента
        double xEnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetSourceData()
        {
            try
            {
                xBegin = Convert.ToDouble(textBox1.Text);
                xEnd = Convert.ToDouble(textBox2.Text);
                xStep = Convert.ToDouble(textBox3.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_SinX()
        {
            try
            {
                GetSourceData();

                for (double x = xBegin; x < xEnd; x += xStep)
                {
                    double y = Math.Sin(x);
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Get_2CosX()
        {
            try
            {
                GetSourceData();

                for (double x = xBegin; x < xEnd; x += xStep)
                {
                    double y = 2 * Math.Cos(x);
                    chart1.Series[1].Points.AddXY(x, y);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBox1.Checked && !checkBox2.Checked)
                {
                    MessageBox.Show("Не выбран вариант построения функции", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                
                if(chart1.ChartAreas.Count > 1)
                {
                    chart1.ChartAreas.Clear();
                    ChartArea chartArea1 = new ChartArea("ChartArea1");
                    chart1.ChartAreas.Add(chartArea1);

                    chart1.Series[0].ChartArea = chart1.ChartAreas[0].Name;
                    chart1.Series[1].ChartArea = chart1.ChartAreas[0].Name;
                }

                if (checkBox1.Checked)
                {
                    Get_SinX();
                }

                if(checkBox2.Checked)
                {
                    Get_2CosX();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Не выбран вариант построения функции", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            if (chart1.ChartAreas.Count < 2)
            {
                ChartArea chartArea2 = new ChartArea("ChartArea2");
                chart1.ChartAreas.Add(chartArea2);
                chart1.Series[0].ChartArea = chart1.ChartAreas[1].Name;
            }

            if (checkBox1.Checked)
            {
                Get_SinX();
            }

            if (checkBox2.Checked)
            {
                Get_2CosX();
            }
        }
    }
}
