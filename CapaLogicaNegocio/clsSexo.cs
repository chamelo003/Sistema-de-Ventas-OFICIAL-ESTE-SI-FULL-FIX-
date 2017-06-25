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
    class clsSexo
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdSexo;
        private String m_Sexo;


        public Int32 IdSexo
        {
            get { return m_IdSexo; }
            set { m_IdSexo = value; }
        }

        public String Sexo
        {
            get { return m_Sexo; }
            set { m_Sexo = value; }
        }

        public DataTable Listado()
        {
            return M.Listado("SP_Mostrar_Sexos", null);
        }

        public DataTable BuscarSexo(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_Sexo", lst);
        }

        public String RegistrarSexo()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Sexo", m_Sexo));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Sexo", ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarSexo()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdSexo", m_IdSexo));
                lst.Add(new clsParametro("@Sexo", m_Sexo));
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
