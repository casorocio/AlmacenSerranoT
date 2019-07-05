Public Class FormularioPrincipal

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        ClientesGrid.Show()

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Productos1.Show()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem.Click
        Categorias1.Show()
    End Sub

    Private Sub ProveedorServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorServicioToolStripMenuItem.Click
        ProveedorServicio1.Show()
    End Sub
End Class