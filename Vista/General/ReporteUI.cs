using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.General
{
    public class ReporteUI
    {
        /*public static void generarPDF(string nombre, string[] dataPadre = null, DataTable dataInfo = null)
        {
            string ruta = Path.GetTempPath();
            ruta = ruta + nombre;
            XDocument doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@ruta, FileMode.Create));

            doc.AddTitle("Mi primer PDF");
            doc.AddCreator("Roberto Torres");

            doc.Open();

            doc.Add(new Paragraph("Ejemplo"));
            doc.Add(Chunk.NEWLINE);

            PdfPTable tblPrueba = new PdfPTable(dataInfo.Columns.Count);
            tblPrueba.WidthPercentage = 100;
            iTextSharp.text.Font formatoEncabezados = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
            crearEncabezado(formatoEncabezados, tblPrueba, dataPadre);
            iTextSharp.text.Font formatoFila = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            crearFilas(formatoFila, tblPrueba, dataInfo);

            doc.Add(tblPrueba);

            doc.Close();
            writer.Close();
            Process.Start(ruta);
        }*/

        /*static void crearEncabezado(iTextSharp.text.Font formato, PdfPTable tblPrueba, string[] Encabezado)
        {
            foreach (string item in Encabezado)
            {
                PdfPCell colm = new PdfPCell(new Phrase(item, formato));
                colm.BorderWidth = 1;
                colm.BackgroundColor = BaseColor.GRAY;
                tblPrueba.AddCell(colm);
            }

        }
        static void crearFilas(iTextSharp.text.Font formato, PdfPTable tblPrueba, DataTable tblInfo)
        {
            for (int j = 0; j <= (tblInfo.Rows.Count - 1); j++)
            {
                for (int i = 0; i <= (tblInfo.Columns.Count - 1); i++)
                {
                    PdfPCell dato = new PdfPCell(new Phrase(tblInfo.Rows[j][i].ToString(), formato));
                    dato.BorderWidth = 1;
                    tblPrueba.AddCell(dato);
                }
            }
        }
    }

    public static void exportarReporte(ReportClass pReporte,
                                           string pNombre,
                                           string pFormula,
                                           ExportFormatType pFormato)
    {
        try
        {
            PrincipalUI.cursorEnEspera();
            ConnectionInfo connInfo = obtenerConexionReporte();
            SetDBLogonForReport(connInfo, pReporte);
            SetDBLogonForSubreports(connInfo, pReporte);
            if (pFormula != null)
            {
                pReporte.RecordSelectionFormula = pFormula;
            }
            string ruta = System.IO.Path.GetTempPath() +
                   pNombre +
                   DateTime.Now.Ticks +
                   obtenerExtensionReporte(pFormato.ToString());

            pReporte.ExportToDisk(pFormato, ruta);
            pReporte.Load(ruta);
            pReporte.Close();
            Process.Start(ruta);
        }
        catch (Exception ex)
        {
            Mensajes.mensajeError(ex);
        }
        PrincipalUI.cursorPredeterminado();

    }

    public static ConnectionInfo obtenerConexionReporte()
    {
        ConnectionInfo connReporte = new ConnectionInfo();
        connReporte.ServerName = SesionActual.getConexion().DataSource;
        connReporte.DatabaseName = SesionActual.getConexion().Database;
        connReporte.UserID = "View_main";
        connReporte.Password = "View_x123456*";
        connReporte.Type = ConnectionInfoType.SQL;
        return connReporte;
    }*/
    }
}
