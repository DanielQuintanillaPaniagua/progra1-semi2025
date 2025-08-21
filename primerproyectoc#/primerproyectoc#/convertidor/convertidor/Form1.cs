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


        private void masaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {
                form2.ShowDialog();

            }

        }


        private void volumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.ShowDialog();
            }
        }



        private void longitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {
                form4.ShowDialog();
            }
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

        Dictionary<string, double> tasas = new Dictionary<string, double>()
{
    {"Dólar", 1},
    {"Euro", 0.85},
    {"Peso Mexicano", 18.74},
    {"Peso Argentino", 1298.46},
    {"Dólar Canadiense", 1.38},
    {"Libra Esterlina", 0.74},
    {"Franco Suizo", 0.92},
    {"Yen Japonés", 148.56},
    {"Yuan Chino", 6.88},
    {"Real Brasileño", 4.91}
};
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtCantidad.Text, out double cantidad))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            string origen = cobOrigen.SelectedItem?.ToString();
            string destino = cobDestino.SelectedItem?.ToString();

            if (origen == null || destino == null)
            {
                MessageBox.Show("Seleccione ambas monedas.");
                return;
            }

            
            double cantidadEnDolar = cantidad / tasas[origen];
            double resultado = cantidadEnDolar * tasas[destino];

            richTextBox1.Text = $"{cantidad} {origen} son {resultado:F2} {destino}.";
        }
    }
}

