Imports System.Data
Imports System.Data.SqlClient

Public Class ClientesGrid
    Dim cli As New Clientes
    Dim conex As New Conexion

    Private Sub ClientesGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cli.LlenarTabla(DataGridView1)

    End Sub

    Private Sub Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Agregar.Click
        Dim ClientesForm As New ClientesForm()
        ClientesForm.ShowDialog()
        cli.LlenarTabla(DataGridView1)

    End Sub

    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        cli.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        cli.Apellido = DataGridView1.Item("Apellido", DataGridView1.CurrentRow.Index).Value
        cli.Nombre = DataGridView1.Item("Nombre", DataGridView1.CurrentRow.Index).Value
        cli.Email = DataGridView1.Item("Email", DataGridView1.CurrentRow.Index).Value
        cli.Telefono = DataGridView1.Item("Telefono", DataGridView1.CurrentRow.Index).Value
        cli.Dirección = DataGridView1.Item("Dirección", DataGridView1.CurrentRow.Index).Value
        cli.Negocio = DataGridView1.Item("Negocio", DataGridView1.CurrentRow.Index).Value

        Dim ClientesForm As New ClientesForm(cli)
        ClientesForm.ShowDialog()
        cli.LlenarTabla(DataGridView1)

    End Sub


    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click
        cli.Id = DataGridView1.Item("Id", DataGridView1.CurrentRow.Index).Value
        Dim respuesta As DialogResult = MessageBox.Show("¿Esta seguro de eliminar?" & cli.Id.ToString & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If respuesta = Windows.Forms.DialogResult.OK Then
            cli.Borrar(cli.Id)
            cli.LlenarTabla(DataGridView1)
        End If
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()

    End Sub
End Class