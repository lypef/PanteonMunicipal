Public Class Inhumanacion_consultas
    Dim f As New functions
    Dim sql As String = ""
    Dim item As Int32 = 0

    Public Sub loader()
        sql = ""
        item = 0
        sql = "SELECT id, TxtNombre, TxtPerpetuidad, TxtNoTumba, TxtFechaDefunsion, TxtNombreResponsable FROM `inhumaciones`"
        f.Inhumanaciones_Consultas(sql, Table)
    End Sub

    Private Sub Inhumanacion_consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        f.GenReport(Table, "REPorte inhumaciones", False)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        f.GenReport(Table, "REPORTE DE INHUMACIONES", False)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Search()
    End Sub

    Private Sub Search()
        sql = "SELECT * FROM inhumaciones WHERE TxtNombre LIKE '%" + TxtSearch.Text + "%' OR TxtZona LIKE '%" + TxtSearch.Text + "%' OR TxtNoTumba LIKE '%" + TxtSearch.Text + "%' OR TxtNombreResponsable LIKE '%" + TxtSearch.Text + "%';"
        f.Inhumanaciones_Consultas(sql, Table)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
            If f.Inhumanaciondelete(item) Then
                f.Mensaje("Elemento eliminado con exito", MsgBoxStyle.Information)
                f.Inhumanaciones_Consultas(sql, Table)
            Else
                f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If item <> 0 Then
            f.InhumanacionEdit(item.ToString)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        f.Inhumanaciones_Consultas(sql, Table)
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        item = Table.SelectedCells(0).Value
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        item = Table.SelectedCells(0).Value
        If item <> 0 Then
            f.InhumanacionDetails(item.ToString)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If item <> 0 Then
            f.InhumanacionDetails(item.ToString)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        _update()
    End Sub

    Public Sub _update()
        f.Inhumanaciones_Consultas(sql, Table)
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        f.InhumanacionPagar(item)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If f.AsignarCheck(item) = False Then
            f.AsignarEspacio(item)
        Else
            f.Mensaje("Este elemento ya contiene un espacio", MsgBoxStyle.Critical)
        End If

    End Sub
End Class