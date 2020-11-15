using Grupo5_Hotel.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Datos
{
    public static class HotelMapper
    {

        public static List<Hotel> TraerHoteles()
        {
            string json = WebHelper.Get("./Hotel/Hoteles/");
            //+ ConfigurationManager.AppSettings["Legajo"]
            return MapList(json);
        }
        public static List<Hotel> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<Hotel>>(json);
        }
        public static TransactionResult MapResultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        public static NameValueCollection ReverseMap(Hotel hotel)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("estrellas", hotel.Estrellas.ToString());
            n.Add("nombre", hotel.Nombre);
            n.Add("direccion", hotel.Direccion);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("amenities", hotel.Amenities.ToString()); 
            n.Add("id", hotel.Id.ToString()); 

            return n;
        }
        public static TransactionResult Insert(Hotel hotel)
        {
            NameValueCollection n = ReverseMap(hotel);
            string result = WebHelper.Post("./Hotel/Hoteles", n);
            return MapResultado(result);
        }
    }
}
