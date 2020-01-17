Public Class papelera

    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Public Sub loading()
        Dim Sql = "SELECT id, TxtPerpetuidad, TxtNoTumba, TxtFechaNacimiento, TxtFechaDefunsion FROM `inhumaciones` WHERE _delete = 1"
        f.Inhumanaciones_Consultas_Delete(Sql, Table)
        Inhumanacion_consultas._update()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim item = Table.SelectedCells(0).Value

        If (MsgBox("¿Esta seguro de recuperar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
            If f.InhumanacionRecovery(item) Then
                f.Mensaje("Elemento recuperado con exito", MsgBoxStyle.Information)
                loading()
            Else
                f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item = Table.SelectedCells(0).Value
        If f.is_admin Then
            If (MsgBox("¿Esta seguro de eliminar para SIEMPRE el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Critical + vbYesNo) = vbYes) Then
                If f.InhumanaciondeleteForEver(item) Then
                    f.Mensaje("Elemento eliminado con exito", MsgBoxStyle.Information)
                    loading()
                Else
                    f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
                End If
            End If
        Else
            f.Mensaje("No cuenta con permisos", MsgBoxStyle.Critical)
        End If
    End Sub
End Class