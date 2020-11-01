using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Entidades.Entidades
{
    public class Cliente : Persona 
    {
        private int id;
        private DateTime fechaAlta;
        private bool activo;

        public Cliente() { }
        public Cliente(int id, string nombre, string apellido, string direccion, string telefono, string mail) : base(id, nombre, apellido, direccion, telefono, mail)
        {
            this.fechaAlta = DateTime.Now;
            this.activo = true;
        }
        public Cliente(int id, string nombre, string apellido, string direccion, string telefono, string mail, DateTime fechaAlta, bool activo) : base (id, nombre,  apellido,  direccion,  telefono,  mail)
        {
            this.id = id;
            this.fechaAlta = fechaAlta;
            this.activo = activo;
        }
       
        public bool Activo
        {
            get
            {
                return this.activo;
            }
            set
            {
                this.activo = value;
            }

        }
        public override bool Equals(object obj)
        {
            return (obj != null && obj is Cliente && this.id == ((Cliente)obj).Id);
        }
    }
}
