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
    End Sub

    Private Sub Exhumacion_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If String.IsNullOrEmpty(TxtFolio.Text) = False Then
            f.ExhumacionAdd(TxtFinado, TxtNoOrden, TxtFecha, TxtHora, TxtFolio, TxtSituacion, TxtSolicitando)
        Else
            f.Mensaje("Ingrese un no de folio o perpetuidad", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class