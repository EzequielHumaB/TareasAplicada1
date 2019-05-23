using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareasAplicada1.BLL;

namespace TareasAplicada1.UI.Registros
{
    public partial class AgendaFormulario : Form
    {
        public AgendaFormulario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombrePersona.Text;
            string telefono = textBoxTelefonoPersona.Text;
            AgendaTelefonica.GuardarNombreyTelefono(nombre, telefono);
            labelNombrePersona.Text = AgendaTelefonica.devolverNombre(nombre);
            labelTelefonoPersona.Text = AgendaTelefonica.devolverTelefono(telefono);

        }

        private void AgendaFormulario_Load(object sender, EventArgs e)
        {

        }
    }
}
