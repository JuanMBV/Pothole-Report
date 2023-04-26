Imports System.Data.SqlClient

Public Class DatosPersonales
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono para la persona !!")
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre para la persona !!")
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno para la persona !!")
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Capturar apellido materno para la persona !!")
        Else
            Dim persona As New ClaseDatosPersonales(txtTelefono.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text)

            persona.getSetTelefono = txtTelefono.Text
            persona.getSetNombre = txtNombre.Text
            persona.getSetPaterno = txtPaterno.Text
            persona.getSetMaterno = txtMaterno.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Datos_Personales WHERE telefono = " & txtTelefono.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader()
            If lector.HasRows Then
                MessageBox.Show("Ya existe una persona con ese teléfono !!!")
                'Lo deje aqui, hacer un if para decidir si se actualiza los datos o no
            Else
                'Llamada al metodo insertar para hacer el query
                persona.insertaPersona()
                txtTelefono.Text = ""
                persona.limpiarCajas()
                persona.DGV(DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono para la persona !!")
        ElseIf txtNombre.Text = "" Then
            MessageBox.Show("Capturar nombre para la persona !!")
        ElseIf txtPaterno.Text = "" Then
            MessageBox.Show("Capturar apellido paterno para la persona !!")
        ElseIf txtMaterno.Text = "" Then
            MessageBox.Show("Capturar apellido materno para la persona !!")
        Else
            Dim persona As New ClaseDatosPersonales(txtTelefono.Text, txtNombre.Text, txtPaterno.Text, txtMaterno.Text)

            persona.getSetTelefono = txtTelefono.Text
            persona.getSetNombre = txtNombre.Text
            persona.getSetPaterno = txtPaterno.Text
            persona.getSetMaterno = txtMaterno.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Datos_Personales WHERE telefono = " & txtTelefono.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo insertar para hacer el query
                persona.actualizarPersona()
                txtTelefono.Text = ""
                persona.limpiarCajas()
                persona.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe una persona con ese teléfono !!!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtTelefono.Text = "" Then
            MessageBox.Show("Capturar telefono para la persona !!")
        Else
            Dim persona As New ClaseDatosPersonales(txtTelefono.Text)

            persona.getSetTelefono = txtTelefono.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Datos_Personales WHERE telefono = " & txtTelefono.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                persona.validarEliminacion()
                txtTelefono.Text = ""
                persona.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub DatosPersonales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim persona As New ClaseDatosPersonales
        persona.DGV(DataGridView1)
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        Dim persona As New ClaseDatosPersonales
        If txtTelefono.Text <> "" Then
            persona.consultaPersona()
        Else
            persona.limpiarCajas()
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
End Class