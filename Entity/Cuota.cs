using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cuota
    {
        public DateTime FechaCuota { get; set; }
        public int NumeroCuota { get; set; }
        public decimal ValorCuota { get; set; }
        public Cliente Cliente { get; set; }
        public Credito Credito { get; set; }


        public void AgregarCredito(Credito credito)
        {
            Credito = credito;
        }

        public void AgregarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
    }
}
