using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TareasAplicada1.BLL
{
    public class OrdenarPalabrasAlfabeticamente
    {

        /*
          Hacer un programa que le solicite al
        usuario dos cadenas y luego las muestre
        en orden alfabético.
         */
        public static int OrdenarPalabras(string palabra1, string palabra2)
        {

            int comparacion = String.Compare(palabra1,palabra2);
            return comparacion;
            
          /*  ArrayList sl = new ArrayList() { 1, 23.33m, "hello", DateTime.Now };
            var result = string.Join(",", sl.ToArray()
                .Select(o => o.ToString()));
            lista.Sort(); */
        }

       





    }




}