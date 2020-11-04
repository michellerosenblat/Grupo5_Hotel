using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Entidades
{
    public class Habitacion
    {
        private int id;
        private int idHotel;
        private string categoria;
        private int cantidadPlazas;
        private bool cancelacion;
        private double precio;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public int IdHotel
        {
            get
            {
                return this.idHotel;
            }
            set
            {
                this.idHotel = value;
            }
        }
        public string Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }
        public int CantidadPlazas
        {
            get
            {
                return this.cantidadPlazas;
            }
            set
            {
                this.cantidadPlazas = value;
            }
        }
        public bool Cancelacion
        {
            get
            {
                return this.cancelacion;
            }
            set
            {
                this.cancelacion = value;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
    }
}
