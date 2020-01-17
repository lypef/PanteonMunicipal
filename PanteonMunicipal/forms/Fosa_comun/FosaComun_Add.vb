Public Class FosaComun_Add
    Dim f As New functions
    Dim SolicitudFiscalia As String = ""

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim tmp As New TextBox
        tmp.Text = SolicitudFiscalia
        f.OpenFileDialog(tmp)
        SolicitudFiscalia = tmp.Text

        If String.IsNullOrEmpty(SolicitudFiscalia) = False Then
            __pdf.src = SolicitudFiscalia
        Else
            __pdf.src = "no.pdf"
        End If
    End Sub

    Private Sub FosaComun_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loader()
    End Sub

    Public Sub _loader()
        TxtFolio.Text = ""
        TxtFuneraria.Text = ""
        TxtSexo.SelectedIndex = 0
        TxtFuneraria.SelectedIndex = 0
        TxtUbicacion.Text = ""
        SolicitudFiscalia = ""
        __pdf.LoadFile("DONTEXISTS.pdf")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(SolicitudFiscalia) = False Then
            If f.FosaComunAdd(TxtFolio, TxtFuneraria, TxtSexo, TxtUbicacion, SolicitudFiscalia) Then
                _loader()
                FosaComun_Consultar.loader()
            End If
        Else
            f.Mensaje("Cargue una solicitud de la fiscalia", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class