using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parceal_ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        
            String[][] etiquetas = new string[][] {

             new string[]{"Pie Cuadrado", "Varda Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas","Manzana","Hectárea" }
        };
        double[][] valores = new double[][] {
           new double []{0.8359, 0.8361, 0.0929, 1,1000, 6988, 10000 }


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
    }
}
