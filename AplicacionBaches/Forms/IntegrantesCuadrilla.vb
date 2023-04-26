Imports System.Data.SqlClient
Public Class IntegrantesCuadrilla
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave del integrante de la cuadrilla !!")
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre del integrante de la cuadrilla!!")
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno del integrante de la cuadrilla!!")
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Capturar apellido materno del integrante de la cuadrilla !!")
        ElseIf txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono del integrante de la cuadrilla !!")
        ElseIf cmbCuadrilla.Text = "" Then
            MessageBox.Show("Capturar la cuadrilla del integrante !!")
        Else
            Dim integrantes As New ClaseIntegrantesCuadrilla(txtClave.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtTelefono.Text, cmbCuadrilla.Text)

            integrantes.getSetIdIntegrante = txtClave.Text
            integrantes.getSetNombre = txtNombre.Text
            integrantes.getSetPaterno = txtPaterno.Text
            integrantes.getSetMaterno = txtMaterno.Text
            integrantes.getSetTelefono = txtTelefono.Text
            integrantes.getSetCuadrilla = cmbCuadrilla.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Integrantes_Cuadrilla WHERE id_integrantes = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader()
            If lector.HasRows Then
                MessageBox.Show("Ya existe un integrante con esa clave !!!")
                'Lo deje aqui, hacer un if para decidir si se actualiza los datos o no
            Else
                'Llamada al metodo insertar para hacer el query
                integrantes.insertaIntegrante()
                txtClave.Text = ""
                integrantes.limpiarCajas()
                integrantes.DGV(DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave del integrante de la cuadrilla !!")
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre del integrante de la cuadrilla!!")
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno del integrante de la cuadrilla!!")
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Capturar apellido materno del integrante de la cuadrilla !!")
        ElseIf txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono del integrante de la cuadrilla !!")
        ElseIf cmbCuadrilla.Text = "" Then
            MessageBox.Show("Capturar la cuadrilla del integrante !!")
        Else
            Dim integrantes As New ClaseIntegrantesCuadrilla(txtClave.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtTelefono.Text, cmbCuadrilla.Text)

            integrantes.getSetIdIntegrante = txtClave.Text
            integrantes.getSetNombre = txtNombre.Text
            integrantes.getSetPaterno = txtPaterno.Text
            integrantes.getSetMaterno = txtMaterno.Text
            integrantes.getSetTelefono = txtTelefono.Text
            integrantes.getSetCuadrilla = cmbCuadrilla.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Integrantes_Cuadrilla WHERE id_integrantes = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo insertar para hacer el query
                integrantes.actualizarIntegrante()
                txtClave.Text = ""
                integrantes.limpiarCajas()
                integrantes.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe una persona con ese teléfono !!!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave del integrante de la cuadrilla !!")
        Else
            Dim integrantes As New ClaseIntegrantesCuadrilla(txtClave.Text)

            integrantes.getSetIdIntegrante = txtClave.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Integrantes_Cuadrilla WHERE id_integrantes = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                integrantes.eliminarIntegrante()
                txtClave.Text = ""
                integrantes.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub IntegrantesCuadrilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim integrantes As New ClaseIntegrantesCuadrilla
        integrantes.poblarComboCuadrillas(cmbCuadrilla)
        integrantes.DGV(DataGridView1)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Dim integrantes As New ClaseIntegrantesCuadrilla
        If txtClave.Text <> "" Then
            integrantes.consultaIntegrante()
        Else
            integrantes.limpiarCajas()
        End If
    End Sub

    Private Sub cmbCuadrilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuadrilla.SelectedIndexChanged
        Dim integrantes As New ClaseIntegrantesCuadrilla
        If cmbCuadrilla.Text <> "Seleccione Cuadrilla" Then
            integrantes.DGV(DataGridView1)
        Else

            integrantes.limpiarCajas()
        End If
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
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

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPaterno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaterno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaterno.KeyPress
        If Char.IsLetter(e.KeyChar) Then
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