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
    public partial class OrdenaPalabrasFormulario : Form
    {
        public OrdenaPalabrasFormulario()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string palabra1 = textBoxPalabra1.Text;
            string palabra2 = textBoxPalabra2.Text;
            //En esta funcion lo que hago es comparar, la funcion OrdenarPalabras, al devolver un entero,
            //lo que hago es que segun el valor, yo cambie el orden en que se van a imprimir las palabras ingresadas
            if (OrdenarPalabrasAlfabeticamente.OrdenarPalabras(palabra1, palabra2) == 1)
            {
                labelOrdenacion.Text = palabra2 + "," + palabra1; // O sea, que voy a imprimir al menor primero, de manera ascendente
            }
            else if
              (OrdenarPalabrasAlfabeticamente.OrdenarPalabras(palabra1, palabra2) < 0)
            {
                labelOrdenacion.Text = palabra1 + "," + palabra2;
            }
            else
            {
                labelOrdenacion.Text = palabra1 + "," + palabra2; //Si son iguales, que se impriman en orden de entrada
            }
        }
    }
}
