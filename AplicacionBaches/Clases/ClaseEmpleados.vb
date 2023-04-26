Imports System.Data.SqlClient
Public Class ClaseEmpleados
    Private id_empleado As Integer
    Private nombre As String
    Private paterno As String
    Private materno As String
    Private telefono As Long
    Private contrasena As String
    Private turno As String

    Public Sub New()
        id_empleado = 0
        nombre = ""
        paterno = ""
        materno = ""
        telefono = 0
        contrasena = ""
        turno = ""
    End Sub

    Public Sub New(ByVal idemp As Integer)
        id_empleado = idemp
    End Sub

    Public Sub New(ByVal idInt As Integer, ByVal nom As String, ByVal pater As String, ByVal mater As String, ByVal telef As Long, ByVal contra As String, ByVal turn As String)
        id_empleado = idInt
        nombre = nom
        paterno = pater
        materno = mater
        telefono = telef
        contrasena = contra
        turno = turn
    End Sub

    Public Property getSetIdEmpleado() As Integer
        Get
            Return id_empleado
        End Get
        Set(ByVal value As Integer)
            id_empleado = value
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

    Public Property getSetContrasena() As String
        Get
            Return contrasena
        End Get
        Set(ByVal Value As String)
            contrasena = Value
        End Set
    End Property

    Public Property getSetTurno() As String
        Get
            Return turno
        End Get
        Set(ByVal value As String)
            turno = value
        End Set
    End Property

    'Metodo para Insertar
    Public Sub insertaEmpleado()
        If id_empleado <> 0 And nombre <> "" And paterno <> "" And materno <> "" And telefono <> 0 And contrasena <> "" And turno <> "" Then
            Dim xCnx As New SqlCommand("INSERT INTO Empleado VALUES(" & id_empleado & ", (SELECT id_turno FROM Turno WHERE nombre = '" & turno & "'), '" & nombre & "', '" & paterno & "', '" & materno & "', " & telefono & ", '" & contrasena & "')", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
        Else
            MsgBox("Faltan datos para el empelado, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'Metodo para actualizar
    Public Sub actualizarEmpleado()
        If id_empleado <> 0 And nombre <> "" And paterno <> "" And materno <> "" And telefono <> 0 And contrasena <> "" And turno <> "" Then
            Dim xCnx As New SqlCommand("UPDATE Empleado SET id_turno = (SELECT id_turno FROM Turno WHERE nombre = '" & turno & "'), nombre = '" & nombre & "', paterno = '" & paterno & "', materno = '" & materno & "', telefono = " & telefono & ", contrasena = '" & contrasena & "' WHERE id_empleado = " & id_empleado & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados")
        Else
            MsgBox("Faltan datos para el empelado, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Sub eliminarEmpleado()
        If id_empleado <> 0 Then
            Dim xCnx As New SqlCommand("DELETE FROM Empleado WHERE id_empleado = " & id_empleado & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para el empelado, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Function consultaEmpleado() As Boolean
        Dim adapter As New SqlDataAdapter("SELECT id_empleado, Empleado.nombre, paterno, materno, telefono, contrasena, Turno.nombre AS Turno FROM Empleado, Turno WHERE id_empleado = " & Empleados.txtClave.Text & " AND Turno.id_turno = Empleado.id_turno", Form1.myConn)
        Dim dt As New DataTable

        consultaEmpleado = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("id_empleado")) Then
                id_empleado = 0
            Else
                id_empleado = CStr(dt.Rows(0)("id_empleado"))
                Empleados.txtNombre.Text = CStr(dt.Rows(0)("nombre"))
                Empleados.txtPaterno.Text = CStr(dt.Rows(0)("paterno"))
                Empleados.txtMaterno.Text = CStr(dt.Rows(0)("materno"))
                Empleados.txtTelefono.Text = CStr(dt.Rows(0)("telefono"))
                Empleados.txtContra.Text = CStr(dt.Rows(0)("contrasena"))
                Empleados.cmbTurno.Text = CStr(dt.Rows(0)("Turno"))
            End If
            consultaEmpleado = True
        Else
            limpiarCajas()
        End If
    End Function

    Public Sub poblarComboTurno(ByVal objeto As ComboBox)
        Dim lista As SqlDataReader
        Dim xCnx As New SqlCommand("SELECT nombre FROM Turno ORDER BY nombre ASC", Form1.myConn)

        lista = xCnx.ExecuteReader()

        objeto.Items.Clear()

        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
    End Sub

    Public Sub limpiarCajas()
        Empleados.cmbTurno.Text = "Seleccione Turno"
        Empleados.txtNombre.Text = ""
        Empleados.txtPaterno.Text = ""
        Empleados.txtMaterno.Text = ""
        Empleados.txtTelefono.Text = ""
        Empleados.txtContra.Text = ""
    End Sub


    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim adapter As New SqlDataAdapter("SELECT Turno.nombre As Turno, id_empleado As IDEmpleado, Empleado.nombre As Nombre, paterno As Paterno, materno As Materno, telefono As Telefono, contrasena As Contraseña FROM Empleado, Turno WHERE Turno.id_turno = Empleado.id_turno And Turno.nombre = '" & Empleados.cmbTurno.Text & "'", Form1.myConn)
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