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
    public class ClienteServicio
    {
        ClienteMapper mapper;
        List<Cliente> cacheClientes;
        public ClienteServicio()
        {
            mapper = new ClienteMapper();
            RefrescarCache();
        }

        private void RefrescarCache()
        {
            cacheClientes = mapper.TraerClientes();
        }

        public List <Cliente> TraerClientes()
        {
            return cacheClientes;
        }
        public void InsertarCliente (Cliente cliente)
        {
            if (ExisteCliente(cliente))
            {
                throw new ClienteExistenteException(cliente.Id);
            }
            else {
                TransactionResult result = mapper.Insert(cliente);
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
        public bool ExisteCliente (Cliente cliente)
        {
            return cacheClientes.Any(c => c.Equals(cliente));
        }
        public Cliente TraerClientePorId (int id)
        {
            return cacheClientes.Find(c => c.Id == id);
        }
        public int ProximoId()
        {
            return cacheClientes.Max(cliente => cliente.Id) + 1;
        }
    }
    
}
