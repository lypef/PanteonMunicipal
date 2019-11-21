Public Class Inhumanacion_pagos
    Dim f As New functions
    Dim sql As String = ""
    Dim item As Int32 = 0

    Public Sub loader()
        Sql = ""
        item = 0
        sql = "SELECT p.id, i.TxtNombre, i.TxtNombreResponsable, p.descripcion, p.concepto, p.monto, p.fecha FROM inhumaciones i, inhumaciones_pagos p WHERE p.inhumanacion = i.id"
        f.Inhumanaciones_Pagos(sql, Table)
    End Sub

    Private Sub Inhumanacion_pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        f.GenReport(Table, "REPORTE, PAGOS DE INHUMACIONES", False)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _update()
    End Sub

    Public Sub _update()
        f.Inhumanaciones_Pagos(sql, Table)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        item = Table.SelectedCells(0).Value
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        item = Table.SelectedCells(0).Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If f.is_admin Then
            If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
                If f.InhumanaciondeletePagos(item) Then
                    f.Mensaje("Elemento eliminado con exito", MsgBoxStyle.Information)
                    f.Inhumanaciones_Pagos(sql, Table)
                Else
                    f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
                End If
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search()
    End Sub

    Private Sub Search()
        sql = "SELECT p.id, i.TxtNombre, i.TxtNombreResponsable, p.descripcion, p.concepto, p.monto, p.fecha FROM inhumaciones i, inhumaciones_pagos p WHERE p.inhumanacion = i.id and i.TxtNombre LIKE '%" + TxtSearch.Text + "%' or p.inhumanacion = i.id and i.TxtNombreResponsable LIKE '%" + TxtSearch.Text + "%' or p.inhumanacion = i.id and i.TxtNoTumba LIKE '%" + TxtSearch.Text + "%'"
        f.Inhumanaciones_Pagos(sql, Table)
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f.ReportInhumanacionPagop(item)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If f.is_admin Then
            If item <> 0 Then
                f.InhumanacionPagosEdit(item.ToString)
            Else
                f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub
End Class