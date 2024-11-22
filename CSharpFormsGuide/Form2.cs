﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSharpFormsGuide
{
    public partial class Form2 : Form
    {
        Form3 f3;
        public Form2(string someText) //added parameter to form initialisation
        {
            InitializeComponent();
            label1.Text = someText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3 = new Form3(); 
            f3.Show();
            f3.FormClosing += F3_FormClosing;
            this.Visible = false;
        }

        private void F3_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Visible = true;
        }
    }
}