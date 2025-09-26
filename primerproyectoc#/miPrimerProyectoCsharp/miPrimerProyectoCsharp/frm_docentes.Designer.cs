namespace miPrimerProyectoCsharp
{
    partial class frm_docentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbEdicionDocentes = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocentes = new System.Windows.Forms.Button();
            this.btnAgregarDocentes = new System.Windows.Forms.Button();
            this.grbDatosDocentes = new System.Windows.Forms.GroupBox();
            this.txtMateriaDocentes = new System.Windows.Forms.TextBox();
            this.lblMateriaDocentes = new System.Windows.Forms.Label();
            this.idDocentes = new System.Windows.Forms.Label();
            this.lblTelefonoDocentes = new System.Windows.Forms.Label();
            this.txtTelefonoDocentes = new System.Windows.Forms.TextBox();
            this.lblDireccionDocentes = new System.Windows.Forms.Label();
            this.txtDireccionDocentes = new System.Windows.Forms.TextBox();
            this.lblNombreDocentes = new System.Windows.Forms.Label();
            this.txtNombreDocentes = new System.Windows.Forms.TextBox();
            this.lblCodigoDocentes = new System.Windows.Forms.Label();
            this.txtCodigoDocentes = new System.Windows.Forms.TextBox();
            this.lblIdDocentes = new System.Windows.Forms.Label();
            this.grbBusquedaDocentes = new System.Windows.Forms.GroupBox();
            this.grdDocentes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarDocentes = new System.Windows.Forms.TextBox();
            this.grbNavegacionDocentes = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosDocentes = new System.Windows.Forms.Label();
            this.btnUltimoDocentes = new System.Windows.Forms.Button();
            this.btnSiguienteDocentes = new System.Windows.Forms.Button();
            this.btnAnteriorDocentes = new System.Windows.Forms.Button();
            this.btnPrimeroDocentes = new System.Windows.Forms.Button();
            this.grbEdicionDocentes.SuspendLayout();
            this.grbDatosDocentes.SuspendLayout();
            this.grbBusquedaDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).BeginInit();
            this.grbNavegacionDocentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicionDocentes
            // 
            this.grbEdicionDocentes.Controls.Add(this.btnEliminarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnModificarDocentes);
            this.grbEdicionDocentes.Controls.Add(this.btnAgregarDocentes);
            this.grbEdicionDocentes.Location = new System.Drawing.Point(496, 368);
            this.grbEdicionDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocentes.Name = "grbEdicionDocentes";
            this.grbEdicionDocentes.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionDocentes.Size = new System.Drawing.Size(457, 69);
            this.grbEdicionDocentes.TabIndex = 6;
            this.grbEdicionDocentes.TabStop = false;
            this.grbEdicionDocentes.Text = "Edicion";
            // 
            // btnEliminarDocentes
            // 
            this.btnEliminarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDocentes.Location = new System.Drawing.Point(275, 18);
            this.btnEliminarDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarDocentes.Name = "btnEliminarDocentes";
            this.btnEliminarDocentes.Size = new System.Drawing.Size(133, 46);
            this.btnEliminarDocentes.TabIndex = 3;
            this.btnEliminarDocentes.Text = "Eliminar";
            this.btnEliminarDocentes.UseVisualStyleBackColor = true;
            this.btnEliminarDocentes.Click += new System.EventHandler(this.btnEliminarDocentes_Click);
            // 
            // btnModificarDocentes
            // 
            this.btnModificarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDocentes.Location = new System.Drawing.Point(135, 17);
            this.btnModificarDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarDocentes.Name = "btnModificarDocentes";
            this.btnModificarDocentes.Size = new System.Drawing.Size(140, 46);
            this.btnModificarDocentes.TabIndex = 1;
            this.btnModificarDocentes.Text = "Modificar";
            this.btnModificarDocentes.UseVisualStyleBackColor = true;
            this.btnModificarDocentes.Click += new System.EventHandler(this.btnModificarDocentes_Click);
            // 
            // btnAgregarDocentes
            // 
            this.btnAgregarDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDocentes.Location = new System.Drawing.Point(8, 18);
            this.btnAgregarDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarDocentes.Name = "btnAgregarDocentes";
            this.btnAgregarDocentes.Size = new System.Drawing.Size(125, 46);
            this.btnAgregarDocentes.TabIndex = 0;
            this.btnAgregarDocentes.Text = "Nuevo";
            this.btnAgregarDocentes.UseVisualStyleBackColor = true;
            this.btnAgregarDocentes.Click += new System.EventHandler(this.btnAgregarDocentes_Click);
            // 
            // grbDatosDocentes
            // 
            this.grbDatosDocentes.Controls.Add(this.txtMateriaDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblMateriaDocentes);
            this.grbDatosDocentes.Controls.Add(this.idDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtTelefonoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtDireccionDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtNombreDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblCodigoDocentes);
            this.grbDatosDocentes.Controls.Add(this.txtCodigoDocentes);
            this.grbDatosDocentes.Controls.Add(this.lblIdDocentes);
            this.grbDatosDocentes.Enabled = false;
            this.grbDatosDocentes.Location = new System.Drawing.Point(4, 10);
            this.grbDatosDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosDocentes.Name = "grbDatosDocentes";
            this.grbDatosDocentes.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosDocentes.Size = new System.Drawing.Size(461, 338);
            this.grbDatosDocentes.TabIndex = 8;
            this.grbDatosDocentes.TabStop = false;
            this.grbDatosDocentes.Text = "DATOS";
            // 
            // txtMateriaDocentes
            // 
            this.txtMateriaDocentes.Location = new System.Drawing.Point(119, 297);
            this.txtMateriaDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateriaDocentes.Name = "txtMateriaDocentes";
            this.txtMateriaDocentes.Size = new System.Drawing.Size(132, 22);
            this.txtMateriaDocentes.TabIndex = 11;
            // 
            // lblMateriaDocentes
            // 
            this.lblMateriaDocentes.AutoSize = true;
            this.lblMateriaDocentes.Location = new System.Drawing.Point(59, 297);
            this.lblMateriaDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriaDocentes.Name = "lblMateriaDocentes";
            this.lblMateriaDocentes.Size = new System.Drawing.Size(52, 16);
            this.lblMateriaDocentes.TabIndex = 10;
            this.lblMateriaDocentes.Text = "Materia";
            // 
            // idDocentes
            // 
            this.idDocentes.AutoSize = true;
            this.idDocentes.Location = new System.Drawing.Point(107, 47);
            this.idDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idDocentes.Name = "idDocentes";
            this.idDocentes.Size = new System.Drawing.Size(44, 16);
            this.idDocentes.TabIndex = 9;
            this.idDocentes.Text = "label1";
            // 
            // lblTelefonoDocentes
            // 
            this.lblTelefonoDocentes.AutoSize = true;
            this.lblTelefonoDocentes.Location = new System.Drawing.Point(59, 252);
            this.lblTelefonoDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoDocentes.Name = "lblTelefonoDocentes";
            this.lblTelefonoDocentes.Size = new System.Drawing.Size(35, 16);
            this.lblTelefonoDocentes.TabIndex = 8;
            this.lblTelefonoDocentes.Text = "TEL:";
            // 
            // txtTelefonoDocentes
            // 
            this.txtTelefonoDocentes.Location = new System.Drawing.Point(107, 247);
            this.txtTelefonoDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoDocentes.Name = "txtTelefonoDocentes";
            this.txtTelefonoDocentes.Size = new System.Drawing.Size(132, 22);
            this.txtTelefonoDocentes.TabIndex = 7;
            // 
            // lblDireccionDocentes
            // 
            this.lblDireccionDocentes.AutoSize = true;
            this.lblDireccionDocentes.Location = new System.Drawing.Point(7, 193);
            this.lblDireccionDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionDocentes.Name = "lblDireccionDocentes";
            this.lblDireccionDocentes.Size = new System.Drawing.Size(83, 16);
            this.lblDireccionDocentes.TabIndex = 6;
            this.lblDireccionDocentes.Text = "DIRECCION:";
            // 
            // txtDireccionDocentes
            // 
            this.txtDireccionDocentes.Location = new System.Drawing.Point(107, 188);
            this.txtDireccionDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionDocentes.Name = "txtDireccionDocentes";
            this.txtDireccionDocentes.Size = new System.Drawing.Size(347, 22);
            this.txtDireccionDocentes.TabIndex = 5;
            // 
            // lblNombreDocentes
            // 
            this.lblNombreDocentes.AutoSize = true;
            this.lblNombreDocentes.Location = new System.Drawing.Point(23, 137);
            this.lblNombreDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDocentes.Name = "lblNombreDocentes";
            this.lblNombreDocentes.Size = new System.Drawing.Size(69, 16);
            this.lblNombreDocentes.TabIndex = 4;
            this.lblNombreDocentes.Text = "NOMBRE:";
            // 
            // txtNombreDocentes
            // 
            this.txtNombreDocentes.Location = new System.Drawing.Point(107, 132);
            this.txtNombreDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDocentes.Name = "txtNombreDocentes";
            this.txtNombreDocentes.Size = new System.Drawing.Size(273, 22);
            this.txtNombreDocentes.TabIndex = 3;
            // 
            // lblCodigoDocentes
            // 
            this.lblCodigoDocentes.AutoSize = true;
            this.lblCodigoDocentes.Location = new System.Drawing.Point(29, 89);
            this.lblCodigoDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoDocentes.Name = "lblCodigoDocentes";
            this.lblCodigoDocentes.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoDocentes.TabIndex = 2;
            this.lblCodigoDocentes.Text = "CODIGO:";
            // 
            // txtCodigoDocentes
            // 
            this.txtCodigoDocentes.Location = new System.Drawing.Point(107, 89);
            this.txtCodigoDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoDocentes.Name = "txtCodigoDocentes";
            this.txtCodigoDocentes.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoDocentes.TabIndex = 1;
            // 
            // lblIdDocentes
            // 
            this.lblIdDocentes.AutoSize = true;
            this.lblIdDocentes.Location = new System.Drawing.Point(71, 43);
            this.lblIdDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdDocentes.Name = "lblIdDocentes";
            this.lblIdDocentes.Size = new System.Drawing.Size(23, 16);
            this.lblIdDocentes.TabIndex = 0;
            this.lblIdDocentes.Text = "ID:";
            // 
            // grbBusquedaDocentes
            // 
            this.grbBusquedaDocentes.Controls.Add(this.grdDocentes);
            this.grbBusquedaDocentes.Controls.Add(this.txtBuscarDocentes);
            this.grbBusquedaDocentes.Location = new System.Drawing.Point(473, 18);
            this.grbBusquedaDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grbBusquedaDocentes.Name = "grbBusquedaDocentes";
            this.grbBusquedaDocentes.Padding = new System.Windows.Forms.Padding(4);
            this.grbBusquedaDocentes.Size = new System.Drawing.Size(782, 338);
            this.grbBusquedaDocentes.TabIndex = 9;
            this.grbBusquedaDocentes.TabStop = false;
            this.grbBusquedaDocentes.Text = "Busqueda Docentes";
            // 
            // grdDocentes
            // 
            this.grdDocentes.AllowUserToAddRows = false;
            this.grdDocentes.AllowUserToDeleteRows = false;
            this.grdDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono,
            this.materia});
            this.grdDocentes.Location = new System.Drawing.Point(8, 66);
            this.grdDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grdDocentes.Name = "grdDocentes";
            this.grdDocentes.ReadOnly = true;
            this.grdDocentes.RowHeadersWidth = 51;
            this.grdDocentes.Size = new System.Drawing.Size(774, 265);
            this.grdDocentes.TabIndex = 11;
            this.grdDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDocentes_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idDocentes";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // materia
            // 
            this.materia.DataPropertyName = "materia";
            this.materia.HeaderText = "materia";
            this.materia.MinimumWidth = 6;
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 125;
            // 
            // txtBuscarDocentes
            // 
            this.txtBuscarDocentes.Location = new System.Drawing.Point(8, 34);
            this.txtBuscarDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarDocentes.Name = "txtBuscarDocentes";
            this.txtBuscarDocentes.Size = new System.Drawing.Size(545, 22);
            this.txtBuscarDocentes.TabIndex = 10;
            this.txtBuscarDocentes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDocentes_KeyPress);
            // 
            // grbNavegacionDocentes
            // 
            this.grbNavegacionDocentes.Controls.Add(this.lblnRegistrosDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnUltimoDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnSiguienteDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnAnteriorDocentes);
            this.grbNavegacionDocentes.Controls.Add(this.btnPrimeroDocentes);
            this.grbNavegacionDocentes.Location = new System.Drawing.Point(36, 368);
            this.grbNavegacionDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocentes.Name = "grbNavegacionDocentes";
            this.grbNavegacionDocentes.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionDocentes.Size = new System.Drawing.Size(316, 69);
            this.grbNavegacionDocentes.TabIndex = 10;
            this.grbNavegacionDocentes.TabStop = false;
            this.grbNavegacionDocentes.Text = "Navegacion";
            // 
            // lblnRegistrosDocentes
            // 
            this.lblnRegistrosDocentes.AutoSize = true;
            this.lblnRegistrosDocentes.Location = new System.Drawing.Point(99, 34);
            this.lblnRegistrosDocentes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnRegistrosDocentes.Name = "lblnRegistrosDocentes";
            this.lblnRegistrosDocentes.Size = new System.Drawing.Size(42, 16);
            this.lblnRegistrosDocentes.TabIndex = 10;
            this.lblnRegistrosDocentes.Text = "x de n";
            // 
            // btnUltimoDocentes
            // 
            this.btnUltimoDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDocentes.Location = new System.Drawing.Point(241, 17);
            this.btnUltimoDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoDocentes.Name = "btnUltimoDocentes";
            this.btnUltimoDocentes.Size = new System.Drawing.Size(44, 46);
            this.btnUltimoDocentes.TabIndex = 3;
            this.btnUltimoDocentes.Text = ">|";
            this.btnUltimoDocentes.UseVisualStyleBackColor = true;
            this.btnUltimoDocentes.Click += new System.EventHandler(this.btnUltimoDocentes_Click);
            // 
            // btnSiguienteDocentes
            // 
            this.btnSiguienteDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteDocentes.Location = new System.Drawing.Point(193, 17);
            this.btnSiguienteDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteDocentes.Name = "btnSiguienteDocentes";
            this.btnSiguienteDocentes.Size = new System.Drawing.Size(44, 46);
            this.btnSiguienteDocentes.TabIndex = 2;
            this.btnSiguienteDocentes.Text = ">";
            this.btnSiguienteDocentes.UseVisualStyleBackColor = true;
            this.btnSiguienteDocentes.Click += new System.EventHandler(this.btnSiguienteDocentes_Click);
            // 
            // btnAnteriorDocentes
            // 
            this.btnAnteriorDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorDocentes.Location = new System.Drawing.Point(56, 17);
            this.btnAnteriorDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorDocentes.Name = "btnAnteriorDocentes";
            this.btnAnteriorDocentes.Size = new System.Drawing.Size(44, 46);
            this.btnAnteriorDocentes.TabIndex = 1;
            this.btnAnteriorDocentes.Text = "<";
            this.btnAnteriorDocentes.UseVisualStyleBackColor = true;
            this.btnAnteriorDocentes.Click += new System.EventHandler(this.btnAnteriorDocentes_Click);
            // 
            // btnPrimeroDocentes
            // 
            this.btnPrimeroDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroDocentes.Location = new System.Drawing.Point(8, 17);
            this.btnPrimeroDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroDocentes.Name = "btnPrimeroDocentes";
            this.btnPrimeroDocentes.Size = new System.Drawing.Size(44, 46);
            this.btnPrimeroDocentes.TabIndex = 0;
            this.btnPrimeroDocentes.Text = "|<";
            this.btnPrimeroDocentes.UseVisualStyleBackColor = true;
            this.btnPrimeroDocentes.Click += new System.EventHandler(this.btnPrimeroDocentes_Click);
            // 
            // frm_docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 453);
            this.Controls.Add(this.grbNavegacionDocentes);
            this.Controls.Add(this.grbBusquedaDocentes);
            this.Controls.Add(this.grbDatosDocentes);
            this.Controls.Add(this.grbEdicionDocentes);
            this.Name = "frm_docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.frm_docentes_Load);
            this.grbEdicionDocentes.ResumeLayout(false);
            this.grbDatosDocentes.ResumeLayout(false);
            this.grbDatosDocentes.PerformLayout();
            this.grbBusquedaDocentes.ResumeLayout(false);
            this.grbBusquedaDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocentes)).EndInit();
            this.grbNavegacionDocentes.ResumeLayout(false);
            this.grbNavegacionDocentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbEdicionDocentes;
        private System.Windows.Forms.Button btnEliminarDocentes;
        private System.Windows.Forms.Button btnModificarDocentes;
        private System.Windows.Forms.Button btnAgregarDocentes;
        private System.Windows.Forms.GroupBox grbDatosDocentes;
        private System.Windows.Forms.Label idDocentes;
        private System.Windows.Forms.Label lblTelefonoDocentes;
        private System.Windows.Forms.TextBox txtTelefonoDocentes;
        private System.Windows.Forms.Label lblDireccionDocentes;
        private System.Windows.Forms.TextBox txtDireccionDocentes;
        private System.Windows.Forms.Label lblNombreDocentes;
        private System.Windows.Forms.TextBox txtNombreDocentes;
        private System.Windows.Forms.Label lblCodigoDocentes;
        private System.Windows.Forms.TextBox txtCodigoDocentes;
        private System.Windows.Forms.Label lblIdDocentes;
        private System.Windows.Forms.GroupBox grbBusquedaDocentes;
        private System.Windows.Forms.DataGridView grdDocentes;
        private System.Windows.Forms.TextBox txtBuscarDocentes;
        private System.Windows.Forms.GroupBox grbNavegacionDocentes;
        private System.Windows.Forms.Label lblnRegistrosDocentes;
        private System.Windows.Forms.Button btnUltimoDocentes;
        private System.Windows.Forms.Button btnSiguienteDocentes;
        private System.Windows.Forms.Button btnAnteriorDocentes;
        private System.Windows.Forms.Button btnPrimeroDocentes;
        private System.Windows.Forms.TextBox txtMateriaDocentes;
        private System.Windows.Forms.Label lblMateriaDocentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
    }
}