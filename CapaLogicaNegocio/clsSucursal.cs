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
    class clsSucursal
    {
        private clsManejador M = new clsManejador();
        private Int32 m_IdSucursal;
        private String m_Direccion;
        private String m_Telefono;
        private String m_RTN;


        public Int32 IdSucursal
        {
            get { return m_IdSucursal; }
            set { m_IdSucursal = value; }
        }

        public String Direccion
        {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }

        public String Telefono
        {
            get { return m_Telefono; }
            set { m_Telefono = value; }
        }

        public String RTN
        {
            get { return m_RTN; }
            set { m_RTN = value; }
        }

        public DataTable MostrarSucursales()
        {
            return M.Listado("SP_Mostrar_Sucursales", null);
        }

        public DataTable BuscarSucursal(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_Sucursal", lst);
        }

        public String RegistrarSucursal()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@Telefono", m_Telefono));
                lst.Add(new clsParametro("@RTN", m_RTN));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Sucursal", ref lst);
                Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarCliente()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdSucursal", m_IdSucursal));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@Telefono", m_Telefono));
                lst.Add(new clsParametro("@RTN", m_RTN));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Sucursal", ref lst);
                Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

    }
}
