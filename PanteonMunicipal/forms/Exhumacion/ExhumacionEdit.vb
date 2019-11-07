Public Class ExhumacionEdit
    Dim f As New functions
    Public item As String = ""

    Private Sub ExhumacionEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If f.ExhumacionUpdate(TxtFinado, TxtNoOrden, TxtFecha, TxtHora, TxtFolio, TxtSituacion, TxtSolicitando, item) Then
            Exhumacion_consultas._update()
        End If
    End Sub
End Class