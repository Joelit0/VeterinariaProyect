<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMascotas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelDateM = New System.Windows.Forms.Label()
        Me.LabelNombreM = New System.Windows.Forms.Label()
        Me.LabeId = New System.Windows.Forms.Label()
        Me.textNombreM = New System.Windows.Forms.TextBox()
        Me.textCi = New System.Windows.Forms.TextBox()
        Me.btnAgregarMascota = New System.Windows.Forms.Button()
        Me.labelPersonas = New System.Windows.Forms.Label()
        Me.textAnioNaci = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelDateM
        '
        Me.LabelDateM.AutoSize = True
        Me.LabelDateM.Location = New System.Drawing.Point(75, 184)
        Me.LabelDateM.Name = "LabelDateM"
        Me.LabelDateM.Size = New System.Drawing.Size(82, 13)
        Me.LabelDateM.TabIndex = 15
        Me.LabelDateM.Text = "Año Nacimiento"
        '
        'LabelNombreM
        '
        Me.LabelNombreM.AutoSize = True
        Me.LabelNombreM.Location = New System.Drawing.Point(113, 152)
        Me.LabelNombreM.Name = "LabelNombreM"
        Me.LabelNombreM.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreM.TabIndex = 14
        Me.LabelNombreM.Text = "Nombre"
        '
        'LabeId
        '
        Me.LabeId.AutoSize = True
        Me.LabeId.Location = New System.Drawing.Point(82, 118)
        Me.LabeId.Name = "LabeId"
        Me.LabeId.Size = New System.Drawing.Size(75, 13)
        Me.LabeId.TabIndex = 13
        Me.LabeId.Text = "Cedula Dueño"
        '
        'textNombreM
        '
        Me.textNombreM.Location = New System.Drawing.Point(178, 149)
        Me.textNombreM.Name = "textNombreM"
        Me.textNombreM.Size = New System.Drawing.Size(94, 20)
        Me.textNombreM.TabIndex = 10
        '
        'textCi
        '
        Me.textCi.Location = New System.Drawing.Point(178, 115)
        Me.textCi.Name = "textCi"
        Me.textCi.Size = New System.Drawing.Size(94, 20)
        Me.textCi.TabIndex = 9
        '
        'btnAgregarMascota
        '
        Me.btnAgregarMascota.Location = New System.Drawing.Point(178, 239)
        Me.btnAgregarMascota.Name = "btnAgregarMascota"
        Me.btnAgregarMascota.Size = New System.Drawing.Size(94, 39)
        Me.btnAgregarMascota.TabIndex = 16
        Me.btnAgregarMascota.Text = "Agregar"
        Me.btnAgregarMascota.UseVisualStyleBackColor = True
        '
        'labelPersonas
        '
        Me.labelPersonas.AutoSize = True
        Me.labelPersonas.Font = New System.Drawing.Font("Segoe Print", 29.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPersonas.Location = New System.Drawing.Point(112, 9)
        Me.labelPersonas.Name = "labelPersonas"
        Me.labelPersonas.Size = New System.Drawing.Size(205, 69)
        Me.labelPersonas.TabIndex = 18
        Me.labelPersonas.Text = "Mascotas"
        '
        'textAnioNaci
        '
        Me.textAnioNaci.Location = New System.Drawing.Point(178, 184)
        Me.textAnioNaci.Name = "textAnioNaci"
        Me.textAnioNaci.Size = New System.Drawing.Size(94, 20)
        Me.textAnioNaci.TabIndex = 19
        '
        'FormMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 384)
        Me.Controls.Add(Me.textAnioNaci)
        Me.Controls.Add(Me.labelPersonas)
        Me.Controls.Add(Me.btnAgregarMascota)
        Me.Controls.Add(Me.LabelDateM)
        Me.Controls.Add(Me.LabelNombreM)
        Me.Controls.Add(Me.LabeId)
        Me.Controls.Add(Me.textNombreM)
        Me.Controls.Add(Me.textCi)
        Me.Name = "FormMascotas"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDateM As Label
    Friend WithEvents LabelNombreM As Label
    Friend WithEvents LabeId As Label
    Friend WithEvents textNombreM As TextBox
    Friend WithEvents textCi As TextBox
    Friend WithEvents btnAgregarMascota As Button
    Friend WithEvents labelPersonas As Label
    Friend WithEvents textAnioNaci As TextBox
End Class
