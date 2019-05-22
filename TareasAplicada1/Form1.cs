using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareasAplicada1.UI.Registros;

namespace TareasAplicada1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Capitulo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Capitulo6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Capitulo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactorialCapitulo5 factorial = new FactorialCapitulo5();
            factorial.StartPosition = FormStartPosition.CenterParent;
            factorial.Show();

        }

        private void EjercicioDeAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaFormulario agenda = new AgendaFormulario();
            agenda.StartPosition = FormStartPosition.CenterScreen;
            agenda.Show();

        }

        private void DiccionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiccionarioFormulario diccionario = new DiccionarioFormulario();
            diccionario.StartPosition = FormStartPosition.CenterScreen;
            diccionario.Show();
        }
    }
}
