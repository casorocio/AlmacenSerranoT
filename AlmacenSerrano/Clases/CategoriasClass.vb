Imports System.Data
Imports System.Data.SqlClient
Public Class CategoriasClass
    Inherits Conexion1
    Dim Id_ As Integer
    Dim Tipo_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
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

    'Dim Supplier As New suppliers
    Dim conex As New Conexion1

    Public Sub LLenarTabla(ByVal tabla As DataGridView)
        'Dim strComando As String = "select * from dbo.Orders"
        Dim sqlComando As New SqlCommand("CategoriaLLenarTabla", conex.sqlconexion)
        conex.Abrir()
        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqldatatable As New DataTable
        sqlAdapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        conex.cerrar()

    End Sub
    Public Sub Borrar(ByVal SuppliersID As Integer)
        Dim conex As New Conexion1
        conex.Abrir()
        Dim sqlcomando As New SqlCommand("CategoriaBorrar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure
        sqlcomando.Parameters.AddWithValue("@ID", Id)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()

    End Sub
    Public Sub Agregar(ByVal Categoria As CategoriasClass)
        Dim conex As New Conexion1
        conex.Abrir()

        Dim sqlcomando As New SqlCommand("CategoriaAgregar", conex.sqlconexion)
        sqlcomando.CommandType = CommandType.StoredProcedure

        sqlcomando.Parameters.AddWithValue("Id", Categoria.Id)
        sqlcomando.Parameters.AddWithValue("Tipo", Categoria.Tipo)
        sqlcomando.ExecuteNonQuery()
        conex.cerrar()
    End Sub

    Public Sub Modificar(ByVal Categoria As CategoriasClass)

        Dim conex As New Conexion1

        Dim sqlComando As New SqlCommand("CategoriaModificar", conex.sqlconexion)
        conex.Abrir()

        sqlComando.CommandType = CommandType.StoredProcedure
        'sqlComando.Parameters.AddWithValue("@Id, Categoria.Id)
        sqlComando.Parameters.AddWithValue("@Tipo", Categoria.Tipo)


        sqlComando.ExecuteNonQuery()




        conex.cerrar()

    End Sub

    Public Sub CargarCombo(ByVal combo As ComboBox)
        Dim conex As New conexion1
        conex.Abrir()

        Dim objcomando As New SqlCommand("CategoriaCombo", sqlconexion)
        objcomando.CommandType = CommandType.StoredProcedure
        Dim objdatatable As New Data.DataTable
        Dim objdataadapter As New SqlDataAdapter(objcomando)
        objdataadapter.Fill(objdatatable)

        With combo
            .DataSource = objdatatable
            .DisplayMember = "Tipo"
            .ValueMember = "Id"

        End With

        conex.cerrar()


    End Sub
End Class
