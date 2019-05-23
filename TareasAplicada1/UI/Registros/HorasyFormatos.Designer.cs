namespace TareasAplicada1.UI.Registros
{
    partial class HorasyFormatos
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
            this.labelHoraAM = new System.Windows.Forms.Label();
            this.labelHoraFM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHoraAM
            // 
            this.labelHoraAM.AutoSize = true;
            this.labelHoraAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraAM.Location = new System.Drawing.Point(54, 69);
            this.labelHoraAM.Name = "labelHoraAM";
            this.labelHoraAM.Size = new System.Drawing.Size(152, 55);
            this.labelHoraAM.TabIndex = 0;
            this.labelHoraAM.Text = "label1";
            // 
            // labelHoraFM
            // 
            this.labelHoraFM.AutoSize = true;
            this.labelHoraFM.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraFM.Location = new System.Drawing.Point(54, 155);
            this.labelHoraFM.Name = "labelHoraFM";
            this.labelHoraFM.Size = new System.Drawing.Size(152, 55);
            this.labelHoraFM.TabIndex = 1;
            this.labelHoraFM.Text = "label2";
            // 
            // HorasyFormatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 287);
            this.Controls.Add(this.labelHoraFM);
            this.Controls.Add(this.labelHoraAM);
            this.Name = "HorasyFormatos";
            this.Text = "HorasyFormatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHoraAM;
        private System.Windows.Forms.Label labelHoraFM;
    }
}