using Grupo5_Hotel.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Datos
{
    public static class HabitacionMapper
    {
        public static List<Habitacion> TraerHabitacionesPorId(int idHotel)
        {
            string json = WebHelper.Get("/Hotel/Habitaciones/" + idHotel);
            return MapList(json);
        }
        public static List<Habitacion> MapList (string json)
        {
            return JsonConvert.DeserializeObject<List<Habitacion>>(json);
        }
        public static TransactionResult Resultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        public static NameValueCollection ReverseMap (Habitacion habitacion)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idHotel", habitacion.IdHotel.ToString());
            n.Add("CantidadPlazas", habitacion.CantidadPlazas.ToString());
            n.Add("Categoria", habitacion.Categoria);
            n.Add("Precio", habitacion.Precio.ToString());
            n.Add("Cancelable", habitacion.Cancelable.ToString());
            //n.Add("id", habitacion.Id.ToString());
            return n;
        }
        public static TransactionResult Insert (Habitacion habitacion)
        {
            NameValueCollection n = ReverseMap(habitacion);
            string result = WebHelper.Post("Hotel/Habitaciones/", n);
            return Resultado(result);
        }
    }
}
