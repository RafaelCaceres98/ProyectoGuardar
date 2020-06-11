using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class CuotaRepository
    {
        ConnectionManager Connection;

        public CuotaRepository(ConnectionManager connection)
        {
            Connection = connection;
        }

        public void CrearCuota(Cuota cuota)
        {
            using(var command = Connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECUOTA.CREARCUOTA";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("v_numerocuota", OracleDbType.Int32).Value = cuota.NumeroCuota;
                command.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = cuota.FechaCuota.ToShortDateString();
                command.Parameters.Add("v_valorcuota", OracleDbType.Decimal).Value = cuota.ValorCuota;
                command.Parameters.Add("v_credito", OracleDbType.Int32).Value = cuota.Credito.NumeroCredito;
                command.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = cuota.Cliente.Cedula;
                command.ExecuteNonQuery();
            }
        }

        public decimal TotalPagado()
        {
            using(var command = Connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECUOTA.TotalPagado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                return decimal.Parse(((object)command.ExecuteScalar()).ToString());
            }
        }

        public decimal TotalPagadoFiltrado(string numerocredito)
        {
            using(var command = Connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECUOTA.TotalFIltrado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                command.Parameters.Add("v_credito", OracleDbType.Int32).Value = int.Parse(numerocredito);
                return decimal.Parse(((object)command.ExecuteScalar()).ToString());
            }
        }

        public decimal TotalRecaudado()
        {
            using(var command = Connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECUOTA.TotalRecaudado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                return decimal.Parse(((object)command.ExecuteScalar()).ToString());
            }
        }
    }
}
