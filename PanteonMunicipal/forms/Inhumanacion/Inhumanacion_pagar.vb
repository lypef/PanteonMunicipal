Public Class Inhumanacion_pagar

    Dim f As New functions
    Public id As Int32 = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿Esta seguro de realizar este pago" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
            If f.Inhumacion_Pagos_Add(id, TxtDescripcion, TxtConcepto, Txtpago, TxtPresidente) Then
                Me.Dispose()
                f.ReportInhumanacionPagop(f.InhumanacionPago_ReturnLastID())
            End If
        End If
    End Sub
End Class