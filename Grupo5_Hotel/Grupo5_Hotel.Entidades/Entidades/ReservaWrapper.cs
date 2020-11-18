using Grupo5_Hotel.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel
{
    public class ReservaWrapper
    {
        int codReserva;
        Cliente cliente;
        Habitacion habitacion;
        Hotel hotel;
        int cantDias;
        string fechaIngreso;
        string fechaEgreso;
        Reserva reserva;
        public ReservaWrapper(Reserva reserva,  Cliente cliente, Hotel hotel)
        {
            codReserva = reserva.Id;
            this.cliente = cliente;
            //this.habitacion = habitacion;
            this.hotel = hotel;
            cantDias = (reserva.FechaEgreso - reserva.FechaIngreso).Days;
            fechaIngreso= reserva.FechaIngreso.ToString("dddd, dd MMMM yyyy");
            fechaEgreso = reserva.FechaEgreso.ToString("dddd, dd MMMM yyyy");
            this.reserva = reserva;
        }
       public int CodReserva
        {
            set
            {
                this.codReserva = value;
            }
            get
            {
                return this.codReserva;
            }
        }
        public Reserva Reserva
        {
            set
            {
                this.reserva = value;
            }
            get
            {
                return this.reserva;
            }
        }
        public Cliente Cliente
        {
            set
            {
                this.cliente = value;
            }
            get
            {
                return this.cliente;
            }
        }
        public Habitacion Habitacion
        {
            set
            {
                this.habitacion = value;
            }
            get
            {
                return this.hotel.Habitaciones.SingleOrDefault(x => x.Id == this.reserva.IdHabitacion);
            }
        }
        public Hotel Hotel
        {
            set
            {
                this.hotel = value;
            }
            get
            {
                return this.hotel;
            }
        }
        public string FechaIngreso
        {
            set
            {
                this.fechaIngreso = value;
            }
            get
            {
                return this.fechaIngreso;
            }
        }

        public string FechaEgreso
        {
            set
            {
                this.fechaEgreso = value;
            }
            get
            {
                return this.fechaEgreso;
            }
        }
        public int CantDias
        {
            set
            {
                this.cantDias = value;
            }
            get
            {
                return this.cantDias;
            }
        }
    }
}
