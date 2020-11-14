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
        ClienteMapper clienteMapper;
        List<Reserva> cacheReservas;
        List<Hotel> listaHoteles;
        List<Cliente> listaClientes;
        List<Habitacion> listaHabitaciones;
        public ReservaServicio()
        {
            reservaMapper = new ReservaMapper();
            hotelMapper = new HotelMapper ();
            habitacionMapper = new HabitacionMapper();
            clienteMapper = new ClienteMapper();
            RefrescarCache();
            LlenarListas();
        }

        private void RefrescarCache()
        {
            cacheReservas = reservaMapper.TraerReservas();
            List<Hotel> cacheHotel = hotelMapper.TraerHoteles();
            //List<Habitacion> cacheHabitaciones = new List<Habitacion>();
        }

        public List<Reserva> TraerReservas()
        {
            return cacheReservas;
        }
        public List <ReservaWrapper> TraerReservaWrapper()
        {
            List<ReservaWrapper> listaReservaWrapper = new List<ReservaWrapper>();
            LlenarListas();
            foreach (Reserva r in cacheReservas)
            {
                Habitacion habitacion = DevolverHabitacionDe(r);
                Hotel hotel = listaHoteles.Find(ho => ho.Id == habitacion.IdHotel);
                Cliente cliente = listaClientes.Find(c => c.Id == r.IdCliente);
                listaReservaWrapper.Add(new ReservaWrapper(r, habitacion, cliente, hotel));
            }
            return listaReservaWrapper;
        }

        private void LlenarListas()
        {
            listaHoteles = hotelMapper.TraerHoteles();
            listaClientes = clienteMapper.TraerClientes();
            listaHabitaciones = new List<Habitacion>();
            foreach (Hotel h in listaHoteles)
            {
                listaHabitaciones.AddRange(habitacionMapper.TraerHabitacionesPorId(h.Id));
            }
        }
        private Habitacion DevolverHabitacionDe (Reserva r)
        {
            return listaHabitaciones.Find(hab => hab.Id == r.IdHabitacion);
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
        public List<Reserva> TraerReservasPorIdCliente(int idcliente)
        {
            List<Reserva> reservasporcliente = new List<Reserva>();
            foreach (Reserva r in cacheReservas)
                if (r.IdCliente == idcliente)
                    reservasporcliente.Add(r);
            return reservasporcliente;
        }
        public List<Reserva> TraerReservasPorHotel(Hotel hotel)
        {
            List<Reserva> reservasporhotel = new List<Reserva>();
            foreach (Reserva r in cacheReservas)
                if(r.Habitacion != null) //necesario por haber datos mal cargado en pruebas pasadas
                    if (r.Habitacion.IdHotel == hotel.Id)
                        reservasporhotel.Add(r);
            return reservasporhotel;
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
            if (r.CantidadHuespedes > DevolverHabitacionDe(r).CantidadPlazas)
            {
               throw new CantHuespedesException();
            }
        }
    }
}
