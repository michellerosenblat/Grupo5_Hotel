using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Entidades
{
    public class Reserva
    {
        private int id;
        private int idCliente;
        private int idHabitacion;
        private int cantidadHuespedes;
        private DateTime fechaIngreso;
        private DateTime fechaEgreso;
        private Cliente cliente;
        private Habitacion habitacion;
        public Reserva() { }

        public Reserva(int ID, int IDCliente, int IDHabitacion, int CantHues, DateTime FI, DateTime FE)
        {
            this.id = ID;
            this.idCliente = IDCliente;
            this.IdHabitacion = IDHabitacion;
            this.cantidadHuespedes = CantHues;
            this.fechaIngreso = FI;
            this.fechaEgreso = FE;
            this.habitacion = new Habitacion();
        }
        public Reserva(int ID, Cliente cliente, int IDHabitacion, int CantHues, DateTime FI, DateTime FE)
        {
            this.id = ID;
            this.cliente = cliente;
            this.idCliente = cliente.Id;
            this.IdHabitacion = IDHabitacion;
            this.cantidadHuespedes = CantHues;
            this.fechaIngreso = FI;
            this.fechaEgreso = FE;
            this.habitacion = new Habitacion();
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int IdCliente
        {
            get { return this.idCliente; }
            set { this.idCliente = value; }
        }
        public int IdHabitacion
        {
            get { return this.idHabitacion; }
            set { this.idHabitacion = value; }
        }
        public int CantidadHuespedes
        {
            get { return this.cantidadHuespedes; }
            set { this.cantidadHuespedes = value; }
        }
        public DateTime FechaIngreso
        {
            get { return this.fechaIngreso; }
            set { this.fechaIngreso = value; }
        }
        public DateTime FechaEgreso
        {
            get { return this.fechaEgreso; }
            set { this.fechaEgreso = value; }
        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public Habitacion Habitacion
        {
            get { return this.habitacion; }
            set { this.habitacion = value; }
        }
        public override bool Equals(object obj)
        { return (obj != null && obj is Reserva && this.id == ((Reserva)obj).Id); }
    }
}
