namespace convertidor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.convertidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMonedaTitulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cobObciones = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertidoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // convertidoresToolStripMenuItem
            // 
            this.convertidoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaToolStripMenuItem,
            this.volumenToolStripMenuItem,
            this.longitudToolStripMenuItem,
            this.almacenamientoToolStripMenuItem,
            this.tiempoToolStripMenuItem});
            this.convertidoresToolStripMenuItem.Name = "convertidoresToolStripMenuItem";
            this.convertidoresToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.convertidoresToolStripMenuItem.Text = "convertidores";
            this.convertidoresToolStripMenuItem.Click += new System.EventHandler(this.convertidoresToolStripMenuItem_Click);
            // 
            // masaToolStripMenuItem
            // 
            this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
            this.masaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.masaToolStripMenuItem.Text = "Masa";
            this.masaToolStripMenuItem.Click += new System.EventHandler(this.masaToolStripMenuItem_Click);
            // 
            // volumenToolStripMenuItem
            // 
            this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
            this.volumenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.volumenToolStripMenuItem.Text = "Volumen";
            this.volumenToolStripMenuItem.Click += new System.EventHandler(this.volumenToolStripMenuItem_Click);
            // 
            // longitudToolStripMenuItem
            // 
            this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
            this.longitudToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.longitudToolStripMenuItem.Text = "Longitud";
            this.longitudToolStripMenuItem.Click += new System.EventHandler(this.longitudToolStripMenuItem_Click);
            // 
            // almacenamientoToolStripMenuItem
            // 
            this.almacenamientoToolStripMenuItem.Name = "almacenamientoToolStripMenuItem";
            this.almacenamientoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.almacenamientoToolStripMenuItem.Text = "Almacenamiento";
            this.almacenamientoToolStripMenuItem.Click += new System.EventHandler(this.almacenamientoToolStripMenuItem_Click);
            // 
            // tiempoToolStripMenuItem
            // 
            this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
            this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tiempoToolStripMenuItem.Text = "Tiempo";
            this.tiempoToolStripMenuItem.Click += new System.EventHandler(this.tiempoToolStripMenuItem_Click);
            // 
            // lblMonedaTitulo
            // 
            this.lblMonedaTitulo.AutoSize = true;
            this.lblMonedaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonedaTitulo.Location = new System.Drawing.Point(203, 51);
            this.lblMonedaTitulo.Name = "lblMonedaTitulo";
            this.lblMonedaTitulo.Size = new System.Drawing.Size(430, 20);
            this.lblMonedaTitulo.TabIndex = 1;
            this.lblMonedaTitulo.Text = "ingrese la cantidad en (dolares estado unidenses)";
            this.lblMonedaTitulo.Click += new System.EventHandler(this.lblMonedaTitulo_Click_1);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(149, 129);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCantidad.Size = new System.Drawing.Size(118, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantida a convertir";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(290, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // cobObciones
            // 
            this.cobObciones.FormattingEnabled = true;
            this.cobObciones.Items.AddRange(new object[] {
            "euro",
            "peso mexicano",
            "peso argentino",
            "dolar canadiense",
            "libra esterlina"});
            this.cobObciones.Location = new System.Drawing.Point(473, 129);
            this.cobObciones.Name = "cobObciones";
            this.cobObciones.Size = new System.Drawing.Size(121, 24);
            this.cobObciones.TabIndex = 4;
            this.cobObciones.SelectedIndexChanged += new System.EventHandler(this.cobObciones_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(334, 368);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(93, 45);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(287, 236);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(379, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(254, 43);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cobObciones);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMonedaTitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
        private System.Windows.Forms.Label lblMonedaTitulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cobObciones;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

