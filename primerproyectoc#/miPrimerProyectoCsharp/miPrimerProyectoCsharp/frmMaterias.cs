using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyectoCsharp
{
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }
        Conexion objCOnexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void ActualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["Materia"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["IdMateria"] };

            grdMaterias.DataSource = objDt.DefaultView;
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idMaterias.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigoMaterias.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreMateria.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUVMaterias.Text = objDt.Rows[posicion]["uv"].ToString();


                lblnRegistrosMateria.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }


        private void frmMaterias_Load(object sender, EventArgs e)
        {
            ActualizarDs();
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            MostrarDatos();
        }
        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosMateria.Enabled = estado;
            grbNavegacionMateria.Enabled = !estado;
            btnEliminarMateria.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idMaterias.Text = "";
            txtCodigoMaterias.Text = "";
            txtNombreMateria.Text = "";
            txtUVMaterias.Text = "";

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }

        }

        private void btnModificarMateria_Click(object sender, EventArgs e)
        {
            if (btnModificarMateria.Text == "Modificar")
            {
                btnAgregarMateria.Text = "Guardar";
                btnModificarMateria.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                MostrarDatos();
                estadoControles(false);
                btnAgregarMateria.Text = "Nuevo";
                btnModificarMateria.Text = "Modificar";
            }
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreMateria.Text,
                "Eliminando Materia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objCOnexion.administrarDatosAlumnos(
                    new String[] { idMaterias.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar Materia.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    ActualizarDs();
                }
            }
        }


        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '" + valor + "%'";
                grdMaterias.DataSource = objDv;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void txtBuscarAlumnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                try
                {
                    filtrarDatos(txtBuscarMateria.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void seleccionarDocentes()
        {
            try
            {
                if (grdMaterias.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdMaterias.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                MostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocentes();

        }
    }
}






