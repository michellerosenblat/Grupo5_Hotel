using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades
{
    public abstract class Persona
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected string direccion;
        protected long telefono;
        protected string mail;

        public Persona(int id, string nombre, string apellido, string direccion, long telefono, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.mail = mail;
        }

        public string Nombre { 
            get 
            {
                 return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
            }
    }
}
