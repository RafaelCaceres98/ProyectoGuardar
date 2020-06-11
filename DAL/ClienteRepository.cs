using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Net.Mail;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
        private ConnectionManager connection;
        private OracleDataReader Reader;
        private IList<Cliente> Clientes;
        public ClienteRepository(ConnectionManager connectionManager)
        {
            connection = connectionManager;
            Clientes = new List<Cliente>();
        }

        public void Guardar(Cliente cliente) 
        {

            using (var command = connection._conexion.CreateCommand()) 
            {
                command.CommandText = "PAQUETECLIENTE.GuardarCliente";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("v_id_cliente", OracleDbType.Varchar2).Value = cliente.Cedula;
                command.Parameters.Add("v_primernombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("v_segundonombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("v_primerapellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("v_segundoapellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("v_genero", OracleDbType.Char).Value = cliente.Genero;
                command.Parameters.Add("v_celular", OracleDbType.Varchar2).Value = cliente.Celular;
                command.Parameters.Add("v_direccion", OracleDbType.Varchar2).Value = cliente.Direccion;
                command.Parameters.Add("v_email", OracleDbType.Varchar2).Value = cliente.Email.Address;
                command.ExecuteNonQuery();
            }
            
        }

        public IList<Cliente> ConsultarClientes()
        {
            Clientes.Clear();
            using(var command = connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECLIENTE.ConsultarClientes";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Cliente cliente;
                    cliente = MapCLiente(Reader);
                    Clientes.Add(cliente);
                }
            }
            return Clientes;
        }

        public  IList<Cliente> ClientesGenero(char genero)
        {
            Clientes.Clear();
            using (var command = connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECLIENTE.FIltrarClientes";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("genero", OracleDbType.Char).Value = genero;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Cliente cliente;
                    cliente = MapCLiente(Reader);
                    Clientes.Add(cliente);
                }
            }
            return Clientes;
        }

        public IList<Cliente> ClientesFiltroCedula(string cedula)
        {
            Clientes.Clear();
            using (var command = connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECLIENTE.FiltroCedulta";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("cedula", OracleDbType.Char).Value = "%"+cedula+"%";
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    Cliente cliente;
                    cliente = MapCLiente(Reader);
                    Clientes.Add(cliente);
                }
            }
            return Clientes;
        }

        private Cliente MapCLiente(OracleDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = (string)reader["id_cliente"];
            cliente.PrimerNombre = (string)reader["primernombre"];
            cliente.SegundoNombre = (string)reader["segundonombre"];
            cliente.PrimerApellido = (string)reader["primerapellido"];
            cliente.SegundoApellido = (string)reader["segundoapellido"];
            cliente.Genero = ((string)reader["genero"])[0];
            cliente.Celular = (string)reader["celular"];
            cliente.Direccion = (string)reader["direccion"];
            cliente.Email = new MailAddress((string)reader["email"]);
            return cliente;
        }

        public Cliente BuscarCliente(string cedula)
        {
            Cliente cliente=null;
            using (var command = connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECLIENTE.FiltroCedulta";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("cedula", OracleDbType.Char).Value = cedula;
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    
                    cliente = MapCLiente(Reader);
                }
            }
            return cliente;
        }
    }
}
