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
    public class CreditoRepository
    {
        private ConnectionManager Connection;
        private OracleDataReader Reader;
        private IList<Credito> Creditos;
        
        public CreditoRepository(ConnectionManager conection)
        {
            Connection = conection;
            Creditos = new List<Credito>();
        }
        public void Guardar(Credito credito)
        {
            using(var comando = Connection._conexion.CreateCommand())
            {
                comando.CommandText = "PAQUETECREDITO.GuardarCredito";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("v_valorcredito", OracleDbType.Decimal).Value = credito.ValorCredito;
                comando.Parameters.Add("v_tasainteres", OracleDbType.Decimal).Value = credito.TasaInteres;
                comando.Parameters.Add("v_fechainicial", OracleDbType.Varchar2).Value = credito.FechaInicial.ToShortDateString();
                comando.Parameters.Add("v_fechafinal", OracleDbType.Varchar2).Value = credito.FechaFinal.ToShortDateString();
                comando.Parameters.Add("v_numerocuotas", OracleDbType.Int32).Value = credito.NumeroCuotas;
                comando.Parameters.Add("v_valorcuota", OracleDbType.Decimal).Value = credito.ValorCuota;
                comando.Parameters.Add("v_cuotaspagas", OracleDbType.Int32).Value = credito.CuotasPagadas;
                comando.Parameters.Add("v_cliente_id", OracleDbType.Varchar2).Value = credito.Cliente.Cedula;
                comando.ExecuteNonQuery();
            }
        }

        public IList<Credito> ConsultarCreditosCliente(string cedula)
        {
            Creditos.Clear();
            using(var comando = Connection._conexion.CreateCommand())
            {
                comando.CommandText = "PAQUETECREDITO.ConsultarCreditosCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                comando.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = cedula;
                Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Credito credito;
                    credito = Map(Reader);
                    Creditos.Add(credito);
                }
            }
            return Creditos;
        }

        private Credito Map(OracleDataReader Reader)
        {
            Credito credito = new Credito();
            credito.NumeroCredito = int.Parse(((object)Reader["sk_cuota"]).ToString());
            credito.ValorCredito = decimal.Parse(((object)Reader["valorcredito"]).ToString());
            credito.TasaInteres = decimal.Parse(((object)Reader["tasainteres"]).ToString());
            credito.FechaInicial = DateTime.Parse((string)Reader["fechainicial"]);
            credito.FechaFinal = DateTime.Parse((string)Reader["fechafinal"]);
            credito.NumeroCuotas = int.Parse(((object)Reader["numerocuotas"]).ToString());
            credito.ValorCuota = decimal.Parse(((object)Reader["valorcuota"]).ToString());
            credito.CuotasPagadas = int.Parse(((object)Reader["cuotaspagadas"]).ToString());
            return credito;
        }

        public decimal TotalPrestado()
        {
            using(var command = Connection._conexion.CreateCommand())
            {
                command.CommandText = "PAQUETECREDITO.TotalPrestado";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("registro", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                return decimal.Parse(((object)command.ExecuteScalar()).ToString());
            }
        }
    }
}
