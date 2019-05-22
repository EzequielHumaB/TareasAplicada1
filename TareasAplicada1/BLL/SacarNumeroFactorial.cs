using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  TareasAplicada1.BLL
{
    public class SacarNumeroFactorial
    {

        public static int NumeroFactorial(int numero)
        {
            int i = 1;
            int factorial = 1;
            for (i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        



    }

   
}
