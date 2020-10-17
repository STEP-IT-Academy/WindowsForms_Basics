using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HW_WF_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //listView1.Columns[0].TextAlign = HorizontalAlignment.Center;
            richTextBox1.AllowDrop = true;
        }

        private void BuildTreeView(string dir, TreeNode node)
        {
            DateTime startTime = DateTime.Now;
            textBox3.Text = DateTime.Now.ToShortTimeString();

            try
            {
                DirectoryInfo currentDirectory = new DirectoryInfo(dir);
                DirectoryInfo[] directories = currentDirectory.GetDirectories();

                foreach (DirectoryInfo directory in directories)
                {
                    if (dir == textBox1.Text)
                    {
                        progressBar1.Value++;
                    }

                    TreeNode currentNode = new TreeNode(directory.Name, 1, 1);
                    node.Nodes.Add(currentNode);
                    BuildTreeView(directory.FullName, currentNode);
                }

                foreach (FileInfo file in currentDirectory.GetFiles())
                {
                    imageList1.Images.Add(Icon.ExtractAssociatedIcon(file.FullName));
                    imageList2.Images.Add(Icon.ExtractAssociatedIcon(file.FullName));

                    TreeNode currentNode = new TreeNode(file.Name, imageList1.Images.Count - 1, imageList1.Images.Count - 1);
                    node.Nodes.Add(currentNode);
                }

                if (progressBar1.Value == progressBar1.Maximum)
                {
                    textBox3.Text = (DateTime.Now - startTime).ToString();
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;
                progressBar1.Visible = true;
                progressBar2.Visible = false;
                label2.Visible = true;
                textBox3.Visible = true;
                treeView1.Nodes.Clear();
                listView1.Items.Clear();
                richTextBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                while (imageList1.Images.Count != 2 && imageList2.Images.Count != 2)
                {
                    imageList1.Images.RemoveAt(imageList1.Images.Count - 1);
                    imageList2.Images.RemoveAt(imageList2.Images.Count - 1);
                }

                TreeNode rootNode = null;
                string rootDiectory = textBox1.Text;
                progressBar1.Maximum = Directory.GetDirectories(rootDiectory).Length;

                if (textBox1.Text.Length <= 3)
                    rootNode = new TreeNode(rootDiectory, 0, 0);
                else 
                    rootNode = new TreeNode(rootDiectory, 1, 1);

                treeView1.Nodes.Add(rootNode);
                BuildTreeView(rootDiectory, rootNode);
                treeView1.ExpandAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                progressBar1.Visible = false;
                label2.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;

            if (e.Node.Nodes.Count > 0)
            {
                listView1.Items.Clear();
                richTextBox1.Clear();
                textBox2.Clear();

                foreach (TreeNode node in e.Node.Nodes)
                {
                    FileInfo fileInfo = new FileInfo(node.FullPath);
                    listView1.Items.Add(node.Text, node.ImageIndex);
                    listView1.Items[listView1.Items.Count - 1].SubItems.Add(fileInfo.CreationTime.ToShortDateString());
                }
            }
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if(listView1.GetItemAt(e.X, e.Y) != null && e.Button == MouseButtons.Left)
            {
                progressBar2.Visible = false;
                progressBar2.Value = 0;

                foreach (TreeNode item in treeView1.SelectedNode.Nodes)
                {
                    if(item.Text == listView1.GetItemAt(e.X, e.Y).Text)
                    {
                        richTextBox1.DoDragDrop(item, DragDropEffects.Move);
                    }
                }
            }
        }

        private void richTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                progressBar2.Visible = true;
                richTextBox1.Clear();
                textBox2.Clear();
               
                TreeNode node = e.Data.GetData(typeof(TreeNode)) as TreeNode;
                textBox2.Text = node.Text;

                progressBar2.Maximum = File.ReadAllLines(node.FullPath).Length;

                using (StreamReader reader = new StreamReader(node.FullPath))
                {   
                    while(!reader.EndOfStream)
                    {
                        richTextBox1.Text += reader.ReadLine();
                        progressBar2.Value++;
                    }
                }
            }
            catch(Exception exc)
            {
                richTextBox1.Text += exc.Message;
            }
        }
    }
}