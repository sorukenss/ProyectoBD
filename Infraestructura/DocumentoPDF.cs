using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPDF(List<Empleado> empleados, string Path)
        {
            FileStream stream = new FileStream(Path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Proyecto RegCol");
            document.Open();
            document.Add(new Paragraph("Informe de Empleados registrados"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(empleados));
            document.Close();
        }

        private PdfPTable LlenarTabla(List<Empleado> empleados)
        {
            PdfPTable pdfPTable = new PdfPTable(8);
            pdfPTable.AddCell(new Paragraph("Cedula"));
            pdfPTable.AddCell(new Paragraph("Primer Nombre"));
            pdfPTable.AddCell(new Paragraph("Segundo Nombre"));
            pdfPTable.AddCell(new Paragraph("Primer Apellido"));
            pdfPTable.AddCell(new Paragraph("Segundo Apellido"));
            pdfPTable.AddCell(new Paragraph("Sexo"));
            pdfPTable.AddCell(new Paragraph("Correo"));
            pdfPTable.AddCell(new Paragraph("Contraseña"));
            foreach (var item in empleados)
            {
                pdfPTable.AddCell(new Paragraph(item.Cedula));
                pdfPTable.AddCell(new Paragraph(item.primerNombre));
                pdfPTable.AddCell(new Paragraph(item.segundoNombre));
                pdfPTable.AddCell(new Paragraph(item.primerApellido));
                pdfPTable.AddCell(new Paragraph(item.segundoApellido));
                pdfPTable.AddCell(new Paragraph(item.Sexo));
                pdfPTable.AddCell(new Paragraph(item.Email));
                pdfPTable.AddCell(new Paragraph(item.Password));
            }
            return pdfPTable;
        }
    }
}
