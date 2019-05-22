using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TareasAplicada1.BLL
{

    /*
     Hacer un programa que funcione como
    una agenda telefónica y que guarde el
    nombre de la persona y su número
    telefónico 
     */
    public class AgendaTelefonica
    {
       
        public static void GuardarNombreyTelefono(string nombre, string telefono)
        {
            ArrayList guardar = new ArrayList();
            guardar.Add(nombre);
            guardar.Add(telefono);
        }

        public static string devolverNombre(string nombre)
        {
            return nombre;
        }

        public static string devolverTelefono(string telefono)
        {
            return telefono;
        }




    }
}
