using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    public class clsMunicipio
    {
        clsManejador M = new clsManejador();

        public Int32 m_IdMunicipio { get; set; }
        public String m_Municipio { get; set; }
        public Int32 m_IdDepto { get; set; }
 
        public Int32 IdMunicipio
        {
            get { return m_IdMunicipio; }
            set { m_IdMunicipio = value; }
        }

        public String Municipio
        {
            get { return m_Municipio; }
            set { m_Municipio = value; }
        }

        public Int32 IdDepto
        {
            get { return m_IdDepto; }
            set { m_IdDepto = value; }
        }
        
        public DataTable MostrarMunicipio()
        {
            return M.Listado("SP_Mostrar_Municipios", null);
        }

        public String RegistrarMunicipio()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Municipio", m_Municipio));
                lst.Add(new clsParametro("@IdDepto", m_IdDepto));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Municipio", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String ActualizarMunicipio()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdMunicipio", m_IdMunicipio));
                lst.Add(new clsParametro("@Municipio", m_Municipio));
                lst.Add(new clsParametro("@IdDepto", m_IdDepto));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_Municipio", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

    }
}
