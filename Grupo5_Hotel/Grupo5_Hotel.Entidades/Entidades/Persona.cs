using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        protected string telefono;
        protected string mail;

        public Persona(int id, string nombre, string apellido, string direccion, string telefono, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.mail = mail;
        }
        public Persona() { }
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
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
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
        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
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
    }
}
