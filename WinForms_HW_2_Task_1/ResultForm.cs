using System.Windows.Forms;

namespace HW_WF_2
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        public ResultForm(SingleArray sourceArray, string action, int actionResult)
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = sourceArray.Lenght;

            for (int i = 0; i < sourceArray.Lenght; i++)
            {
                dataGridView1[0, i].Value = sourceArray[i];
            }

            label1.Text = action;
            textBox1.Text = actionResult.ToString();
        }
    }
}
