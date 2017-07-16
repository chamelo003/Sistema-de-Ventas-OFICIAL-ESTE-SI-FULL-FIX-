using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
   public class clsEmpleado
    {
       clsManejador M = new clsManejador();

       public String m_IdEmpleado { get; set; }
       public String m_Nombres { get;set;}
       public String m_Apellidos { get;set;}
       public String m_Telefono { get; set; }
       public String m_Celular { get; set; }
       public String m_Direccion { get; set; }
       public Int32 m_IdMunicipio { get; set; }
       public Int32 m_IdSexo { get; set; }
       public Int32 m_IdCargo { get; set; }

        public String IdEmpleado
        {
            get { return m_IdEmpleado; }
            set { m_IdEmpleado = value; }
        }
        public String Nombres
        {
            get { return m_Nombres; }
            set { m_Nombres = value; }
        }
        public String Apellidos
        {
            get { return m_Apellidos; }
            set { m_Apellidos = value; }
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

        public String Direccion
        {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }

        public Int32 IdMunicipio
        {
            get { return m_IdMunicipio; }
            set { m_IdMunicipio = value; }
        }

        public Int32 IdSexo
        {
            get { return m_IdSexo; }
            set { m_IdSexo = value; }
        }
        public Int32 IdCargo
        {
            get { return m_IdCargo; }
            set { m_IdCargo = value; }
        }


       public DataTable MostrarEmpleados() {
          return M.Listado("SP_Mostrar_Empleados", null);
       }

        public String RegistrarEmpleado()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdEmpleado", m_IdEmpleado));
                lst.Add(new clsParametro("@Nombres", m_Nombres));
                lst.Add(new clsParametro("@Apellidos", m_Apellidos));
                lst.Add(new clsParametro("@Telefono", m_Telefono));
                lst.Add(new clsParametro("@Celular", m_Celular));
                lst.Add(new clsParametro("@Direccion", m_Direccion));
                lst.Add(new clsParametro("@IdMunicipio", m_IdMunicipio));
                lst.Add(new clsParametro("@IdSexo", m_IdSexo));
                lst.Add(new clsParametro("@IdCargo", m_IdCargo));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Empleado", ref lst);
                Mensaje = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public DataTable BuscarEmpleadoe(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_Empleado", lst);
        }

    }
}
