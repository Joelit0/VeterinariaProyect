Public Class FormListarMascota
    Dim ListarMascotas As New List(Of Mascota)

    Private Sub btnListarMascotas_Click(sender As Object, e As EventArgs) Handles btnListarMascotas.Click
        Dim logica As New logicaMascota
        Dim mascotaListada As New Mascota
        ListarMascotas = logica.ListarMascota()

        For Each Mascota As Mascota In ListarMascotas
            ListViewListarMascota.Items.Add(Mascota.Nombre)
        Next
    End Sub
End Class