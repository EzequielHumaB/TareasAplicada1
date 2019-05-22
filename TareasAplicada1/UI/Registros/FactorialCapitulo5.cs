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
    public partial class FactorialCapitulo5 : Form
    {
        public FactorialCapitulo5()
        {
            InitializeComponent();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {



        }

        private void NumericUpDownNumeroIngresado_ValueChanged(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(Math.Round(numericUpDownNumeroIngresado.Value, 0));
            labelResultadoNumero.Text = "El resultado es : " +
                SacarNumeroFactorial.NumeroFactorial(numero);


        }
    }
}
 