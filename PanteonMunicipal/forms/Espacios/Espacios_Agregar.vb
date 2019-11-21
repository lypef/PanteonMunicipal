Public Class Espacios_Agregar

    Dim f As New functions
    Public item As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If f.IsDecimal(TxtCosto) Then
            If (MsgBox("¿Esta seguro de realizar esta asignacion ?" + vbNewLine, MsgBoxStyle.Exclamation + vbYesNo) = vbYes) Then
                If f.EspaciosAsignacionAdd(item, TxtCombo, TxtModalidad, TxtObservaciones, TxtCosto, TxtCaducidad) Then
                    Me.Dispose()
                    f.ReportAsignacionEspacioPago(f.AsignacionEspacio_ReturnLastID())
                End If
            End If
        Else
            f.Mensaje("Ingrese un costo valido", MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Espacios_Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _loader()
    End Sub

    Public Sub _loader()
        TxtModalidad.Text = "Ninguno"
        TxtObservaciones.Text = "Ninguno"
        TxtCosto.Text = "0"
    End Sub
End Class