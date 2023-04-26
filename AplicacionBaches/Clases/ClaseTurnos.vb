Imports System.Data.SqlClient
Public Class ClaseTurnos
    Private id_turno As Integer
    Private nombre As String
    Public Sub New()
        id_turno = 0
        nombre = ""
    End Sub

    Public Sub New(ByVal idTurn As Integer)
        id_turno = idTurn
    End Sub

    Public Sub New(ByVal idTurno As Integer, ByVal nom As String)
        id_turno = idTurno
        nombre = nom
    End Sub

    Public Property getSetidTurno() As Integer
        Get
            Return id_turno
        End Get
        Set(ByVal Value As Integer)
            id_turno = Value
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

    'Metodo para Insertar
    Public Sub insertarTurno()
        If id_turno <> 0 And nombre <> "" Then
            Dim xCnx As New SqlCommand("INSERT INTO Turno VALUES(" & id_turno & ", '" & nombre & "')", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
        Else
            MsgBox("Faltan datos para el turno, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar
    Public Sub actualizarTurno()
        If id_turno <> 0 And nombre <> "" Then
            Dim xCnx As New SqlCommand("UPDATE Turno SET nombre = '" & nombre & "' WHERE id_turno = " & id_turno & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados")
        Else
            MsgBox("Faltan datos para el turno, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarTurno()
        If id_turno <> 0 Then
            Dim xCnx As New SqlCommand("DELETE FROM Turno WHERE id_turno = " & id_turno & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para el turno, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub validarEliminacion()
        Dim xCnx As New SqlCommand("Select * From Empleado where id_turno = " & id_turno & "", Form1.myConn)
        Dim lector As SqlDataReader

        lector = xCnx.ExecuteReader()

        If lector.HasRows Then
            MessageBox.Show("No se puede eliminar porque hay registros en otras tablas !!")
        Else
            eliminarTurno()
        End If
    End Sub

    Public Function consultaTurno() As Boolean
        Dim adapter As New SqlDataAdapter("SELECT * FROM Turno WHERE id_turno = " & Turnos.txtClave.Text & "", Form1.myConn)
        Dim dt As New DataTable

        consultaTurno = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("id_turno")) Then
                id_turno = 0
            Else
                id_turno = CStr(dt.Rows(0)("id_turno"))
                Turnos.txtDescripcion.Text = CStr(dt.Rows(0)("nombre"))
            End If
            consultaTurno = True
        Else
            Turnos.txtDescripcion.Text = ""
        End If
    End Function

    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT id_turno As IDTurno, nombre As Nombre FROM Turno", Form1.myConn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns.Item(0).Width = 90
        DataGridView1.Columns.Item(1).Width = 199
    End Sub
End Class