Imports System.Data.SqlClient
Public Class ClaseDatosPersonales
    Private telefono As Long
    Private nombre As String
    Private paterno As String
    Private materno As String
    Public Sub New()
        telefono = 0
        nombre = ""
        paterno = ""
        materno = ""
    End Sub

    Public Sub New(ByVal telef As Long)
        telefono = telef
    End Sub
    Public Sub New(ByVal telef As Long, ByVal nom As String, ByVal pater As String, ByVal mater As String)
        telefono = telef
        nombre = nom
        paterno = pater
        materno = mater
    End Sub

    Public Property getSetTelefono() As Long
        Get
            Return telefono
        End Get
        Set(ByVal Value As Long)
            telefono = Value
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

    Public Property getSetPaterno() As String
        Get
            Return paterno
        End Get
        Set(ByVal Value As String)
            paterno = Value
        End Set
    End Property

    Public Property getSetMaterno() As String
        Get
            Return materno
        End Get
        Set(ByVal Value As String)
            materno = Value
        End Set
    End Property

    'Metodo para Insertar
    Public Sub insertaPersona()
        If telefono <> 0 And nombre <> "" And paterno <> "" And materno <> "" Then
            Dim xCnx As New SqlCommand("INSERT INTO Datos_Personales VALUES(" & telefono & ", '" & nombre & "', '" & paterno & "', '" & materno & "')", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
        Else
            MsgBox("Faltan datos para la persona, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar
    Public Sub actualizarPersona()
        If telefono <> 0 And nombre <> "" And paterno <> "" And materno <> "" Then
            Dim xCnx As New SqlCommand("UPDATE Datos_Personales SET nombre = '" & nombre & "', paterno = '" & paterno & "', materno = '" & materno & "' WHERE telefono = " & telefono & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados")
        Else
            MsgBox("Faltan datos para la persona, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarPersona()
        If telefono <> 0 Then
            Dim xCnx As New SqlCommand("DELETE FROM Datos_Personales WHERE telefono = " & telefono & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para la persona, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub validarEliminacion()
        Dim xCnx As New SqlCommand("Select * From Reportes where telefono = " & telefono & "", Form1.myConn)
        Dim lector As SqlDataReader

        lector = xCnx.ExecuteReader()

        If lector.HasRows Then
            MessageBox.Show("No se puede eliminar porque hay registros en otras tablas !!")
        Else
            eliminarPersona()
        End If
    End Sub

    Public Function consultaPersona() As Boolean
        Dim adapter As New SqlDataAdapter("SELECT * FROM Datos_Personales WHERE telefono = " & DatosPersonales.txtTelefono.Text & "", Form1.myConn)
        Dim dt As New DataTable

        consultaPersona = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("telefono")) Then
                telefono = 0
            Else
                telefono = CStr(dt.Rows(0)("telefono"))
                DatosPersonales.txtNombre.Text = CStr(dt.Rows(0)("nombre"))
                DatosPersonales.txtPaterno.Text = CStr(dt.Rows(0)("paterno"))
                DatosPersonales.txtMaterno.Text = CStr(dt.Rows(0)("materno"))
            End If
            consultaPersona = True
        Else
            limpiarCajas()
        End If
    End Function

    Public Sub limpiarCajas()
        DatosPersonales.txtNombre.Text = ""
        DatosPersonales.txtPaterno.Text = ""
        DatosPersonales.txtMaterno.Text = ""
    End Sub

    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT telefono As Telefono, nombre As Nombre, paterno As Paterno, materno As Materno FROM Datos_Personales", Form1.myConn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns.Item(0).Width = 68
        DataGridView1.Columns.Item(1).Width = 95
        DataGridView1.Columns.Item(2).Width = 63
        DataGridView1.Columns.Item(3).Width = 63
    End Sub
End Class