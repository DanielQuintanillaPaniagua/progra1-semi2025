using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String[][] etiquetas = new string[][] {

             new string[]{"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas","Manzana","Hectárea" }
        };
        double[][] valores = new double[][] {
           new double []{0.092903,0,705012 ,0.836127, 1e-6,437.5,10000}


        };
        private double convertir(int tipo, int de, int a, double cantidad)
        {
            if (cantidad <= 0)
            {
                return 0;
            }
            return cantidad * valores[tipo][a] / valores[tipo][de];
        }
        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);

                int tipo = cboTipo.SelectedIndex;
                int de = cboDe.SelectedIndex;
                int a = cboA.SelectedIndex;
                double respuesta = convertir(tipo, de, a, cantidad);


                lblRespuesta.Text = "RESPUESTA: " + respuesta.ToString("N2");
            }
            catch (Exception er)
            {
                lblRespuesta.Text = "Error " + er.Message + " solo valores validos";
            }
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();
            cboDe.Items.AddRange(etiquetas[cboTipo.SelectedIndex]);
            cboA.Items.AddRange(etiquetas[cboTipo.SelectedIndex]);

        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {

        }
    }
}