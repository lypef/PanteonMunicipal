Public Class Espacios_Consultas

    Dim f As New functions
    Dim Sql = ""
    Dim item = 0

    Public Sub _loader()
        Sql = ""
        item = 0
        Sql = "SELECT a.id, a.TxtModalidad, a.TxtObservaciones, a.TxtCaducidad, a.TxtCosto, i.TxtNombre, s.nombre , l.nombre, i.TxtNombreResponsable FROM espacios_asignacion a, inhumaciones i, espacios_secciones_lugares l, espacios_secciones s  WHERE a.inhumacion = i.id and a.espacios_secciones_lugares = l.id and l.seccion = s.id"
        f.EspaciosAsignaciones_Consultas(Sql, Table)
    End Sub

    Private Sub Espacios_Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loader()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        f.EspaciosAsignaciones_Consultas(Sql, Table)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        f.GenReport(Table, "REPORTE DE ESPACIOS", False)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        item = f.ListSecciones_LugaresAsignados(Table.CurrentRow.Index)
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        item = f.ListSecciones_LugaresAsignados(Table.CurrentRow.Index)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        f.ReportAsignacionEspacioPago(item)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
            If f.EspaciosAsignados_Delete(item) Then
                f.Mensaje("Elemento eliminado con exito", MsgBoxStyle.Information)
                f.EspaciosAsignaciones_Consultas(Sql, Table)
            Else
                f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class