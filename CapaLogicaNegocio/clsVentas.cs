using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
   public class clsVentas
    {
       clsManejador M = new clsManejador();

       public Int32 m_IdVenta { get; set; }
       public Int32 m_IdEmpleado { get; set; }
       public Int32 m_IdCliente { get; set; }
       public Int32 m_IdTipoVenta { get; set; }
       public String m_Num_Factura { get; set; }
       public DateTime m_FechaVenta { get; set; }
       public Decimal m_Descuento { get; set; }
       public Decimal m_Subtotal { get; set; }
       public Decimal m_Impuesto{ get; set; }
       public Decimal m_Total { get; set; }
       public Int32 m_IdSucursal { get; set; }

        public String GenerarSerieDocumento()
       {
           List<clsParametro> lst = new List<clsParametro>();
           String Serie="";
           try{
               lst.Add(new clsParametro("@Serie", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
               M.EjecutarSP("[Serie Documento]", ref lst);
               Serie = Convert.ToString(lst[0].Valor.ToString());
           }catch (Exception ex){
               throw ex;
           }
           return Convert.ToString(Serie);
       }

       public String NumeroComprobante(String objTipoDocumento) {
           List<clsParametro> lst = new List<clsParametro>();
           String NroCorrelativo="";
           try{
               lst.Add(new clsParametro("@NroCorrelativo", "", SqlDbType.VarChar, ParameterDirection.Output, 7));
               M.EjecutarSP("[Numero Correlativo]", ref lst);
               NroCorrelativo = Convert.ToString(lst[1].Valor.ToString());
           }catch (Exception ex){ 
               throw ex;
           }
           return Convert.ToString(NroCorrelativo);
       }



       public String RegistrarVenta() {
           String Mensaje = "";
           List<clsParametro> lst = new List<clsParametro>();
           try{
               lst.Add(new clsParametro("@IdEmpleado", m_IdEmpleado));
               lst.Add(new clsParametro("@IdCliente", m_IdCliente));
               lst.Add(new clsParametro("@IdTipoVenta", m_IdTipoVenta));
               lst.Add(new clsParametro("@NumFactura", m_Num_Factura));
               lst.Add(new clsParametro("@FechaVenta", m_FechaVenta));
               lst.Add(new clsParametro("@Descuento", m_Descuento));
               lst.Add(new clsParametro("@Subtotal", m_Subtotal));
               lst.Add(new clsParametro("@Impuesto", m_Impuesto));
               lst.Add(new clsParametro("@Total", m_Total));
               lst.Add(new clsParametro("@IdSucursal", m_IdSucursal));
               lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
               M.EjecutarSP("SP_Agregar_Venta", ref lst);
               return Mensaje=lst[10].Valor.ToString();
           }catch (Exception ex){
               throw ex;
           }
       }


        public String ActualizarVenta()
        {
            String Mensaje = "";
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@IdVenta", m_IdVenta));
                lst.Add(new clsParametro("@IdEmpleado", m_IdEmpleado));
                lst.Add(new clsParametro("@IdCliente", m_IdCliente));
                lst.Add(new clsParametro("@IdTipoVenta", m_IdTipoVenta));
                lst.Add(new clsParametro("@NumFactura", m_Num_Factura));
                lst.Add(new clsParametro("@FechaVenta", m_FechaVenta));
                lst.Add(new clsParametro("@Descuento", m_Descuento));
                lst.Add(new clsParametro("@Subtotal", m_Subtotal));
                lst.Add(new clsParametro("@Impuesto", m_Impuesto));
                lst.Add(new clsParametro("@Total", m_Total));
                lst.Add(new clsParametro("@IdSucursal", m_IdSucursal));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("SP_Agregar_Venta", ref lst);
                return Mensaje = lst[10].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
