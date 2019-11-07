Public Class Inhumanacion_pagos_edit
    Dim f As New functions
    Public item As Int32 = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If f.InhumanacionPagosUpdate(TxtDescripcion, TxtConcepto, Txtpago, TxtPresidente, item) Then
            Inhumanacion_pagos._update()
        End If
    End Sub
End Class