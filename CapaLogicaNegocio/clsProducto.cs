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
    public class clsProducto
    {
        private clsManejador M = new clsManejador();

        private Int32 m_IdProducto;
        private String m_Cod_Barra;
        private String m_Nombre_Producto;
        private Int32 m_Unidad_Existencia;
        private Int32 m_Existencia_Min;
        private Decimal m_Precio_Costo;
        private Decimal m_Precio_Venta1;
        private Decimal m_Precio_Venta2;
        private Decimal m_Precio_Venta3;
        private Decimal m_Precio_Venta4;
        private Boolean m_ISV;
        private DateTime m_Fecha_Ingreso;
        private DateTime m_Fecha_Caduc;
        private String m_Imagen;
        private Int32 m_IdProveedor;
        private Int32 m_IdCategoria;

        public Int32 IdProducto
        {
            get { return m_IdProducto; }
            set{m_IdProducto=value;}
        }

        public String Cod_Barra{
            get { return m_Cod_Barra; }
            set { m_Cod_Barra = value; }
        }

        public String NombreProducto
        {
            get { return m_Nombre_Producto; }
            set { m_Nombre_Producto = value; }
        }

        public Int32 Unidad_Exis
        {
            get { return m_Unidad_Existencia; }
            set { m_Unidad_Existencia = value; }
        }

        public Int32 Existencia_Min
        {
            get { return m_Existencia_Min; }
            set { m_Existencia_Min = value; }
        }

        public Decimal Precio_Costo
        {
            get { return m_Precio_Costo; }
            set { m_Precio_Costo = value; }
        }

        public Decimal Precio_Venta1
        {
            get { return m_Precio_Venta1; }
            set { m_Precio_Venta1 = value; }
        }

        public Decimal Precio_Venta2
        {
            get { return m_Precio_Venta2; }
            set { m_Precio_Venta2 = value; }
        }

        public Decimal Precio_Venta3
        {
            get { return m_Precio_Venta3; }
            set { m_Precio_Venta3 = value; }
        }

        public Decimal Precio_Venta4
        {
            get { return m_Precio_Venta4; }
            set { m_Precio_Venta4 = value; }
        }

        public Boolean ISV
        {
            get { return m_ISV; }
            set { m_ISV = value; }
        }

        public DateTime Fecha_Ingreso
        {
            get { return m_Fecha_Ingreso; }
            set { m_Fecha_Ingreso  = value; }
        }

        public DateTime Fecha_Caduc
        {
            get { return m_Fecha_Caduc; }
            set { m_Fecha_Caduc = value; }
        }

        public String Imagen
        {
            get { return m_Imagen; }
            set { m_Imagen = value; }
        }

        public Int32 IdProveedor
        {
            get { return m_IdProveedor; }
            set { m_IdProveedor = value; }
        }
        public Int32 IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }


        public DataTable MostrarProductos()
        {
            return M.Listado("SP_Mostrar_Productos", null);
        }

        public DataTable BuscarProducto(String objDatos) {
            DataTable dt = new DataTable();
            List<clsParametro> lst = new List<clsParametro>();
            try
            {
                lst.Add(new clsParametro("@V", objDatos));
                dt = M.Listado("SP_Buscar_Producto", lst);
            }
            catch (Exception ex)
            {    
                throw ex;
            }
            return dt;
        }

        public String RegistrarProductos()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@Cod_Barra", m_Cod_Barra));
                lst.Add(new clsParametro("@Nombre_Producto", m_Nombre_Producto));
                lst.Add(new clsParametro("@Unidad_Existencia", m_Unidad_Existencia));
                lst.Add(new clsParametro("@Existencia_Min", m_Existencia_Min));
                lst.Add(new clsParametro("@Precio_Costo", m_Precio_Costo));
                lst.Add(new clsParametro("@Precio_Venta1", m_Precio_Venta1));
                lst.Add(new clsParametro("@Precio_Venta2", m_Precio_Venta2));
                lst.Add(new clsParametro("@Precio_Venta3", m_Precio_Venta3));
                lst.Add(new clsParametro("@Precio_Venta4", m_Precio_Venta4));
                lst.Add(new clsParametro("@ISV", m_ISV));
                lst.Add(new clsParametro("@Fecha_Ingreso", m_Fecha_Ingreso));
                lst.Add(new clsParametro("@Fecha_Caduc", m_Fecha_Caduc));
                lst.Add(new clsParametro("@Imagen", m_Imagen));
                lst.Add(new clsParametro("@IdProveedor", m_IdProveedor));
                lst.Add(new clsParametro("@IdCategoria", m_IdCategoria));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Agregar_Producto", ref lst);
                Mensaje = lst[15].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }

        public String ActualizarProductos()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";

            try
            {
                lst.Add(new clsParametro("@IdProducto", m_IdProducto));
                lst.Add(new clsParametro("@Cod_Barra", m_Cod_Barra));
                lst.Add(new clsParametro("@Nombre_Producto", m_Nombre_Producto));
                lst.Add(new clsParametro("@Unidad_Existencia", m_Unidad_Existencia));
                lst.Add(new clsParametro("@Existencia_Min", m_Existencia_Min));
                lst.Add(new clsParametro("@Precio_Costo", m_Precio_Costo));
                lst.Add(new clsParametro("@Precio_Venta1", m_Precio_Venta1));
                lst.Add(new clsParametro("@Precio_Venta2", m_Precio_Venta2));
                lst.Add(new clsParametro("@Precio_Venta3", m_Precio_Venta3));
                lst.Add(new clsParametro("@Precio_Venta4", m_Precio_Venta4));
                lst.Add(new clsParametro("@ISV", m_ISV));
                lst.Add(new clsParametro("@Fecha_Ingreso", m_Fecha_Ingreso));
                lst.Add(new clsParametro("@Fecha_Caduc", m_Fecha_Caduc));
                lst.Add(new clsParametro("@Imagen", m_Imagen));
                lst.Add(new clsParametro("@IdProveedor", m_IdProveedor));
                lst.Add(new clsParametro("@IdCategoria", m_IdCategoria));
                lst.Add(new clsParametro("@M", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                M.EjecutarSP("SP_Editar_Producto", ref lst);
                Mensaje = lst[15].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Mensaje;
        }
    }
}