using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Excepciones
{
    public class FechaIncorrectaException : Exception
    {
        public FechaIncorrectaException() : base("La fecha de egreso debe ser posterior a la de ingreso") { }
    }
}
