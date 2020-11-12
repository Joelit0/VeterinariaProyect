Public Class FormPersonas

    Private ListaTelefono As New List(Of Integer)

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles labelPersonas.Click

    End Sub

    Private Sub CiPersonaInput_TextChanged(sender As Object, e As EventArgs) Handles textCi.TextChanged

    End Sub


    Public Sub btnCapturarPersonas_Click(sender As Object, e As EventArgs) Handles btnCapturarPersonas.Click
        Dim ci As Integer
        Dim nombre As String
        Dim telefono As Integer
        Dim direccion As String

        ci = Convert.ToInt32(textCi.Text)
        nombre = textNombre.Text
        direccion = textDireccion.Text

        Try
            Dim newPersona As New Persona()
            newPersona.Ci = ci
            newPersona.Nombre = nombre
            newPersona.Direccion = direccion
            newPersona.ListaTelefono = ListaTelefono

            Dim logica As New logicaPersona
            logica.altaPersona(newPersona)

        Catch ex As Exception
            MsgBox("Ah ocurrido un error: " + ex.Message)
        End Try


    End Sub

    Private Sub labelVerResultado_Click(sender As Object, e As EventArgs) Handles labelVerResultado.Click


    End Sub

    Private Sub FormPyM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Telefono_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub listaTelefonos_SelectedIndexChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        listViewTelefonos.Clear()

        Dim cedula As Integer
        cedula = textCi.Text

        Dim personaNueva As New Persona
        Dim logica As New logicaPersona
        personaNueva = logica.buscarPersona(cedula)
        personaNueva.ListaTelefono = logica.buscarTelefono(cedula)


        If IsNothing(personaNueva) Then
        Else
            textNombre.Text = personaNueva.Nombre
            textDireccion.Text = personaNueva.Direccion

            For index As Integer = 0 To personaNueva.ListaTelefono.Count - 1
                listViewTelefonos.Items.Add(personaNueva.ListaTelefono(index))
            Next
        End If
    End Sub

    Private Sub addTelefonos_Click(sender As Object, e As EventArgs) Handles addTelefonos.Click
        Dim telefono As Integer
        telefono = Convert.ToInt32(textBoxTelefono.Text)

        listViewTelefonos.Items.Add(telefono)
        ListaTelefono.Add(telefono)
        textBoxTelefono.Text = ""
    End Sub

    Private Sub listViewTelefonos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listViewTelefonos.SelectedIndexChanged
        Try
            Dim telefonoEscrito As Integer
            Dim telefonoEliminado As Integer

            telefonoEscrito = listViewTelefonos.SelectedItems(0).SubItems(0).Text
            telefonoEliminado = Convert.ToInt32(telefonoEscrito)

            Dim iterador As Integer = 0

            While iterador < ListaTelefono.Count
                If telefonoEliminado = ListaTelefono.Item(iterador) Then
                    ListaTelefono.Remove(telefonoEliminado)
                    iterador = ListaTelefono.Count
                End If
                iterador = iterador + 1
            End While

            listViewTelefonos.Clear()
            iterador = 0

            While iterador < ListaTelefono.Count
                listViewTelefonos.Items.Add(ListaTelefono.Item(iterador))
            End While
        Catch ex As Exception
            MsgBox("Ah ocurrido un error: " + ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textBoxTelefono.TextChanged

    End Sub
End Class
