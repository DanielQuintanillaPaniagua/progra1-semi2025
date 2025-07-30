namespace CalculadoraDeInpuestos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DGVEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVISSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVAFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDeduciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVEmpleado,
            this.DGVSueldo,
            this.DGVRenta,
            this.DGVISSS,
            this.DGVAFP,
            this.DGVDeduciones,
            this.DGVPago});
            this.dataGridView1.Location = new System.Drawing.Point(81, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // DGVEmpleado
            // 
            this.DGVEmpleado.HeaderText = "Empleado";
            this.DGVEmpleado.MinimumWidth = 6;
            this.DGVEmpleado.Name = "DGVEmpleado";
            this.DGVEmpleado.ReadOnly = true;
            this.DGVEmpleado.Width = 125;
            // 
            // DGVSueldo
            // 
            this.DGVSueldo.HeaderText = "Sueldo";
            this.DGVSueldo.MinimumWidth = 6;
            this.DGVSueldo.Name = "DGVSueldo";
            this.DGVSueldo.ReadOnly = true;
            this.DGVSueldo.Width = 125;
            // 
            // DGVRenta
            // 
            this.DGVRenta.HeaderText = "Renta";
            this.DGVRenta.MinimumWidth = 6;
            this.DGVRenta.Name = "DGVRenta";
            this.DGVRenta.ReadOnly = true;
            this.DGVRenta.Width = 125;
            // 
            // DGVISSS
            // 
            this.DGVISSS.HeaderText = "ISSS";
            this.DGVISSS.MinimumWidth = 6;
            this.DGVISSS.Name = "DGVISSS";
            this.DGVISSS.ReadOnly = true;
            this.DGVISSS.Width = 125;
            // 
            // DGVAFP
            // 
            this.DGVAFP.HeaderText = "AFP";
            this.DGVAFP.MinimumWidth = 6;
            this.DGVAFP.Name = "DGVAFP";
            this.DGVAFP.ReadOnly = true;
            this.DGVAFP.Width = 125;
            // 
            // DGVDeduciones
            // 
            this.DGVDeduciones.HeaderText = "Deduciones";
            this.DGVDeduciones.MinimumWidth = 6;
            this.DGVDeduciones.Name = "DGVDeduciones";
            this.DGVDeduciones.ReadOnly = true;
            this.DGVDeduciones.Width = 125;
            // 
            // DGVPago
            // 
            this.DGVPago.HeaderText = "Pago";
            this.DGVPago.MinimumWidth = 6;
            this.DGVPago.Name = "DGVPago";
            this.DGVPago.ReadOnly = true;
            this.DGVPago.Width = 125;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(483, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pago a Empleado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(77, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(197, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre del empleado:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.Location = new System.Drawing.Point(78, 135);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(80, 20);
            this.lblSueldo.TabIndex = 3;
            this.lblSueldo.Text = "sueldo$:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVRenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVISSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVAFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVDeduciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPago;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSueldo;
    }
}

