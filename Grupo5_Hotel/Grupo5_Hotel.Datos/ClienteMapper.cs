﻿using Grupo5_Hotel.Entidades.Entidades;
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
    public static class ClienteMapper
    {
        public static List<Cliente> TraerClientes()
        {
            string json = WebHelper.Get("./cliente/");
            // si se quiere filtrar por nro de legajo agregar esto +ConfigurationManager.AppSettings["Legajo"]
            return MapList(json);
        }
        public static List<Cliente> MapList(string json)
        {
            return JsonConvert.DeserializeObject<List<Cliente>>(json);
        }
        private static TransactionResult MapResultado(string json)
        {
            return JsonConvert.DeserializeObject<TransactionResult>(json);
        }
        private static NameValueCollection ReverseMap (Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Email", cliente.Email); // STRING
            n.Add("Telefono", cliente.Telefono); // INT
            n.Add("Activo", cliente.Activo.ToString()); // bool
            return n;
        }
        public static TransactionResult Insert (Cliente cliente)
        {
            NameValueCollection n = ReverseMap(cliente);
            string result = WebHelper.Post("./cliente", n);
            return MapResultado(result);
        }
    }
}
