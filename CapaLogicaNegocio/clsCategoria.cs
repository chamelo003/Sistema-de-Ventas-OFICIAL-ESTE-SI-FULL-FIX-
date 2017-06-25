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
   public class clsCategoria
    {
       private clsManejador M = new clsManejador();

        private Int32 m_IdCategoria;
        private String m_Categoria;

       
        public Int32 IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }

        public String Categoria
        {
            get { return m_Categoria; }
            set { m_Categoria = value; }
        }

        public DataTable MostrarCategorias() {
            return M.Listado("Sp_Mostrar_Categorias",null);
        }

        public String RegistrarCategoria() {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Categoria",m_Categoria));
                lst.Add(new clsParametro("@M","",SqlDbType.VarChar,ParameterDirection.Output,50));
                M.EjecutarSP("SP_Agregar_Categoria",ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {    
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarCategoria(String objDatos) {
            List<clsParametro> lst = new List<clsParametro>();
            DataTable dt = new DataTable();
            try
            {
                lst.Add(new clsParametro("@V", objDatos));
                return dt = M.Listado("SP_Buscar_Categoria",lst);
            }
            catch (Exception ex)
            {    
                throw ex;
            }
        }

        public String ActualizarCategoria() { 
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdCategoria",m_IdCategoria));
                lst.Add(new clsParametro("@Categoria",m_Categoria));
                M.EjecutarSP("SP_Editar_Categoria", ref lst);
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
