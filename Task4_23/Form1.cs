using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_23
{
    public partial class Form1 : Form
    {
        private FileNameExtractor _extractor;

        public Form1()
        {
            InitializeComponent();
            _extractor = new FileNameExtractor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add("Вы ничего не ввели");
                return;
            }

            string result = _extractor.ExtractFileNameWithExtension(textBox1.Text);

            if (result == "Nothing")
            {
                listBox1.Items.Add("Не удалось считать полное имя файла. Повторите попытку");
                return;
            }
            else
            {
                listBox1.Items.Add($"Результат: {result}");
            }
        }
    }
}
