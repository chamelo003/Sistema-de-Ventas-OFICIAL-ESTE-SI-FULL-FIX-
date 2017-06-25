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
    class clsSAR
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdSAR;
        private String m_CAI;
        private String m_Establecimiento;
        private String m_Punto_Emision;
        private DateTime m_Fecha_Aut;
        private DateTime m_Fecha_Limite;
        private String m_Rango_Aut_Inicial;
        private String m_Rango_Aut_Final;


        public Int32 IdSAR
        {
            get { return m_IdSAR; }
            set { m_IdSAR = value; }
        }

        public String CAI
        {
            get { return m_CAI; }
            set { m_CAI = value; }
        }
        public String Establecimiento
        {
            get { return m_Establecimiento; }
            set { m_Establecimiento = value; }
        }

        public String PuntoEmision
        {
            get { return m_Punto_Emision ; }
            set { m_Punto_Emision = value; }
        }


        public DateTime FechaAutorizacion 
        {
            get { return m_Fecha_Aut; }
            set { m_Fecha_Aut = value; }
        }

        public DateTime FechaLimite
        {
            get { return m_Fecha_Limite; }
            set { m_Fecha_Limite = value; }
        }

        public String RangoInicial
        {
            get { return m_Rango_Aut_Inicial; }
            set { m_Rango_Aut_Inicial = value; }
        }

        public String RangoFinal
        {
            get { return m_Rango_Aut_Final; }
            set { m_Rango_Aut_Final = value; }
        }


        public DataTable MostrarSAR()
        {
            return M.Listado("SP_Mostrar_SAR", null);
        }

        public DataTable BuscarSAR(String objDatos)
        {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            lst.Add(new clsParametro("@M", objDatos));
            return dt = M.Listado("SP_Buscar_SAR", lst);
        }

        public String RegistrarSAR() 
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
               lst.Add(new clsParametro("@CAI", m_CAI));
                lst.Add(new clsParametro("@Establecimentp", m_Establecimiento));
                lst.Add(new clsParametro("@PuntoEmision", m_Punto_Emision));
                lst.Add(new clsParametro("@FechaAuto", m_Fecha_Aut));
                lst.Add(new clsParametro("@FechaLimite", m_Fecha_Limite));
                lst.Add(new clsParametro("@RangoInicial", m_Rango_Aut_Inicial)); 
                lst.Add(new clsParametro("@RangoFinal", m_Rango_Aut_Final));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_SAR", ref lst);
                Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarSAR()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@IdSAR", m_IdSAR));
                lst.Add(new clsParametro("@CAI", m_CAI));
                lst.Add(new clsParametro("@Establecimentp", m_Establecimiento));
                lst.Add(new clsParametro("@PuntoEmision", m_Punto_Emision));
                lst.Add(new clsParametro("@FechaAuto", m_Fecha_Aut));
                lst.Add(new clsParametro("@FechaLimite", m_Fecha_Limite));
                lst.Add(new clsParametro("@RangoInicial", m_Rango_Aut_Inicial));
                lst.Add(new clsParametro("@RangoFinal", m_Rango_Aut_Final));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_SAR", ref lst);
                Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}
