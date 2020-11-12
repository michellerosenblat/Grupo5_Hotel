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
        public static string ValidarComboBox (int num, string campoEsperado)
        {
            string error = "";
            if (num == -1)
            {
                error = "Seleccione un " + campoEsperado + "\n";
            }
            return error;
        }
        public static string ValidarPlaza (string cantHuespedes, int plaza, string campoEsperado)
        {
            string error = ValidarNumero(cantHuespedes, campoEsperado);
            if (error == "")
            {
                if (!(int.Parse(cantHuespedes) <= plaza))
                {
                    error += "La cantidad de huespedes no puede ser mayor a la plaza";
                }
            }
            return error;
        }
    }
}
