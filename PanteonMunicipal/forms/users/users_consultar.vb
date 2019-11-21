Public Class users_consultar
    Dim f As New functions
    Dim sql As String = ""
    Dim item As Int32 = 0

    Public Sub loader()
        sql = ""
        item = 0
        sql = "SELECT u.id, u.username, u.password, u.name, if (u.is_admin = 1, 'ADMINISTRADOR', 'USUARIO') as nivel FROM users u"
        f.users_Consultas(sql, Table)
    End Sub

    Private Sub _update()
        f.users_Consultas(sql, Table)
    End Sub

    Private Sub users_consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        f.GenReport(Table, "REPORTE DE USUARIOS", False)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        item = f.Listusers(Table.CurrentRow.Index)
    End Sub

    Private Sub Table_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Table.CellMouseClick
        item = f.Listusers(Table.CurrentRow.Index)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If f.is_admin Then
            If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
                If f.Users_Delete(item) Then
                    _update()
                Else
                    f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
                End If
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        _update()
    End Sub
End Class