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

namespace miPrimerProyectoCsharp
{
    public partial class frm_docentes : Form
    {
        public frm_docentes()
        {
            InitializeComponent();
        }
        Conexion objCOnexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objCOnexion.obtenerDatos();
            objDt = objDs.Tables["docentes"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocentes"] };

            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();

        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocentes.Text = objDt.Rows[posicion]["idDocentes"].ToString();
                txtCodigoDocentes.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombreDocentes.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccionDocentes.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtTelefonoDocentes.Text = objDt.Rows[posicion]["telefono"].ToString();
                txtMateriaDocentes.Text = objDt.Rows[posicion]["materia"].ToString();

                lblnRegistrosDocentes.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }

        private void frm_docentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteDocentes_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocentes_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocentes_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }


        private void btnPrimeroDocentes_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosDocentes.Enabled = estado;
            grbNavegacionDocentes.Enabled = !estado;
            btnEliminarDocentes.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idDocentes.Text = "";
            txtCodigoDocentes.Text = "";
            txtNombreDocentes.Text = "";
            txtDireccionDocentes.Text = "";
            txtTelefonoDocentes.Text = "";
            txtMateriaDocentes.Text = "";
        }

        private void btnAgregarDocentes_Click(object sender, EventArgs e)
        {
            if (btnAgregarDocentes.Text == "Nuevo")
            {
                btnAgregarDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] Docentes = {
                    idDocentes.Text, txtCodigoDocentes.Text, txtNombreDocentes.Text, txtDireccionDocentes.Text,
                    txtTelefonoDocentes.Text, txtMateriaDocentes.Text
                };
                String respuesta = objCOnexion.administrarDatosDocentes(Docentes, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnAgregarDocentes.Text = "Nuevo";
                    btnModificarDocentes.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnModificarDocentes_Click(object sender, EventArgs e)
        {
            if (btnModificarDocentes.Text == "Modificar")
            {
                btnAgregarDocentes.Text = "Guardar";
                btnModificarDocentes.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnAgregarDocentes.Text = "Nuevo";
                btnModificarDocentes.Text = "Modificar";
            }
        }

        private void btnEliminarDocentes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocentes.Text,
                "Eliminando alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objCOnexion.administrarDatosAlumnos(
                    new String[] { idDocentes.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }
        
        
        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '" + valor + "%'";
                grdDocentes.DataSource = objDv;
                seleccionarDocentes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void txtBuscarDocentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarDocentes.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void seleccionarDocentes()
        {
            try
            {
                if (grdDocentes.CurrentRow == null)
                {
                    MessageBox.Show("No hay filas");
                    return;
                }
                string id = grdDocentes.CurrentRow.Cells["id"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocentes();

        }
    }
}












