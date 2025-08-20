namespace convertidor
{
    partial class Form2
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
            this.lblMasaTitulo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.cobOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cobDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMasaTitulo
            // 
            this.lblMasaTitulo.AutoSize = true;
            this.lblMasaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasaTitulo.Location = new System.Drawing.Point(241, 9);
            this.lblMasaTitulo.Name = "lblMasaTitulo";
            this.lblMasaTitulo.Size = new System.Drawing.Size(175, 20);
            this.lblMasaTitulo.TabIndex = 2;
            this.lblMasaTitulo.Text = "ingrese la cantidad ";
            this.lblMasaTitulo.Click += new System.EventHandler(this.lblMasaTitulo_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(330, 60);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(200, 63);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCantidad.Size = new System.Drawing.Size(118, 16);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantida a convertir";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(197, 217);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(297, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(403, 21);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(365, 393);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(93, 45);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // cobOrigen
            // 
            this.cobOrigen.FormattingEnabled = true;
            this.cobOrigen.Items.AddRange(new object[] {
            "Dólar",
            "Euro",
            " Peso Mexicano",
            "Peso Argentino",
            " Dólar Canadiense",
            "  Libra Esterlina",
            " Franco Suizo",
            "  Yen Japonés",
            "  Yuan Chino",
            "  Real Brasileño"});
            this.cobOrigen.Location = new System.Drawing.Point(131, 131);
            this.cobOrigen.Name = "cobOrigen";
            this.cobOrigen.Size = new System.Drawing.Size(121, 24);
            this.cobOrigen.TabIndex = 10;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(36, 134);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(89, 16);
            this.lblOrigen.TabIndex = 11;
            this.lblOrigen.Text = "unidad origen";
            // 
            // cobDestino
            // 
            this.cobDestino.AutoCompleteCustomSource.AddRange(new string[] {
            "Dólar",
            "Euro",
            " Peso Mexicano",
            "Peso Argentino",
            " Dólar Canadiense",
            "  Libra Esterlina",
            " Franco Suizo",
            "  Yen Japonés",
            "  Yuan Chino",
            "  Real Brasileño"});
            this.cobDestino.FormattingEnabled = true;
            this.cobDestino.Items.AddRange(new object[] {
            "Dólar",
            "Euro",
            " Peso Mexicano",
            "Peso Argentino",
            " Dólar Canadiense",
            "  Libra Esterlina",
            " Franco Suizo",
            "  Yen Japonés",
            "  Yuan Chino",
            "  Real Brasileño"});
            this.cobDestino.Location = new System.Drawing.Point(409, 126);
            this.cobDestino.Name = "cobDestino";
            this.cobDestino.Size = new System.Drawing.Size(121, 24);
            this.cobDestino.TabIndex = 12;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(299, 131);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(95, 16);
            this.lblDestino.TabIndex = 13;
            this.lblDestino.Text = "unidad destino";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cobDestino);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.cobOrigen);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblMasaTitulo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasaTitulo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox cobOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cobDestino;
        private System.Windows.Forms.Label lblDestino;
    }
}