﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button1.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             label1.Font = new Font(label1.Font, FontStyle.Italic );
            button1.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button2.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Underline);
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = Color.Yellow;


        }
    }
}
