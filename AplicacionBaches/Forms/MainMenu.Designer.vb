<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TablasPapasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadrillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosPersonalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasHijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntegranteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TablasPapasToolStripMenuItem, Me.TablasHijosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TablasPapasToolStripMenuItem
        '
        Me.TablasPapasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CuadrillaToolStripMenuItem, Me.TurnoToolStripMenuItem, Me.ColoniaToolStripMenuItem, Me.DatosPersonalesToolStripMenuItem})
        Me.TablasPapasToolStripMenuItem.Name = "TablasPapasToolStripMenuItem"
        Me.TablasPapasToolStripMenuItem.Size = New System.Drawing.Size(129, 29)
        Me.TablasPapasToolStripMenuItem.Text = "Tablas papas"
        '
        'CuadrillaToolStripMenuItem
        '
        Me.CuadrillaToolStripMenuItem.Name = "CuadrillaToolStripMenuItem"
        Me.CuadrillaToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.CuadrillaToolStripMenuItem.Text = "Cuadrilla"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'ColoniaToolStripMenuItem
        '
        Me.ColoniaToolStripMenuItem.Name = "ColoniaToolStripMenuItem"
        Me.ColoniaToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.ColoniaToolStripMenuItem.Text = "Colonia"
        '
        'DatosPersonalesToolStripMenuItem
        '
        Me.DatosPersonalesToolStripMenuItem.Name = "DatosPersonalesToolStripMenuItem"
        Me.DatosPersonalesToolStripMenuItem.Size = New System.Drawing.Size(249, 34)
        Me.DatosPersonalesToolStripMenuItem.Text = "Datos Personales"
        '
        'TablasHijosToolStripMenuItem
        '
        Me.TablasHijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntegranteToolStripMenuItem, Me.EmpleadoToolStripMenuItem})
        Me.TablasHijosToolStripMenuItem.Name = "TablasHijosToolStripMenuItem"
        Me.TablasHijosToolStripMenuItem.Size = New System.Drawing.Size(121, 29)
        Me.TablasHijosToolStripMenuItem.Text = "Tablas Hijos"
        '
        'IntegranteToolStripMenuItem
        '
        Me.IntegranteToolStripMenuItem.Name = "IntegranteToolStripMenuItem"
        Me.IntegranteToolStripMenuItem.Size = New System.Drawing.Size(276, 34)
        Me.IntegranteToolStripMenuItem.Text = "Integrantes Cuadrilla"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(276, 34)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TablasPapasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadrillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColoniaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatosPersonalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TablasHijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntegranteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
End Class
