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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormPersonasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaBuscarYModifcarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMascotasToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaModificarBuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarMascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPersonasToolStripMenuItem2, Me.FormMascotasToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormPersonasToolStripMenuItem2
        '
        Me.FormPersonasToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaBuscarYModifcarToolStripMenuItem, Me.ListarToolStripMenuItem, Me.BajaToolStripMenuItem})
        Me.FormPersonasToolStripMenuItem2.Name = "FormPersonasToolStripMenuItem2"
        Me.FormPersonasToolStripMenuItem2.Size = New System.Drawing.Size(66, 20)
        Me.FormPersonasToolStripMenuItem2.Text = "Personas"
        '
        'AltaBuscarYModifcarToolStripMenuItem
        '
        Me.AltaBuscarYModifcarToolStripMenuItem.Name = "AltaBuscarYModifcarToolStripMenuItem"
        Me.AltaBuscarYModifcarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.AltaBuscarYModifcarToolStripMenuItem.Text = "Alta - Buscar - Modifcar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'FormMascotasToolStripMenuItem2
        '
        Me.FormMascotasToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaModificarBuscarToolStripMenuItem, Me.ListarMascotasToolStripMenuItem})
        Me.FormMascotasToolStripMenuItem2.Name = "FormMascotasToolStripMenuItem2"
        Me.FormMascotasToolStripMenuItem2.Size = New System.Drawing.Size(69, 20)
        Me.FormMascotasToolStripMenuItem2.Text = "Mascotas"
        '
        'AltaModificarBuscarToolStripMenuItem
        '
        Me.AltaModificarBuscarToolStripMenuItem.Name = "AltaModificarBuscarToolStripMenuItem"
        Me.AltaModificarBuscarToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AltaModificarBuscarToolStripMenuItem.Text = "Alta - Buscar - Modificar "
        '
        'ListarMascotasToolStripMenuItem
        '
        Me.ListarMascotasToolStripMenuItem.Name = "ListarMascotasToolStripMenuItem"
        Me.ListarMascotasToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ListarMascotasToolStripMenuItem.Text = "Listar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PersonasYMascotas.My.Resources.Resources.logo_veterinaria
        Me.PictureBox1.Location = New System.Drawing.Point(82, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(632, 351)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormInicio"
        Me.Text = "FormInicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormPersonasToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FormMascotasToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AltaBuscarYModifcarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaModificarBuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarMascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
End Class
