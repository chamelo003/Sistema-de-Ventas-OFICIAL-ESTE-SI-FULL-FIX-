--CREATE DATABASE POSIX2

use POSIX2

--CREATE SCHEMA POSIX2

CREATE TABLE DEPARTAMENTO(
	IdDepto int primary key identity,
	Departamento varchar(30) not null
)

CREATE TABLE MUNICIPIO(
	IdMunicipio int primary key identity,
	Municipio varchar(30) not null,
	IdDepto int not null,
	CONSTRAINT [FK_MUNICIPIO_DEPTO] FOREIGN KEY(IdDepto) REFERENCES DEPARTAMENTO (IdDepto)
)

CREATE TABLE SEXO(
	IdSexo int primary key identity,
	Sexo varchar(9) unique not null
)

CREATE TABLE TIPO_PROVEEDOR(
	IdTipoProveedor int primary key identity,
	TipoProveedor varchar(12) unique not null
)

CREATE TABLE PROVEEDORES(
	IdProveedor int primary key identity,
	Nombre varchar(60) not null,
 	Direccion varchar(MAX) not null,
	Telefono char(9) not null, 
	Correo varchar(50) not null,
	RTN char(14) not null, 
	IdMunicipio int not null,
	IdTipoProveedor int not null,
	Contacto varchar(50),
	TelefContacto char(9),
	CONSTRAINT [FK_PROVEEDOR_MUNICIPIO] FOREIGN KEY(IdMunicipio) REFERENCES MUNICIPIO (IdMunicipio),
	CONSTRAINT [FK_PROVEEDOR_TIPO_PROVEEDOR] FOREIGN KEY(IdTipoProveedor) REFERENCES TIPO_PROVEEDOR (IdTipoProveedor)
)

CREATE TABLE CATEGORIAS_PRODUCTOS(
	IdCategoria int primary key identity,
	Categoria varchar(50) unique not null
)


CREATE TABLE PRODUCTOS(
	IdProducto int primary key identity,
	Cod_Barra int null,
	Nombre_Producto varchar(100) not null,
	Unidad_Existencia int not null,
	Existecia_Min int not null,
	Precio_Costo decimal(7,2) not null,
	Precio_Venta1 decimal(7,2) not null,
	Precio_Venta2 decimal(7,2) not null,
	Precio_Venta3 decimal(7,2) not null,
	Precio_Venta4 decimal(7,2) not null,
	ISV bit not null,
	Fecha_Ingreso date not null,
	Fecha_Caduc date null,
	Imagen varchar(MAX) null,
	IdProveedor int not null,
	IdCategoria int not null,
	CONSTRAINT [FK_PRODUCTO_PROVEEDOR] FOREIGN KEY(IdProveedor) REFERENCES PROVEEDORES (IdProveedor),
	CONSTRAINT [FK_PRODUCTO_CATEGORIA] FOREIGN KEY(IdCategoria) REFERENCES CATEGORIAS_PRODUCTOS (IdCategoria),
)

CREATE TABLE CARGOS_EMPLEADOS(
	IdCargo int primary key identity,
	Cargo varchar(60) unique not null
)

CREATE TABLE EMPLEADOS(
	IdEmpleado char(15) primary key,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null,
	Telefono char(9) not null, 
	Celular char(9) not null,
	Direccion varchar(MAX) not null,
	IdMunicipio int not null,
	IdSexo int not null,
	IdCargo int not null,
	CONSTRAINT [FK_EMPLEADOS_MUNICIPIO] FOREIGN KEY(IdMunicipio) REFERENCES MUNICIPIO (IdMunicipio),
	CONSTRAINT [FK_EMPLEADOS_SEXO] FOREIGN KEY(IdSexo) REFERENCES SEXO (IdSexo),
	CONSTRAINT [FK_EMPLEADOS_CARGOS] FOREIGN KEY(IdCargo) REFERENCES CARGOS_EMPLEADOS (IdCargo)
)

CREATE TABLE REFERENCIAS_EMPLEADOS(
	IdRef int primary key identity,
	NombreRef varchar(50) not null,
	ApellidoRef varchar(50) not null,
	TelefonoRef varchar(50) not null,
	CelularRef varchar(50) not null,
	Direccion varchar(MAX) not null
)

CREATE TABLE EMPLEADOS_HAS_REFERENCIAS(
	IdEmpleado char(15),
	IdRef int,
	CONSTRAINT PK_EMPLEADOS_HAS_REFERENCIAS PRIMARY KEY (IdEmpleado,IdRef),
	CONSTRAINT [FK_EMPLEADOS_HAS_REFERENCIAS_EMPLEADOS] FOREIGN KEY(IdEmpleado) REFERENCES EMPLEADOS (IdEmpleado),
	CONSTRAINT [FK_EMPLEADOS_HAS_REFERENCIAS_REFERENCIAS_EMPLEADOS] FOREIGN KEY(IdRef) REFERENCES REFERENCIAS_EMPLEADOS (IdRef)
)

CREATE TABLE TIPOS_USUARIOS(
	IdTipoUsuario int primary key identity,
	TipoUsuario varchar(50) not null
)

CREATE TABLE USUARIOS(
	IdUsuario int primary key identity,
	Usuario varchar(50) not null unique,
	Contrasenha varchar(50) not null,
	Estado bit not null,
	IdEmpleado char(15) not null,
	IdTipoUsuario int not null,
	CONSTRAINT [FK_USUARIOS_EMPLEADOS] FOREIGN KEY(IdEmpleado) REFERENCES EMPLEADOS (IdEmpleado),
	CONSTRAINT [FK_USUARIOS_TIPO_USUARIOS] FOREIGN KEY(IdTipoUsuario) REFERENCES TIPOS_USUARIOS (IdTipoUsuario),
)

CREATE TABLE PISTAS_DE_AUDITORIA(
	IdLog int primary key identity,
	IdUsuario int not null,
	Actividad varchar(MAX) not null,
	Fecha datetime not null,
	CONSTRAINT [FK_AUDITLOGS_USUARIOS] FOREIGN KEY(IdUsuario) REFERENCES USUARIOS (IdUsuario),
)

CREATE TABLE CLIENTES(
	IdCliente int identity primary key,
	RTN char(14),
	Nombres varchar(30) not null,
	Apellidos varchar(30) not null,
	Direccion varchar(MAX),
	Telefono char(9),
	Celular char(9) not null,
	Correo varchar(100) not null,
	IdSexo int not null,
	IdMunicipio int not null,
	CONSTRAINT [FK_CLIENTE_SEXO] FOREIGN KEY (IdSexo) REFERENCES SEXO (IdSexo),
	CONSTRAINT [FK_CLIENTE_MUNICIPIO] FOREIGN KEY (IdMunicipio) REFERENCES MUNICIPIO (IdMunicipio)
)

CREATE TABLE CLIENTES_HAS_PREFFS(
	IdCliente int,
	IdCategoria int,
	Observacion varchar(MAX),
	CONSTRAINT PK_CLIENTES_HAS_PREFFS PRIMARY KEY (IdCliente,IdCategoria),
	CONSTRAINT [FK_CLIENTES_HAS_PREFFS_CLIENTES] FOREIGN KEY(IdCliente) REFERENCES CLIENTES (IdCliente),
	CONSTRAINT [FK_CLIENTES_HAS_PREFFS_PREFERENCIAS] FOREIGN KEY(IdCategoria) REFERENCES CATEGORIAS_PRODUCTOS (IdCategoria)
)

CREATE TABLE DATOS_EMPRESA(
	RTN char(14) primary key,
	Nombre_Empresa varchar(80) not null,
	Correo varchar(50) not null,
	Direccion varchar(50) not null,
	RazonSocial varchar(50) not null,
)

CREATE TABLE SUCURSAL(
	IdSucursal int identity primary key,
	Direccion varchar(300) not null,
	Telefono char(9) not null,
	CasaMatriz char(14) not null,
	CONSTRAINT [FK_SUCURSAL_EMPRESA] FOREIGN KEY(CasaMatriz) REFERENCES DATOS_EMPRESA(RTN)
)

CREATE TABLE SAR(
	IdSAR int identity primary key,
	CAI char(37) not null,
	Establecimiento char(3) not null,
	Punto_Emision char(3) not null,
	Fecha_Aut date not null,
	Fecha_Limite date not null,
	Rango_Aut_Inicial char(8) not null,
	Rango_Aut_Final char(8) not null,
	IdSucursal int not null,
	CONSTRAINT [FK_SAR_SUCURSAL] FOREIGN KEY(IdSucursal) REFERENCES SUCURSAL(IdSucursal)
)

CREATE TABLE TIPO_VENTA(
	IdTipoVenta int identity primary key,
	Tipo_Venta varchar(15)
)

CREATE TABLE VENTAS(
	IdVenta int primary key identity,
	IdEmpleado char(15) not null,
	IdCliente int not null,
	IdTipoVenta int not null,
	Correlativo int not null,
	FechaVenta date not null,
	Subtotal decimal(7,2) not null,
	Descuento decimal(7,2) not null,	
	Impuesto decimal(7,2) not null,
	Total decimal(7,2) not null,
	IdSucursal int not null
	CONSTRAINT [FK_VENTAS_EMPLEADOS] FOREIGN KEY(IdEmpleado) REFERENCES EMPLEADOS (IdEmpleado),
	CONSTRAINT [FK_VENTAS_CLIENTES] FOREIGN KEY(IdCliente) REFERENCES CLIENTES (IdCliente),
	CONSTRAINT [FK_VENTAS_SUCURSAL] FOREIGN KEY(IdSucursal) REFERENCES SUCURSAL(IdSucursal),
	CONSTRAINT [FK_VENTAS_TIPO_VENTAS] FOREIGN KEY(IdTipoVenta) REFERENCES TIPO_VENTA(IdTipoVenta),
)

CREATE TABLE DETALLE_VENTAS(
	IdVenta int,
	IdProducto int,
	Cantidad int not null,
	CONSTRAINT PK_DETALLE_VENTAS PRIMARY KEY (IdVenta,IdProducto),
	CONSTRAINT [FK_DETALLE_VENTAS_VENTAS] FOREIGN KEY(IdVenta) REFERENCES VENTAS (IdVenta),
	CONSTRAINT [FK_DETALLE_VENTAS_PRODUCTO] FOREIGN KEY(IdProducto) REFERENCES PRODUCTOS (IdProducto)
)

----------- INSERCION DE DATOS ------------------
INSERT INTO SEXO VALUES ('FEMENINO')
INSERT INTO SEXO VALUES ('MASCULINO')
INSERT INTO TIPO_PROVEEDOR VALUES ('JURIDICO')
INSERT INTO TIPO_PROVEEDOR VALUES ('NATURAL')
INSERT INTO TIPO_VENTA VALUES ('CREDITO')
INSERT INTO TIPO_VENTA VALUES ('CONTADO')

