using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Entity
{
    public class Cliente
    {
        public string Cedula { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public char Genero { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public Credito Credito { get; set; }
        public MailAddress Email{ get; set; }
        public Cuota Cuota { get; set; }
    }
}
