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
    class clsProveedores
    {

        private clsManejador M = new clsManejador();

        private Int32 m_IdProveedor;
        private String m_Nombre;
        private String m_Direccion;
        private String m_Telefono;
        private String m_Correo;
        private String m_RTN;
        private Int32 m_IdMunicipio;
        private Int32 m_IdTipoProveedor;
        private String m_Contacto;
        private String m_TelefContacto;


        public Int32 IdProveedor
        {
            get { return m_IdProveedor; }
            set { m_IdProveedor = value; }
        }
        public String Nombre
        {
            get { return m_Nombre; }
            set { m_RTN = value; }
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


        public String Correo
        {
            get { return m_Correo; }
            set { m_Correo = value; }
        }

        public String RTN
        {
            get { return m_RTN; }
            set { m_RTN = value; }
        }

        public Int32 IdMunicipio
        {
            get { return m_IdMunicipio; }
            set { m_IdMunicipio = value; }
        }

        public Int32 IdTipoProveedor
        {
            get { return m_IdTipoProveedor; }
            set { m_IdTipoProveedor = value; }
        }


        public String Contacto
        {
            get { return m_Contacto; }
            set { m_Contacto = value; }
        }

        public String TelefContacto
        {
            get { return m_TelefContacto; }
            set { m_TelefContacto = value; }
        }


        public DataTable MostrarProveedores()
        {
            return M.Listado("SP_Mostrar_Proveedores", null);
        }

        public DataTable BuscarProveedor(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_Proveedor", lst);
        }

        public String RegistrarProveedor()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Nombre", m_Nombre));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@Telefono", m_Telefono));
                lst.Add(new clsParametro("@Correo", m_Correo));
                lst.Add(new clsParametro("@RTN", m_RTN));
                lst.Add(new clsParametro("@IdMunicipio", m_Telefono));
                lst.Add(new clsParametro("@IdTipoProveedor", m_IdTipoProveedor));
                lst.Add(new clsParametro("@Contacto", m_Contacto));
                lst.Add(new clsParametro("@TelefContacto", m_TelefContacto));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Proveedor", ref lst);
                Mensaje = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProveedor()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdProveedor", m_IdProveedor));
                lst.Add(new clsParametro("@Nombre", m_Nombre));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@Telefono", m_Telefono));
                lst.Add(new clsParametro("@Correo", m_Correo));
                lst.Add(new clsParametro("@RTN", m_RTN));
                lst.Add(new clsParametro("@IdMunicipio", m_Telefono));
                lst.Add(new clsParametro("@IdTipoProveedor", m_IdTipoProveedor));
                lst.Add(new clsParametro("@Contacto", m_Contacto));
                lst.Add(new clsParametro("@TelefContacto", m_TelefContacto));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_Prveedor", ref lst);
                Mensaje = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
    
}
