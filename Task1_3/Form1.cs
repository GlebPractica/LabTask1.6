using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_3
{
    public partial class Form1 : Form
    {
        private SentenceCounter counter;

        public Form1()
        {
            InitializeComponent();
            counter = new SentenceCounter();
        }

        private void BttnCountSen_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите строку с предложениями!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int sentenceCount = counter.CountSentences(input);

            listBox1.Items.Add($"Количество предложений: {sentenceCount}");
        }
    }
}
