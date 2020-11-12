﻿using System;
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
        private Hotel hotel;

        public Habitacion (int idHotel, int cantidadPlazas, string categoria, int precio, bool cancelacion){
        
            this.idHotel = idHotel;
            this.cantidadPlazas = cantidadPlazas;
            this.categoria = categoria;
            this.precio = precio;
            this.cancelacion = cancelacion;
            this.hotel = new Hotel();

        }
        public Habitacion() { }
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
        public Hotel Hotel
        {
            get
            {
                return this.hotel;
            }
            set
            {
                this.hotel = value;
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
        public override bool Equals(object obj)
        {
            return obj is Habitacion && obj != null && this.id == ((Habitacion)obj).Id;
        }

        public override string ToString()
        {
            return categoria + " " +cantidadPlazas +  " personas";
        }
    }
}
