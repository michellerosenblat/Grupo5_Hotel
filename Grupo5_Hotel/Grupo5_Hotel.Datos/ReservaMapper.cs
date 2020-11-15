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
    public static class ReservaMapper
    {
        public static List<Reserva> TraerReservas()
        {
            string json = WebHelper.Get("./Hotel/Reservas/" + ConfigurationManager.AppSettings["Legajo"]);
            return MapList(json);
        }
        public static List<Reserva> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<Reserva>>(json);
        }
        public static TransactionResult Resultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        public static NameValueCollection ReverseMap(Reserva reserva)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idHabitacion", reserva.IdHabitacion.ToString());
            n.Add("idCliente", reserva.IdCliente.ToString());
            n.Add("CantidadHuespedes", reserva.CantidadHuespedes.ToString());
            n.Add("FechaIngreso", reserva.FechaIngreso.ToString());
            n.Add("FechaEgreso", reserva.FechaEgreso.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("id", reserva.Id.ToString());
            return n;
        }
        public static TransactionResult Insert(Reserva reserva)
        {
            NameValueCollection n = ReverseMap(reserva);
            string result = WebHelper.Post("./Hotel/Reservas/", n);
            return Resultado(result);
        }
    }
}
