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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            switch (cobObciones.SelectedIndex)
            {
                case 0: // Gigabyte a megabyte
                    double gigabytes = Convert.ToDouble(txtCantidad.Text);
                    double megabytes = gigabytes * 1024;
                    richTextBox1.Text = $"{gigabytes} GB son {megabytes} MB";
                    break;
                case 1: // Gigabyte a kilobyte
                    double gigabytesKB = Convert.ToDouble(txtCantidad.Text);
                    double kilobytes = gigabytesKB * 1024 * 1024;
                    richTextBox1.Text = $"{gigabytesKB} GB son {kilobytes} KB";
                    break;
                case 2: // Gigabyte a byte
                    double gigabytesBytes = Convert.ToDouble(txtCantidad.Text);
                    double bytes = gigabytesBytes * 1024 * 1024 * 1024;
                    richTextBox1.Text = $"{gigabytesBytes} GB son {bytes} Bytes";
                    break;
                default:
                    MessageBox.Show("Seleccione una opción válida.");
                    break;
            }
        }
    }
}



