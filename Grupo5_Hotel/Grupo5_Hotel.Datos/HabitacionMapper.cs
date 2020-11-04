﻿using Grupo5_Hotel.Entidades.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo5_Hotel.Datos
{
    public class HabitacionMapper
    {
        public List <Habitacion> TraerHabitacionesPorId(int idHotel)
        {
            string json = WebHelper.Get("./Habitaciones/" + idHotel);
            return MapList(json);
        }
        public List <Habitacion> MapList (string json)
        {
            return JsonConvert.DeserializeObject<List<Habitacion>>(json);
        }
        public TransactionResult Resultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        public NameValueCollection ReverseMap (Habitacion habitacion)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("IdHotel", habitacion.IdHotel.ToString());
            n.Add("CantidadPlazas", habitacion.CantidadPlazas.ToString());
            n.Add("Categoria", habitacion.Categoria);
            n.Add("Precio", habitacion.Precio.ToString());
            n.Add("Cancelacion", habitacion.Cancelacion.ToString());
            return n;
        }
        public TransactionResult Insert (Habitacion habitacion)
        {
            NameValueCollection n = ReverseMap(habitacion);
            string result = WebHelper.Post("./Habitaciones/" + habitacion.IdHotel, n);
            return Resultado(result);
        }
    }
}
