using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TareasAplicada1.BLL
{
    /*Hacer un programa que funcione como un
    diccionario, con palabra y definición,
    usando el Hashtable.
         */
    public class Capitulo7Diccionario
    {
        public static bool Diccionario(string palabra, string definicion)
        {
            //Metodos del segundo capitulo del ejercicio 5
            Hashtable Diccionario = new Hashtable();
            if (palabra == null)
            {
                return false; 
            } else
            {
                Diccionario.Add(palabra, definicion);
                return true;
            }            
        }
        
        public static string devolverPalabra(string palabra)
        {
            return palabra;
        }

        public static string devolverDefinicion(string definicion)
        {
            return definicion;
        }

      

    }
}
