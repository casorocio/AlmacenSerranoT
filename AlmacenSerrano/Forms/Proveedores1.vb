Imports System.Data
Imports System.Data.SqlClient
Public Class Proveedores1
    Dim Proveedor As New ProveedoresClass
    Dim conex As New conexion1
    Private Sub Proveedores1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Proveedor.LLenarTabla(DataGridView1)

    End Sub

   
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Proveedores2 As New Proveedores2(Proveedor)
        Proveedores2.ShowDialog()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Proveedor.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Proveedor.Compania = IIf(IsDBNull(DataGridView1.Item("Compania", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Compania", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Categoria = IIf(IsDBNull(DataGridView1.Item("Categoria", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Categoria", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Apellido = IIf(IsDBNull(DataGridView1.Item("Apellido", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Apellido", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Nombre = IIf(IsDBNull(DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Email = IIf(IsDBNull(DataGridView1.Item("Email", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Email", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Telefono = IIf(IsDBNull(DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Direccion = IIf(IsDBNull(DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Terminosdepago = IIf(IsDBNull(DataGridView1.Item("Terminosdepago", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Terminosdepago", DataGridView1.CurrentRow.Index).Value))
        Proveedor.Notas = IIf(IsDBNull(DataGridView1.Item("Notas", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Notas", DataGridView1.CurrentRow.Index).Value))

        Dim Proveedores2 As New Proveedores2(Proveedor)
        Proveedores2.ShowDialog()
        Proveedor.LLenarTabla(DataGridView1)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Proveedor.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿Esta seguro de eliminar?" & Proveedor.Id.ToString & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            Proveedor.Borrar(Proveedor.Id)
            Proveedor.LLenarTabla(DataGridView1)
        End If
    End Sub


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub
End Class