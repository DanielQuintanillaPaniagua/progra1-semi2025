﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, mun2, resultado;
            num1 = double.Parse( txtNum1.Text);
            mun2 = double.Parse(txtNum2.Text);
            resultado = num1 + mun2;
            lblRespuesta.Text = "El resultado es: " + resultado.ToString();


        }
    }
}