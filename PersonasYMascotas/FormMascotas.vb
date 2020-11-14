Public Class FormMascotas
    Private Sub btnCapturarMascotas_Click(sender As Object, e As EventArgs) Handles btnAgregarMascota.Click
        Dim ci As Integer
        Dim nombre As String
        Dim anioNacimiento As Integer

        ci = Convert.ToInt32(textCi.Text)
        nombre = textNombreM.Text
        anioNacimiento = Convert.ToInt32(textAnioNaci.Text)

        Try
            Dim newMascota As New Mascota()
            newMascota.Ci = ci
            newMascota.Nombre = nombre
            newMascota.AnioNacimiento = anioNacimiento

            Dim logica As New logicaMascota
            logica.altaMascota(newMascota)

        Catch ex As Exception
            MsgBox("Ah ocurrido un error: " + ex.Message)
        End Try
    End Sub
End Class