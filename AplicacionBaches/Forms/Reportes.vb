Imports System.Data.SqlClient
Public Class Reportes
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Validar para no repetir clave
        Dim xCnx As New SqlCommand("Select * from REPORTES WHERE id_bache = " & txtReporte.Text & "", Form1.myConn)
        Dim lector As SqlDataReader
        lector = xCnx.ExecuteReader()
        If lector.HasRows Then
            MessageBox.Show("Ya existe un reporte con esa clave !!!")
        Else
            'Llamada al metodo insertar para hacer el query
            Dim r As New ClaseReportes

            Dim fechaReporteFormateada As String = dtpFechaReporte.Value.ToString("yyyy-MM-dd")
            Dim fechaAsignadaFormateada As String = dtpFechaAsignada.Value.ToString("yyyy-MM-dd")
            Dim fechaSolucionFormateada As String = dtpFechaSolucion.Value.ToString("yyyy-MM-dd")

            If txtReporte.Text = "" Then
                MessageBox.Show("Capturar clave del reporte !!")
            ElseIf txtTelefono.Text = "" Then
                MessageBox.Show("Capturar telefono de la persona que esta reportando !!")
            ElseIf cmbDireccion.Text = "Seleccione direccion" Then
                MessageBox.Show("Capturar la direccion del reporte !!")
            ElseIf cmbEntreCalle1.Text = "Seleccione entre calle 1" Then
                MessageBox.Show("Capturar la entre calle 1 del reporte !!")
            ElseIf cmbEntreCalle2.Text = "Seleccione entre calle 2" Then
                MessageBox.Show("Capturar la entre calle 2 del reporte !!")
            ElseIf cmbColonia.Text = "" Then
                MessageBox.Show("Capturar la colonia del reporte !!")
            ElseIf txtHoraReporte.Text = "" Then
                MessageBox.Show("Capturar una hora de reporte valida !!")
            ElseIf cmbCuadrilla.Text = "Seleccione cuadrilla" Then
                MessageBox.Show("Capturar una Cuadrilla !!")
            ElseIf r.validarFechaHora(fechaReporteFormateada, txtHoraReporte.Text, fechaAsignadaFormateada, txtHoraAsignada.Text) Then
                MessageBox.Show("Capturar una fecha asignada valida !!")
            ElseIf txtHoraAsignada.Text = "" Then
                MessageBox.Show("Capturar una hora asignada valida !!")
            ElseIf r.validarHoraReporte(txtHoraReporte.Text) Then
                MessageBox.Show("Hora de trabajo no permintida !!")
            Else
                Dim sol As Byte
                If rBtnSi.Checked Then
                    sol = 1
                ElseIf rBtnNo.Checked Then
                    sol = 0
                End If

                Dim array() As String = txtEmpleado.Text.Split(" ")
                Dim name As String = array(0)



                Dim reportes As New ClaseReportes(txtReporte.Text, name, txtTelefono.Text, cmbDireccion.Text,
                                                  cmbEntreCalle1.Text, cmbEntreCalle2.Text, cmbColonia.Text, fechaReporteFormateada,
                                                  txtHoraReporte.Text, cmbCuadrilla.Text, fechaAsignadaFormateada, txtHoraAsignada.Text,
                                                  sol, fechaSolucionFormateada, txtHoraSolucion.Text)

                reportes.getSetIdBache = txtReporte.Text
                reportes.getSetEmpleado = name
                reportes.getSetCuadrilla = cmbCuadrilla.Text
                reportes.getSetColonia = cmbColonia.Text
                reportes.getSetTelefono = txtTelefono.Text
                reportes.getSetDireccion = cmbDireccion.Text
                reportes.getSetEntreCalle1 = cmbEntreCalle1.Text
                reportes.getSetEntreCalle2 = cmbEntreCalle2.Text
                reportes.getSetFechaReporte = fechaReporteFormateada
                reportes.getSetHoraReporte = txtHoraReporte.Text
                reportes.getSetHoraAsignada = txtHoraAsignada.Text
                reportes.getSetFechaAsignada = fechaAsignadaFormateada
                reportes.getSetHoraSolucion = txtHoraSolucion.Text
                reportes.getSetFechaSolucion = fechaSolucionFormateada
                reportes.getSetSolu = sol

                reportes.insertaReporte()
                reportes.DGV(DataGridView1)
                txtReporte.Focus()
            End If
        End If

    End Sub

    'Boton de guardar al 100%

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim xCnx As New SqlCommand("Select * from REPORTES WHERE id_bache = " & txtReporte.Text & "", Form1.myConn)
        Dim lector As SqlDataReader
        lector = xCnx.ExecuteReader()
        If lector.HasRows Then
            'Llamada al metodo insertar para hacer el query
            Dim r As New ClaseReportes

            Dim fechaReporteFormateada As String = dtpFechaReporte.Value.ToString("yyyy-MM-dd")
            Dim fechaAsignadaFormateada As String = dtpFechaAsignada.Value.ToString("yyyy-MM-dd")
            Dim fechaSolucionFormateada As String = dtpFechaSolucion.Value.ToString("yyyy-MM-dd")

            If txtReporte.Text = "" Then
                MessageBox.Show("Capturar clave del reporte !!")
            ElseIf txtTelefono.Text = "" Then
                MessageBox.Show("Capturar telefono de la persona que esta reportando !!")
            ElseIf cmbDireccion.Text = "Seleccione direccion" Then
                MessageBox.Show("Capturar la direccion del reporte !!")
            ElseIf cmbEntreCalle1.Text = "Seleccione entre calle 1" Then
                MessageBox.Show("Capturar la entre calle 1 del reporte !!")
            ElseIf cmbEntreCalle2.Text = "Seleccione entre calle 2" Then
                MessageBox.Show("Capturar la entre calle 2 del reporte !!")
            ElseIf cmbColonia.Text = "" Then
                MessageBox.Show("Capturar la colonia del reporte !!")
            ElseIf txtHoraReporte.Text = "" Then
                MessageBox.Show("Capturar una hora de reporte valida !!")
            ElseIf cmbCuadrilla.Text = "Seleccione cuadrilla" Then
                MessageBox.Show("Capturar una Cuadrilla !!")
            ElseIf r.validarFechaHora(fechaReporteFormateada, txtHoraReporte.Text, fechaAsignadaFormateada, txtHoraAsignada.Text) Then
                MessageBox.Show("Capturar una fecha asignada valida !!")
            ElseIf txtHoraAsignada.Text = "" Then
                MessageBox.Show("Capturar una hora asignada valida !!")
            ElseIf r.validarFechaHora(fechaAsignadaFormateada, txtHoraAsignada.Text, fechaSolucionFormateada, txtHoraSolucion.Text) Then
                MessageBox.Show("Capturar una fecha solucion valida !!")
            ElseIf txtHoraSolucion.Text = "" Then
                MessageBox.Show("Capturar una hora solucion valida !!")
            ElseIf r.validarHoraReporte(txtHoraReporte.Text) Then
                MessageBox.Show("Hora de trabajo no permintida !!")
            Else
                Dim sol As Byte
                If rBtnSi.Checked Then
                    sol = 1
                ElseIf rBtnNo.Checked Then
                    sol = 0
                End If

                Dim array() As String = txtEmpleado.Text.Split(" ")
                Dim name As String = array(0)



                Dim reportes As New ClaseReportes(txtReporte.Text, name, txtTelefono.Text, cmbDireccion.Text,
                                                  cmbEntreCalle1.Text, cmbEntreCalle2.Text, cmbColonia.Text, fechaReporteFormateada,
                                                  txtHoraReporte.Text, cmbCuadrilla.Text, fechaAsignadaFormateada, txtHoraAsignada.Text,
                                                  sol, fechaSolucionFormateada, txtHoraSolucion.Text)

                reportes.getSetIdBache = txtReporte.Text
                reportes.getSetEmpleado = name
                reportes.getSetCuadrilla = cmbCuadrilla.Text
                reportes.getSetColonia = cmbColonia.Text
                reportes.getSetTelefono = txtTelefono.Text
                reportes.getSetDireccion = cmbDireccion.Text
                reportes.getSetEntreCalle1 = cmbEntreCalle1.Text
                reportes.getSetEntreCalle2 = cmbEntreCalle2.Text
                reportes.getSetFechaReporte = fechaReporteFormateada
                reportes.getSetHoraReporte = txtHoraReporte.Text
                reportes.getSetHoraAsignada = txtHoraAsignada.Text
                reportes.getSetFechaAsignada = fechaAsignadaFormateada
                reportes.getSetHoraSolucion = txtHoraSolucion.Text
                reportes.getSetFechaSolucion = fechaSolucionFormateada
                reportes.getSetSolu = sol
                reportes.actualizarReporte()
                reportes.limpiarCajas()
                txtReporte.Text = ""
                reportes.DGV(DataGridView1)
                txtReporte.Focus()
            End If
        Else
            MessageBox.Show("No existe un registro con esa clave !!!")
        End If
    End Sub

    'Boton de modify funcionando al 100% aparentemente, igual estar al pendiente

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtReporte.Text = "" Then
            MessageBox.Show("Capturar clave del reporte !!")
        Else
            Dim reportes As New ClaseReportes(txtReporte.Text)

            reportes.getSetIdBache = txtReporte.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Reportes WHERE id_bache = " & txtReporte.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                reportes.eliminarReporte()
                reportes.limpiarCajas()
                txtReporte.Text = ""
                reportes.DGV(DataGridView1)
                txtReporte.Focus()
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------
    'Arriba van a ir los botones, abajo lo general de la ventana
    '-------------------------------------------------------------------------------------------------

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reportes As New ClaseReportes
        reportes.poblarComboColonia(cmbColonia)
        reportes.poblarComboCuadrilla(cmbCuadrilla)
        reportes.DGV(DataGridView1)
        reportes.establecerEmpleado()
    End Sub

    Private Sub txtReporte_TextChanged(sender As Object, e As EventArgs) Handles txtReporte.TextChanged
        Dim reportes As New ClaseReportes
        If txtReporte.Text <> "" Then
            reportes.consultaReporte()
        Else
            reportes.limpiarCajas()
        End If
    End Sub

    Private Sub cmbColonia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColonia.SelectedIndexChanged
        Dim reportes As New ClaseReportes
        Dim colon As String = cmbColonia.Text
        reportes.poblarComboCalles(cmbDireccion, colon)
        reportes.poblarComboCalles(cmbEntreCalle1, colon)
        reportes.poblarComboCalles(cmbEntreCalle2, colon)
    End Sub

    Private Sub btnLlenar_Click(sender As Object, e As EventArgs) Handles btnLlenar.Click
        DatosPersonales.ShowDialog()
    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        Dim reportes As New ClaseReportes
        reportes.limpiarCajas()
        txtReporte.Text = ""
    End Sub

    Private Sub rBtnSi_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnSi.CheckedChanged
        dtpFechaSolucion.Enabled = rBtnSi.Checked
        txtHoraSolucion.Enabled = rBtnSi.Checked
    End Sub

    Private Sub txtReporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReporte.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class