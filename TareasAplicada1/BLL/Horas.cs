using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasAplicada1.BLL
{
    /*
     Hacer un programa que muestre la hora
     del día en formato AM/FM seguida del
     año, el día y el mes actual.
     */
    public class Horas
    {
        public static string formatoAMyfechaActual()
        {
            string formato = " ";
            formato = string.Format("{0:h yyyy dd M}",DateTime.Now);
            return formato;
        }

        public static string formatoFMyFechaAcutal()
        {
            string formato = " ";
            formato = string.Format("{0: H yyyy dd M}", DateTime.Now);
            return formato;
        }

    }
}
