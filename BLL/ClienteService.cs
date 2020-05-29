using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;


namespace BLL
{
   public class ClienteService
    {
        private ClienteRepository clienteRepository;
        private readonly ConnectionManager connection;

        public ClienteService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            clienteRepository = new ClienteRepository(connection);
        }

        public string GuardarCliente(Cliente cliente) {
            try
            {
                connection.Open();
                clienteRepository.Guardar(cliente);
                connection.Close();
                return $"Se ah guardado correctamente";
            }
            catch (Exception e)
            {

                return $"Ah ocurrido un problema{e.Message.ToString()}";
            }
        
        }
    }
}
