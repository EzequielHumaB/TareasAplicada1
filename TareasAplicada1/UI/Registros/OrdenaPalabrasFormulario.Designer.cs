namespace TareasAplicada1.UI.Registros
{
    partial class OrdenaPalabrasFormulario
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPalabra1 = new System.Windows.Forms.TextBox();
            this.textBoxPalabra2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelOrdenacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una palabra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese otra palabra";
            // 
            // textBoxPalabra1
            // 
            this.textBoxPalabra1.Location = new System.Drawing.Point(227, 22);
            this.textBoxPalabra1.Name = "textBoxPalabra1";
            this.textBoxPalabra1.Size = new System.Drawing.Size(161, 22);
            this.textBoxPalabra1.TabIndex = 2;
            // 
            // textBoxPalabra2
            // 
            this.textBoxPalabra2.Location = new System.Drawing.Point(227, 69);
            this.textBoxPalabra2.Name = "textBoxPalabra2";
            this.textBoxPalabra2.Size = new System.Drawing.Size(161, 22);
            this.textBoxPalabra2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ordenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelOrdenacion
            // 
            this.labelOrdenacion.AutoSize = true;
            this.labelOrdenacion.Location = new System.Drawing.Point(53, 125);
            this.labelOrdenacion.Name = "labelOrdenacion";
            this.labelOrdenacion.Size = new System.Drawing.Size(0, 17);
            this.labelOrdenacion.TabIndex = 6;
            // 
            // OrdenaPalabrasFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 208);
            this.Controls.Add(this.labelOrdenacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPalabra2);
            this.Controls.Add(this.textBoxPalabra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdenaPalabrasFormulario";
            this.Text = "Palabras ordenadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPalabra1;
        private System.Windows.Forms.TextBox textBoxPalabra2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOrdenacion;
    }
}