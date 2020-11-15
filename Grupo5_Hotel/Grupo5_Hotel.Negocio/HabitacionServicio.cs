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
    public class HabitacionServicio
    {
        //private HabitacionMapper mapper;
        public HabitacionServicio()
        {
            //mapper = new HabitacionMapper();
        }
        public List <Habitacion>TraerHabitacionesPorId(int idHotel)
        {
            return HabitacionMapper.TraerHabitacionesPorId(idHotel);
        }
        public void InsertarHabitacion (Habitacion habitacion)
        {
            TransactionResult result = HabitacionMapper.Insert(habitacion);
            if (!result.IsOk)
            {
                throw new ErrorServidorException(result.Error);
            }
        }
    }
}
