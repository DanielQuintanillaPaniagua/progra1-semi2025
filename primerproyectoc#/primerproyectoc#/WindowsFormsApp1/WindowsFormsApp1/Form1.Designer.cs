namespace WindowsFormsApp1
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.grbOpociones = new System.Windows.Forms.GroupBox();
            this.optModulo = new System.Windows.Forms.RadioButton();
            this.optFactorial = new System.Windows.Forms.RadioButton();
            this.optProcentaje = new System.Windows.Forms.RadioButton();
            this.optExponente = new System.Windows.Forms.RadioButton();
            this.optDivicion = new System.Windows.Forms.RadioButton();
            this.optMultiplicacion = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.cboOpciones = new System.Windows.Forms.ComboBox();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.grbOpociones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(101, 48);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(138, 22);
            this.txtNum1.TabIndex = 0;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(39, 54);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(42, 16);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "num1:";
            this.lblnum1.Click += new System.EventHandler(this.lblnum1_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(101, 218);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(126, 40);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Calcular";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(39, 98);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(42, 16);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "num2:";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(101, 92);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(138, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(39, 151);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(70, 16);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "respuesta:";
            // 
            // grbOpociones
            // 
            this.grbOpociones.Controls.Add(this.optModulo);
            this.grbOpociones.Controls.Add(this.optFactorial);
            this.grbOpociones.Controls.Add(this.optProcentaje);
            this.grbOpociones.Controls.Add(this.optExponente);
            this.grbOpociones.Controls.Add(this.optDivicion);
            this.grbOpociones.Controls.Add(this.optMultiplicacion);
            this.grbOpociones.Controls.Add(this.optResta);
            this.grbOpociones.Controls.Add(this.optSuma);
            this.grbOpociones.Location = new System.Drawing.Point(301, 12);
            this.grbOpociones.Name = "grbOpociones";
            this.grbOpociones.Size = new System.Drawing.Size(200, 230);
            this.grbOpociones.TabIndex = 6;
            this.grbOpociones.TabStop = false;
            this.grbOpociones.Text = "Opciones";
            this.grbOpociones.Enter += new System.EventHandler(this.grbOpociones_Enter);
            // 
            // optModulo
            // 
            this.optModulo.AutoSize = true;
            this.optModulo.Location = new System.Drawing.Point(6, 203);
            this.optModulo.Name = "optModulo";
            this.optModulo.Size = new System.Drawing.Size(73, 20);
            this.optModulo.TabIndex = 7;
            this.optModulo.TabStop = true;
            this.optModulo.Text = "modulo";
            this.optModulo.UseVisualStyleBackColor = true;
            // 
            // optFactorial
            // 
            this.optFactorial.AutoSize = true;
            this.optFactorial.Location = new System.Drawing.Point(6, 177);
            this.optFactorial.Name = "optFactorial";
            this.optFactorial.Size = new System.Drawing.Size(75, 20);
            this.optFactorial.TabIndex = 6;
            this.optFactorial.TabStop = true;
            this.optFactorial.Text = "factorial";
            this.optFactorial.UseVisualStyleBackColor = true;
            // 
            // optProcentaje
            // 
            this.optProcentaje.AutoSize = true;
            this.optProcentaje.Location = new System.Drawing.Point(6, 151);
            this.optProcentaje.Name = "optProcentaje";
            this.optProcentaje.Size = new System.Drawing.Size(92, 20);
            this.optProcentaje.TabIndex = 5;
            this.optProcentaje.TabStop = true;
            this.optProcentaje.Text = "procentaje";
            this.optProcentaje.UseVisualStyleBackColor = true;
            // 
            // optExponente
            // 
            this.optExponente.AutoSize = true;
            this.optExponente.Location = new System.Drawing.Point(6, 125);
            this.optExponente.Name = "optExponente";
            this.optExponente.Size = new System.Drawing.Size(92, 20);
            this.optExponente.TabIndex = 4;
            this.optExponente.TabStop = true;
            this.optExponente.Text = "Exponente";
            this.optExponente.UseVisualStyleBackColor = true;
            // 
            // optDivicion
            // 
            this.optDivicion.AutoSize = true;
            this.optDivicion.Location = new System.Drawing.Point(6, 99);
            this.optDivicion.Name = "optDivicion";
            this.optDivicion.Size = new System.Drawing.Size(76, 20);
            this.optDivicion.TabIndex = 3;
            this.optDivicion.TabStop = true;
            this.optDivicion.Text = "Division";
            this.optDivicion.UseVisualStyleBackColor = true;
            // 
            // optMultiplicacion
            // 
            this.optMultiplicacion.AutoSize = true;
            this.optMultiplicacion.Location = new System.Drawing.Point(6, 73);
            this.optMultiplicacion.Name = "optMultiplicacion";
            this.optMultiplicacion.Size = new System.Drawing.Size(109, 20);
            this.optMultiplicacion.TabIndex = 2;
            this.optMultiplicacion.TabStop = true;
            this.optMultiplicacion.Text = "multiplicacion";
            this.optMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(6, 47);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(64, 20);
            this.optResta.TabIndex = 1;
            this.optResta.TabStop = true;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Location = new System.Drawing.Point(6, 21);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(63, 20);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // cboOpciones
            // 
            this.cboOpciones.FormattingEnabled = true;
            this.cboOpciones.Items.AddRange(new object[] {
            "suma",
            "resta",
            "multiplicacion",
            "divicion",
            "primo",
            "factorial"});
            this.cboOpciones.Location = new System.Drawing.Point(617, 38);
            this.cboOpciones.Name = "cboOpciones";
            this.cboOpciones.Size = new System.Drawing.Size(121, 24);
            this.cboOpciones.TabIndex = 7;
            this.cboOpciones.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.Location = new System.Drawing.Point(617, 163);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(110, 55);
            this.btnCalcular2.TabIndex = 8;
            this.btnCalcular2.Text = "calcular";
            this.btnCalcular2.UseVisualStyleBackColor = true;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 294);
            this.Controls.Add(this.btnCalcular2);
            this.Controls.Add(this.cboOpciones);
            this.Controls.Add(this.grbOpociones);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbOpociones.ResumeLayout(false);
            this.grbOpociones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.GroupBox grbOpociones;
        private System.Windows.Forms.RadioButton optDivicion;
        private System.Windows.Forms.RadioButton optMultiplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
        private System.Windows.Forms.RadioButton optExponente;
        private System.Windows.Forms.RadioButton optModulo;
        private System.Windows.Forms.RadioButton optFactorial;
        private System.Windows.Forms.RadioButton optProcentaje;
        private System.Windows.Forms.ComboBox cboOpciones;
        private System.Windows.Forms.Button btnCalcular2;
    }
}

