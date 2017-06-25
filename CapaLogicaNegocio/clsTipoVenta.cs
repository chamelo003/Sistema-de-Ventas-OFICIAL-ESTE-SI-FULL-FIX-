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
    class clsTipoVenta
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdTipoVenta;
        private String m_TipoVenta;


        public Int32 IdTipoVenta
        {
            get { return m_IdTipoVenta; }
            set { m_IdTipoVenta = value; }
        }

        public String TipoVenta
        {
            get { return m_TipoVenta; }
            set { m_TipoVenta = value; }
        }

        public DataTable Listado()
        {
            return M.Listado("SP_Mostrar_TipoVentas", null);
        }

        public DataTable BuscarTipoVentas(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_TipoVenta", lst);
        }

        public String RegistrarTipoVenta()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@TipoVenta", m_TipoVenta));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_TipoVenta", ref lst);
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
                lst.Add(new clsParametro("@IdTipoVenta", m_IdTipoVenta));
                lst.Add(new clsParametro("@TipoVenta", m_TipoVenta));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_TipoVenta", ref lst);
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
