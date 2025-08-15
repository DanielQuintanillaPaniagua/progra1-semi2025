using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calucladora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Suma
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int resultado = num1 + num2;
                labelResultado.Text = "Resultado: " + resultado.ToString();
            }
            else if (radioButton2.Checked)
            {
                // Resta
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int resultado = num1 - num2;
                labelResultado.Text = "Resultado: " + resultado.ToString();
            }
            else if (radioButton3.Checked)
            {
                // Multiplicación
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int resultado = num1 * num2;
                labelResultado.Text = "Resultado: " + resultado.ToString();
            }
            else if (radioButton4.Checked)
            {
                // División
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                if (num2 != 0)
                {
                    double resultado = num1 / num2;
                    labelResultado.Text = "Resultado: " + resultado.ToString();
                }
                else
                {
                    labelResultado.Text = "Error: División por cero";
                }
            }
        }
    }
}
