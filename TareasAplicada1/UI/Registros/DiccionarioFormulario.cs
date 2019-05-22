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
using TareasAplicada1.BLL;

namespace TareasAplicada1.UI.Registros
{
    public partial class DiccionarioFormulario : Form
    {
        public DiccionarioFormulario()
        {
            InitializeComponent();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            string palabra = textBoxPalabraIngresada.Text;
            string definicion = richTextBoxPalabraDefinida.Text;
            Capitulo7Diccionario.Diccionario(palabra, definicion);
            labelPalabra.Text = "Palabra: " + Capitulo7Diccionario.devolverPalabra(palabra);
            labelDefinicion.Text = "Definicion: " + Capitulo7Diccionario.devolverDefinicion(definicion);
        }



    }
}
