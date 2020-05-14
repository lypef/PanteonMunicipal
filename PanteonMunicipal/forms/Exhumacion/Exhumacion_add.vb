Public Class Exhumacion_add
    Dim f As New functions

    Public Sub loader()
        TxtFinado.Text = ""
        TxtNoOrden.Text = ""
        TxtFecha.Value = DateTime.Now
        TxtHora.Value = DateTime.Now
        TxtFolio.Text = ""
        TxtSituacion.SelectedIndex = 0
        TxtSolicitando.Text = ""
        ComboSolicitado.SelectedIndex = 0
        ComboMotivo.SelectedIndex = 0
        TxtAdjuntar.Enabled = False
    End Sub

    Private Sub Exhumacion_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If String.IsNullOrEmpty(TxtFolio.Text) = False And ComboMotivo.SelectedIndex > 0 And ComboSolicitado.SelectedIndex > 0 Then

            If (f.ExhumacionAdd(TxtFinado, TxtNoOrden, TxtFecha, TxtHora, TxtFolio, TxtSituacion, TxtSolicitando, TxtAdjuntar, ComboSolicitado, ComboMotivo, TxtPago)) Then
                __Pdf.LoadFile("DONTEXISTS.pdf")
                f.Mensaje("Exhumacion agregada", MessageBoxIcon.Information)
            End If
        Else
            f.Mensaje("Verifique su informacion", MsgBoxStyle.Exclamation)
        End If
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