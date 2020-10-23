<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMascotas
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
        Me.LabelDateM = New System.Windows.Forms.Label()
        Me.LabelNombreM = New System.Windows.Forms.Label()
        Me.LabeId = New System.Windows.Forms.Label()
        Me.textDate = New System.Windows.Forms.TextBox()
        Me.textNombreM = New System.Windows.Forms.TextBox()
        Me.textId = New System.Windows.Forms.TextBox()
        Me.labelMascotas = New System.Windows.Forms.Label()
        Me.btnCapturarMascotas = New System.Windows.Forms.Button()
        Me.verResultadoM = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelDateM
        '
        Me.LabelDateM.AutoSize = True
        Me.LabelDateM.Location = New System.Drawing.Point(275, 158)
        Me.LabelDateM.Name = "LabelDateM"
        Me.LabelDateM.Size = New System.Drawing.Size(108, 13)
        Me.LabelDateM.TabIndex = 15
        Me.LabelDateM.Text = "Fecha de Nacimiento"
        '
        'LabelNombreM
        '
        Me.LabelNombreM.AutoSize = True
        Me.LabelNombreM.Location = New System.Drawing.Point(339, 123)
        Me.LabelNombreM.Name = "LabelNombreM"
        Me.LabelNombreM.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreM.TabIndex = 14
        Me.LabelNombreM.Text = "Nombre"
        '
        'LabeId
        '
        Me.LabeId.AutoSize = True
        Me.LabeId.Location = New System.Drawing.Point(366, 89)
        Me.LabeId.Name = "LabeId"
        Me.LabeId.Size = New System.Drawing.Size(16, 13)
        Me.LabeId.TabIndex = 13
        Me.LabeId.Text = "Id"
        '
        'textDate
        '
        Me.textDate.Location = New System.Drawing.Point(388, 155)
        Me.textDate.Name = "textDate"
        Me.textDate.Size = New System.Drawing.Size(94, 20)
        Me.textDate.TabIndex = 11
        '
        'textNombreM
        '
        Me.textNombreM.Location = New System.Drawing.Point(388, 120)
        Me.textNombreM.Name = "textNombreM"
        Me.textNombreM.Size = New System.Drawing.Size(94, 20)
        Me.textNombreM.TabIndex = 10
        '
        'textId
        '
        Me.textId.Location = New System.Drawing.Point(389, 86)
        Me.textId.Name = "textId"
        Me.textId.Size = New System.Drawing.Size(94, 20)
        Me.textId.TabIndex = 9
        '
        'labelMascotas
        '
        Me.labelMascotas.AutoSize = True
        Me.labelMascotas.Font = New System.Drawing.Font("Rockwell", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMascotas.Location = New System.Drawing.Point(386, 40)
        Me.labelMascotas.Name = "labelMascotas"
        Me.labelMascotas.Size = New System.Drawing.Size(57, 16)
        Me.labelMascotas.TabIndex = 12
        Me.labelMascotas.Text = "Mascotas"
        '
        'btnCapturarMascotas
        '
        Me.btnCapturarMascotas.Location = New System.Drawing.Point(388, 212)
        Me.btnCapturarMascotas.Name = "btnCapturarMascotas"
        Me.btnCapturarMascotas.Size = New System.Drawing.Size(89, 32)
        Me.btnCapturarMascotas.TabIndex = 16
        Me.btnCapturarMascotas.Text = "Capturar datos"
        Me.btnCapturarMascotas.UseVisualStyleBackColor = True
        '
        'verResultadoM
        '
        Me.verResultadoM.AutoSize = True
        Me.verResultadoM.Location = New System.Drawing.Point(316, 283)
        Me.verResultadoM.Name = "verResultadoM"
        Me.verResultadoM.Size = New System.Drawing.Size(0, 13)
        Me.verResultadoM.TabIndex = 17
        '
        'FormMascotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.verResultadoM)
        Me.Controls.Add(Me.btnCapturarMascotas)
        Me.Controls.Add(Me.LabelDateM)
        Me.Controls.Add(Me.LabelNombreM)
        Me.Controls.Add(Me.LabeId)
        Me.Controls.Add(Me.textDate)
        Me.Controls.Add(Me.textNombreM)
        Me.Controls.Add(Me.textId)
        Me.Controls.Add(Me.labelMascotas)
        Me.Name = "FormMascotas"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDateM As Label
    Friend WithEvents LabelNombreM As Label
    Friend WithEvents LabeId As Label
    Friend WithEvents textDate As TextBox
    Friend WithEvents textNombreM As TextBox
    Friend WithEvents textId As TextBox
    Friend WithEvents labelMascotas As Label
    Friend WithEvents btnCapturarMascotas As Button
    Friend WithEvents verResultadoM As Label
End Class
