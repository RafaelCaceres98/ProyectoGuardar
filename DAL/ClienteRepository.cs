using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
        private ConnectionManager connection;
        public ClienteRepository(ConnectionManager connectionManager)
        {
            connection = connectionManager;
        }

        public void Guardar(Cliente cliente) {
            OracleCommand command = new OracleCommand("GuardarCliente",connection._conexion);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = cliente.Cedula;
            command.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
            command.Parameters.Add("segundonombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
            command.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
            command.Parameters.Add("segundoapellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
            command.Parameters.Add("genero", OracleDbType.Varchar2).Value = cliente.Genero;
            command.Parameters.Add("celular", OracleDbType.Varchar2).Value = cliente.Celular;
            command.Parameters.Add("direccion", OracleDbType.Varchar2).Value = cliente.Direccion;
            command.ExecuteNonQuery();


        }
    }
}
