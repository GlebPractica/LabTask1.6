﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3_3
{
    public partial class Form1 : Form
    {
        private WordCounter wordCounter;

        public Form1()
        {
            InitializeComponent();
            wordCounter = new WordCounter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Add("Вы не ввели строку. Повторите попытку");
                return;
            }
            
            listBox1.Items.Add($"Результат: {wordCounter.CountWords(textBox1.Text)}");
        }
    }
}