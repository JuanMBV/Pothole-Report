Public Class MainMenu
    Private Sub CuadrillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadrillaToolStripMenuItem.Click
        Cuadrillas.ShowDialog()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ColoniaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoniaToolStripMenuItem.Click
        Colonias.ShowDialog()
    End Sub

    Private Sub TurnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnoToolStripMenuItem.Click
        Turnos.ShowDialog()
    End Sub

    Private Sub DatosPersonalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosPersonalesToolStripMenuItem.Click
        DatosPersonales.ShowDialog()
    End Sub

    Private Sub IntegranteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegranteToolStripMenuItem.Click
        IntegrantesCuadrilla.ShowDialog()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        Empleados.ShowDialog()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Reportes.ShowDialog()
    End Sub
End Class