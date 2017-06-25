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
    class clsTipoUsuario
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdTipoUsuario;
        private String m_TipoUsuario;


        public Int32 IdTipoUsuario
        {
            get { return m_IdTipoUsuario; }
            set { m_IdTipoUsuario = value; }
        }

        public String TipoUsuario
        {
            get { return m_TipoUsuario; }
            set { m_TipoUsuario = value; }
        }

        public DataTable Listado()
        {
            return M.Listado("SP_Mostrar_TipoUsuarios", null);
        }

        public DataTable BuscarTipoUsuario(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_TipoUsuario", lst);
        }

        public String RegistrarTipoUsuario()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@TipoUsuario", m_TipoUsuario));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_TipoUsuario", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarTipoVenta()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdTipoUsuario", m_IdTipoUsuario));
                lst.Add(new clsParametro("@TipoUsuario", m_TipoUsuario));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_TipoUsuario", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
