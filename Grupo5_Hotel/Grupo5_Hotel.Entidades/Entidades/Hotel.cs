using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Grupo5_Hotel.Entidades.Entidades
{
    [DataContract]
    public class Hotel
    {
        [DataMember]
        private int id;
        [DataMember]
        private string nombre;
        [DataMember]
        private string direccion;
        [DataMember]
        private int estrellas;
        [DataMember]
        private bool amenities;
        private List<Habitacion> habitaciones;
        public Hotel() {
            habitaciones = new List<Habitacion>();
        }
        public Hotel(int id, string nombre, string direccion, int estrellas, bool amenities) 
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.estrellas = estrellas;
            this.amenities = amenities;
        }
        public List <Habitacion> Habitaciones
        {
            get
            {
                return this.habitaciones;
            }
            set
            {
                this.habitaciones = value;
            }
        }
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
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        public int Estrellas
        {
            get
            {
                return this.estrellas;
            }
            set
            {
                this.estrellas = value;
            }
        }
        public bool Amenities
        {
            get
            {
                return this.amenities;
            }
            set
            {
                this.amenities = value;
            }
        }
        public override string ToString()
        {
            return nombre;
        }
    }
}