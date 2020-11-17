using Grupo5_Hotel.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupo5_Hotel.Entidades;
using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Entidades.Excepciones;

namespace Grupo5_Hotel.Negocio
{
    public static class HabitacionServicio
    {
        //private HabitacionMapper mapper;
        /*public static HabitacionServicio()
        {
            //mapper = new HabitacionMapper();
        }*/
        public static List <Habitacion>TraerHabitacionesPorId(int idHotel)
        {
            return HabitacionMapper.TraerHabitacionesPorId(idHotel);
        }
        public static void InsertarHabitacion (Habitacion habitacion)
        {
            TransactionResult result = HabitacionMapper.Insert(habitacion);
            if (!result.IsOk)
            {
                throw new ErrorServidorException(result.Error);
            }
        }
    }
}
