Imports System.Data.SqlClient
Public Class ClaseColonias
    Private id_colonia As Integer
    Private nombre As String
    Private cp As Integer

    Public Sub New()
        id_colonia = 0
        nombre = ""
        cp = 0
    End Sub

    Public Sub New(ByVal idColonia As Integer)
        id_colonia = idColonia
    End Sub

    Public Sub New(ByVal idColonia As Integer, ByVal nom As String, ByVal coP As Integer)
        id_colonia = idColonia
        nombre = nom
        cp = coP
    End Sub

    Public Property getSetidColonia() As Integer
        Get
            Return id_colonia
        End Get
        Set(ByVal value As Integer)
            id_colonia = value
        End Set
    End Property

    Public Property getSetNombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property getSetCP() As Integer
        Get
            Return cp
        End Get
        Set(ByVal value As Integer)
            cp = value
        End Set
    End Property

    'Metodo para Insertar
    Public Sub insertarColonia()
        If id_colonia <> 0 And nombre <> "" And cp <> 0 Then
            Dim xCnx As New SqlCommand("INSERT INTO Colonia VALUES(" & id_colonia & ", '" & nombre & "', " & cp & ")", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
        Else
            MsgBox("Faltan datos para la colonia, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar
    Public Sub actualizarColonia()
        If id_colonia <> 0 And nombre <> "" And cp <> 0 Then
            Dim xCnx As New SqlCommand("UPDATE Colonia SET nombre = '" & nombre & "', cp = " & cp & " WHERE id_colonia = " & id_colonia & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados")
        Else
            MsgBox("Faltan datos para la colonia, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarColonia()
        If id_colonia <> 0 Then
            Dim xCnx As New SqlCommand("DELETE FROM Colonia WHERE id_colonia = " & id_colonia & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para la colonia, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub validarEliminacion()
        Dim xCnx As New SqlCommand("Select * From reportes where id_colonia = " & id_colonia & "", Form1.myConn)
        Dim lector As SqlDataReader

        lector = xCnx.ExecuteReader()

        If lector.HasRows Then
            MessageBox.Show("No se puede eliminar porque hay registros en otras tablas !!")
        Else
            eliminarColonia()
        End If
    End Sub

    Public Function consultaColonia() As Boolean
        Dim adapter As New SqlDataAdapter("SELECT * FROM Colonia WHERE id_colonia = " & Colonias.txtClave.Text & "", Form1.myConn)
        Dim dt As New DataTable

        consultaColonia = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("id_colonia")) Then
                id_colonia = 0
            Else
                id_colonia = CStr(dt.Rows(0)("id_colonia"))
                Colonias.txtDescripcion.Text = CStr(dt.Rows(0)("nombre"))
                Colonias.txtCp.Text = CStr(dt.Rows(0)("cp"))
            End If
            consultaColonia = True
        Else
            limpiarCajas()
        End If
    End Function

    Public Sub limpiarCajas()
        Colonias.txtDescripcion.Text = ""
        Colonias.txtCp.Text = ""
    End Sub

    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT id_colonia As IDColonia, nombre As Nombre, cp As CP FROM Colonia", Form1.myConn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        DataGridView1.DataSource = dt

        DataGridView1.Columns.Item(0).Width = 79
        DataGridView1.Columns.Item(1).Width = 120
        DataGridView1.Columns.Item(2).Width = 90
    End Sub
End Class