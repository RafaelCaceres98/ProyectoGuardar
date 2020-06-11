using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;

namespace Infraestructura
{
   public  class Correo
    {

        private MailMessage email;
        private SmtpClient smtp;

        public Correo()
        {
            smtp = new SmtpClient();
        }

        private void ConfigurarSmt() 
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("rricardocaceres@unicesar.edu.co","rafael1998");
        
        }

        private void ConfigurarEmail(Cliente cliente, string ruta) 
        {
            email = new MailMessage();
            email.To.Add(cliente.Email);
            email.From = new MailAddress(cliente.Email.ToString());
            email.Subject = $"Registro Exitoso";
            email.Body = $"<b>Sr {cliente.PrimerNombre}</b> <br " +
                $" > Se ha registrado satisfactoriamente";
            Attachment PDF = new Attachment(ruta);
            email.Attachments.Add(PDF);
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

        }

        public string EnviarEmail(Cliente cliente, string ruta) 
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(cliente,ruta);
                smtp.Send(email);
                return ("Correo guardado exitosamente");

            }
            catch (Exception e)
            {


                return ("Error al enviar el correo" + e.Message);
            }
            finally {
                email.Dispose();
            }
        
        
        }

    }


}
