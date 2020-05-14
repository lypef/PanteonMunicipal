Imports System.IO

Public Class FosaComunAddDocs
    Dim TxtAdjuntar As String
    Dim f As New functions
    Dim item As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TxtAdjuntar = f.OpenFileDialogString()
        If String.IsNullOrEmpty(TxtAdjuntar) = False Then
            __Pdf.src = TxtAdjuntar
        Else
            __Pdf.src = "no.pdf"
        End If
    End Sub

    Public Sub _loader(_item As String)
        Me.item = _item
        TxtAdjuntar = ""
        TextBox1.Text = ""
        f.Combobox_Documentos(Combo, item)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (f.DocsFosaComunAdd(TxtAdjuntar, TextBox1, item)) Then
            _loader(item)
            __Pdf.src = "no.pdf"
        End If
    End Sub

    Private Sub Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo.SelectedIndexChanged
        If Combo.SelectedIndex > 0 Then
            If File.Exists(functions.ListDocs(Combo.SelectedIndex).ToString()) Then
                __Pdf.src = functions.ListDocs(Combo.SelectedIndex).ToString()
            Else
                __Pdf.src = "no.pdf"
            End If
        End If
    End Sub
End Class