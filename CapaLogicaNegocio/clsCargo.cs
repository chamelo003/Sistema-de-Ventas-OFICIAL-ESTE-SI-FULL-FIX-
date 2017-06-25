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
   public class clsCargo
    {
       private clsManejador M = new clsManejador();

        Int32 m_IdCargo;
        String m_Cargo;

        public Int32 IdCargo
        {
            get { return m_IdCargo; }
            set { m_IdCargo = value; }
        }

        public String Descripcion
        {
            get { return m_Cargo; }
            set { m_Cargo = value; }
        }

        public DataTable MostrarCargos() {
            return M.Listado("SP_Mostrar_Cargos", null);
        }

        public String RegistrarCargo() {
            String Mensaje = "";
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@Cargo", m_Cargo));
                lst.Add(new clsParametro("@M","",SqlDbType.VarChar,ParameterDirection.Output,50));
                M.EjecutarSP("SP_Agregar_Cargo",ref lst);
                Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {               
               throw ex;
            }
            return Mensaje;
        }

      public String ActualizarCargo() {
            String Mensaje = "";
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdCargo", m_IdCargo));
                lst.Add(new clsParametro("@Cargo", m_Cargo));
                M.EjecutarSP("SP_Editar_Cargo", ref lst);
                Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {               
               throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarCargo(String objDescripcion) {
            DataTable dt=new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdCargo", m_IdCargo));
                lst.Add(new clsParametro("@Cargo", m_Cargo));
                return dt = M.Listado("SP_Buscar_Cargo",lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
