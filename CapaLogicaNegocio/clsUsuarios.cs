using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
   public class clsUsuarios
    {
       clsManejador M = new clsManejador();

       public Int32 m_IdUsuario { get; set; }
       public String m_Usuario { get; set; }
       public String m_Contrasenha { get; set; }
       public Boolean m_Estado { get; set; }
       public String m_IdEmpleado { get; set; }
       public Int32 m_IdTipoUsuario { get; set; }
       

        public Int32 IdUsuario
        {
            get { return m_IdUsuario; }
            set { m_IdUsuario = value; }
        }

        public String Usuario
        {
            get { return m_Usuario; }
            set { m_Usuario = value; }
        }

        public String Contrasenha
        {
            get { return m_Contrasenha; }
            set { m_Contrasenha = value; }
        }
        public Boolean Estado
        {
            get { return m_Estado; }
            set { m_Estado = value; }
        }

        public String IdEmpleado
        {
            get { return m_IdEmpleado; }
            set { m_IdEmpleado = value; }
        }

        public Int32 IdTipoUsuario
        {
            get { return m_IdTipoUsuario; }
            set { m_IdTipoUsuario = value; }
        }

        public DataTable MostrarUsuarios()
        {
            return M.Listado("SP_Mostrar_Usuarios", null);
        }

        public String RegistrarUsuarios() {
           List<clsParametro> lst = new List<clsParametro>();
           String Mensaje = "";
           try{
               lst.Add(new clsParametro("@Usuario", m_Usuario));
               lst.Add(new clsParametro("@Contrasenha", m_Contrasenha));
               lst.Add(new clsParametro("@Estado", m_Estado));
               lst.Add(new clsParametro("@IdEmpleado", m_IdEmpleado));
               lst.Add(new clsParametro("@IdTipoUsuario", m_IdTipoUsuario));
               lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
               M.EjecutarSP("SP_Agregar_Usuario",ref lst);
               return Mensaje = lst[5].Valor.ToString();
           }catch (Exception ex){
               throw ex;
           }
       }

       public String IniciarSesion() {
           List<clsParametro> lst = new List<clsParametro>();
           String Mensaje="";
           try{
               lst.Add(new clsParametro("@Usuario",m_Usuario));
               lst.Add(new clsParametro("@Contrasenha", m_Contrasenha));
               lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
               M.EjecutarSP("SP_Iniciar_Sesion",ref lst);
               return Mensaje=lst[2].Valor.ToString();
           }catch (Exception ex){
               throw ex;
           }
       }

       public DataTable DevolverDatosSesion(String objUsuario,String objContrasenha) {
           List<clsParametro> lst = new List<clsParametro>();
           try{
               lst.Add(new clsParametro("@Usuario", objUsuario));
               lst.Add(new clsParametro("@Contrasenha", objContrasenha));
               return M.Listado("DevolverDatosSesion",lst);
           }catch (Exception ex){
               throw ex;
           }
       }

        public String ActualizarUsuario()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdUsuario", m_IdUsuario));
                lst.Add(new clsParametro("@IdEmpleado", m_IdEmpleado));
                lst.Add(new clsParametro("@Usuario", m_Usuario));
                lst.Add(new clsParametro("@Contrasenha", m_Contrasenha));
                lst.Add(new clsParametro("@Estado", m_Estado));                
                lst.Add(new clsParametro("@IdTipoUsuario", m_IdTipoUsuario));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_Municipio", ref lst);
                return Mensaje = lst[6].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
