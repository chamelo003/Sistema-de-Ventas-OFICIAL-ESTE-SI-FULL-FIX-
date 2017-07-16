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
    public class clsCliente
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdCliente;
        private String m_RTN;
        private String m_Nombres;
        private String m_Apellidos;
        private String m_Direccion;
        private String m_Telefono;
        private String m_Celular;
        private String m_Correo;
        private Int32  m_IdSexo;
        private Int32 m_IdMunicipio;


        public Int32 IdCLiente
        {
            get { return m_IdCliente; }
            set { m_IdCliente = value; }
        }
        public String RTN
        {
            get { return m_RTN; }
            set { m_RTN = value; }
        }
        public String Nombres
        {
            get { return m_Nombres; }
            set { m_Nombres = value; }
        }

        public String Apellidos{
            get { return m_Apellidos; }
            set { m_Apellidos = value; }
        }


        public String Direccion{
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }

        public String Telefono
        {
            get { return m_Telefono; }
            set { m_Telefono = value; }
        }

        public String Celular
        {
            get { return m_Celular; }
            set { m_Celular = value; }
        }

        public String Correo
        {
            get { return m_Correo; }
            set { m_Correo = value; }
        }

        public Int32 IdSexo
        {
            get { return m_IdSexo; }
            set { m_IdSexo = value; }
        }


        public Int32 IdMunicipio
        {
            get { return m_IdMunicipio; }
            set { m_IdMunicipio = value; }
        }



        public DataTable MostrarClientes() {
           return M.Listado("SP_Mostrar_Clientes", null);
        }

        public DataTable BuscarCliente(String objDatos) {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@V",objDatos));
            return dt=M.Listado("SP_Buscar_Cliente",lst);
        }

        public String RegistrarCliente() {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@RTN",m_RTN));
                lst.Add(new clsParametro("@Nombres",m_Nombres));
                lst.Add(new clsParametro("@Apellidos", m_Apellidos));
                lst.Add(new clsParametro("@Direccion",m_Direccion));
                lst.Add(new clsParametro("@Telefono",m_Telefono));
                lst.Add(new clsParametro("@Celular", m_Celular));
                lst.Add(new clsParametro("@Correo", m_Correo));
                lst.Add(new clsParametro("@IdSexo", m_IdSexo));
                lst.Add(new clsParametro("@IdMunicipio", m_IdMunicipio));
                lst.Add(new clsParametro("@M","",SqlDbType.VarChar,ParameterDirection.Output,50));
                M.EjecutarSP("SP_Agregar_Cliente", ref lst);
                Mensaje=lst[9].Valor.ToString();
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
                lst.Add(new clsParametro("@IdCLiente", m_IdCliente));
                lst.Add(new clsParametro("@RTN", m_RTN));
                lst.Add(new clsParametro("@Nombres", m_Nombres));
                lst.Add(new clsParametro("@Apellidos", m_Apellidos));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@Telefono", m_Telefono));
                lst.Add(new clsParametro("@Celular", m_Celular));
                lst.Add(new clsParametro("@Correo", m_Correo));
                lst.Add(new clsParametro("@IdSexo", m_IdSexo));
                lst.Add(new clsParametro("@IdMunicipio", m_IdMunicipio));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_Cliente", ref lst);
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
