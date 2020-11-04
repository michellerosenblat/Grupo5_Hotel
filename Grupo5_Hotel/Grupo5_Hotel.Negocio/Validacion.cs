using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Negocio
{
    public static class Validacion
    {
        public static string ValidarNumero(string input, string campoEsperado)
        {
            int nro;
            string error="";
            if (!int.TryParse(input, out nro))
            {
                error = campoEsperado + " debe ser numérico" + "\n";
            }
            else if (nro < 0){
                error = campoEsperado + " debe ser positivo" + "\n";
            }
            return error;
        }
        public static string ValidarString (string input, string campoEsperado)
        {
            string error = "";
            if (input == "")
            {
                error =campoEsperado + " no puede ser vacío" + "\n";
            }
            return error;
        }
    }
}
