Public Class Exhumacion_consultas
    Dim f As New functions
    Dim sql As String = ""
    Public item As String = ""

    Public Sub loader()
        Sql = ""
        item = 0
        sql = "SELECT e.TxtFolio, e.TxtFinado, e.TxtNoOrden, e.TxtFecha, e.TxtHora, e.TxtSituacion, e.TxtSolicitando FROM exhumaciones e"
        f.Exhumanaciones_Consultas(sql, Table)
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _update()
    End Sub

    Public Sub _update()
        f.Exhumanaciones_Consultas(sql, Table)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        f.GenReport(Table, "REPORTE DE EXHUMACIONES", False)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        item = Table.SelectedCells(0).Value
        If String.IsNullOrEmpty(item) = False Then
            f.ExhumacionDetails(item)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        item = Table.SelectedCells(0).Value
        If String.IsNullOrEmpty(item) = False Then
            f.ExhumacionDetails(item)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If f.is_admin Then
            If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
                If f.Exhumanaciondelete(item) Then
                    f.Mensaje("Elemento eliminado con exito", MsgBoxStyle.Information)
                    f.Exhumanaciones_Consultas(sql, Table)
                Else
                    f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
                End If
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If f.is_admin Then
            If String.IsNullOrEmpty(item) = False Then
                f.ExhumacionEdit(item)
            Else
                f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search()
    End Sub

    Private Sub Search()
        loader()
        sql = "SELECT e.TxtFolio, e.TxtFinado, e.TxtNoOrden, e.TxtFecha, e.TxtHora, e.TxtSituacion, e.TxtSolicitando FROM exhumaciones e where e.TxtFolio LIKE '%" + TxtSearch.Text + "%' or e.TxtFinado LIKE '%" + TxtSearch.Text + "%' or e.TxtNoOrden LIKE '%" + TxtSearch.Text + "%' or e.TxtSolicitando LIKE '%" + TxtSearch.Text + "%'"
        f.Exhumanaciones_Consultas(sql, Table)
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search()
        End If
    End Sub
End Class