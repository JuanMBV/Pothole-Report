Imports System.Data.SqlClient
Public Class Empleados
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave del empleado !!")
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre del empleado !!")
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno del empleado !!")
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Capturar apellido materno del empleado !!")
        ElseIf txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono del empleado !!")
        ElseIf cmbTurno.Text = "" Then
            MessageBox.Show("Capturar el turno del empleado !!")
        Else
            Dim empleados As New ClaseEmpleados(txtClave.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtTelefono.Text, txtContra.Text, cmbTurno.Text)

            empleados.getSetIdEmpleado = txtClave.Text
            empleados.getSetNombre = txtNombre.Text
            empleados.getSetPaterno = txtPaterno.Text
            empleados.getSetMaterno = txtMaterno.Text
            empleados.getSetTelefono = txtTelefono.Text
            empleados.getSetTurno = cmbTurno.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Empleado WHERE id_empleado = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader()
            If lector.HasRows Then
                MessageBox.Show("Ya existe un empleado con esa clave !!!")
                'Lo deje aqui, hacer un if para decidir si se actualiza los datos o no
            Else
                'Llamada al metodo insertar para hacer el query
                empleados.insertaEmpleado()
                txtClave.Text = ""
                empleados.limpiarCajas()
                empleados.DGV(DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave del empleado !!")
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre del empleado !!")
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno del empleado !!")
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Capturar apellido materno del empleado !!")
        ElseIf txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono del empleado !!")
        ElseIf cmbTurno.Text = "" Then
            MessageBox.Show("Capturar el turno del empleado !!")
        Else
            Dim empleados As New ClaseEmpleados(txtClave.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text, txtTelefono.Text, txtContra.Text, cmbTurno.Text)

            empleados.getSetIdEmpleado = txtClave.Text
            empleados.getSetNombre = txtNombre.Text
            empleados.getSetPaterno = txtPaterno.Text
            empleados.getSetMaterno = txtMaterno.Text
            empleados.getSetTelefono = txtTelefono.Text
            empleados.getSetTurno = cmbTurno.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Empleado WHERE id_empleado = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo insertar para hacer el query
                empleados.actualizarEmpleado()
                txtClave.Text = ""
                empleados.limpiarCajas()
                empleados.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave del empleado !!")
        Else
            Dim empleados As New ClaseEmpleados(txtClave.Text)

            empleados.getSetIdEmpleado = txtClave.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Empleado WHERE id_empleado = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                empleados.eliminarEmpleado()
                txtClave.Text = ""
                empleados.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empleados As New ClaseEmpleados
        empleados.poblarComboTurno(cmbTurno)
        empleados.DGV(DataGridView1)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Dim empleados As New ClaseEmpleados
        If txtClave.Text <> "" Then
            empleados.consultaEmpleado()
        Else
            empleados.limpiarCajas()
        End If
    End Sub

    Private Sub cmbTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTurno.SelectedIndexChanged
        Dim empleados As New ClaseEmpleados
        If cmbTurno.Text <> "Seleccione Turno" Then
            empleados.DGV(DataGridView1)
        Else
            empleados.limpiarCajas()
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