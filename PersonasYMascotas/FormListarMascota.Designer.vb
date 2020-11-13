<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarMascota
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
        Me.ListViewListarMascota = New System.Windows.Forms.ListView()
        Me.NombreColumna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnListarMascotas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewListarMascota
        '
        Me.ListViewListarMascota.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NombreColumna})
        Me.ListViewListarMascota.HideSelection = False
        Me.ListViewListarMascota.Location = New System.Drawing.Point(73, 179)
        Me.ListViewListarMascota.Name = "ListViewListarMascota"
        Me.ListViewListarMascota.Size = New System.Drawing.Size(629, 181)
        Me.ListViewListarMascota.TabIndex = 1
        Me.ListViewListarMascota.UseCompatibleStateImageBehavior = False
        Me.ListViewListarMascota.View = System.Windows.Forms.View.Details
        '
        'NombreColumna
        '
        Me.NombreColumna.Text = "Nombre"
        Me.NombreColumna.Width = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listar Mascotas"
        '
        'btnListarMascotas
        '
        Me.btnListarMascotas.Location = New System.Drawing.Point(73, 97)
        Me.btnListarMascotas.Name = "btnListarMascotas"
        Me.btnListarMascotas.Size = New System.Drawing.Size(111, 46)
        Me.btnListarMascotas.TabIndex = 3
        Me.btnListarMascotas.Text = "Listar Mascotas"
        Me.btnListarMascotas.UseVisualStyleBackColor = True
        '
        'FormListarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnListarMascotas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewListarMascota)
        Me.Name = "FormListarMascota"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewListarMascota As ListView
    Friend WithEvents NombreColumna As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents btnListarMascotas As Button
End Class
