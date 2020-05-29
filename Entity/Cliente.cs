using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Genero { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public Credito Credito { get; set; }
        public Cuota Cuota { get; set; }

        

        public void AgregarCredito(Credito credito)
        {
            Credito = credito;
        }


        public void CrearCuota(DateTime fecha,decimal valor,int numerocuota)
        {
            Cuota = new Cuota();
            Cuota.Cliente = this;
            Cuota.FechaCuota = fecha;
            Cuota.ValorCuota = valor;
            Cuota.NumeroCuota = numerocuota;
        }
    }
}
