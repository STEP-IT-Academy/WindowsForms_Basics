using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace HW_WF_4
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        static bool flag = true;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "XML|*.xml";
            openFileDialog1.DefaultExt = ".xml";
            openFileDialog1.FileName = "";

            saveFileDialog1.InitialDirectory = Application.StartupPath;

        }

        /// <summary>
        /// Чтение из XML файла в List<Students>
        /// </summary>
        private void ReadFromXMLFile()
        {
            try
            {
                List<int> marks = new List<int>();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(openFileDialog1.FileName);
                XmlNodeList studentsNode = xmlDoc.GetElementsByTagName("Student", xmlDoc.DocumentElement.NamespaceURI);

                foreach (XmlNode node in studentsNode)
                {
                    foreach (XmlElement element in node["Marks"])
                    {
                        marks.Add(int.Parse(element.InnerText));
                    }

                    students.Add(new Student { Name = node["Name"].InnerText, Age = byte.Parse(node["Age"].InnerText), Marks = marks.ToArray() });
                    marks.Clear();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (students.Count > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.Filter = "XML|*.xml";
                saveFileDialog1.DefaultExt = ".xml";

                try
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

                    using (FileStream fstream = File.Create(saveFileDialog1.FileName))
                    {
                        xmlSerializer.Serialize(fstream, students);
                    }

                    MessageBox.Show("Сохранение данных в формате XML завершилось успешно.");
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Нет данных для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (students.Count > 0 && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog1.Filter = "JSON|*.json";
                saveFileDialog1.DefaultExt = ".json";

                try
                {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Student>), 
                        new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true });

                    using (FileStream fstream = File.Create(saveFileDialog1.FileName))
                    {
                        jsonSerializer.WriteObject(fstream, students);
                    }

                    MessageBox.Show("Сохранение данных в формате JSON завершилось успешно.");
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Нет данных для сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                students.Clear();
                ReadFromXMLFile();

                for (int i = 0; i < students.Count; i++)
                {
                    richTextBox1.Text += students[i] + "\n";
                }
            }
        }

        private void проверитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(students.Count > 0)
            {
                try
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.ValidationType = ValidationType.Schema;
                    settings.Schemas.Add("http://tempuri.org/XMLSchemaForStudent.xsd", "XMLSchemaForStudent.xsd");
                    settings.ValidationEventHandler += ValidationCallBack;

                    XmlReader xmlReader = XmlReader.Create(openFileDialog1.FileName, settings);
                    while (xmlReader.Read()) { };

                    if(flag)
                    {
                        MessageBox.Show("Проверка прошла успешно!");  
                    }
                    flag = true;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не загружен файл для  проверки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ValidationCallBack(object sender, ValidationEventArgs eventArgs)
        {
            flag = false;
            if (eventArgs.Severity == XmlSeverityType.Warning || eventArgs.Severity == XmlSeverityType.Error)
                MessageBox.Show("\tВалидация не прошла." + eventArgs.Message);
            else
                MessageBox.Show("\tОшибка валидации: " + eventArgs.Message);
        }
    }
}