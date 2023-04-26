Imports System.Data.SqlClient

Public Class Form1
    Public myConn As SqlConnection
    Private myCmd As SqlCommand

    Public Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("server=LAPTOP-2JLVGFJS\SQLEXPRESS; database=Baches; Integrated Security=SSPI;MultipleActiveResultSets=True")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        myConn.Open()

        Dim consulta As String = "Select * from empleado where id_empleado= '" & txtIdEmployee.Text & "' and contrasena = '" & txtPassword.Text & "'"

        myCmd = New SqlCommand(consulta, myConn)
        Dim lector As SqlDataReader
        lector = myCmd.ExecuteReader(CommandBehavior.CloseConnection)

        If lector.HasRows Then
            Me.Hide()
            MainMenu.ShowDialog()
        Else
            MessageBox.Show("Este usuario no existe o datos incorrectos")
            myConn.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        txtIdEmployee.Text = vbNullString
        txtPassword.Text = ""

        'Para poner o madar el cursor a una caja de textos
        txtIdEmployee.Focus()
    End Sub

    Private Sub txtIdEmployee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdEmployee.KeyPress
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