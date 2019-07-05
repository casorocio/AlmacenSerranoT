Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedorServicioClass
    Inherits Conexion

    Dim Id_ As Integer
    Dim Tipo_ As String
    Dim Compania_ As String
    Dim Apellido_ As String
    Dim Nombre_ As String
    Dim Email_ As String
    Dim Telefono_ As String
    Dim Direccion_ As String
    Dim Tipodepago_ As String
    Dim Nota_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property


    Public Property Compania() As String
        Get
            Return Compania_
        End Get
        Set(ByVal value As String)
            Compania_ = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Tipo_
        End Get
        Set(ByVal value As String)
            Tipo_ = value
        End Set
    End Property

    Public Property Apellido() As String
        Get
            Return Apellido_
        End Get
        Set(ByVal value As String)
            Apellido_ = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return Email_
        End Get
        Set(ByVal value As String)
            Email_ = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property
    Public Property Tipodepago() As String
        Get
            Return Tipodepago_
        End Get
        Set(ByVal value As String)
            Tipodepago_ = value
        End Set
    End Property

    Public Property Nota() As String
        Get
            Return Nota_
        End Get
        Set(ByVal value As String)
            Nota_ = value
        End Set
    End Property

    Dim conex As New Conexion

    Public Sub LLenarTabla(ByVal tabla As DataGridView)
        'Dim strComando As String = "select * from dbo.Orders"
        Dim sqlComando As New SqlCommand("ProveedorServicioLLenarTabla", sqlconexion)
        Abrir()
        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqldatatable As New DataTable
        sqlAdapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        cerrar()

    End Sub

    Public Sub Modificar(ByVal ProveedorServicio As ProveedorServicioClass)

        Dim conex As New Conexion

        Dim sqlComando As New SqlCommand("ProveedorServicioModificar", conex.sqlconexion)
        conex.Abrir()

        sqlComando.CommandType = CommandType.StoredProcedure


        sqlComando.Parameters.AddWithValue("@Compania", ProveedorServicio.Compania)
        sqlComando.Parameters.AddWithValue("@Tipo", ProveedorServicio.Tipo)
        sqlComando.Parameters.AddWithValue("@Apellido", ProveedorServicio.Apellido)
        sqlComando.Parameters.AddWithValue("@Nombre", ProveedorServicio.Nombre)
        sqlComando.Parameters.AddWithValue("@Email", ProveedorServicio.Email)
        sqlComando.Parameters.AddWithValue("@Telefono", ProveedorServicio.Telefono)
        sqlComando.Parameters.AddWithValue("@Direccion", ProveedorServicio.Direccion)
        sqlComando.Parameters.AddWithValue("@Tipodepago", ProveedorServicio.Tipodepago)
        sqlComando.Parameters.AddWithValue("@Nota", ProveedorServicio.Nota)
        sqlComando.Parameters.AddWithValue("@Id", ProveedorServicio.Id)
        sqlComando.ExecuteNonQuery()


        conex.cerrar()
    End Sub
    Public Sub Agregar(ByVal ProveedorServicio As ProveedorServicioClass)
        Dim conex As New Conexion
        conex.Abrir()

        Dim sqlcomando As New SqlCommand("ProveedorServicioAgregar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure

        sqlcomando.Parameters.AddWithValue("@Compania", ProveedorServicio.Compania)
        sqlcomando.Parameters.AddWithValue("@Tipo", ProveedorServicio.Tipo)
        sqlcomando.Parameters.AddWithValue("@Apellido", ProveedorServicio.Apellido)
        sqlcomando.Parameters.AddWithValue("@Nombre", ProveedorServicio.Nombre)
        sqlcomando.Parameters.AddWithValue("@Email", ProveedorServicio.Email)
        sqlcomando.Parameters.AddWithValue("@Telefono", ProveedorServicio.Telefono)
        sqlcomando.Parameters.AddWithValue("@Direccion", ProveedorServicio.Direccion)
        sqlcomando.Parameters.AddWithValue("@Tipodepago", ProveedorServicio.Tipodepago)
        sqlcomando.Parameters.AddWithValue("@Nota", ProveedorServicio.Nota)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()

    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim conex As New Conexion
        conex.Abrir()
        Dim sqlcomando As New SqlCommand("ProveedorServicioBorrar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        sqlcomando.Parameters.AddWithValue("@Id", Id)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()
    End Sub

End Class
