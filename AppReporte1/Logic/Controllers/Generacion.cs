using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppReporte1.Logic.Controllers
{
    public class Generacion
    {

        #region Atributos
        protected readonly string Query_inventario = @"C:\Splittel\AppReporte01\Inventario.sql";
        protected readonly string Query_VentasEjecutivo = @"C:\Splittel\AppReporte01\Ventaejecutivo.sql";
        protected readonly string Query_VentasProducto = @"C:\Splittel\AppReporte01\VentaArticulo.sql";
        public Reporte Reporte { get; set; }
        #endregion
        #region Contrustores
        public Generacion()
        {
            
        }
        #endregion
        #region mEtodos
        public MemoryStream FillInVentario(Sociedad sociedad, TipoReporte tipoReporte, DateTime Inicio, DateTime Fin)
        {
            Reporte = new Reporte();
            

            

            #region MyRegion
            //dataGrid.Columns.Clear();



            //for (int i = 0; i < Data.FieldCount; i++)
            //{
            //    dataGrid.Columns.Add(new DataGridViewTextBoxColumn
            //    {
            //        HeaderText = Data.GetName(i),
            //        ReadOnly = true,
            //        Name = $"Column_{i}",
            //    });
            //    Columnas.Add(Data.GetName(i));
            //}

            //dataGrid.Rows.Clear();
            //while (Data.Read())
            //{
            //    List<object> Valores = new List<object>();

            //    Columnas.ForEach(Col =>
            //    {
            //        Valores.Add(Data.GetValue(Data.GetOrdinal(Col)));
            //    });
            //    dataGrid.Rows.Add(Valores.ToArray());
            //}
            #endregion

            #region Proces
            
            var stream = new MemoryStream();

            using (var package = new ExcelPackage(stream))
            {
                if(tipoReporte == TipoReporte.Inventario)
                {
                    if (sociedad == Sociedad.Fibremex)
                    {
                        Reporte.OpenConnection();
                    }
                    else
                    {
                        Reporte.OpenConnection(ReporteSource.Optronics);
                    }

                    string Q_Ruta = $"EXEC AR_AppReporte01 @TipoReporte = N'{tipoReporte.ToString()}', @DateInicio = '{Inicio.ToString("yyyyMMdd")}', @dateFin = '{Fin.ToString("yyyyMMdd")}'";
                    var Data = sociedad == Sociedad.Fibremex ? Reporte.Db_Fibremex.GetDataReader(Q_Ruta) : Reporte.Db_Optronics.GetDataReader(Q_Ruta);

                    ProcessHOja(package, sociedad.ToString(), Data);
                }
                else
                {
                    Reporte.OpenConnection();
                    string Q_Ruta = $"EXEC AR_AppReporte01 @TipoReporte = N'{tipoReporte.ToString()}', @DateInicio = '{Inicio.ToString("yyyyMMdd")}', @dateFin = '{Fin.ToString("yyyyMMdd")}'";
                    var Data = Reporte.Db_Fibremex.GetDataReader(Q_Ruta);
                    ProcessHOja(package, Sociedad.Fibremex.ToString(), Data);

                    Reporte.OpenConnection(ReporteSource.Optronics);
                    Data = Reporte.Db_Optronics.GetDataReader(Q_Ruta);
                    ProcessHOja(package, Sociedad.Optronics.ToString(), Data);
                }


                package.Save();
            }

            string excelName = $"Rep_ProduccionHrs_{DateTime.Now.ToString("yyyyMMddHHmmssfff")}.xlsx";
            // above I define the name of the file using the current datetime.
            //return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
            #endregion
            Terminar();
            return stream;
        }
        public void Terminar()
        {
            Reporte.CloseConnection();
            Reporte.CloseConnection(ReporteSource.Optronics);
            Reporte = null;
        }
        private void ProcessHOja(ExcelPackage package, string Hoja, SqlDataReader Data)
        {
            List<string> Columnas = new List<string>();
            package.Workbook.Worksheets.Add(Hoja);
            var excelWorksheet = package.Workbook.Worksheets[Hoja];

            #region Columnas
            for (int i = 1; i <= Data.FieldCount; i++)
            {
                Color myColor = System.Drawing.ColorTranslator.FromHtml("#ffab40");
                excelWorksheet.Cells[1, i].Value = Data.GetName(i - 1);
                excelWorksheet.Cells[1, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                excelWorksheet.Cells[1, i].Style.Fill.BackgroundColor.SetColor(myColor);
                Columnas.Add(Data.GetName(i - 1));
            }
            #endregion

            #region Rows
            int fila = 2;
            while (Data.Read())
            {
                List<object> Valores = new List<object>();
                int colIn = 1;
                Columnas.ForEach(Col =>
                {
                    excelWorksheet.Cells[fila, colIn].Value = Data.GetValue(Data.GetOrdinal(Col));
                    colIn++;
                });
                fila++;
            }
            #endregion

            excelWorksheet.Cells.AutoFitColumns();
        }
        #endregion
    }

    public enum TipoReporte
    {
        Inventario = 0,
        VentasEjecutivo = 1,
        VentasProducto = 2,
    }
    public enum Sociedad
    {
        Fibremex = 1,
        Optronics = 2
    }
}
