using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ConexionDataBase
{
    internal class Helper
    {
        //validar que solo ingrese numeros
        public void soloNumeros(KeyPressEventArgs e)
        {
         if(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
         else
                e.Handled = true;
        }
        public bool ValidarEmail(string email)
        {
            //expresión regular para comparar el email, y que tenga el formato
            string formato = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            //comparamos el email ingresado con el formato 
            if (Regex.IsMatch(email, formato))
                //si hay coicidencia entrega true sino false
                if (Regex.Replace(email, formato, string.Empty).Length == 0)
                    return true;
            return false;
        }
    }
}
