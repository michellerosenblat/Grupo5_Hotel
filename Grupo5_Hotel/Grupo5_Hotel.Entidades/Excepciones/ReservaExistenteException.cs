using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Excepciones
{
    public class ReservaExistenteException : Exception
    {
        public ReservaExistenteException(int id) : base("Ya existe la reserva con id " + id) { }
    }
}
