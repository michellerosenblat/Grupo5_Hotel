using Grupo5_Hotel.Datos;
using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Negocio
{
    public static class HotelServicio
    {
        private static List<Hotel> cacheHoteles;
       static HotelServicio()
        {
            RefrescarCache();
        }

        private static void RefrescarCache()
        {
            cacheHoteles = HotelMapper.TraerHoteles();
        }

        public static List<Hotel> TraerHoteles()
        {
            return cacheHoteles;
        }
        public static void InsertarHotel(Hotel hotel)
        {
            if (ExisteHotel(hotel))
            {
                throw new Exception("no se encontró el hotel");
            }
            else
            {
                TransactionResult result = HotelMapper.Insert(hotel);
                if (!result.IsOk)
                {
                    throw new ErrorServidorException(result.Error);
                }
                else
                {
                    RefrescarCache();
                }
            }
        }
        public static bool ExisteHotel(Hotel hotel)
        {
            return cacheHoteles.Any(h => h.Equals(hotel));
        }
        public static Hotel TraerHotelPorId(int id)
        {
            return cacheHoteles.Find(h => h.Id == id);
        }
        public static int ProximoId()
        {
            return cacheHoteles.Max(hotel => hotel.Id) + 1;
        }
    }
}
