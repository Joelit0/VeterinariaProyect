Public Class FormListarPersona
    Dim ListarPersonas As New List(Of Persona)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logica As New logicaPersona
        Dim personaListada As New Persona
        ListarPersonas = logica.ListarPersona()

        For Each Persona As Persona In ListarPersonas
            ListViewListarPersona.Items.Add(Persona.Nombre)
        Next
    End Sub
End Class
