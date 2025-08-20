using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convertidor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cobObciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            switch (cobObciones.SelectedIndex)
            {
                case 0: // Kilogramos a gramos
                    if (double.TryParse(txtCantidad.Text, out double cantidadKg))
                    {
                        double resultado = cantidadKg * 1000;
                        richTextBox1.Text = $"{cantidadKg} Kilogramos son {resultado} Gramos";
                    }
                    break;
                case 1: //kilogramos a miligramos
                    if (double.TryParse(txtCantidad.Text, out double cantidadKg2))
                    {
                        double resultado = cantidadKg2 * 1000000;
                        richTextBox1.Text = $"{cantidadKg2} Kilogramos son {resultado} Miligramos";
                    }
                    break;
                    case 2: // kilogramos a libras
                    if (double.TryParse(txtCantidad.Text, out double cantidadKg3))
                    {
                        double resultado = cantidadKg3 * 2.20462;
                        richTextBox1.Text = $"{cantidadKg3} Kilogramos son {resultado} Libras";
                    }
                    break;
                default:
                    MessageBox.Show("Seleccione una opción válida.");
                    break;



            }
        }

        private void lblMasaTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

