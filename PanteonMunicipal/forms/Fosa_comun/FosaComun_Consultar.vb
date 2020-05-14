Public Class FosaComun_Consultar

    Dim f As New functions
    Dim sql As String = ""
    Dim item As String = ""


    Private Sub FosaComun_Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Public Sub loader()
        sql = ""
        item = 0
        sql = "SELECT * FROM `fosa_comun`"
        f.FosaComun_Consultas(sql, Table)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FosaComun_Add.Show()
        FosaComun_Add._loader()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        f.GenReport(Table, "REPORTE FOSA COMUN", False)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        item = Table.SelectedCells(0).Value
        If String.IsNullOrEmpty(item) = False Then
            f.FosaComunDetails(item)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        item = Table.SelectedCells(0).Value
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If f.is_admin Then
            If String.IsNullOrEmpty(item) = False Then
                f.FosaComunEdit(item)
            Else
                f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(item) = False Then
            f.FosaComunDetails(item)
        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _Update()
    End Sub

    Public Sub _Update()
        f.FosaComun_Consultas(sql, Table)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If f.is_admin Then
            If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
                If f.FosaComundelete(item) Then
                    f.Mensaje("Elemento eliminado con exito", MsgBoxStyle.Information)
                    _Update()
                Else
                    f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
                End If
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search()
    End Sub

    Private Sub search()
        sql = "SELECT * FROM fosa_comun WHERE TxtFolio LIKE '%" + TxtSearch.Text + "%' or TxtUbicacion LIKE '%" + TxtSearch.Text + "%'"
        f.FosaComun_Consultas(sql, Table)
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            search()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrEmpty(item) = False Then
            FosaComunAddDocs._loader(item)
            FosaComunAddDocs.Show()

        Else
            f.Mensaje("Seleccione un elemento", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class