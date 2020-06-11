using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class CuotaService
    {
        private CuotaRepository CuotaRepositorio;
        private ConnectionManager Conection;

        public CuotaService(string conection)
        {
            Conection = new ConnectionManager(conection);
            CuotaRepositorio = new CuotaRepository(Conection);
        }

        public string CrearCuota(Cuota cuota)
        {
            try
            {
                Conection.Open();
                CuotaRepositorio.CrearCuota(cuota);
                Conection.Close();
                return $"Se ha creado la cuota. ";
            }
            catch(Exception e)
            {
                Conection.Close();
                return $"Error. {e.Message.ToString()}";
            }
        }

        public decimal TotalPagado()
        {
            decimal Total;
            try
            {
                Conection.Open();
                Total = CuotaRepositorio.TotalPagado();
                Conection.Close();
                return Total;
            }
            catch(Exception e)
            {
                Conection.Close();
                return 0;
            }
        }

        public decimal TotalPagadoFiltrado(string numerocredito)
        {
            decimal Total;
            try
            {
                Conection.Open();
                Total = CuotaRepositorio.TotalPagadoFiltrado(numerocredito);
                Conection.Close();
                return Total;
            }
            catch (Exception e)
            {
                Conection.Close();
                return 0;
            }
        }

        public decimal TotalRecaudado()
        {
            decimal Total;
            try
            {
                Conection.Open();
                Total = CuotaRepositorio.TotalRecaudado();
                Conection.Close();
                return Total;
            }
            catch (Exception e)
            {
                Conection.Close();
                return 0;
            }
        }
    }
}
