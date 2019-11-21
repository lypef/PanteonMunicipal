Public Class Espacios_NuevaSeccion

    Dim f = New functions

    Public Sub _loader()
        Combo.Text = ""
        f.Espacios_SeccionesGET("select * from espacios_secciones", Table)
    End Sub

    Private Sub Espacios_NuevaSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loader()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(Combo.Text) Then
            _loader()
        Else
            If f.Espacios_SeccionAdd(Combo) Then
                _loader()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Table_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellValueChanged
        f.Espacios_SeccionUpdate(Table.CurrentRow.Cells(0).Value.ToString, Table.CurrentRow.Index)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim item = Table.CurrentRow.Index.ToString

        If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
            If f.Espacios_SeccionaDelete(item) Then
                _loader()
            Else
                f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class