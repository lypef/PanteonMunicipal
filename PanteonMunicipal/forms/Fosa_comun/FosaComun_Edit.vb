Public Class FosaComun_Edit
    Dim f As New functions
    Public item As String
    Public SolicitudFiscalia As String = ""

    Private Sub FosaComun_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub _loader()
        TxtFolio.Text = ""
        TxtFuneraria.Text = ""
        TxtSexo.SelectedIndex = 0
        TxtUbicacion.Text = ""
        SolicitudFiscalia = ""
        __pdf.LoadFile("DONTEXISTS.pdf")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FosaComun_Consultar._Update()
    End Sub

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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If f.FosaComunUpdate(TxtFolio, TxtFuneraria, TxtSexo, TxtUbicacion, SolicitudFiscalia, item) Then
            FosaComun_Consultar.loader()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class