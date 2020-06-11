using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;
using System.IO;

namespace Infraestructura
{
    public class PDF
    {
        public void GuardarPdf(Cliente cliente, string path)

        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion IPS");
            document.Open();
            document.Add(new Paragraph("DATOS REGISTRADOS DE "+cliente.PrimerNombre+" EN CREDISOFT" ));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(cliente));
            document.Close();
        }

        public PdfPTable LlenarTabla(Cliente cliente)
        {
            PdfPTable tabla = new PdfPTable(8);
            tabla.AddCell(new Paragraph("Cedula"));
            tabla.AddCell(new Paragraph("PrimerNombre"));
            tabla.AddCell(new Paragraph("SegundoNombre"));
            tabla.AddCell(new Paragraph("PrimerApellido"));
            tabla.AddCell(new Paragraph("SegundoApellido"));
            tabla.AddCell(new Paragraph("Genero"));
            tabla.AddCell(new Paragraph("Celular"));
            tabla.AddCell(new Paragraph("Correo"));
            tabla.AddCell(new Paragraph(cliente.Cedula));
                tabla.AddCell(new Paragraph(cliente.PrimerNombre));
                tabla.AddCell(new Paragraph(cliente.SegundoNombre));
                tabla.AddCell(new Paragraph(cliente.PrimerApellido));
                tabla.AddCell(new Paragraph(cliente.SegundoApellido));
                tabla.AddCell(new Paragraph(cliente.Genero));
                tabla.AddCell(new Paragraph(cliente.Celular));
                tabla.AddCell(new Paragraph(cliente.Email.ToString()));
            return tabla;
        }
    }
}
