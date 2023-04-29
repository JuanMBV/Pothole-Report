Imports System.Data.SqlClient
Imports System.Globalization

Public Class ClaseReportes
    Private id_bache As Integer
    Private empleado As String
    Private telefono As Long
    Private direccion As String
    Private entreCalle1 As String
    Private entreCalle2 As String
    Private colonia As String
    Private fechaReporte As String
    Private horaReporte As String
    Private cuadrilla As String
    Private fechaAsignada As String
    Private horaAsignada As String
    Private solu As Byte
    Private fechaSolucion As String
    Private horaSolucion As String

    Public Sub New()
        'COnstructor vacio
    End Sub

    Public Sub New(ByVal idBache As Integer)
        id_bache = idBache
    End Sub

    Public Sub New(ByVal idbache As Integer, ByVal emp As String, ByVal telef As Long, ByVal direcc As String,
                   ByVal calle1 As String, ByVal calle2 As String, ByVal col As String, ByVal fechRep As String,
                   ByVal horaRep As String, ByVal cuadr As String, ByVal fechAsig As String, ByVal horaAsig As String,
                   ByVal sol As Byte, ByVal fechSol As String, ByVal horaSol As String)
        id_bache = idbache
        empleado = emp
        telefono = telef
        direccion = direcc
        entreCalle1 = calle1
        entreCalle2 = calle2
        colonia = col
        fechaReporte = fechRep
        horaReporte = horaRep
        cuadrilla = cuadr
        fechaAsignada = fechAsig
        horaAsignada = horaAsig
        solu = sol
        fechaSolucion = fechSol
        horaSolucion = horaSol
    End Sub

    Public Property getSetIdBache() As Integer
        Get
            Return id_bache
        End Get
        Set(ByVal value As Integer)
            id_bache = value
        End Set
    End Property

    Public Property getSetEmpleado() As String
        Get
            Return empleado
        End Get
        Set(ByVal Value As String)
            empleado = Value
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

    Public Property getSetDireccion() As String
        Get
            Return direccion
        End Get
        Set(ByVal value As String)
            direccion = value
        End Set
    End Property

    Public Property getSetEntreCalle1() As String
        Get
            Return entreCalle1
        End Get
        Set(ByVal value As String)
            entreCalle1 = value
        End Set
    End Property

    Public Property getSetEntreCalle2() As String
        Get
            Return entreCalle2
        End Get
        Set(ByVal value As String)
            entreCalle2 = value
        End Set
    End Property

    Public Property getSetColonia() As String
        Get
            Return colonia
        End Get
        Set(ByVal value As String)
            colonia = value
        End Set
    End Property

    Public Property getSetFechaReporte() As String
        Get
            Return fechaReporte
        End Get
        Set(ByVal value As String)
            fechaReporte = value
        End Set
    End Property

    Public Property getSetHoraReporte() As String
        Get
            Return horaReporte
        End Get
        Set(ByVal value As String)
            horaReporte = value
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

    Public Property getSetFechaAsignada() As String
        Get
            Return fechaAsignada
        End Get
        Set(ByVal value As String)
            fechaAsignada = value
        End Set
    End Property

    Public Property getSetHoraAsignada() As String
        Get
            Return horaAsignada
        End Get
        Set(ByVal value As String)
            horaAsignada = value
        End Set
    End Property

    Public Property getSetSolu() As Byte
        Get
            Return solu
        End Get
        Set(ByVal value As Byte)
            solu = value
        End Set
    End Property

    Public Property getSetFechaSolucion() As String
        Get
            Return fechaSolucion
        End Get
        Set(ByVal value As String)
            fechaSolucion = value
        End Set
    End Property

    Public Property getSetHoraSolucion() As String
        Get
            Return horaSolucion
        End Get
        Set(ByVal value As String)
            horaSolucion = value
        End Set
    End Property

    '-------------------------------------------------------------------------------------------
    'Creo que lo de arriba ya esta bien JJAJAJJAJAJ
    '-------------------------------------------------------------------------------------------


    'Metodo para Insertar


    Public Sub insertaReporte()
        If id_bache <> 0 And empleado <> "" And telefono <> 0 And validarTelefono() = True And direccion <> "" And entreCalle1 <> "" And entreCalle2 <> "" And colonia <> "" And fechaReporte <> "" And horaReporte <> "" And cuadrilla <> "" And fechaAsignada <> "" And horaAsignada <> "" Then

            Dim consulta As String
            Dim xCnx As SqlCommand

            If solu = 0 Then
                consulta = "INSERT INTO Reportes VALUES(" & id_bache & ", (SELECT id_empleado FROM Empleado WHERE nombre = '" & empleado & "'), (SELECT id_cuadrilla FROM Cuadrilla WHERE nombre = '" & cuadrilla & "'), (SELECT id_colonia FROM Colonia WHERE nombre = '" & colonia & "'), " & telefono & ", '" & direccion & "', '" & entreCalle1 & "', '" & entreCalle2 & "', '" & fechaReporte & "', '" & horaReporte & "', '" & horaAsignada & "', '" & fechaAsignada & "', @horaSolucion, @fechaSolucion, " & solu & ")"
                xCnx = New SqlCommand(consulta, Form1.myConn)
                xCnx.Parameters.AddWithValue("@horaSolucion", DBNull.Value)
                xCnx.Parameters.AddWithValue("@fechaSolucion", DBNull.Value)
            Else
                consulta = "INSERT INTO Reportes VALUES(" & id_bache & ", (SELECT id_empleado FROM Empleado WHERE nombre = '" & empleado & "'), (SELECT id_cuadrilla FROM Cuadrilla WHERE nombre = '" & cuadrilla & "'), (SELECT id_colonia FROM Colonia WHERE nombre = '" & colonia & "'), " & telefono & ", '" & direccion & "', '" & entreCalle1 & "', '" & entreCalle2 & "', '" & fechaReporte & "', '" & horaReporte & "', '" & horaAsignada & "', '" & fechaAsignada & "', '" & horaSolucion & "', '" & fechaSolucion & "', " & solu & ")"
                xCnx = New SqlCommand(consulta, Form1.myConn)
            End If
            xCnx.ExecuteNonQuery()
            MsgBox("Datos Insertados")
            limpiarCajas()
            Reportes.txtReporte.Text = ""
        Else
            If validarTelefono() = False Then
                MsgBox("Telefono no registrado, verifique !!", MsgBoxStyle.Critical, "ATENCION !!")
            Else
                MsgBox("Faltan datos para el reporte, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
            End If
        End If
    End Sub

    'El metodo de insertar funciona al 100%

    'Metodo para actualizar
    Public Sub actualizarReporte()
        If id_bache <> 0 And empleado <> "" And telefono <> 0 And direccion <> "" And entreCalle1 <> "" And entreCalle2 <> "" And colonia <> "" And fechaReporte <> "" And horaReporte <> "" And cuadrilla <> "" And fechaAsignada <> "" And horaAsignada <> "" Then
            Dim xCnx As New SqlCommand("UPDATE Reportes SET id_empleado = (SELECT id_empleado FROM Empleado WHERE nombre = '" & empleado & "'), id_cuadrilla = (SELECT id_cuadrilla FROM Cuadrilla WHERE nombre = '" & cuadrilla & "'), id_colonia = (SELECT id_colonia FROM Colonia WHERE nombre = '" & colonia & "'), telefono = " & telefono & ", direccion = '" & direccion & "', entre_calle1 = '" & entreCalle1 & "', entre_calle2 = '" & entreCalle2 & "', fecha_reporte = '" & fechaReporte & "', hora_reporte = '" & horaReporte & "', hora_asignada = '" & horaAsignada & "', fecha_asignada = '" & fechaAsignada & "', hora_solucion = '" & horaSolucion & "', fecha_solucion = '" & fechaSolucion & "', solucion = " & solu & " WHERE id_bache = " & id_bache & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Actualizados")
        Else
            MsgBox("Faltan datos para el reporte, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    'El metodo de actualizar aparentemente funciona al 100%, igual estar al pendiente 

    'Metodo para eliminar
    Public Sub eliminarReporte()
        If id_bache <> 0 Then
            Dim xCnx As New SqlCommand("DELETE FROM Reportes WHERE id_bache = " & id_bache & "", Form1.myConn)

            xCnx.ExecuteNonQuery()
            MsgBox("Datos Eliminados!!")
        Else
            MsgBox("Faltan datos para el reporte, verifique !!", MsgBoxStyle.Critical, "ATENCION!!")
        End If
    End Sub

    Public Function consultaReporte() As Boolean
        Dim adapter As New SqlDataAdapter("SELECT id_bache, Empleado.nombre AS Empleado, Empleado.paterno As Paterno, Empleado.materno, Cuadrilla.nombre AS Cuadrilla, Colonia.nombre AS Colonia, Reportes.telefono, direccion, entre_calle1, entre_calle2, fecha_reporte, hora_reporte, hora_asignada, fecha_asignada, hora_solucion, fecha_solucion, solucion FROM Reportes, Empleado, Cuadrilla, Colonia WHERE id_bache = " & Reportes.txtReporte.Text & " AND Empleado.id_empleado = Reportes.id_empleado AND Colonia.id_colonia = Reportes.id_colonia AND Cuadrilla.id_cuadrilla = Reportes.id_cuadrilla", Form1.myConn)
        Dim dt As New DataTable

        consultaReporte = False

        adapter.Fill(dt)

        If dt.Rows.Count = 1 Then
            If IsDBNull(dt.Rows(0)("id_bache")) Then
                id_bache = 0
                limpiarCajas()
            Else
                'Aqui tengo que checar q regresen bien las fechas mas que nada
                'Tambien checar que al regresaral empleado tambien se regrese el apellido
                id_bache = CStr(dt.Rows(0)("id_bache"))
                Dim nomEmp As String = String.Concat(dt.Rows(0)("Empleado"), " ", dt.Rows(0)("Paterno"), " ", dt.Rows(0)("Materno"))

                Reportes.txtEmpleado.Text = nomEmp
                Reportes.txtTelefono.Text = CStr(dt.Rows(0)("telefono"))
                Reportes.cmbDireccion.Text = CStr(dt.Rows(0)("direccion"))
                Reportes.cmbEntreCalle1.Text = CStr(dt.Rows(0)("entre_calle1"))
                Reportes.cmbEntreCalle2.Text = CStr(dt.Rows(0)("entre_calle2"))
                Reportes.cmbColonia.Text = CStr(dt.Rows(0)("Colonia"))
                Reportes.dtpFechaReporte.Text = CStr(dt.Rows(0)("fecha_reporte"))
                Reportes.txtHoraReporte.Text = Format(TimeValue(dt.Rows(0)("hora_reporte").ToString), "HH:mm")
                Reportes.cmbCuadrilla.Text = CStr(dt.Rows(0)("cuadrilla"))
                Reportes.dtpFechaAsignada.Text = CStr(dt.Rows(0)("fecha_asignada"))
                Reportes.txtHoraAsignada.Text = Format(TimeValue(dt.Rows(0)("hora_asignada").ToString), "HH:mm")
                'Agregar forma de que se autocomplete los radiobutton
                If dt.Rows(0)("solucion") = True Then
                    Reportes.rBtnSi.Checked = True
                    Reportes.dtpFechaSolucion.Text = dt.Rows(0)("fecha_solucion").ToString
                    Reportes.txtHoraSolucion.Text = Format(TimeValue(dt.Rows(0)("hora_solucion").ToString), "HH:mm")
                End If
            End If
            consultaReporte = True
        Else
            limpiarCajas()
        End If
    End Function

    Public Sub poblarComboCalles(ByVal objeto As ComboBox, ByVal colon As String)
        Dim lista As SqlDataReader
        Dim xCnx As New SqlCommand("SELECT Calles.nombre FROM CALLES_HAS_COLONIA, Calles, Colonia WHERE Calles_has_Colonia.id_calle = Calles.id_calle AND Calles_has_Colonia.id_colonia = Colonia.id_colonia AND Calles_has_Colonia.id_colonia = (SELECT id_colonia FROM Colonia WHERE nombre = '" & colon & "')", Form1.myConn)

        lista = xCnx.ExecuteReader()

        objeto.Items.Clear()

        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
    End Sub

    Public Sub poblarComboColonia(ByVal objeto As ComboBox)
        Dim lista As SqlDataReader
        Dim xCnx As New SqlCommand("SELECT nombre FROM Colonia ORDER BY nombre ASC", Form1.myConn)

        lista = xCnx.ExecuteReader()

        objeto.Items.Clear()

        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
    End Sub

    Public Sub poblarComboCuadrilla(ByVal objeto As ComboBox)
        Dim lista As SqlDataReader
        Dim xCnx As New SqlCommand("SELECT nombre FROM Cuadrilla ORDER BY nombre ASC", Form1.myConn)

        lista = xCnx.ExecuteReader()

        objeto.Items.Clear()

        While lista.Read()
            objeto.Items.Add(lista.GetValue(0))
        End While
    End Sub

    Public Sub limpiarCajas()
        establecerEmpleado()
        Reportes.txtTelefono.Text = ""
        Reportes.cmbDireccion.Text = "Seleccione direccion"
        Reportes.cmbEntreCalle1.Text = "Seleccione entre calle 1"
        Reportes.cmbEntreCalle2.Text = "Seleccione entre calle 2"
        Reportes.cmbColonia.Text = "Seleccione colonia"
        Reportes.dtpFechaAsignada.Text = "" 'Aqui debe de regresar a la fecha actual
        Reportes.txtHoraAsignada.Text = ""
        Reportes.dtpFechaReporte.Text = "" 'Aqui debe de regresar a la fecha actual
        Reportes.txtHoraReporte.Text = ""
        Reportes.cmbCuadrilla.Text = "Seleccione cuadrilla"
        Reportes.rBtnNo.Checked = True
        Reportes.dtpFechaSolucion.Text = "" 'Aqui debe de regresar a la fecha actual
        Reportes.txtHoraSolucion.Text = ""
    End Sub

    Public Sub establecerEmpleado()
        Dim xCnx As New SqlCommand("Select nombre, paterno, materno from Empleado WHERE id_empleado = " & Form1.txtIdEmployee.Text & "", Form1.myConn)
        Dim lector As SqlDataReader
        Dim nombreCompleto As String = ""
        lector = xCnx.ExecuteReader()
        While lector.Read()
            nombreCompleto = String.Concat(lector("nombre"), " ", lector("paterno"), " ", lector("materno"))
        End While
        Reportes.txtEmpleado.Text = nombreCompleto
    End Sub

    Public Function validarTelefono() As Boolean
        Dim xCnx As New SqlCommand("SELECT * FROM Datos_Personales WHERE telefono = " & Reportes.txtTelefono.Text & "", Form1.myConn)
        Dim lector As SqlDataReader

        lector = xCnx.ExecuteReader()

        If lector.HasRows Then
            validarTelefono = True
        Else
            validarTelefono = False
        End If
    End Function

    Public Function validarHoraReporte(ByVal horaReporte As String) As Boolean
        Dim horaRep As Date = DateTime.ParseExact(horaReporte, "HH:mm", CultureInfo.InvariantCulture)
        Dim horaInicio As New TimeSpan(8, 0, 0)
        Dim horaFin As New TimeSpan(16, 0, 0)

        Dim horaReporteTS As TimeSpan = horaRep.TimeOfDay

        If horaReporteTS >= horaInicio AndAlso horaReporteTS <= horaFin Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function validarFechaHora(ByVal fecha1 As String, ByVal hora1 As String, ByVal fecha2 As String, ByVal hora2 As String) As Boolean
        Dim f1 As Date = DateTime.ParseExact(fecha1, "yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim f2 As Date = DateTime.ParseExact(fecha2, "yyyy-MM-dd", CultureInfo.InvariantCulture)
        Dim h1 As Date = DateTime.ParseExact(hora1, "HH:mm", CultureInfo.InvariantCulture)
        Dim h2 As Date = DateTime.ParseExact(hora2, "HH:mm", CultureInfo.InvariantCulture)

        If DateTime.Compare(f2 + h2.TimeOfDay, f1 + h1.TimeOfDay) >= 0 Then
            validarFechaHora = False
        Else
            validarFechaHora = True
        End If
    End Function


    Public Sub DGV(ByVal DataGridView1 As DataGridView)
        Dim fechaActual As String = Date.Now.ToString("yyyy-MM-dd")
        Dim adapter As New SqlDataAdapter("SELECT id_bache As IDBache, CONCAT(Empleado.nombre, ' ', Empleado.paterno, ' ', Empleado.materno) As Atiende, Cuadrilla.nombre As CuadrillaAsignada, Colonia.nombre As Colonia, Reportes.telefono As Telefono, direccion As Direccion, entre_calle1 As EntreCalle1, entre_calle2 As EntreCalle2, fecha_reporte As FechaReporte, hora_reporte As HoraReporte, fecha_asignada As FechaAsignada, hora_asignada As HoraAsignada, solucion As Se_soluciono, fecha_solucion As FechaSolucion, hora_solucion As HoraSolucion FROM Reportes, Empleado, Cuadrilla, Colonia WHERE Empleado.id_empleado = Reportes.id_empleado AND Cuadrilla.id_cuadrilla = Reportes.id_cuadrilla AND Colonia.id_colonia = Reportes.id_colonia AND fecha_reporte = '" & fechaActual & "'", Form1.myConn)
        Dim dt As New DataTable

        adapter.Fill(dt)
        DataGridView1.DataSource = dt
        'Aqui falta las demas columnas (Son demasiadas AaaAAaAAA)
    End Sub
End Class