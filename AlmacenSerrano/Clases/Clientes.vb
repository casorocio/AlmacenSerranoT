Imports System.Data
Imports System.Data.SqlClient

Public Class Clientes
    Inherits Conexion
    Dim Id_ As Integer
    Dim Apellido_ As String
    Dim Nombre_ As String
    Dim Email_ As String
    Dim Telefono_ As String
    Dim Dirección_ As String
    Dim Negocio_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
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

    Public Property Dirección() As String
        Get
            Return Dirección_
        End Get
        Set(ByVal value As String)
            Dirección_ = value
        End Set
    End Property

    Public Property Negocio() As String
        Get
            Return Negocio_
        End Get
        Set(ByVal value As String)
            Negocio_ = value
        End Set
    End Property

    Public Sub LlenarTabla(ByVal tabla As DataGridView)
        abrir()
        Dim sqlcomando As New SqlCommand("ClienteLlenarTabla", sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        Dim sqladapter As New SqlDataAdapter(sqlcomando)
        Dim sqldatatable As New DataTable
        sqladapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        tabla.Columns("Id").Width = 50
        'tabla.Columns("ShipCity").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cerrar()
    End Sub

    Public Sub Modificar(ByVal cli As Clientes)
        'Dim conex As New Conexion
        abrir()

        Dim sqlcomando As New SqlCommand("ClientesModificar", sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure


        sqlcomando.Parameters.AddWithValue("@Apellido", cli.Apellido)
        sqlcomando.Parameters.AddWithValue("@Nombre", cli.Nombre)
        sqlcomando.Parameters.AddWithValue("@Email", cli.Email)
        sqlcomando.Parameters.AddWithValue("@Telefono", cli.Telefono)
        sqlcomando.Parameters.AddWithValue("@Dirección", cli.Dirección)
        sqlcomando.Parameters.AddWithValue("@Negocio", cli.Negocio)
        sqlcomando.Parameters.AddWithValue("@Id", cli.Id)


        sqlcomando.ExecuteNonQuery()
        cerrar()

    End Sub

    Public Sub Agregar(ByVal cli As Clientes)
        'Dim conex As New Conexion
        abrir()

        Dim sqlcomando As New SqlCommand("ClientesAgregar", sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure


        sqlcomando.Parameters.AddWithValue("@Apellido", cli.Apellido)
        sqlcomando.Parameters.AddWithValue("@Nombre", cli.Nombre)
        sqlcomando.Parameters.AddWithValue("@Email", cli.Email)
        sqlcomando.Parameters.AddWithValue("@Telefono", cli.Telefono)
        sqlcomando.Parameters.AddWithValue("@Dirección", cli.Dirección)
        sqlcomando.Parameters.AddWithValue("@Negocio", cli.Negocio)
        sqlcomando.ExecuteNonQuery()
        cerrar()
    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        'Dim conex As New Conexion
        abrir()
        Dim sqlcomando As New SqlCommand("ClientesBorrar", sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        sqlcomando.Parameters.AddWithValue("@Id", Id)
        Try
            sqlcomando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se puede borrar el registro, verifique...!")
        End Try
        cerrar()

    End Sub
End Class
