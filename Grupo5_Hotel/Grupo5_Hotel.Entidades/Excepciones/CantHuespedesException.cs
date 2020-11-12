using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Excepciones
{
    public class CantHuespedesException : Exception
    {
        public CantHuespedesException () : base ("La cantidad de huespedes no puede ser mayor a la plaza") { }
    }
}
