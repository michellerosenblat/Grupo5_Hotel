using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Excepciones
{
    public class ErrorServidorException : Exception
    {
       public ErrorServidorException (string error) : base ("Hubo un error en la petición al servidor. Detalle: " + error) { }
    }
}
