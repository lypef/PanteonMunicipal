Public Class login
    Dim f As New functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginGO()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Text = "root"
        TxtPassword.Text = "root"

        f.FormModelo(Me)
        f.ExistData()
    End Sub

    Private Sub TxtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginGO()
        End If
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginGO()
        End If
    End Sub

    Private Sub LoginGO()
        If f.login(TxtUsername, TxtPassword) Then
            Me.Visible = False
            Dim form As New platform
            form.Show()
        End If
    End Sub
End Class
