namespace TareasAplicada1.UI.Registros
{
    partial class AgendaFormulario
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
            this.textBoxNombrePersona = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoPersona = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNombrePersona = new System.Windows.Forms.Label();
            this.labelTelefonoPersona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre de la persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su numero de telefono";
            // 
            // textBoxNombrePersona
            // 
            this.textBoxNombrePersona.Location = new System.Drawing.Point(281, 30);
            this.textBoxNombrePersona.Name = "textBoxNombrePersona";
            this.textBoxNombrePersona.Size = new System.Drawing.Size(179, 22);
            this.textBoxNombrePersona.TabIndex = 3;
            // 
            // textBoxTelefonoPersona
            // 
            this.textBoxTelefonoPersona.Location = new System.Drawing.Point(281, 80);
            this.textBoxTelefonoPersona.Name = "textBoxTelefonoPersona";
            this.textBoxTelefonoPersona.Size = new System.Drawing.Size(179, 22);
            this.textBoxTelefonoPersona.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ver Persona";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelNombrePersona
            // 
            this.labelNombrePersona.AutoSize = true;
            this.labelNombrePersona.Location = new System.Drawing.Point(47, 128);
            this.labelNombrePersona.Name = "labelNombrePersona";
            this.labelNombrePersona.Size = new System.Drawing.Size(0, 17);
            this.labelNombrePersona.TabIndex = 6;
            // 
            // labelTelefonoPersona
            // 
            this.labelTelefonoPersona.AutoSize = true;
            this.labelTelefonoPersona.Location = new System.Drawing.Point(47, 171);
            this.labelTelefonoPersona.Name = "labelTelefonoPersona";
            this.labelTelefonoPersona.Size = new System.Drawing.Size(0, 17);
            this.labelTelefonoPersona.TabIndex = 7;
            // 
            // AgendaFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 236);
            this.Controls.Add(this.labelTelefonoPersona);
            this.Controls.Add(this.labelNombrePersona);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTelefonoPersona);
            this.Controls.Add(this.textBoxNombrePersona);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgendaFormulario";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.AgendaFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombrePersona;
        private System.Windows.Forms.TextBox textBoxTelefonoPersona;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNombrePersona;
        private System.Windows.Forms.Label labelTelefonoPersona;
    }
}