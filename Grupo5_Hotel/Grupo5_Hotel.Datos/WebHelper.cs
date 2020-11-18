﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grupo5_Hotel.Entidades;
using System.Net;
using System.Collections.Specialized;
using System.Configuration;

namespace Grupo5_Hotel.Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;
        static string usuario;
        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            //rutaBase = "https://cai-api.azurewebsites.net/api/v1";
            rutaBase = ConfigurationManager.AppSettings["URL_API"];
            //usuario = ConfigurationManager.AppSettings["Legajo"];
            client.Headers.Add("ContentType", "application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            var uri = rutaBase + url; ;

            var responseString = client.DownloadString(uri);

            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;

            try
            {
                var response = client.UploadValues(uri, parametros);

                var responseString = Encoding.Default.GetString(response);

                return responseString;
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":5,\"error\":null}";
            }


        }

    }
}
