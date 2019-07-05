Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedorServicio1
    Dim ProveedorServicio As New ProveedorServicioClass
    Dim conex As New Conexion
    Private Sub ProveedorServicio1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProveedorServicio.LLenarTabla(DataGridView1)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim ProveedorServicio2 As New ProveedorServicio2(ProveedorServicio)
        ProveedorServicio2.ShowDialog()
        ProveedorServicio.LLenarTabla(DataGridView1)
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        ProveedorServicio.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        ProveedorServicio.Compania = IIf(IsDBNull(DataGridView1.Item("Compania", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Compania", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Tipo = IIf(IsDBNull(DataGridView1.Item("Tipo", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Tipo", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Apellido = IIf(IsDBNull(DataGridView1.Item("Apellido", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Apellido", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Nombre = IIf(IsDBNull(DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Email = IIf(IsDBNull(DataGridView1.Item("Email", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Email", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Telefono = IIf(IsDBNull(DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Direccion = IIf(IsDBNull(DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Direccion", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Tipodepago = IIf(IsDBNull(DataGridView1.Item("Tipodepago", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Tipodepago", DataGridView1.CurrentRow.Index).Value))
        ProveedorServicio.Nota = IIf(IsDBNull(DataGridView1.Item("Nota", DataGridView1.CurrentRow.Index).Value), "", (DataGridView1.Item("Nota", DataGridView1.CurrentRow.Index).Value))

        Dim ProveedorServicio2 As New ProveedorServicio2(ProveedorServicio)
        ProveedorServicio2.ShowDialog()
        ProveedorServicio.LLenarTabla(DataGridView1)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ProveedorServicio.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿Esta seguro de eliminar?" & ProveedorServicio.Id.ToString & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            ProveedorServicio.Borrar(ProveedorServicio.Id)
            ProveedorServicio.LLenarTabla(DataGridView1)
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub
End Class