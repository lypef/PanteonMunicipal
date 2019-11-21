Public Class users_add
    Dim f As New functions

    Private Sub users_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtAdmin.SelectedIndex = 1
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If f.Users_Add(TxtUsername, TxtPassword, Txtnombre, TxtAdmin) Then
            Me.Dispose()
            f.Mensaje("Agregado", MsgBoxStyle.Information)
        Else
            f.Mensaje("No es posible realizar en este momento", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class