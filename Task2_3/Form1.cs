using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_3
{
    public partial class Form1 : Form
    {
        private StringModifier stringModifier;

        public Form1()
        {
            InitializeComponent();
            stringModifier = new StringModifier();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add("Вы не ввели строку. Повторите попытку");
                return;
            }
            
            listBox1.Items.Add($"Результат: {stringModifier.RemoveFirstAndLastOccurrence(textBox1.Text, textBox2.Text.ToCharArray()[0])}");
        }
    }
}
