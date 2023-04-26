Imports System.Data.SqlClient

Public Class Cuadrillas
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para la Cuadrilla !!")
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre para la Cuadrilla !!")
        Else
            Dim cuadrillas As New ClaseCuadrillas(txtClave.Text, txtDescripcion.Text)

            cuadrillas.getSetidCuadrila = txtClave.Text
            cuadrillas.getSetNombre = txtDescripcion.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from cuadrilla where id_cuadrilla = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader()
            If lector.HasRows Then
                MessageBox.Show("Ya existe un registro con esa clave!!!")
                'Lo deje aqui, hacer un if para decidir si se actualiza los datos o no
            Else
                'Llamada al metodo insertar para hacer el query
                cuadrillas.insertarCuadrilla()
                txtClave.Text = ""
                txtDescripcion.Text = ""
                cuadrillas.DGV(DataGridView1)
            End If
        End If
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para la Cuadrilla !!")
        ElseIf txtDescripcion.Text = "" Then
            MessageBox.Show("Capturar nombre para la Cuadrilla !!")
        Else
            Dim cuadrillas As New ClaseCuadrillas(txtClave.Text, txtDescripcion.Text)

            cuadrillas.getSetidCuadrila = txtClave.Text
            cuadrillas.getSetNombre = txtDescripcion.Text

            'Validar para no repetir clave
            Dim xCnx As New SqlCommand("Select * from cuadrilla where id_cuadrilla = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo insertar para hacer el query
                cuadrillas.actualizarCuadrilla()
                txtClave.Text = ""
                txtDescripcion.Text = ""
                cuadrillas.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtClave.Text = "" Then
            MessageBox.Show("Capturar clave para la Cuadrilla !!")
        Else
            Dim cuadrillas As New ClaseCuadrillas(txtClave.Text)

            cuadrillas.getSetidCuadrila = txtClave.Text

            'Validar si existe esa clave
            Dim xCnx As New SqlCommand("Select * from cuadrilla where id_cuadrilla = " & txtClave.Text & "", Form1.myConn)
            Dim lector As SqlDataReader
            lector = xCnx.ExecuteReader(CommandBehavior.CloseConnection)
            If lector.HasRows Then
                'Llamada al metodo delete para hacer el query
                cuadrillas.validarEliminacion()
                txtClave.Text = ""
                cuadrillas.DGV(DataGridView1)
            Else
                MessageBox.Show("No existe un registro con esa clave !!!")
            End If
        End If
    End Sub

    Private Sub Cuadrillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cuadrillas As New ClaseCuadrillas
        cuadrillas.DGV(DataGridView1)
    End Sub

    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        If txtClave.Text <> "" Then
            Dim cuadrillas As New ClaseCuadrillas
            cuadrillas.consultaCuadrilla()
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