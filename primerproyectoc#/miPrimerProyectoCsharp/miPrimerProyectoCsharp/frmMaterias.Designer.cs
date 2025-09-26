namespace miPrimerProyectoCsharp
{
    partial class frmMaterias
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
            this.grbBusquedaMateria = new System.Windows.Forms.GroupBox();
            this.grdMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.grbEdicionMateria = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacionMateria = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.grbDatosMateria = new System.Windows.Forms.GroupBox();
            this.idMaterias = new System.Windows.Forms.Label();
            this.lblUVMaterias = new System.Windows.Forms.Label();
            this.txtUVMaterias = new System.Windows.Forms.TextBox();
            this.lblNombreMaterias = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMaterias = new System.Windows.Forms.Label();
            this.txtCodigoMaterias = new System.Windows.Forms.TextBox();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.grbBusquedaMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).BeginInit();
            this.grbEdicionMateria.SuspendLayout();
            this.grbNavegacionMateria.SuspendLayout();
            this.grbDatosMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaMateria
            // 
            this.grbBusquedaMateria.Controls.Add(this.grdMaterias);
            this.grbBusquedaMateria.Controls.Add(this.txtBuscarMateria);
            this.grbBusquedaMateria.Location = new System.Drawing.Point(535, 24);
            this.grbBusquedaMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbBusquedaMateria.Name = "grbBusquedaMateria";
            this.grbBusquedaMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbBusquedaMateria.Size = new System.Drawing.Size(635, 338);
            this.grbBusquedaMateria.TabIndex = 7;
            this.grbBusquedaMateria.TabStop = false;
            this.grbBusquedaMateria.Text = "Busqueda Alumnos";
            // 
            // grdMaterias
            // 
            this.grdMaterias.AllowUserToAddRows = false;
            this.grdMaterias.AllowUserToDeleteRows = false;
            this.grdMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.uv});
            this.grdMaterias.Location = new System.Drawing.Point(8, 66);
            this.grdMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.grdMaterias.Name = "grdMaterias";
            this.grdMaterias.ReadOnly = true;
            this.grdMaterias.RowHeadersWidth = 51;
            this.grdMaterias.Size = new System.Drawing.Size(455, 265);
            this.grdMaterias.TabIndex = 11;
            this.grdMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMaterias_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "idMateria";
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
            // uv
            // 
            this.uv.HeaderText = "uv";
            this.uv.MinimumWidth = 6;
            this.uv.Name = "uv";
            this.uv.ReadOnly = true;
            this.uv.Width = 125;
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(8, 34);
            this.txtBuscarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(545, 22);
            this.txtBuscarMateria.TabIndex = 10;
            this.txtBuscarMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarAlumnos_KeyPress);
            // 
            // grbEdicionMateria
            // 
            this.grbEdicionMateria.Controls.Add(this.btnEliminarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnModificarMateria);
            this.grbEdicionMateria.Controls.Add(this.btnAgregarMateria);
            this.grbEdicionMateria.Location = new System.Drawing.Point(394, 370);
            this.grbEdicionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionMateria.Name = "grbEdicionMateria";
            this.grbEdicionMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionMateria.Size = new System.Drawing.Size(457, 69);
            this.grbEdicionMateria.TabIndex = 6;
            this.grbEdicionMateria.TabStop = false;
            this.grbEdicionMateria.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(275, 18);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(133, 46);
            this.btnEliminarMateria.TabIndex = 3;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(135, 17);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(140, 46);
            this.btnModificarMateria.TabIndex = 1;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(8, 18);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(125, 46);
            this.btnAgregarMateria.TabIndex = 0;
            this.btnAgregarMateria.Text = "Nuevo";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // grbNavegacionMateria
            // 
            this.grbNavegacionMateria.Controls.Add(this.lblnRegistrosMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacionMateria.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacionMateria.Location = new System.Drawing.Point(67, 370);
            this.grbNavegacionMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionMateria.Name = "grbNavegacionMateria";
            this.grbNavegacionMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionMateria.Size = new System.Drawing.Size(316, 69);
            this.grbNavegacionMateria.TabIndex = 5;
            this.grbNavegacionMateria.TabStop = false;
            this.grbNavegacionMateria.Text = "Navegacion";
            // 
            // lblnRegistrosMateria
            // 
            this.lblnRegistrosMateria.AutoSize = true;
            this.lblnRegistrosMateria.Location = new System.Drawing.Point(99, 34);
            this.lblnRegistrosMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnRegistrosMateria.Name = "lblnRegistrosMateria";
            this.lblnRegistrosMateria.Size = new System.Drawing.Size(42, 16);
            this.lblnRegistrosMateria.TabIndex = 10;
            this.lblnRegistrosMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(241, 17);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(44, 46);
            this.btnUltimoMateria.TabIndex = 3;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(193, 17);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(44, 46);
            this.btnSiguienteMateria.TabIndex = 2;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(56, 17);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(44, 46);
            this.btnAnteriorMateria.TabIndex = 1;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(8, 17);
            this.btnPrimeroMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(44, 46);
            this.btnPrimeroMateria.TabIndex = 0;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            // 
            // grbDatosMateria
            // 
            this.grbDatosMateria.Controls.Add(this.idMaterias);
            this.grbDatosMateria.Controls.Add(this.lblUVMaterias);
            this.grbDatosMateria.Controls.Add(this.txtUVMaterias);
            this.grbDatosMateria.Controls.Add(this.lblNombreMaterias);
            this.grbDatosMateria.Controls.Add(this.txtNombreMateria);
            this.grbDatosMateria.Controls.Add(this.lblCodigoMaterias);
            this.grbDatosMateria.Controls.Add(this.txtCodigoMaterias);
            this.grbDatosMateria.Controls.Add(this.lblIdMateria);
            this.grbDatosMateria.Enabled = false;
            this.grbDatosMateria.Location = new System.Drawing.Point(66, 24);
            this.grbDatosMateria.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosMateria.Name = "grbDatosMateria";
            this.grbDatosMateria.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosMateria.Size = new System.Drawing.Size(461, 338);
            this.grbDatosMateria.TabIndex = 4;
            this.grbDatosMateria.TabStop = false;
            this.grbDatosMateria.Text = "DATOS";
            // 
            // idMaterias
            // 
            this.idMaterias.AutoSize = true;
            this.idMaterias.Location = new System.Drawing.Point(107, 47);
            this.idMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idMaterias.Name = "idMaterias";
            this.idMaterias.Size = new System.Drawing.Size(44, 16);
            this.idMaterias.TabIndex = 9;
            this.idMaterias.Text = "label1";
            // 
            // lblUVMaterias
            // 
            this.lblUVMaterias.AutoSize = true;
            this.lblUVMaterias.Location = new System.Drawing.Point(7, 193);
            this.lblUVMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUVMaterias.Name = "lblUVMaterias";
            this.lblUVMaterias.Size = new System.Drawing.Size(26, 16);
            this.lblUVMaterias.TabIndex = 6;
            this.lblUVMaterias.Text = "UV";
            // 
            // txtUVMaterias
            // 
            this.txtUVMaterias.Location = new System.Drawing.Point(41, 193);
            this.txtUVMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.txtUVMaterias.Name = "txtUVMaterias";
            this.txtUVMaterias.Size = new System.Drawing.Size(347, 22);
            this.txtUVMaterias.TabIndex = 5;
            // 
            // lblNombreMaterias
            // 
            this.lblNombreMaterias.AutoSize = true;
            this.lblNombreMaterias.Location = new System.Drawing.Point(23, 137);
            this.lblNombreMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMaterias.Name = "lblNombreMaterias";
            this.lblNombreMaterias.Size = new System.Drawing.Size(69, 16);
            this.lblNombreMaterias.TabIndex = 4;
            this.lblNombreMaterias.Text = "NOMBRE:";
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(107, 132);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(273, 22);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblCodigoMaterias
            // 
            this.lblCodigoMaterias.AutoSize = true;
            this.lblCodigoMaterias.Location = new System.Drawing.Point(29, 89);
            this.lblCodigoMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMaterias.Name = "lblCodigoMaterias";
            this.lblCodigoMaterias.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoMaterias.TabIndex = 2;
            this.lblCodigoMaterias.Text = "CODIGO:";
            // 
            // txtCodigoMaterias
            // 
            this.txtCodigoMaterias.Location = new System.Drawing.Point(107, 89);
            this.txtCodigoMaterias.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoMaterias.Name = "txtCodigoMaterias";
            this.txtCodigoMaterias.Size = new System.Drawing.Size(132, 22);
            this.txtCodigoMaterias.TabIndex = 1;
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Location = new System.Drawing.Point(71, 43);
            this.lblIdMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(23, 16);
            this.lblIdMateria.TabIndex = 0;
            this.lblIdMateria.Text = "ID:";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 454);
            this.Controls.Add(this.grbBusquedaMateria);
            this.Controls.Add(this.grbEdicionMateria);
            this.Controls.Add(this.grbNavegacionMateria);
            this.Controls.Add(this.grbDatosMateria);
            this.Name = "frmMaterias";
            this.Text = "frmMaterias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            this.grbBusquedaMateria.ResumeLayout(false);
            this.grbBusquedaMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterias)).EndInit();
            this.grbEdicionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.ResumeLayout(false);
            this.grbNavegacionMateria.PerformLayout();
            this.grbDatosMateria.ResumeLayout(false);
            this.grbDatosMateria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaMateria;
        private System.Windows.Forms.DataGridView grdMaterias;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.GroupBox grbEdicionMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacionMateria;
        private System.Windows.Forms.Label lblnRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox grbDatosMateria;
        private System.Windows.Forms.Label idMaterias;
        private System.Windows.Forms.Label lblUVMaterias;
        private System.Windows.Forms.TextBox txtUVMaterias;
        private System.Windows.Forms.Label lblNombreMaterias;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblCodigoMaterias;
        private System.Windows.Forms.TextBox txtCodigoMaterias;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uv;
    }
}