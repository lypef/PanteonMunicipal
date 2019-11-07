Public Class Inhumanacion_edit
    Dim f As New functions
    Public item As Int32 = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If f.InhumanacionUpdate(TxtNombre, TxtSexo, TxtZona, TxtPerpetuidad, TxtNoTumba, TxtFechaNacimiento, TxtFechaDefunsion, TxtFechaRegistro, TxtTipoTumba, TxtNombreResponsable, TxtDireccionResponsable, TxtTelefonoResponsable, item) Then
            Inhumanacion_consultas._update()
        End If
    End Sub
End Class