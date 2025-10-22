namespace parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbBusquedaUsuario = new System.Windows.Forms.GroupBox();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.grbEdicionUsuario = new System.Windows.Forms.GroupBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.lblnRegistrosUsuario = new System.Windows.Forms.Label();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.idusuario1 = new System.Windows.Forms.Label();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioRegistro = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.grbBusquedaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.grbEdicionUsuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.grbDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBusquedaUsuario
            // 
            this.grbBusquedaUsuario.Controls.Add(this.grdUsuario);
            this.grbBusquedaUsuario.Controls.Add(this.txtBuscarUsuario);
            this.grbBusquedaUsuario.Location = new System.Drawing.Point(575, 18);
            this.grbBusquedaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbBusquedaUsuario.Name = "grbBusquedaUsuario";
            this.grbBusquedaUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbBusquedaUsuario.Size = new System.Drawing.Size(722, 338);
            this.grbBusquedaUsuario.TabIndex = 7;
            this.grbBusquedaUsuario.TabStop = false;
            this.grbBusquedaUsuario.Text = "Busqueda Alumnos";
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUserToAddRows = false;
            this.grdUsuario.AllowUserToDeleteRows = false;
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.usuario,
            this.clave,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdUsuario.Location = new System.Drawing.Point(8, 66);
            this.grdUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.ReadOnly = true;
            this.grdUsuario.RowHeadersWidth = 51;
            this.grdUsuario.Size = new System.Drawing.Size(689, 265);
            this.grdUsuario.TabIndex = 11;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "id";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 125;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "usuario";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 125;
            // 
            // clave
            // 
            this.clave.HeaderText = "clave";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Location = new System.Drawing.Point(8, 34);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(545, 22);
            this.txtBuscarUsuario.TabIndex = 10;
            // 
            // grbEdicionUsuario
            // 
            this.grbEdicionUsuario.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnAgregarUsuario);
            this.grbEdicionUsuario.Location = new System.Drawing.Point(434, 364);
            this.grbEdicionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicionUsuario.Name = "grbEdicionUsuario";
            this.grbEdicionUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicionUsuario.Size = new System.Drawing.Size(457, 69);
            this.grbEdicionUsuario.TabIndex = 6;
            this.grbEdicionUsuario.TabStop = false;
            this.grbEdicionUsuario.Text = "Edicion";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(275, 18);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(133, 46);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(135, 17);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(140, 46);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(8, 18);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(125, 46);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Text = "Nuevo";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.lblnRegistrosUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(107, 364);
            this.grbNavegacionUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(316, 69);
            this.grbNavegacionUsuario.TabIndex = 5;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "Navegacion";
            // 
            // lblnRegistrosUsuario
            // 
            this.lblnRegistrosUsuario.AutoSize = true;
            this.lblnRegistrosUsuario.Location = new System.Drawing.Point(99, 34);
            this.lblnRegistrosUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnRegistrosUsuario.Name = "lblnRegistrosUsuario";
            this.lblnRegistrosUsuario.Size = new System.Drawing.Size(42, 16);
            this.lblnRegistrosUsuario.TabIndex = 10;
            this.lblnRegistrosUsuario.Text = "x de n";
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoUsuario.Location = new System.Drawing.Point(241, 17);
            this.btnUltimoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnUltimoUsuario.TabIndex = 3;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            this.btnUltimoUsuario.Click += new System.EventHandler(this.btnUltimoUsuario_Click);
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(193, 17);
            this.btnSiguienteUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnSiguienteUsuario.TabIndex = 2;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuario.Click += new System.EventHandler(this.btnSiguienteUsuario_Click);
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(56, 17);
            this.btnAnteriorUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuario.Click += new System.EventHandler(this.btnAnteriorUsuario_Click);
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(8, 17);
            this.btnPrimeroUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(44, 46);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuario.Click += new System.EventHandler(this.btnPrimeroUsuario_Click);
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.label1);
            this.grbDatosUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.idusuario1);
            this.grbDatosUsuario.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatosUsuario.Controls.Add(this.txtdireccion);
            this.grbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblUsuarioRegistro);
            this.grbDatosUsuario.Controls.Add(this.txtUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblidUsuario);
            this.grbDatosUsuario.Enabled = false;
            this.grbDatosUsuario.Location = new System.Drawing.Point(106, 18);
            this.grbDatosUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatosUsuario.Size = new System.Drawing.Size(461, 338);
            this.grbDatosUsuario.TabIndex = 4;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "DATOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "TELEFONO:";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(110, 298);
            this.txtTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(207, 22);
            this.txtTelefonoUsuario.TabIndex = 10;
            // 
            // idusuario1
            // 
            this.idusuario1.AutoSize = true;
            this.idusuario1.Location = new System.Drawing.Point(107, 47);
            this.idusuario1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idusuario1.Name = "idusuario1";
            this.idusuario1.Size = new System.Drawing.Size(44, 16);
            this.idusuario1.TabIndex = 9;
            this.idusuario1.Text = "label1";
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(18, 255);
            this.lblTelefonoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(83, 16);
            this.lblTelefonoAlumno.TabIndex = 8;
            this.lblTelefonoAlumno.Text = "DIRECCION:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(110, 252);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(207, 22);
            this.txtdireccion.TabIndex = 7;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(18, 191);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(59, 16);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(107, 188);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(347, 22);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Location = new System.Drawing.Point(23, 137);
            this.lblClaveUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(53, 16);
            this.lblClaveUsuario.TabIndex = 4;
            this.lblClaveUsuario.Text = "CLAVE:";
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(107, 132);
            this.txtClaveUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(273, 22);
            this.txtClaveUsuario.TabIndex = 3;
            // 
            // lblUsuarioRegistro
            // 
            this.lblUsuarioRegistro.AutoSize = true;
            this.lblUsuarioRegistro.Location = new System.Drawing.Point(29, 89);
            this.lblUsuarioRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioRegistro.Name = "lblUsuarioRegistro";
            this.lblUsuarioRegistro.Size = new System.Drawing.Size(54, 16);
            this.lblUsuarioRegistro.TabIndex = 2;
            this.lblUsuarioRegistro.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(107, 89);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(132, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(71, 43);
            this.lblidUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(23, 16);
            this.lblidUsuario.TabIndex = 0;
            this.lblidUsuario.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 450);
            this.Controls.Add(this.grbBusquedaUsuario);
            this.Controls.Add(this.grbEdicionUsuario);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbDatosUsuario);
            this.Name = "Form1";
            this.Text = "usuario ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbBusquedaUsuario.ResumeLayout(false);
            this.grbBusquedaUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.grbEdicionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusquedaUsuario;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.GroupBox grbEdicionUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Label lblnRegistrosUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
        private System.Windows.Forms.GroupBox grbDatosUsuario;
        private System.Windows.Forms.Label idusuario1;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label lblUsuarioRegistro;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}

