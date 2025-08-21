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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
           switch
                (cobObciones.SelectedIndex)
            {
                case 0: // Milimetros a Centimetros
                    richTextBox1.Text = $"{txtCantidad.Text} mm = {Convert.ToDouble(txtCantidad.Text) / 10} cm";
                    break;
               
                default:
                    richTextBox1.Text = "Seleccione una opción válida.";
                    break;
            }
        }
    }
}
