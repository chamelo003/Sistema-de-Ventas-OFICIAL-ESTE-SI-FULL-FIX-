using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    class clsReferenciasEmpleados
    {
        clsManejador M = new clsManejador();

        public Int32 m_IdRef { get; set; }
        public String m_NombreRef { get; set; }
        public String m_ApellidoRef { get; set; }
        public String m_TelefonoRef { get; set; }
        public String m_CelularRef { get; set; }
        public String m_Direccion { get; set; }


        public Int32 IdRef
        {
            get { return m_IdRef; }
            set { m_IdRef = value; }
        }

        public String NombreRef
        {
            get { return m_NombreRef; }
            set { m_NombreRef = value; }
        }

        public String ApellidoRef
        {
            get { return m_ApellidoRef; }
            set { m_ApellidoRef = value; }
        }
        public String TelefonoRef
        {
            get { return m_TelefonoRef; }
            set { m_TelefonoRef = value; }
        }

        public String CelularRef
        {
            get { return m_CelularRef; }
            set { m_CelularRef = value; }
        }

        public String Direccion
        {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }

        public DataTable MostrarReferenciasEmp()
        {
            return M.Listado("SP_Mostrar_ReferenciasEmp", null);
        }


        public DataTable BuscarReferenciaEmp(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@V", objDatos));
                dt = M.Listado("SP_Buscar_Referencia", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }

        public String RegistrarReferenciaEmp()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@NombreRef", m_NombreRef));
                lst.Add(new clsParametro("@ApellidoRef", m_ApellidoRef));
                lst.Add(new clsParametro("@TelfonoRef", m_TelefonoRef));
                lst.Add(new clsParametro("@CelularRef", m_CelularRef));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agreagar_ReferenciasEmp", ref lst);
                return Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ActualizarReferenciaEmp()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@IdRef", m_IdRef));
                lst.Add(new clsParametro("@NombreRef", m_NombreRef));
                lst.Add(new clsParametro("@ApellidoRef", m_ApellidoRef));
                lst.Add(new clsParametro("@TelefonoRef", m_TelefonoRef));
                lst.Add(new clsParametro("@CelularRef", m_CelularRef));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_ReferenciaEmp", ref lst);
                Mensaje = lst[5].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }


    }
}
