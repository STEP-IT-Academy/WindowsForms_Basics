using System.Windows.Forms;

namespace HW_WF_3_T2
{
    public partial class ResultForm : Form
    {
        public ResultForm(double[,] source, double[,] result)
        {
            InitializeComponent();

            dataGridView1.RowCount = source.GetLength(0);
            dataGridView2.RowCount = result.GetLength(0);
            dataGridView1.ColumnCount = source.GetLength(1);
            dataGridView2.ColumnCount = result.GetLength(1);

            for (int i = 0; i < source.GetLength(0); i++)
            {
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = source[i, j];
                    dataGridView2.Rows[i].Cells[j].Value = result[i, j];
                }
            }
        }
    }
}