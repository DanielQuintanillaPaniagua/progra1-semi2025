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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double[][] tablaActividad = {
                new Double[] {0.01, 500, 1.5, 0},
                new Double[] { 500.01, 1000, 1.5, 3},
                new Double[] { 1000.01, 2000, 3, 3},
                new Double[] { 2000.01, 3000, 6, 3},
                new double[] { 3000.01, 6000, 9, 2},
                new double[] { 8000.01, 18000, 15, 2},
                new double[] { 20000, 30000, 39, 2},
                new double[] { 30000.01, 60000, 63, 1},
                new double[] { 60000.01, 10000, 93, 0.8},
                new double[] { 100000.01, 200000,125,0.7 },
                new double[] { 200000.01, 300000, 165,0.6 },
                new double[] { 300000.01, 400000, 265,0.45 },
                new double[] { 400000.01, 500000, 300,0.4 },
                new double[] { 500000.01, 1000000, 340, 0.30 },
                new double[] { 1000000.01,999999999999999,490,0.18 }
                };



        private double CalcularValor(double monto)
        {
            for (int i = 0; i < tablaActividad.Length; i++)
            {
                double desde = tablaActividad[i][0];
                double hasta = tablaActividad[i][1];
                double adicional = tablaActividad[i][2];
                double fijo = tablaActividad[i][3];

                if (monto > desde && monto < hasta)
                {
                    double valor = ((monto - desde) / 1000) * adicional + fijo;
                    return Math.Round(valor, 2);
                }
            }
            return 0; 
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            {
                double monto = double.Parse(txtactividadEconomica.Text);
                double valor = CalcularValor(monto);
                lblresultado.Text = "El valor a pagar es: " + valor.ToString("N2");

            }
        }
    }
}





      