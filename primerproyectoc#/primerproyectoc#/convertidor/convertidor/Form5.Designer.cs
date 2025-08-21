namespace convertidor
{
    partial class Form5
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
            this.lblAlmacenamientoTitulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cobObciones = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlmacenamientoTitulo
            // 
            this.lblAlmacenamientoTitulo.AutoSize = true;
            this.lblAlmacenamientoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamientoTitulo.Location = new System.Drawing.Point(172, 18);
            this.lblAlmacenamientoTitulo.Name = "lblAlmacenamientoTitulo";
            this.lblAlmacenamientoTitulo.Size = new System.Drawing.Size(289, 20);
            this.lblAlmacenamientoTitulo.TabIndex = 2;
            this.lblAlmacenamientoTitulo.Text = "ingrese la cantidad en (GIgabyte)";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 53);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCantidad.Size = new System.Drawing.Size(118, 16);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantida a convertir";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(136, 53);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // cobObciones
            // 
            this.cobObciones.FormattingEnabled = true;
            this.cobObciones.Items.AddRange(new object[] {
            "megabyte ",
            "kilobyte ",
            "byte "});
            this.cobObciones.Location = new System.Drawing.Point(281, 53);
            this.cobObciones.Name = "cobObciones";
            this.cobObciones.Size = new System.Drawing.Size(121, 24);
            this.cobObciones.TabIndex = 5;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(248, 214);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(323, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(254, 43);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(323, 383);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(93, 45);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cobObciones);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblAlmacenamientoTitulo);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlmacenamientoTitulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cobObciones;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnConvertir;
    }
}