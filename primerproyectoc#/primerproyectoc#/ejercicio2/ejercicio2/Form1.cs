using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double[][] tabla = {
            new double[] {0, 472, 0, 0},
            new double[] {472.01, 895.24, 0.10, 17.67},
            new double[] {895.25, 2038.10, 0.20, 60},
            new double[] {2038.11, 9999999, 0.30, 288.57}
        };

        
        private double calcularDeducciones(double sueldo, double porcentaje)
        {
            return sueldo * porcentaje;
        }

        
        private double calcularISR(double sueldo)
        {
            double isr = 0;
            for (int i = 0; i < tabla.Length; i++)
            {
                if (sueldo >= tabla[i][0] && sueldo <= tabla[i][1])
                {
                    isr = (sueldo - tabla[i][0]) * tabla[i][2] + tabla[i][3];
                    break;
                }
            }
            return isr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo = 0, afp = 0, isss = 0, isr = 0, sueldoNeto = 0;

            
            

            
            isss = calcularDeducciones(sueldo, 0.03);
            afp = calcularDeducciones(sueldo, 0.0725);
            isr = calcularISR(sueldo - isss - afp);

            
            sueldoNeto = sueldo - (isss + afp + isr);

            
            lblISSS.Text = "ISSS: " + isss.ToString("C");
            lblAFP.Text = "AFP: " + afp.ToString("C");
            lblIsr.Text = "ISR: " + isr.ToString("C");
            lblTotaldeduciones.Text = "Total deducciones: " + (isss + afp + isr).ToString("C");
            lblSueldoneto.Text = "Sueldo neto: " + sueldoNeto.ToString("C");
        }
    }
}