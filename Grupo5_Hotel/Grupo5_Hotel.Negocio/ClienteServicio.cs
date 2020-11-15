using Grupo5_Hotel.Datos;
using Grupo5_Hotel.Entidades.Entidades;
using Grupo5_Hotel.Entidades.Excepciones;
using System.Collections.Generic;
using System.Linq;

namespace Grupo5_Hotel.Negocio
{
    public static class ClienteServicio
    {
        //static ClienteMapper mapper = new ClienteMapper();
        static List<Cliente> cacheClientes = ClienteMapper.TraerClientes();
       /* public static ClienteServicio()
        {
            mapper = new ClienteMapper();
            RefrescarCache();
        }*/

        private static void RefrescarCache()
        {
            cacheClientes = ClienteMapper.TraerClientes();
        }

        public static List <Cliente> TraerClientes()
        {
            return cacheClientes;
        }
        public static void InsertarCliente (Cliente cliente)
        {
            if (ExisteCliente(cliente))
            {
                throw new ClienteExistenteException(cliente.Id);
            }
            else {
                TransactionResult result = ClienteMapper.Insert(cliente);
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
        public static bool ExisteCliente (Cliente cliente)
        {
            return cacheClientes.Any(c => c.Equals(cliente));
        }
        public static Cliente TraerClientePorId (int id)
        {
            return cacheClientes.Find(c => c.Id == id);
        }
        public static int ProximoId()
        {
            return cacheClientes.Max(cliente => cliente.Id) + 1;
        }
    }
    
}
