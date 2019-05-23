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
    public partial class HorasyFormatos : Form
    {
        public HorasyFormatos()
        {
            InitializeComponent();
            labelHoraAM.Text = Horas.formatoAMyfechaActual();
            labelHoraFM.Text = Horas.formatoFMyFechaAcutal();

        }

      
    }
}
