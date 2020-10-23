<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.LogoVeterinaria = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FormPersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMascotasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.LogoVeterinaria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoVeterinaria
        '
        Me.LogoVeterinaria.BackColor = System.Drawing.Color.Transparent
        Me.LogoVeterinaria.BackgroundImage = Global.Inicio.My.Resources.Resources.logo_veterinaria
        Me.LogoVeterinaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LogoVeterinaria.Image = Global.Inicio.My.Resources.Resources.logo_veterinaria
        Me.LogoVeterinaria.Location = New System.Drawing.Point(312, 0)
        Me.LogoVeterinaria.Name = "LogoVeterinaria"
        Me.LogoVeterinaria.Size = New System.Drawing.Size(208, 191)
        Me.LogoVeterinaria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoVeterinaria.TabIndex = 0
        Me.LogoVeterinaria.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(455, 227)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasToolStripMenuItem, Me.FormMascotasToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(153, 48)
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PersonasToolStripMenuItem.Text = "FormPersonas"
        '
        'FormMascotasToolStripMenuItem
        '
        Me.FormMascotasToolStripMenuItem.Name = "FormMascotasToolStripMenuItem"
        Me.FormMascotasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FormMascotasToolStripMenuItem.Text = "FormMascotas"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPersonaToolStripMenuItem, Me.FormMascotasToolStripMenuItem1})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(181, 70)
        '
        'FormPersonaToolStripMenuItem
        '
        Me.FormPersonaToolStripMenuItem.Name = "FormPersonaToolStripMenuItem"
        Me.FormPersonaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormPersonaToolStripMenuItem.Text = "FormPersona"
        '
        'FormMascotasToolStripMenuItem1
        '
        Me.FormMascotasToolStripMenuItem1.Name = "FormMascotasToolStripMenuItem1"
        Me.FormMascotasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.FormMascotasToolStripMenuItem1.Text = "FormMascotas"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LogoVeterinaria)
        Me.Name = "FormInicio"
        Me.Text = "Inicio"
        CType(Me.LogoVeterinaria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoVeterinaria As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents FormPersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormMascotasToolStripMenuItem1 As ToolStripMenuItem
End Class
