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
    class clsSARSucursal
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdSar;
        private Int32 m_IdSucursal;


        public Int32 IdSar
        {
            get { return m_IdSar; }
            set { m_IdSar= value; }
        }
        public Int32 IdSucursal
        {
            get { return m_IdSucursal; }
            set { m_IdSucursal = value; }
        }

        public DataTable MostrarSarSucursal()
        {
            return M.Listado("SP_Mostrar_SarSucursales", null);
        }

        public DataTable BuscarSarSucursal(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_SarSucursal", lst);
        }

        public String RegistrarSarSucursal()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdSar", m_IdSar));
                lst.Add(new clsParametro("@IdSucursal", m_IdSucursal));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_SarSucursal", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarSAR()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdSar", m_IdSar));
                lst.Add(new clsParametro("@IdSucursal", m_IdSucursal));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_SarSucursal", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }

}
