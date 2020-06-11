using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using Infraestructura;


namespace BLL
{
   public class ClienteService
    {
        
        private ClienteRepository clienteRepository;
        private CreditoRepository creditoRepository;
        private IList<Cliente> Clientes;
        private readonly ConnectionManager connection;

        public ClienteService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            clienteRepository = new ClienteRepository(connection);
            creditoRepository = new CreditoRepository(connection);
        }

        public string GuardarCliente(Cliente cliente,Credito credito, string ruta) 
        {
            Correo correo = new Correo();
            string MensajeEmail = string.Empty;
            try
            {
                
                connection.Open();
                clienteRepository.Guardar(cliente);
                creditoRepository.Guardar(credito);
                correo.EnviarEmail(cliente, ruta);
                return $"Se ah guardado correctamente" + "MensajeEmail";
            }
            catch (Exception e)
            {

                return $"Ah ocurrido un problema{e.Message.ToString()}";
            }
            finally{ connection.Close(); }
        }

        public string GenerarPdf(Cliente cliente, string filename)

        {
            PDF documentoPdf = new PDF();
            try
            {
                documentoPdf.GuardarPdf(cliente, filename);
                return "Se generó el Documento satisfactoriamente";
            }
            catch (Exception e)
            {
                return "Error al crear docuemnto" + e.Message;
            }
        }

        public IList<Cliente> ConsultarClientes()
        {
            try
            {
                connection.Open();
                Clientes = clienteRepository.ConsultarClientes();
                return Clientes;
            }
            catch(Exception e)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public IList<Cliente> ClientesGenero(char genero)
        {
            try
            {
                connection.Open();
                Clientes = clienteRepository.ClientesGenero(genero);
                return Clientes;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public IList<Cliente> ClientesFiltroCedula(string cedula)
        {
            try
            {
                connection.Open();
                Clientes = clienteRepository.ClientesFiltroCedula(cedula);
                return Clientes;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public Cliente BuscarCliente(string cedula)
        {
            Cliente cliente;
            try
            {
                connection.Open();
                cliente = clienteRepository.BuscarCliente(cedula);
                return cliente;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
