﻿namespace TareasAplicada1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.capitulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capitulo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capituloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // capitulosToolStripMenuItem
            // 
            this.capitulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capitulo1ToolStripMenuItem,
            this.capitulo2ToolStripMenuItem,
            this.capituloToolStripMenuItem});
            this.capitulosToolStripMenuItem.Name = "capitulosToolStripMenuItem";
            this.capitulosToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.capitulosToolStripMenuItem.Text = "Capitulos";
            // 
            // capitulo1ToolStripMenuItem
            // 
            this.capitulo1ToolStripMenuItem.Name = "capitulo1ToolStripMenuItem";
            this.capitulo1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.capitulo1ToolStripMenuItem.Text = "Capitulo 5";
            this.capitulo1ToolStripMenuItem.Click += new System.EventHandler(this.Capitulo1ToolStripMenuItem_Click);
            // 
            // capitulo2ToolStripMenuItem
            // 
            this.capitulo2ToolStripMenuItem.Name = "capitulo2ToolStripMenuItem";
            this.capitulo2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.capitulo2ToolStripMenuItem.Text = "Capitulo 6";
            // 
            // capituloToolStripMenuItem
            // 
            this.capituloToolStripMenuItem.Name = "capituloToolStripMenuItem";
            this.capituloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.capituloToolStripMenuItem.Text = "Capitulo 7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem capitulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capitulo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capituloToolStripMenuItem;
    }
}

