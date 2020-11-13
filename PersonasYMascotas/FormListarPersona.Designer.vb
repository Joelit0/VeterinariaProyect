<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarPersona
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
        Me.ListViewListarPersona = New System.Windows.Forms.ListView()
        Me.NombreColumna = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListViewListarPersona
        '
        Me.ListViewListarPersona.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NombreColumna})
        Me.ListViewListarPersona.HideSelection = False
        Me.ListViewListarPersona.Location = New System.Drawing.Point(83, 178)
        Me.ListViewListarPersona.Name = "ListViewListarPersona"
        Me.ListViewListarPersona.Size = New System.Drawing.Size(629, 181)
        Me.ListViewListarPersona.TabIndex = 0
        Me.ListViewListarPersona.UseCompatibleStateImageBehavior = False
        Me.ListViewListarPersona.View = System.Windows.Forms.View.Details
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
        Me.Label1.Location = New System.Drawing.Point(315, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listar Personas"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Buscar Persona"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormListarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListViewListarPersona)
        Me.Name = "FormListarPersona"
        Me.Text = "FormListarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListViewListarPersona As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreColumna As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
