Public Class Espacios_NuevaSeccion_Lugar

    Dim f As New functions

    Private Sub Espacios_NuevaSeccion_Lugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loader()
    End Sub

    Public Sub _loader()
        f.Combobox_Secciones(ComboBox1)
        TxtNombre.Text = ""
        f.Espacios_SeccionesLugaresGET("SELECT l.id, s.nombre, l.nombre, if (l.ocupado > 0, 'OCUPADO','DISPONIBLE') as ocupado FROM espacios_secciones_lugares l, espacios_secciones s WHERE l.seccion = s.id order by l.id desc", Table)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If f.Espacios_Seccion_LugaresAdd(TxtNombre, ComboBox1) Then
            _loader()
        Else
            f.Mensaje("Verifique su informacion", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub Table_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellValueChanged
        f.Espacios_Seccion_LugaresUpdate(Table.CurrentRow.Cells(1).Value.ToString, Table.CurrentRow.Index)
        _loader()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim item = Table.CurrentRow.Index.ToString

        If (MsgBox("¿Esta seguro de eliminar el item # " + item.ToString + "?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
            If f.Espacios_Secciona_LugaresDelete(item) Then
                _loader()
            Else
                f.Mensaje("No se puede eliminar el elemento", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
End Class