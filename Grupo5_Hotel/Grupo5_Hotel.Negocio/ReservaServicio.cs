using Grupo5_Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupo5_Hotel.Entidades;
using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Entidades.Excepciones;
using System.Net.Http.Headers;

namespace Grupo5_Hotel.Negocio
{
    public class ReservaServicio
    {
        ReservaMapper reservaMapper;
        HotelMapper hotelMapper;
        HabitacionMapper habitacionMapper;
        List<Reserva> cacheReservas;
        public ReservaServicio()
        {
            reservaMapper = new ReservaMapper();
            hotelMapper = new HotelMapper ();
            habitacionMapper = new HabitacionMapper();
            RefrescarCache();
        }

        private void RefrescarCache()
        {
            cacheReservas = reservaMapper.TraerReservas();
            List<Hotel> cacheHotel = hotelMapper.TraerHoteles();
            List<Habitacion> cacheHabitaciones = new List<Habitacion>();
            foreach (Hotel h in cacheHotel)
            {
                cacheHabitaciones.AddRange(habitacionMapper.TraerHabitacionesPorId(h.Id));
            }
            foreach (Reserva r in cacheReservas)
            {
                r.Habitacion = cacheHabitaciones.Find(hab => hab.Id == r.IdHabitacion);
            }
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
                ValidacionDeReserva(reserva);
                TransactionResult result = reservaMapper.Insert(reserva);
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
        public void ValidacionDeReserva(Reserva r)
        {
            string error = "";
            if (r.FechaEgreso <= r.FechaIngreso)
            {
                throw new FechaIncorrectaException ();
            }
            if (r.CantidadHuespedes > r.Habitacion.CantidadPlazas)
            {
               throw new CantHuespedesException();
            }
        }
    }
}
