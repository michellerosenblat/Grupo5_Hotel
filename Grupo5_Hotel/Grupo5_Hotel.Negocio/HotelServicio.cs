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
    public class HotelServicio
    {
        HotelesMapper mapper;
        List<Hotel> cacheHoteles;
        public HotelServicio()
        {
            mapper = new HotelesMapper();
            RefrescarCache();
        }

        private void RefrescarCache()
        {
            cacheHoteles = mapper.TraerHoteles();
        }

        public List<Hotel> TraerHoteles()
        {
            return cacheHoteles;
        }
        public void InsertarHotel(Hotel hotel)
        {
            if (ExisteHotel(hotel))
            {
                throw new Exception("no se encontró el hotel");
            }
            else
            {
                TransactionResult resultado = mapper.Insert(hotel);
                if (!resultado.IsOk)
                {
                    throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultado.Error);
                }
                else
                {
                    RefrescarCache();
                }
            }
        }
        public bool ExisteHotel(Hotel hotel)
        {
            return cacheHoteles.Any(h => h.Equals(hotel));
        }
        public Hotel TraerHotelPorId(int id)
        {
            return cacheHoteles.Find(h => h.Id == id);
        }
        public int ProximoId()
        {
            return cacheHoteles.Max(hotel => hotel.Id) + 1;
        }
    }
}
