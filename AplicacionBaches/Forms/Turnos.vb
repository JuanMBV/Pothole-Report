Imports System.Data.SqlClient

Public Class Turnos
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para el Turno !!")
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre para el Turno !!")
        Else
            Dim turnos As New ClaseTurnos(txtClave.Text, txtDescripcion.Text)

            turnos.getSetidTurno = txtClave.Text
            turnos.getSetNombre = txtDescripcion.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Turno where id_turno = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader()
            If lector.HasRows Then
                MessageBox.Show("Ya existe un registro con esa clave!!!")
                'Lo deje aqui, hacer un if para decidir si se actualiza los datos o no
            Else
                'Llamada al metodo insertar para hacer el query
                turnos.insertarTurno()
                txtClave.Text = ""
                txtDescripcion.Text = ""
                turnos.DGV(DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para el Turno !!")
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre para el Turno !!")
        Else
            Dim turnos As New ClaseTurnos(txtClave.Text, txtDescripcion.Text)

            turnos.getSetidTurno = txtClave.Text
            turnos.getSetNombre = txtDescripcion.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Turno where id_turno = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo insertar para hacer el query
                turnos.actualizarTurno()
                txtClave.Text = ""
                txtDescripcion.Text = ""
                turnos.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para el Turno !!")
        Else
            Dim turnos As New ClaseTurnos(txtClave.Text)

            turnos.getSetidTurno = txtClave.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Turno where id_turno = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                turnos.validarEliminacion()
                txtClave.Text = ""
                turnos.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub Turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim turnos As New ClaseTurnos
        turnos.DGV(DataGridView1)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        If txtClave.Text <> "" Then
            Dim turnos As New ClaseTurnos
            turnos.consultaTurno()
        Else
            txtClave.Text = ""
            txtDescripcion.Text = ""
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
End Class