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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            switch
                (cobObciones.SelectedIndex)
            {
                case 0: // Kilometros a hectometros
                    if (double.TryParse(txtCantidad.Text, out double kmToHectometers))
                    {
                        double hectometros = kmToHectometers * 10;
                        richTextBox1.Text = $"{kmToHectometers} Kilometros son {hectometros} Hectómetros.";
                    }
                   break;
                case 1: // kilometros a decametros
                    if (double.TryParse(txtCantidad.Text, out double kmToDecameters))
                    {
                        double decametros = kmToDecameters * 10000;
                        richTextBox1.Text = $"{kmToDecameters} Kilometros son {decametros} Decámetros.";
                    }
                    break;
                    case 2:  // kilometros a metros
                        if (double.TryParse(txtCantidad.Text, out double kmToMeters))
                    {
                        double metros = kmToMeters * 1000;
                        richTextBox1.Text = $"{kmToMeters} Kilometros son {metros} Metros.";
                    }
                        break;
                    case 3: // kilometros a centimetros
                        if (double.TryParse(txtCantidad.Text, out double kmToCentimeters))
                    {
                        double centimetros = kmToCentimeters * 100000;
                        richTextBox1.Text = $"{kmToCentimeters} Kilometros son {centimetros} Centímetros.";
                    }
                        break;
                    case 4: // kilometros a milimetros
                        if (double.TryParse(txtCantidad.Text, out double kmToMillimeters))
                    {
                        double milimetros = kmToMillimeters * 1000000;
                        richTextBox1.Text = $"{kmToMillimeters} Kilometros son {milimetros} Milímetros.";
                    }
                        break;

                default:
                    MessageBox.Show("Seleccione una opción válida.");
                    break;
            }
        }
    }
}
