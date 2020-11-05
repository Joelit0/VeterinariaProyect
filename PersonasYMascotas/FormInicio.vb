Public Class FormInicio
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked


    End Sub

    Private Sub FormPersonasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FormPersonasToolStripMenuItem2.Click
        FormPersonas.ShowDialog()
    End Sub

    Private Sub FormMascotasToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FormMascotasToolStripMenuItem2.Click
        FormMascotas.ShowDialog()
    End Sub
End Class