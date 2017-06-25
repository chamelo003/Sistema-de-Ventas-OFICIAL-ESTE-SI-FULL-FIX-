using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
   public class clsDetalleVenta
    {
       clsManejador M = new clsManejador();

        public Int32 m_IdVenta { get; set; }
        public Int32 m_IdProducto { get; set; }
        public Int32 m_Cantidad { get; set; }

        public Int32 IdProducto
        {
            get { return m_IdProducto; }
            set { m_IdProducto = value; }
        }
        public Int32 Cantidad
        {
            get { return m_Cantidad; }
            set { m_Cantidad = value; }
        }
        public DataTable MostrarDetalleVentas()
        {
            return M.Listado("SP_Mostrar_DetalleEmp", null);
        }

        public String RegistrarDetalleVenta() {
           List<clsParametro> lst = new List<clsParametro>();
           String Mensaje = "";
           try{
                lst.Add(new clsParametro("@IdProducto", IdProducto));
                lst.Add(new clsParametro("@Cantidad",Cantidad));
               lst.Add(new clsParametro("@M","",SqlDbType.VarChar,ParameterDirection.Output,100));
               M.EjecutarSP("SP_Agregar_DetalleVenta", ref lst);
               Mensaje = lst[2].Valor.ToString();
           }catch (Exception ex){
               throw ex;
           }
           return Mensaje;
       }
    }
}
