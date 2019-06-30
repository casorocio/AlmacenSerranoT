Imports System.Data
Imports System.Data.SqlClient
Public Class Productos1

    Dim Productos As New ProductosClass
    Dim conex As New Conexion1


    Private Sub Productos1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Productos.LLenarTabla(DataGridView1)

    End Sub



    'Public Sub LLenarTabla(ByVal tabla As DataGridView)
    '    'Dim strComando As String = "select * from dbo.Suppliers"
    '    Dim sqlComando As New SqlCommand("ProductosLLenarTabla", conex.sqlconexion)
    '    conex.Abrir()
    '    Dim sqlAdapter As New SqlDataAdapter(sqlComando)
    '    Dim sqldatatable As New DataTable
    '    sqlAdapter.Fill(sqldatatable)
    '    tabla.DataSource = sqldatatable
    '    conex.cerrar()

    'End Sub



    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Productos.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Productos.Idcategoria = DataGridView1.Item("Idcategoria", DataGridView1.CurrentRow.Index).Value
        Productos.Producto = DataGridView1.Item("Producto", DataGridView1.CurrentRow.Index).Value
        Productos.Descripcion = DataGridView1.Item("Descripcion", DataGridView1.CurrentRow.Index).Value
        Productos.Cantidad = DataGridView1.Item("Cantidad", DataGridView1.CurrentRow.Index).Value
        Productos.Preciounitcompra = DataGridView1.Item("Preciounitcompra", DataGridView1.CurrentRow.Index).Value
        Productos.Preciounitventa = DataGridView1.Item("Preciounitventa", DataGridView1.CurrentRow.Index).Value
        Productos.Preciounitmay = DataGridView1.Item("Preciounitmay", DataGridView1.CurrentRow.Index).Value
        Productos.Iva = DataGridView1.Item("Iva", DataGridView1.CurrentRow.Index).Value
        Productos.Cantmininv = DataGridView1.Item("Cantmininv", DataGridView1.CurrentRow.Index).Value
        Productos.Idproveedor = DataGridView1.Item("Idproveedor", DataGridView1.CurrentRow.Index).Value
        Dim Productos2 As New Productos2()
        Productos2.ShowDialog()
        Productos.LLenarTabla(DataGridView1)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Productos2 As New Productos2
        Productos2.ShowDialog()
    End Sub



    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Productos.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿Esta seguro de eliminar?" & Productos.Id.ToString & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            Productos.Borrar(Productos.Id)
            Productos.LLenarTabla(DataGridView1)
        End If
    End Sub

    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub
End Class