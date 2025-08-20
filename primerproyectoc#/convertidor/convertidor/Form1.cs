using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertidor
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

        private void lblMonedaTitulo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblMonedaTitulo_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void masaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();

            }

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            switch (cobObciones.SelectedIndex)
            {
                case 0: // dolar a euro
                    if (double.TryParse(txtCantidad.Text, out double cantidad))
                    {
                        double resultado = cantidad * 0.85;
                        richTextBox1.Text = $"{cantidad} Dólares son {resultado} Euros.";
                    }
                    break;

                case 1: // dolar a peso mexicano
                    if (double.TryParse(txtCantidad.Text, out double cantidad2))
                    {
                        double resultado2 = cantidad2 * 18.74;
                        richTextBox1.Text = $"{cantidad2} Dólares son {resultado2} Pesos Mexicanos.";
                    }
                    break;
                    case 2: // dolar a peso argentino
                    if (double.TryParse(txtCantidad.Text, out double cantidad3))
                    {
                        double resultado3 = cantidad3 * 1298.46;
                        richTextBox1.Text = $"{cantidad3} Dólares son {resultado3} Pesos Argentinos.";
                    }
                    break;
                    case 3:
                    // dolar a dolar canadiense
                    if (double.TryParse(txtCantidad.Text, out double cantidad4))
                    {
                        double resultado4 = cantidad4 * 1.38;
                        richTextBox1.Text = $"{cantidad4} Dólares son {resultado4} Dólares Canadienses.";
                    }
                    break;
                    case 4: // dolar a libra esterlina
                    if (double.TryParse(txtCantidad.Text, out double cantidad5))
                    {
                        double resultado5 = cantidad5 * 0.74;
                        richTextBox1.Text = $"{cantidad5} Dólares son {resultado5} Libras Esterlinas.";
                    }
                    break;
                default:
                    MessageBox.Show("Seleccione una opción válida.");
                    break;



            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void volumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.ShowDialog();
            }
        }

        private void cobObciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {
                form4.ShowDialog();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void almacenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form5 form5 = new Form5())
            {
                form5.ShowDialog();
            }
        }

        private void tiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form6 form6 = new Form6())
            {
                form6.ShowDialog();
            }
        }
    }
}

