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
    class clsTipoProveedor
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdTipoProveedor;
        private String m_TipoProveedor;


        public Int32 IdTipoProveedor
        {
            get { return m_IdTipoProveedor; }
            set { m_IdTipoProveedor = value; }
        }

        public String TipoProveedor
        {
            get { return m_TipoProveedor; }
            set { m_TipoProveedor = value; }
        }

        public DataTable Listado()
        {
            return M.Listado("SP_Mostrar_TipoProveedores", null);
        }

        public DataTable BuscarTipoProveedor(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_TipoProveedor", lst);
        }

        public String RegistrarTipoProveedor()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@TipoProveedor", m_TipoProveedor));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_TipoProveedor", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarTipoProveedor()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdTipoProveedor", m_IdTipoProveedor));
                lst.Add(new clsParametro("@TipoProveedor", m_TipoProveedor));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_TipoProveedor", ref lst);
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
