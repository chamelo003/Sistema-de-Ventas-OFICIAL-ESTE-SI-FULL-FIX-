using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaEnlaceDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class ClsDepto
    {
        clsManejador M = new clsManejador();

        public Int32 m_IdDepto { get; set; }
        public String m_Depto { get; set; }

        public Int32 IdDepto
        {
            get { return m_IdDepto; }
            set { m_IdDepto = value; }
        }

        public String Depto
        {
            get { return m_Depto; }
            set { m_Depto = value; }
        }

        public DataTable MostrarDeptos()
        {
            return M.Listado("SP_Mostrar_Departamentos", null);
        }

        public String RegistrarDepto()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Departamento", m_Depto));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Departamento", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ActualizarDepto()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdDepto", m_IdDepto));
                lst.Add(new clsParametro("@Departamento", m_Depto));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_Departamento", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
