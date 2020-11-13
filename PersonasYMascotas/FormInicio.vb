Public Class FormInicio
    Private Sub AltaBuscarYModifcarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaBuscarYModifcarToolStripMenuItem.Click
        FormPersonas.ShowDialog()
    End Sub

    Private Sub ListarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarToolStripMenuItem.Click
        FormListarPersona.ShowDialog()
    End Sub

    Private Sub ListarMascotasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMascotasToolStripMenuItem.Click
        FormListarMascota.ShowDialog()
    End Sub

    Private Sub AltaModificarBuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaModificarBuscarToolStripMenuItem.Click
        FormMascotas.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        FormBajaPersona.ShowDialog()
    End Sub
End Class
