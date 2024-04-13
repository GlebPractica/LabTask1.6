using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_23
{
    public partial class Form1 : Form
    {
        private SequenceBuilder sequenceBuilder;

        public Form1()
        {
            InitializeComponent();
            sequenceBuilder = new SequenceBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string outputText = sequenceBuilder.BuildSequence() + "\t\t";
            listBox1.Items.Add(outputText);
        }
    }
}
