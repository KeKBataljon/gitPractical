﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_Practical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 edwinForm = new Form2();
            edwinForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MDP form = new MDP();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormStian form = new FormStian();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormJustin form = new FormJustin();
            form.Show();
        }
    }
}
