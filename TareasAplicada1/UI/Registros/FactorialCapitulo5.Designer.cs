namespace TareasAplicada1.UI.Registros
{
    partial class FactorialCapitulo5
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultadoNumero = new System.Windows.Forms.Label();
            this.numericUpDownNumeroIngresado = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroIngresado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factorial de un numero";
            // 
            // labelResultadoNumero
            // 
            this.labelResultadoNumero.AutoSize = true;
            this.labelResultadoNumero.Location = new System.Drawing.Point(36, 64);
            this.labelResultadoNumero.Name = "labelResultadoNumero";
            this.labelResultadoNumero.Size = new System.Drawing.Size(72, 17);
            this.labelResultadoNumero.TabIndex = 1;
            this.labelResultadoNumero.Text = "Resultado";
            // 
            // numericUpDownNumeroIngresado
            // 
            this.numericUpDownNumeroIngresado.Location = new System.Drawing.Point(206, 25);
            this.numericUpDownNumeroIngresado.Name = "numericUpDownNumeroIngresado";
            this.numericUpDownNumeroIngresado.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownNumeroIngresado.TabIndex = 2;
            this.numericUpDownNumeroIngresado.ValueChanged += new System.EventHandler(this.NumericUpDownNumeroIngresado_ValueChanged);
            // 
            // FactorialCapitulo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 134);
            this.Controls.Add(this.numericUpDownNumeroIngresado);
            this.Controls.Add(this.labelResultadoNumero);
            this.Controls.Add(this.label1);
            this.Name = "FactorialCapitulo5";
            this.Text = "Factorial";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumeroIngresado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResultadoNumero;
        private System.Windows.Forms.NumericUpDown numericUpDownNumeroIngresado;
    }
}