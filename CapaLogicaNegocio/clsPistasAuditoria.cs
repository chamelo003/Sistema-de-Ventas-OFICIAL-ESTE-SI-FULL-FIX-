using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    class clsPistasAuditoria
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdLog;
        private Int32 m_IdUsuario;
        private String m_Actividad;
        private DateTime m_Fecha;


        public Int32 IdLog
        {
            get { return m_IdLog; }
            set { m_IdLog = value; }
        }
        public Int32 IdUsuario
        {
            get { return m_IdUsuario; }
            set { m_IdUsuario = value; }
        }
        public String Actividad
        {
            get { return m_Actividad; }
            set { m_Actividad = value; }
        }
        public DateTime Fecha
        {
            get { return m_Fecha; }
            set { m_Fecha = value; }
        }

        public DataTable Listado()
        {
            return M.Listado("SP_Mostrar_Pistas", null);
        }

        public DataTable BuscarLog(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_Log", lst);
        }

    }
}
