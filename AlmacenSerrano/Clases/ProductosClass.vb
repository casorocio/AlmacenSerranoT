Imports System.Data
Imports System.Data.SqlClient
Public Class ProductosClass
    Inherits Conexion1

    Dim Id_ As Integer
    Dim Idcategoria_ As Integer
    Dim Producto_ As String
    Dim Descripcion_ As String
    Dim Cantidad_ As Integer
    Dim Preciounitcompra_ As Integer
    Dim Preciounitventa_ As Integer
    Dim Preciounitmay_ As Integer
    Dim Iva_ As Integer
    Dim Cantmininv_ As Integer
    Dim Idproveedor_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property
    Public Property Idcategoria() As Integer
        Get
            Return Idcategoria_
        End Get
        Set(ByVal value As Integer)
            Idcategoria_ = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return Producto_
        End Get
        Set(ByVal value As String)
            Producto_ = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As Integer)
            Cantidad_ = value
        End Set
    End Property

    Public Property Preciounitcompra() As Integer
        Get
            Return Preciounitcompra_
        End Get
        Set(ByVal value As Integer)
            Preciounitcompra_ = value
        End Set
    End Property

    Public Property Preciounitventa() As Integer
        Get
            Return Preciounitventa_
        End Get
        Set(ByVal value As Integer)
            Preciounitventa_ = value
        End Set
    End Property

    Public Property Preciounitmay() As Integer
        Get
            Return Preciounitmay_
        End Get
        Set(ByVal value As Integer)
            Preciounitmay_ = value
        End Set
    End Property

    Public Property Iva() As Integer
        Get
            Return Iva_
        End Get
        Set(ByVal value As Integer)
            Iva_ = value
        End Set
    End Property
    Public Property Cantmininv() As Integer
        Get
            Return Cantmininv_
        End Get
        Set(ByVal value As Integer)
            Cantmininv_ = value
        End Set
    End Property
    Public Property Idproveedor() As Integer
        Get
            Return Idproveedor_
        End Get
        Set(ByVal value As Integer)
            Idproveedor_ = value
        End Set
    End Property


    Dim conex As New Conexion1


    Public Sub LLenarTabla(ByVal tabla As DataGridView)
        'Dim strComando As String = "select * from dbo.Orders"
        Dim sqlComando As New SqlCommand("ProductosLLenarTabla", sqlconexion)
        Abrir()
        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqldatatable As New DataTable
        sqlAdapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        cerrar()

    End Sub
    Public Sub Modificar(ByVal Productos As ProductosClass)

        Dim conex As New Conexion1

        Dim sqlComando As New SqlCommand("ProductosModificar", conex.sqlconexion)
        conex.Abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id", Productos.Id)
        sqlComando.Parameters.AddWithValue("@Producto", Productos.Producto)
        sqlComando.Parameters.AddWithValue("@Descripcion", Productos.Descripcion)
        sqlComando.Parameters.AddWithValue("@Cantidad", Productos.Cantidad)
        sqlComando.Parameters.AddWithValue("@Preciounitcompra", Productos.Preciounitcompra)
        sqlComando.Parameters.AddWithValue("@Preciountventa", Productos.Preciounitventa)
        sqlComando.Parameters.AddWithValue("@Preciounitmay", Productos.Preciounitmay)
        sqlComando.Parameters.AddWithValue("@Iva", Productos.Iva)
        sqlComando.Parameters.AddWithValue("@Cantmininv", Productos.Cantmininv)
        sqlComando.Parameters.AddWithValue("@Idproveedor", Productos.Idproveedor)

        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub
    Public Sub Agregar(ByVal Productos As ProductosClass)
        Dim conex As New Conexion1
        conex.Abrir()

        Dim sqlcomando As New SqlCommand("ProductosAgregar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure

        sqlcomando.Parameters.AddWithValue("@Id", Productos.Id)
        sqlcomando.Parameters.AddWithValue("@Producto", Productos.Producto)
        sqlcomando.Parameters.AddWithValue("@Descripcion", Productos.Descripcion)
        sqlcomando.Parameters.AddWithValue("@Cantidad", Productos.Cantidad)
        sqlcomando.Parameters.AddWithValue("@Preciounitcompra", Productos.Preciounitcompra)
        sqlcomando.Parameters.AddWithValue("@Preciountventa", Productos.Preciounitventa)
        sqlcomando.Parameters.AddWithValue("@Preciounitmay", Productos.Preciounitmay)
        sqlcomando.Parameters.AddWithValue("@Iva", Productos.Iva)
        sqlcomando.Parameters.AddWithValue("@Cantmininv", Productos.Cantmininv)
        sqlcomando.Parameters.AddWithValue("@Idproveedor", Productos.Idproveedor)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()

    End Sub


    Public Sub Borrar(ByVal Id As Integer)
        Dim conex As New Conexion1
        conex.Abrir()
        Dim sqlcomando As New SqlCommand("ProductosBorrar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        sqlcomando.Parameters.AddWithValue("@Id", Id)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()

    End Sub
End Class
