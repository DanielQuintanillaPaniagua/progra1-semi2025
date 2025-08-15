using System;
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
            num1 = double.Parse(txtNum1.Text);
            mun2 = double.Parse(txtNum2.Text);
            resultado = num1 + mun2;
            lblRespuesta.Text = "El resultado es: " + resultado.ToString();
            if (optSuma.Checked)
            {
                resultado = num1 + mun2;
                if (optResta.Checked)
                {
                    resultado = num1 - mun2;
                    if (optMultiplicacion.Checked)
                    {
                        resultado = num1 * mun2;
                        if (optDivicion.Checked)
                        {
                            resultado = num1 * mun2;
                            if (optExponente.Checked)
                            {
                                resultado = Math.Pow(num1, mun2);
                                if (optProcentaje.Checked)
                                {
                                    resultado = (num1 * num1) / 100;
                                    if (optFactorial.Checked)
                                    {
                                        resultado = 1;
                                        for (int i = 1; i <= num1; i++)
                                        {
                                            resultado *= i;
                                            if (optModulo.Checked)
                                            {
                                                resultado = num1 % mun2;
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }


                }
            }
        }
        private void grbOpociones_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            switch (cboOpciones.SelectedIndex)
            {
                case 0:
                    resultado = num1 + num2;
                    break;
                case 1:
                    resultado = num1 - num2;
                    break;
                case 2:
                    resultado = num1 * num2;
                    break;
                case 3:
                    resultado = num1 / num2;
                    break;
                case 4:
                    int i = 1, acum = 0;
                    while (i <= num1 && acum < 3)
                    {
                        if (num1 % i == 0)
                        {
                            acum++;
                        }
                        i++;
                    }
                    if (acum == 2)
                    {
                        lblRespuesta.Text = "El numero es primo";
                    }
                    else
                    {
                        lblRespuesta.Text = "El numero no es primo";
                    }
                    break;
            }
        }
    }
}