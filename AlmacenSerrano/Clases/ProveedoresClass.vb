Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedoresClass
    Inherits conexion1

    Dim Id_ As Integer
    Dim Compania_ As String
    Dim Categoria_ As String
    Dim Apellido_ As String
    Dim Nombre_ As String
    Dim Email_ As String
    Dim Telefono_ As String
    Dim Direccion_ As String
    Dim Terminosdepago_ As String
    Dim Notas_ As String

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

    Public Property Categoria() As String
        Get
            Return Categoria_
        End Get
        Set(ByVal value As String)
            Categoria_ = value
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
    Public Property Terminosdepago() As String
        Get
            Return Terminosdepago_
        End Get
        Set(ByVal value As String)
            Terminosdepago_ = value
        End Set
    End Property

    Public Property Notas() As String
        Get
            Return Notas_
        End Get
        Set(ByVal value As String)
            Notas_ = value
        End Set
    End Property

    Dim conex As New conexion1

    Public Sub LLenarTabla(ByVal tabla As DataGridView)
        'Dim strComando As String = "select * from dbo.Orders"
        Dim sqlComando As New SqlCommand("ProveedoresLLenarTabla", sqlconexion)
        Abrir()
        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqldatatable As New DataTable
        sqlAdapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        cerrar()

    End Sub

    Public Sub Modificar(ByVal Proveedores As ProveedoresClass)

        Dim conex As New conexion1

        Dim sqlComando As New SqlCommand("ProveedoresModificar", conex.sqlconexion)
        conex.Abrir()

        sqlComando.CommandType = CommandType.StoredProcedure

        sqlComando.Parameters.AddWithValue("@Id", Proveedores.Id)
        sqlComando.Parameters.AddWithValue("@Compania", Proveedores.Compania)
        sqlComando.Parameters.AddWithValue("@Categoria", Proveedores.Categoria)
        sqlComando.Parameters.AddWithValue("@Apellido", Proveedores.Apellido)
        sqlComando.Parameters.AddWithValue("@Nombre", Proveedores.Nombre)
        sqlComando.Parameters.AddWithValue("@Email", Proveedores.Email)
        sqlComando.Parameters.AddWithValue("@Telefono", Proveedores.Telefono)
        sqlComando.Parameters.AddWithValue("@Direccion", Proveedores.Direccion)
        sqlComando.Parameters.AddWithValue("@Terminosdepago", Proveedores.Terminosdepago)
        sqlComando.Parameters.AddWithValue("@Notas", Proveedores.Notas)

        sqlComando.ExecuteNonQuery()


        conex.cerrar()

    End Sub

    Public Sub Agregar(ByVal Proveedores As ProveedoresClass)
        Dim conex As New conexion1
        conex.Abrir()

        Dim sqlcomando As New SqlCommand("ProveedoresAgregar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure

        sqlcomando.Parameters.AddWithValue("@Id", Proveedores.Id)
        sqlcomando.Parameters.AddWithValue("@Compania", Proveedores.Compania)
        sqlcomando.Parameters.AddWithValue("@Categoria", Proveedores.Categoria)
        sqlcomando.Parameters.AddWithValue("@Apellido", Proveedores.Apellido)
        sqlcomando.Parameters.AddWithValue("@Nombre", Proveedores.Nombre)
        sqlcomando.Parameters.AddWithValue("@Email", Proveedores.Email)
        sqlcomando.Parameters.AddWithValue("@Telefono", Proveedores.Telefono)
        sqlcomando.Parameters.AddWithValue("@Direccion", Proveedores.Direccion)
        sqlcomando.Parameters.AddWithValue("@Terminosdepago", Proveedores.Terminosdepago)
        sqlcomando.Parameters.AddWithValue("@Notas", Proveedores.Notas)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()

    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim conex As New Conexion1
        conex.Abrir()
        Dim sqlcomando As New SqlCommand("ProveedoresBorrar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        sqlcomando.Parameters.AddWithValue("@Id", Id)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()
    End Sub

    Public Sub CargarCombo(ByVal combo As ComboBox)
        Dim conex As New conexion1
        conex.Abrir()

        Dim objcomando As New SqlCommand("ProveedoresCombo", sqlconexion)
        objcomando.CommandType = CommandType.StoredProcedure
        Dim objdatatable As New Data.DataTable
        Dim objdataadapter As New SqlDataAdapter(objcomando)
        objdataadapter.Fill(objdatatable)

        With combo
            .DataSource = objdatatable
            .DisplayMember = "Compania"
            .ValueMember = "Id"

        End With

        conex.cerrar()


    End Sub


End Class
