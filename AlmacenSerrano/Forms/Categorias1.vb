Imports System.Data
Imports System.Data.SqlClient
Public Class Categorias1
    Dim Categoria As New CategoriasClass
    Dim conex As New Conexion1

   

    Public Sub LLenarTabla(ByVal tabla As DataGridView)
        'Dim strComando As String = "select * from dbo.Suppliers"
        Dim sqlComando As New SqlCommand("CategoriaLLenarTabla", conex.sqlconexion)
        conex.Abrir()
        Dim sqlAdapter As New SqlDataAdapter(sqlComando)
        Dim sqldatatable As New DataTable
        sqlAdapter.Fill(sqldatatable)
        tabla.DataSource = sqldatatable
        conex.cerrar()

    End Sub

   

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Categoria.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Categoria.Tipo = DataGridView1.Item("Tipo", DataGridView1.CurrentRow.Index).Value

        Dim Categorias2 As New Categorias2(Categoria)
        Categorias2.ShowDialog()
        LLenarTabla(DataGridView1)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Categorias2 As New Categorias2(Categoria)
        Categorias2.ShowDialog()
    End Sub

   

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Categoria.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿Esta seguro de eliminar?" & Categoria.Id.ToString & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            Categoria.Borrar(Categoria.Id)
            Categoria.LLenarTabla(DataGridView1)
        End If
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub

    Private Sub Categorias1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LLenarTabla(DataGridView1)
    End Sub
End Class