<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textCiEliminar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminarPersona = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textCiEliminar
        '
        Me.textCiEliminar.Location = New System.Drawing.Point(101, 133)
        Me.textCiEliminar.Name = "textCiEliminar"
        Me.textCiEliminar.Size = New System.Drawing.Size(136, 20)
        Me.textCiEliminar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Baja Persona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cedula"
        '
        'btnEliminarPersona
        '
        Me.btnEliminarPersona.Location = New System.Drawing.Point(122, 183)
        Me.btnEliminarPersona.Name = "btnEliminarPersona"
        Me.btnEliminarPersona.Size = New System.Drawing.Size(95, 44)
        Me.btnEliminarPersona.TabIndex = 3
        Me.btnEliminarPersona.Text = "Eliminar"
        Me.btnEliminarPersona.UseVisualStyleBackColor = True
        '
        'FormBajaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 306)
        Me.Controls.Add(Me.btnEliminarPersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textCiEliminar)
        Me.Name = "FormBajaPersona"
        Me.Text = "FormBajaPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textCiEliminar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarPersona As Button
End Class
