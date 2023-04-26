<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHoraReporte = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCuadrilla = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbColonia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHoraAsignada = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.rBtnSi = New System.Windows.Forms.RadioButton()
        Me.rBtnNo = New System.Windows.Forms.RadioButton()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.dtpFechaAsignada = New System.Windows.Forms.DateTimePicker()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.dtpFechaReporte = New System.Windows.Forms.DateTimePicker()
        Me.btnLlenar = New System.Windows.Forms.Button()
        Me.dtpFechaSolucion = New System.Windows.Forms.DateTimePicker()
        Me.txtHoraSolucion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbDireccion = New System.Windows.Forms.ComboBox()
        Me.cmbEntreCalle1 = New System.Windows.Forms.ComboBox()
        Me.cmbEntreCalle2 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(77, 500)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1102, 239)
        Me.DataGridView1.TabIndex = 93
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1081, 207)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(98, 50)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(1081, 118)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(98, 50)
        Me.btnModify.TabIndex = 16
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(1081, 31)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 50)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Reporte #"
        '
        'txtReporte
        '
        Me.txtReporte.Location = New System.Drawing.Point(239, 98)
        Me.txtReporte.MaxLength = 18
        Me.txtReporte.Name = "txtReporte"
        Me.txtReporte.Size = New System.Drawing.Size(218, 26)
        Me.txtReporte.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 29)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Atiende"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 29)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(239, 155)
        Me.txtTelefono.MaxLength = 10
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(218, 26)
        Me.txtTelefono.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 29)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Dirección"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 29)
        Me.Label5.TabIndex = 102
        Me.Label5.Text = "Entre calle 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Entre calle 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(578, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 29)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Fecha Reporte"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(578, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 29)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Hora Reporte"
        '
        'txtHoraReporte
        '
        Me.txtHoraReporte.Location = New System.Drawing.Point(810, 97)
        Me.txtHoraReporte.Name = "txtHoraReporte"
        Me.txtHoraReporte.Size = New System.Drawing.Size(218, 26)
        Me.txtHoraReporte.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(578, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(215, 29)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Cuadrilla Asignada"
        '
        'cmbCuadrilla
        '
        Me.cmbCuadrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCuadrilla.FormattingEnabled = True
        Me.cmbCuadrilla.Location = New System.Drawing.Point(810, 150)
        Me.cmbCuadrilla.Name = "cmbCuadrilla"
        Me.cmbCuadrilla.Size = New System.Drawing.Size(218, 33)
        Me.cmbCuadrilla.TabIndex = 8
        Me.cmbCuadrilla.Text = "Seleccione cuadrilla"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 29)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Colonia"
        '
        'cmbColonia
        '
        Me.cmbColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColonia.FormattingEnabled = True
        Me.cmbColonia.Location = New System.Drawing.Point(239, 207)
        Me.cmbColonia.Name = "cmbColonia"
        Me.cmbColonia.Size = New System.Drawing.Size(218, 34)
        Me.cmbColonia.TabIndex = 2
        Me.cmbColonia.Text = "Seleccione colonia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(578, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 29)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Fecha Asignada"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(578, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(171, 29)
        Me.Label12.TabIndex = 116
        Me.Label12.Text = "Hora Asignada"
        '
        'txtHoraAsignada
        '
        Me.txtHoraAsignada.Location = New System.Drawing.Point(810, 258)
        Me.txtHoraAsignada.Name = "txtHoraAsignada"
        Me.txtHoraAsignada.Size = New System.Drawing.Size(218, 26)
        Me.txtHoraAsignada.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(578, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 29)
        Me.Label13.TabIndex = 118
        Me.Label13.Text = "Solución"
        '
        'rBtnSi
        '
        Me.rBtnSi.AutoSize = True
        Me.rBtnSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnSi.Location = New System.Drawing.Point(810, 313)
        Me.rBtnSi.Name = "rBtnSi"
        Me.rBtnSi.Size = New System.Drawing.Size(60, 33)
        Me.rBtnSi.TabIndex = 11
        Me.rBtnSi.Text = "Si"
        Me.rBtnSi.UseVisualStyleBackColor = True
        '
        'rBtnNo
        '
        Me.rBtnNo.AutoSize = True
        Me.rBtnNo.Checked = True
        Me.rBtnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnNo.Location = New System.Drawing.Point(958, 313)
        Me.rBtnNo.Name = "rBtnNo"
        Me.rBtnNo.Size = New System.Drawing.Size(70, 33)
        Me.rBtnNo.TabIndex = 12
        Me.rBtnNo.TabStop = True
        Me.rBtnNo.Text = "No"
        Me.rBtnNo.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClean.Location = New System.Drawing.Point(1081, 297)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(98, 49)
        Me.btnClean.TabIndex = 18
        Me.btnClean.Text = "Clean"
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'dtpFechaAsignada
        '
        Me.dtpFechaAsignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAsignada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAsignada.Location = New System.Drawing.Point(810, 207)
        Me.dtpFechaAsignada.Name = "dtpFechaAsignada"
        Me.dtpFechaAsignada.Size = New System.Drawing.Size(218, 35)
        Me.dtpFechaAsignada.TabIndex = 9
        '
        'txtEmpleado
        '
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Location = New System.Drawing.Point(239, 48)
        Me.txtEmpleado.MaxLength = 18
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(218, 26)
        Me.txtEmpleado.TabIndex = 127
        '
        'dtpFechaReporte
        '
        Me.dtpFechaReporte.Enabled = False
        Me.dtpFechaReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaReporte.Location = New System.Drawing.Point(810, 40)
        Me.dtpFechaReporte.Name = "dtpFechaReporte"
        Me.dtpFechaReporte.Size = New System.Drawing.Size(218, 35)
        Me.dtpFechaReporte.TabIndex = 6
        '
        'btnLlenar
        '
        Me.btnLlenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLlenar.Location = New System.Drawing.Point(463, 152)
        Me.btnLlenar.Name = "btnLlenar"
        Me.btnLlenar.Size = New System.Drawing.Size(90, 36)
        Me.btnLlenar.TabIndex = 129
        Me.btnLlenar.Text = "Llenar"
        Me.btnLlenar.UseVisualStyleBackColor = True
        '
        'dtpFechaSolucion
        '
        Me.dtpFechaSolucion.Enabled = False
        Me.dtpFechaSolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSolucion.Location = New System.Drawing.Point(810, 361)
        Me.dtpFechaSolucion.Name = "dtpFechaSolucion"
        Me.dtpFechaSolucion.Size = New System.Drawing.Size(218, 35)
        Me.dtpFechaSolucion.TabIndex = 13
        '
        'txtHoraSolucion
        '
        Me.txtHoraSolucion.Enabled = False
        Me.txtHoraSolucion.Location = New System.Drawing.Point(810, 412)
        Me.txtHoraSolucion.Name = "txtHoraSolucion"
        Me.txtHoraSolucion.Size = New System.Drawing.Size(218, 26)
        Me.txtHoraSolucion.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(578, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(165, 29)
        Me.Label14.TabIndex = 131
        Me.Label14.Text = "Hora Solución"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(578, 357)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(180, 29)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Fecha Solución"
        '
        'cmbDireccion
        '
        Me.cmbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDireccion.FormattingEnabled = True
        Me.cmbDireccion.Location = New System.Drawing.Point(239, 262)
        Me.cmbDireccion.Name = "cmbDireccion"
        Me.cmbDireccion.Size = New System.Drawing.Size(218, 34)
        Me.cmbDireccion.TabIndex = 3
        Me.cmbDireccion.Text = "Seleccione direccion"
        '
        'cmbEntreCalle1
        '
        Me.cmbEntreCalle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEntreCalle1.FormattingEnabled = True
        Me.cmbEntreCalle1.Location = New System.Drawing.Point(239, 315)
        Me.cmbEntreCalle1.Name = "cmbEntreCalle1"
        Me.cmbEntreCalle1.Size = New System.Drawing.Size(218, 34)
        Me.cmbEntreCalle1.TabIndex = 4
        Me.cmbEntreCalle1.Text = "Seleccione entre calle 1"
        '
        'cmbEntreCalle2
        '
        Me.cmbEntreCalle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEntreCalle2.FormattingEnabled = True
        Me.cmbEntreCalle2.Location = New System.Drawing.Point(239, 368)
        Me.cmbEntreCalle2.Name = "cmbEntreCalle2"
        Me.cmbEntreCalle2.Size = New System.Drawing.Size(218, 34)
        Me.cmbEntreCalle2.TabIndex = 5
        Me.cmbEntreCalle2.Text = "Seleccione entre calle 2"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 782)
        Me.Controls.Add(Me.cmbEntreCalle2)
        Me.Controls.Add(Me.cmbEntreCalle1)
        Me.Controls.Add(Me.cmbDireccion)
        Me.Controls.Add(Me.dtpFechaSolucion)
        Me.Controls.Add(Me.txtHoraSolucion)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnLlenar)
        Me.Controls.Add(Me.dtpFechaReporte)
        Me.Controls.Add(Me.txtEmpleado)
        Me.Controls.Add(Me.dtpFechaAsignada)
        Me.Controls.Add(Me.btnClean)
        Me.Controls.Add(Me.rBtnNo)
        Me.Controls.Add(Me.rBtnSi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtHoraAsignada)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbColonia)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbCuadrilla)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtHoraReporte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReporte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnModify As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReporte As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHoraReporte As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbCuadrilla As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbColonia As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtHoraAsignada As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents rBtnSi As RadioButton
    Friend WithEvents rBtnNo As RadioButton
    Friend WithEvents btnClean As Button
    Friend WithEvents dtpFechaAsignada As DateTimePicker
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents dtpFechaReporte As DateTimePicker
    Friend WithEvents btnLlenar As Button
    Friend WithEvents dtpFechaSolucion As DateTimePicker
    Friend WithEvents txtHoraSolucion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbDireccion As ComboBox
    Friend WithEvents cmbEntreCalle1 As ComboBox
    Friend WithEvents cmbEntreCalle2 As ComboBox
End Class
