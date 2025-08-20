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
    public partial class Form6 : Form
    {
        public object Case { get; private set; }

        public Form6()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            switch
                (cobObciones.SelectedIndex)
            {
                case 0: //dias a horas
                    richTextBox1.Text = $"{txtCantidad.Text} días son {Convert.ToDouble(txtCantidad.Text) * 24} horas.";
                    break;
                case 1: // dias a minutos
                    richTextBox1.Text = $"{txtCantidad.Text} días son {Convert.ToDouble(txtCantidad.Text) * 1440} minutos.";
                    break;
                case 2: // dias a segundos
                    richTextBox1.Text = $"{txtCantidad.Text} días son {Convert.ToDouble(txtCantidad.Text) * 86400} segundos.";
                    break;
                default:
                    richTextBox1.Text = "Seleccione una opción válida.";
                    break;
            }
        }
    }
}






