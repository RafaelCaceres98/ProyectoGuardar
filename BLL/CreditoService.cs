using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CreditoService
    {
        private ConnectionManager Conection;
        private IList<Credito> Creditos;
        private CreditoRepository CreditoRepositorio;
        public CreditoService(string conection)
        {
            Conection = new ConnectionManager(conection);
            CreditoRepositorio = new CreditoRepository(Conection);
        }

        public string GuardarCredito(Credito credito)
        {
            try
            {
                Conection.Open();
                CreditoRepositorio.Guardar(credito);
                Conection.Close();
                return $"Se ha guardado el credito";
            }
            catch(Exception e)
            {
                Conection.Close();
                return $"Error. {e.Message.ToString()}";
            }
        }

        public IList<Credito> ConsultarCreditosCliente(string cedula)
        {
            try
            {
                Conection.Open();
                Creditos = CreditoRepositorio.ConsultarCreditosCliente(cedula);
                return Creditos;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                Conection.Close();
            }
        }

        public decimal TotalPrestado()
        {
            decimal Total;
            try
            {
                Conection.Open();
                Total = CreditoRepositorio.TotalPrestado();
                return Total;
            }
            catch (Exception e)
            {
                return 0;
            }
            finally
            {
                Conection.Close();
            }
        }
    }
}
