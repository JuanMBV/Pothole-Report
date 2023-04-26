Imports System.Data.SqlClient

Public Class Colonias
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para la Colonia !!")
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre para la Colonia !!")
        ElseIf txtCp.Text = "" Then
            MessageBox.Show("Capturar codigo postal para la Colonia !!")
        Else
            Dim colonias As New ClaseColonias(txtClave.Text, txtDescripcion.Text, txtCp.Text)

            colonias.getSetidColonia = txtClave.Text
            colonias.getSetNombre = txtDescripcion.Text
            colonias.getSetCP = txtCp.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Colonia where id_colonia = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader()
            If lector.HasRows Then
                MessageBox.Show("Ya existe un registro con esa clave!!!")
                'Lo deje aqui, hacer un if para decidir si se actualiza los datos o no
            Else
                'Llamada al metodo insertar para hacer el query
                colonias.insertarColonia()
                txtClave.Text = ""
                colonias.limpiarCajas()
                colonias.DGV(DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para la Colonia !!")
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre para la Colonia !!")
        ElseIf txtCp.Text = "" Then
            MessageBox.Show("Capturar codigo postal para la Colonia !!")
        Else
            Dim colonias As New ClaseColonias(txtClave.Text, txtDescripcion.Text, txtCp.Text)

            colonias.getSetidColonia = txtClave.Text
            colonias.getSetNombre = txtDescripcion.Text
            colonias.getSetCP = txtCp.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from Colonia where id_colonia = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo insertar para hacer el query
                colonias.actualizarColonia()
                txtClave.Text = ""
                colonias.limpiarCajas()
                colonias.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para la Colonia !!")
        Else
            Dim colonias As New ClaseColonias(txtClave.Text)

            colonias.getSetidColonia = txtClave.Text

            'Validar si existe esa clave
            Dim xCnx As New SqlCommand("Select * from Colonia where id_colonia = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                colonias.validarEliminacion()
                txtClave.Text = ""
                colonias.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub Colonias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colonias As New ClaseColonias
        colonias.DGV(DataGridView1)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        Dim colonias As New ClaseColonias
        If txtClave.Text <> "" Then
            colonias.consultaColonia()
        Else
            colonias.limpiarCajas()
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

    Private Sub txtCp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCp.KeyPress
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