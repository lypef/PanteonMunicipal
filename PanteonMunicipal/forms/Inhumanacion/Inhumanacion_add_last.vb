Public Class Inhumanacion_add_last
    Public id As Integer
    Dim f As New functions
    Dim TxtAdjuntar As String

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If (f.InhumanacionAddINEAndfinish(id, TxtFecha, TxtAdjuntar)) Then
            Me.Dispose()
            f.Mensaje("Agregado", MessageBoxIcon.Information)
            'Inicia proceso de pago
            f.InhumanacionPagar(f.InhumanacionLastID())
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtAdjuntar = f.OpenFileDialogString()
        If String.IsNullOrEmpty(TxtAdjuntar) = False Then
            __Pdf.src = TxtAdjuntar
        Else
            TxtAdjuntar = ""
            __Pdf.src = "no.pdf"
        End If
    End Sub

    Public Sub _date()
        Dim r = DateTime.Now.AddYears(7)
        TxtFecha.Value = r
    End Sub
End Class