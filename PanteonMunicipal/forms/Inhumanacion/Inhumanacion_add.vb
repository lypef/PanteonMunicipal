Public Class Inhumanacion_add

    Dim f As New functions

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If String.IsNullOrEmpty(TxtAdjuntar.Text) = False Then
            If f.DifundoAdd(TxtNombre, TxtSexo, TxtZona, TxtPerpetuidad, TxtNoTumba, TxtFechaNacimiento, TxtFechaDefunsion, TxtFechaRegistro, TxtTipoTumba, TxtAdjuntar, TxtNombreResponsable, TxtDireccionResponsable, TxtTelefonoResponsable) Then
                __Pdf.LoadFile("DONTEXISTS.pdf")
                'Inicia proceso de pago
                f.InhumanacionPagar(f.InhumanacionLastID())
            End If
        Else
            f.Mensaje("Cargue una acta de defunsion", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Inhumanacion_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFechaNacimiento.Value = DateTime.Now
        TxtFechaNacimiento.Value = DateTime.Now
        TxtFechaRegistro.Value = DateTime.Now
        TxtSexo.SelectedIndex = 0
        TxtZona.SelectedIndex = 0
        TxtTipoTumba.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f.OpenFileDialog(TxtAdjuntar)
        If String.IsNullOrEmpty(TxtAdjuntar.Text) = False Then
            __Pdf.src = TxtAdjuntar.Text
        Else
            __Pdf.src = "no.pdf"
        End If
    End Sub
End Class