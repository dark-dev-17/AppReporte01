using DbManagerDark1.DbManager;

namespace AppReporte1.Logic
{
    public class Reporte
    {
        #region atributos
        public DarkConnectionSqlSever Db_Fibremex { get; internal set; }
        public DarkConnectionSqlSever Db_Optronics { get; internal set; }
        public int DBS_Fibremex { get; set; }
        public int DBS_Optronics { get; set; }
        #endregion
        public Reporte()
        {
            Db_Fibremex = new DarkConnectionSqlSever("Data Source=192.168.2.17;User ID=USR_LECTURA;Password=splitel.lectura16;Initial Catalog=FIBREMEX;Connect Timeout=9000;Persist Security Info=True;MultipleActiveResultSets=true;");
            Db_Optronics = new DarkConnectionSqlSever("Data Source=192.168.2.17;User ID=USR_LECTURA;Password=splitel.lectura16;Initial Catalog=OPTRONICS;Connect Timeout=9000;Persist Security Info=True;MultipleActiveResultSets=true;");
        }
        #region metodods
        /// <summary>
        /// Conectar
        /// </summary>
        public void OpenConnection(ReporteSource reporteSource = ReporteSource.Fibremex)
        {
            
            if(reporteSource == ReporteSource.Fibremex)
            {
                Db_Fibremex.OpenConnection();
            }
            else
            {
                Db_Optronics.OpenConnection();
            }
        }
        /// <summary>
        /// Desconectar
        /// </summary>
        public void CloseConnection(ReporteSource reporteSource = ReporteSource.Fibremex)
        {
            if (reporteSource == ReporteSource.Fibremex)
            {
                if(Db_Fibremex != null)
                    Db_Fibremex.CloseDataBaseAccess();
            }
            else
            {
                if (Db_Optronics != null)
                    Db_Optronics.CloseDataBaseAccess();
            }
        }
        public void StartTransaction(ReporteSource reporteSource = ReporteSource.Fibremex)
        {
            if (reporteSource == ReporteSource.Fibremex)
            {
                if (Db_Fibremex != null)
                    Db_Fibremex.StartTransaction();
            }
            else
            {
                if (Db_Optronics != null)
                    Db_Optronics.StartTransaction();
            }
        }
        public void Commit(ReporteSource reporteSource = ReporteSource.Fibremex)
        {
            if (reporteSource == ReporteSource.Fibremex)
            {
                if (Db_Fibremex != null)
                    Db_Fibremex.Commit();
            }
            else
            {
                if (Db_Optronics != null)
                    Db_Optronics.Commit();
            }
        }
        public void RollBack(ReporteSource reporteSource = ReporteSource.Fibremex)
        {
            if (reporteSource == ReporteSource.Fibremex)
            {
                if (Db_Fibremex != null)
                    Db_Fibremex.RolBack();
            }
            else
            {
                if (Db_Optronics != null)
                    Db_Optronics.RolBack();
            }
        }
        #endregion
    }

    public enum ReporteSource
    {
        Fibremex = 1,
        Optronics = 2
    }
}
