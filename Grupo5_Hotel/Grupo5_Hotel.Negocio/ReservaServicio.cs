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
    public static class ReservaServicio
    {
        private static List<Reserva> cacheReservas;
        private static List<Hotel> listaHoteles;
        private static List<Cliente> listaClientes;
        private static List<Habitacion> listaHabitaciones;
        private static List<ReservaWrapper> listaReservaWrapper;

        static ReservaServicio()
        {
            RefrescarCache();
            listaReservaWrapper = TraerReservaWrapper();
           
        }
        private static void RefrescarCache()
        {
            cacheReservas = ReservaMapper.TraerReservas();
            listaHoteles = HotelMapper.TraerHoteles();
            listaClientes = ClienteServicio.TraerClientes();
            listaHoteles.ForEach(x => x.Habitaciones.AddRange(HabitacionMapper.TraerHabitacionesPorId(x.Id)));
            LlenarListas();
        }

        public static List<Reserva> TraerReservas()
        {
            return cacheReservas;
        }
        public static List <ReservaWrapper> TraerReservaWrapper()
        {
           listaReservaWrapper = new List<ReservaWrapper>();
            
            foreach (Reserva r in cacheReservas)
            {
                //Habitacion habitacion = DevolverHabitacionDe(r);
                Hotel hotel = listaHoteles.SingleOrDefault(x => x.Habitaciones.Any(d => d.Id == r.Id));
                Cliente cliente = listaClientes.Find(c => c.Id == r.IdCliente);
                listaReservaWrapper.Add(new ReservaWrapper(r,  cliente, hotel));
            }
            return listaReservaWrapper;
        }

        private static void LlenarListas()
        {
            //listaHoteles = HotelServicio.TraerHoteles();
            //listaClientes = ClienteServicio.TraerClientes();
            listaHabitaciones = new List<Habitacion>();
            foreach (Hotel h in listaHoteles)
            {
                listaHabitaciones.AddRange(HabitacionMapper.TraerHabitacionesPorId(h.Id));
            }
        }
        private static Habitacion DevolverHabitacionDe (Reserva r)
        {
            return listaHabitaciones.Find(hab => hab.Id == r.IdHabitacion);
        }

        public static void InsertarReserva(Reserva reserva)
        {
            if (ExisteReserva(reserva))
            {
                throw new ReservaExistenteException(reserva.Id);
            }
            else
            {
                LlenarListas();
                ValidacionDeReserva(reserva);
                TransactionResult result = ReservaMapper.Insert(reserva);
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
        public static bool ExisteReserva(Reserva reserva)
        {
            return cacheReservas.Any(c => c.Equals(reserva));
        }
        public static Reserva TraerReservasPorId(int id)
        {
            return cacheReservas.Find(c => c.Id == id);
        }
        public static int ProximoId()
        {
            return cacheReservas.Max(reserva => reserva.Id) + 1;
        }
        public static void ValidacionDeReserva(Reserva r)
        {
            string error = "";
            if (r.FechaEgreso <= r.FechaIngreso)
            {
                throw new FechaIncorrectaException ();
            }
            if (r.CantidadHuespedes > DevolverHabitacionDe(r).CantidadPlazas)
            {
               throw new CantHuespedesException();
            }
        }
        //esto quedó medio desprolijo, no se si es mejor que la lista sea una propiedad, pero creo que 
        //empeoro mas la performance
        public static List<ReservaWrapper> TraerReservasPorHotel(Hotel hotel)
        {
            List<ReservaWrapper> reservasporhotel = new List<ReservaWrapper>();
            foreach (ReservaWrapper r in listaReservaWrapper)
                if (r.Habitacion != null) //necesario por haber datos mal cargado en pruebas pasadas
                    if (r.Habitacion.IdHotel == hotel.Id)
                        reservasporhotel.Add(r);
            return reservasporhotel;
        }
        public static List<ReservaWrapper> TraerReservasPorIdCliente(int idcliente)
        {
            List<ReservaWrapper> reservasPorCliente = new List <ReservaWrapper>();
            foreach (ReservaWrapper r in listaReservaWrapper)
                if (r.Reserva.IdCliente== idcliente)
                    reservasPorCliente.Add(r);
            return reservasPorCliente;
        }
    }
}
