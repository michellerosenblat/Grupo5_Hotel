using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Entidades
{
    public class Hotel
    {
        public int id;
        public string nombre;
        public string direccion;
        public int estrellas;
        public bool amenities;



        public Hotel() { }
     /*   public Hotel(int id, string nombre, string direccion, int estrellas)         {
            this.fechaAlta = DateTime.Now;
            this.activo = true;
        }
     */

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


    }
}