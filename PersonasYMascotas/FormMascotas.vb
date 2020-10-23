Public Class FormMascotas
    Private Sub labelPersonas_Click(sender As Object, e As EventArgs) Handles labelMascotas.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles LabelNombreM.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LabeId.Click

    End Sub

    Private Sub textTelefono_TextChanged(sender As Object, e As EventArgs) Handles textDate.TextChanged

    End Sub

    Private Sub textNombre_TextChanged(sender As Object, e As EventArgs) Handles textNombreM.TextChanged

    End Sub

    Private Sub textCi_TextChanged(sender As Object, e As EventArgs) Handles textId.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles LabelDateM.Click

    End Sub

    Private Sub FormMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCapturarMascotas_Click(sender As Object, e As EventArgs) Handles btnCapturarMascotas.Click
        Dim id As Integer
        Dim nombre As String
        Dim fechaNacimiento As String

        id = textId.Text
        nombre = textNombreM.Text
        fechaNacimiento = textDate.Text

        verResultadoM.Text = id + " | " + nombre + " | " + fechaNacimiento

    End Sub
End Class