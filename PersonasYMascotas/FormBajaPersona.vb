Public Class FormBajaPersona
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminarPersona.Click
        Dim cedula As Integer
        cedula = textCiEliminar.Text
        Dim logica As New logicaPersona
        logica.bajaPersona(cedula)

        textCiEliminar.Clear()
    End Sub
End Class