Imports System.Data.SqlClient

Public Class ClaseCuadrillas
    Private id_cuadrilla As Integer
    Private nombre As String

    Public Sub New()
        id_cuadrilla = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal idCuadrilla As Integer)
        id_cuadrilla = idCuadrilla
    End Sub

    Public Sub New(ByVal idCuadrilla As Integer, ByVal nom As String)
        id_cuadrilla = idCuadrilla
        nombre = nom
    End Sub

    Public Property getSetidCuadrila() As Integer
        Get
            Return id_cuadrilla
        End Get
        Set(ByVal Value As Integer)
            id_cuadrilla = Value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal Value As String)
            nombre = Value
        End Set
    End Property

    'Metodo para insertar
    Public Sub insertarCuadrilla()
        Dim strSql As String
        Dim xCnx As SqlCommand

        If id_cuadrilla <> 0 And nombre <> "" Then
            strSql = "INSERT INTO Cuadrilla VALUES(" & id_cuadrilla & ", '" & nombre & "')"
            xCnx = New SqlCommand(strSql, Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
        Else
            MsgBox("Faltan datos para la cuadrilla, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar
    Public Sub actualizarCuadrilla()
        Dim strSql As String
        Dim xCnx As SqlCommand

        If id_cuadrilla <> 0 And nombre <> "" Then
            strSql = "Update Cuadrilla SET nombre = '" & nombre & "' WHERE id_cuadrilla = " & id_cuadrilla & ""
            xCnx = New SqlCommand(strSql, Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados!!")
        Else
            MsgBox("Faltan datos para la cuadrilla, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarCuadrilla()
        Dim strSql As String
        Dim xCnx As SqlCommand

        If id_cuadrilla <> 0 Then
            strSql = "DELETE FROM Cuadrilla WHERE id_cuadrilla = " & id_cuadrilla & ""
            xCnx = New SqlCommand(strSql, Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para la cuadrilla, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub validarEliminacion()
        Dim xCnx As New SqlCommand("Select * From reportes where id_cuadrilla = " & id_cuadrilla & "", Form1.myConn)
        Dim lector As SqlDataReader
        Dim xCnx2 As New SqlCommand("Select * from integrantes_cuadrilla Where id_cuadrilla = " & id_cuadrilla & "", Form1.myConn)
        Dim lector2 As SqlDataReader

        lector = xCnx.ExecuteReader()
        lector2 = xCnx2.ExecuteReader()

        If lector.HasRows Or lector2.HasRows Then
            MessageBox.Show("No se puede eliminar porque hay registros en otras tablas !!")
        Else
            eliminarCuadrilla()
        End If
    End Sub

    Public Function consultaCuadrilla() As Boolean
        Dim strSql As String = "SELECT * FROM Cuadrilla WHERE id_cuadrilla = " & Cuadrillas.txtClave.Text & ""
        Dim adapter As New SqlDataAdapter(strSql, Form1.myConn)
        Dim dt As New DataTable

        consultaCuadrilla = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("id_cuadrilla")) Then
                id_cuadrilla = 0
            Else
                id_cuadrilla = CStr(dt.Rows(0)("id_cuadrilla"))
                Cuadrillas.txtDescripcion.Text = CStr(dt.Rows(0)("nombre"))
            End If
            consultaCuadrilla = True
        Else
            Cuadrillas.txtDescripcion.Text = ""
        End If
    End Function

    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim strSql As String = "SELECT id_cuadrilla As IDCuadrilla, nombre As Nombre FROM Cuadrilla"
        Dim adapter As New SqlDataAdapter(strSql, Form1.myConn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns.Item(0).Width = 90
        DataGridView1.Columns.Item(1).Width = 199
    End Sub
End Class

