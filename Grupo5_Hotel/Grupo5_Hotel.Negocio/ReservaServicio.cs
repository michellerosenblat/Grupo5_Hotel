using Grupo5_Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupo5_Hotel.Entidades;
using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Entidades.Excepciones;

namespace Grupo5_Hotel.Negocio
{
    public class ReservaServicio
    {
        ReservaMapper mapper;
        List<Reserva> cacheReservas;
        public ReservaServicio()
        {
            mapper = new ReservaMapper();
            RefrescarCache();
        }

        private void RefrescarCache()
        {
            cacheReservas = mapper.TraerReservas();
        }

        public List<Reserva> TraerReservas()
        {
            return cacheReservas;
        }
        public void InsertarReserva(Reserva reserva)
        {
            if (ExisteReserva(reserva))
            {
                throw new ReservaExistenteException(reserva.Id);
            }
            else
            {
                TransactionResult result = mapper.Insert(reserva);
                if (!result.IsOk)
                {
                    throw new ErrorServidorException(result.Error);
                }
                else
                {
                    RefrescarCache();
                }
            }
        }
        public bool ExisteReserva(Reserva reserva)
        {
            return cacheReservas.Any(c => c.Equals(reserva));
        }
        public Reserva TraerReservasPorId(int id)
        {
            return cacheReservas.Find(c => c.Id == id);
        }
        public int ProximoId()
        {
            return cacheReservas.Max(reserva => reserva.Id) + 1;
        }
    }
}
