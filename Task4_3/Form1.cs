using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_3
{
    public partial class Form1 : Form
    {
        private StringGenerator generator;

        public Form1()
        {
            InitializeComponent();
            generator = new StringGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


            int N = (int)numericUpDown1.Value;
            char C1 = textBox2.Text[0];
            char C2 = textBox3.Text[0];

            listBox1.Items.Add($"Результат при N = {N}; C1 = {C1}; C2 = {C2}.");
            listBox1.Items.Add($">>>{generator.GenerateAlternatingString(N, C1, C2)}");
        }
    }
}
