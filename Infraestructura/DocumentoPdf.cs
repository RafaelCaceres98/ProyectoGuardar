using System;
using System.Collections.Generic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(List<Cliente> cliente, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion de Credisoft");
            document.Open();
            document.Add(new Paragraph("INFORME DE PERSONAS REGISTRADAS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(cliente));
            document.Close();
        }
        private PdfPTable LlenarTabla(List<Cliente> cliente)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Cedula"));
            tabla.AddCell(new Paragraph("Primernombre"));
            tabla.AddCell(new Paragraph("Segundonombre"));
            tabla.AddCell(new Paragraph("Primerapellido"));
            tabla.AddCell(new Paragraph("segundoapellido"));
            tabla.AddCell(new Paragraph("Genero"));
            tabla.AddCell(new Paragraph("Celular"));
            tabla.AddCell(new Paragraph("Direccion"));
            tabla.AddCell(new Paragraph("Email"));
            foreach (var item in cliente)
            {
                tabla.AddCell(new Paragraph(item.Cedula));
                tabla.AddCell(new Paragraph(item.PrimerNombre));
                tabla.AddCell(new Paragraph(item.SegundoNombre));
                tabla.AddCell(new Paragraph(item.PrimerApellido));
                tabla.AddCell(new Paragraph(item.SegundoApellido));
                tabla.AddCell(new Paragraph(item.Genero));
                tabla.AddCell(new Paragraph(item.Celular));
                tabla.AddCell(new Paragraph(item.Direccion));
                tabla.AddCell(new Paragraph(item.Email.ToString()));


            }
            return tabla;

        }
    }
}
