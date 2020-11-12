using Grupo5_Hotel.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel
{
    public class GrillaReservaWrapper
    {
        int codReserva;
        string cliente;
        string habitacion;
        int cantDias;
        string fechaIngreso;
        string fechaEgreso;
        public GrillaReservaWrapper(Reserva r)
        {
            codReserva = r.Id;
            cliente = r.Cliente.Nombre;
            habitacion = r.Habitacion.ToString();
            cantDias = (r.FechaEgreso - r.FechaIngreso).Days;
            fechaIngreso= r.FechaIngreso.ToString();
            fechaEgreso = r.FechaEgreso.ToString();
        }
    }
}
