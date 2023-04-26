Imports System.Data.SqlClient
Public Class ClaseIntegrantesCuadrilla
    Private id_integrantes As Integer
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private telefono As Long
    Private cuadrilla As String
    Public Sub New()
        id_integrantes = 0
        nombre = ""
        paterno = ""
        materno = ""
        telefono = 0
        cuadrilla = ""
    End Sub

    Public Sub New(ByVal idInt As Integer)
        id_integrantes = idInt
    End Sub

    Public Sub New(ByVal idInt As Integer, ByVal nom As String, ByVal pater As String, ByVal mater As String, ByVal telef As Long, ByVal cuad As String)
        id_integrantes = idInt
        nombre = nom
        paterno = pater
        materno = mater
        telefono = telef
        cuadrilla = cuad
    End Sub

    Public Property getSetIdIntegrante() As Integer
        Get
            Return id_integrantes
        End Get
        Set(ByVal value As Integer)
            id_integrantes = value
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

    Public Property getSetTelefono() As Long
        Get
            Return telefono
        End Get
        Set(ByVal Value As Long)
            telefono = Value
        End Set
    End Property

    Public Property getSetCuadrilla() As String
        Get
            Return cuadrilla
        End Get
        Set(ByVal value As String)
            cuadrilla = value
        End Set
    End Property

    'Metodo para Insertar
    Public Sub insertaIntegrante()
        If id_integrantes <> 0 And nombre <> "" And paterno <> "" And materno <> "" And telefono <> 0 And cuadrilla <> "" Then
            Dim xCnx As New SqlCommand("INSERT INTO Integrantes_Cuadrilla VALUES(" & id_integrantes & ", (SELECT id_cuadrilla FROM Cuadrilla WHERE nombre = '" & cuadrilla & "'), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ")", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
        Else
            MsgBox("Faltan datos para el integrante de la cuadrilla, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar
    Public Sub actualizarIntegrante()
        If id_integrantes <> 0 And nombre <> "" And paterno <> "" And materno <> "" And telefono <> 0 And cuadrilla <> "" Then
            Dim xCnx As New SqlCommand("UPDATE Integrantes_Cuadrilla SET id_cuadrilla = (SELECT id_cuadrilla FROM Cuadrilla WHERE nombre = '" & cuadrilla & "'), nombre = '" & nombre & "', paterno = '" & paterno & "', materno = '" & materno & "', telefono = " & telefono & " WHERE id_integrantes = " & id_integrantes & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados")
        Else
            MsgBox("Faltan datos para el integrante de la cuadrilla, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarIntegrante()
        If id_integrantes <> 0 Then
            Dim xCnx As New SqlCommand("DELETE FROM Integrantes_Cuadrilla WHERE id_integrantes = " & id_integrantes & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para el integrante de la cuadrilla, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Function consultaIntegrante() As Boolean
        Dim adapter As New SqlDataAdapter("SELECT id_integrantes, Integrantes_Cuadrilla.nombre, paterno, materno, telefono, Cuadrilla.nombre AS Cuadrilla FROM Integrantes_Cuadrilla, Cuadrilla WHERE id_integrantes = " & IntegrantesCuadrilla.txtClave.Text & " and Cuadrilla.id_cuadrilla = Integrantes_Cuadrilla.id_cuadrilla", Form1.myConn)
        Dim dt As New DataTable

        consultaIntegrante = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("id_integrantes")) Then
                id_integrantes = 0
            Else
                id_integrantes = CStr(dt.Rows(0)("id_integrantes"))
                IntegrantesCuadrilla.txtNombre.Text = CStr(dt.Rows(0)("nombre"))
                IntegrantesCuadrilla.txtPaterno.Text = CStr(dt.Rows(0)("paterno"))
                IntegrantesCuadrilla.txtMaterno.Text = CStr(dt.Rows(0)("materno"))
                IntegrantesCuadrilla.txtTelefono.Text = CStr(dt.Rows(0)("telefono"))
                IntegrantesCuadrilla.cmbCuadrilla.Text = CStr(dt.Rows(0)("Cuadrilla")) 'Validar esta casilla, encontrar la manera de que no regrese el id, si no el nombre xd
            End If
            consultaIntegrante = True
        Else
            limpiarCajas()
        End If
    End Function

    Public Sub poblarComboCuadrillas(ByVal objeto As ComboBox)
        Dim lista As SqlDataReader
        Dim xCnx As New SqlCommand("SELECT nombre FROM Cuadrilla ORDER BY nombre ASC", Form1.myConn)

        lista = xCnx.ExecuteReader()

        objeto.Items.Clear()

        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
    End Sub

    Public Sub limpiarCajas()
        IntegrantesCuadrilla.txtNombre.Text = ""
        IntegrantesCuadrilla.txtPaterno.Text = ""
        IntegrantesCuadrilla.txtMaterno.Text = ""
        IntegrantesCuadrilla.txtTelefono.Text = ""
        IntegrantesCuadrilla.cmbCuadrilla.Text = "Seleccione Cuadrilla"
    End Sub

    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT cuadrilla.nombre as Cuadrilla, id_integrantes As IDIntegrante, integrantes_cuadrilla.nombre As Nombre, paterno As Paterno, materno As Materno, telefono As Telefono FROM Integrantes_Cuadrilla, Cuadrilla WHERE cuadrilla.id_cuadrilla = integrantes_cuadrilla.id_cuadrilla AND cuadrilla.nombre = '" & IntegrantesCuadrilla.cmbCuadrilla.Text & "'", Form1.myConn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns.Item(0).Width = 68
        DataGridView1.Columns.Item(1).Width = 95
        DataGridView1.Columns.Item(2).Width = 63
        DataGridView1.Columns.Item(3).Width = 63
        DataGridView1.Columns.Item(4).Width = 60
        DataGridView1.Columns.Item(5).Width = 60
    End Sub
End Class