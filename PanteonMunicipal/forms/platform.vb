Public Class platform
    Dim f As New functions

    Private Sub platform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.FormModelo(Me)
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        f.AddForm_Desktop(Inhumanacion_add, Desktop)
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        f.AddForm_Desktop(Inhumanacion_consultas, Desktop)
        Inhumanacion_consultas.loader()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        f.AddForm_Desktop(Inhumanacion_pagos, Desktop)
        Inhumanacion_pagos.loader()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        f.AddForm_Desktop(Exhumacion_add, Desktop)
        Exhumacion_add.loader()
    End Sub

    Private Sub ConsultasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem1.Click
        f.AddForm_Desktop(Exhumacion_consultas, Desktop)
        Exhumacion_consultas.loader()
    End Sub

    Private Sub FosaComunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FosaComunToolStripMenuItem.Click
        f.Mensaje(":D", MsgBoxStyle.Information)
    End Sub

    Private Sub FosaComunToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs) Handles FosaComunToolStripMenuItem.DoubleClick
        f.Mensaje(":D", MsgBoxStyle.Information)
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click
        f.DesktopClean(Desktop)
    End Sub

    Private Sub ArchivoToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.DoubleClick
        f.DesktopClean(Desktop)
    End Sub
End Class