Public Class platform
    Dim f As New functions

    Private Sub platform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.FormModelo(Me)
        _loadCheats()
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

    End Sub

    Private Sub FosaComunToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs) Handles FosaComunToolStripMenuItem.DoubleClick
        f.AddForm_Desktop(FosaComun_Consultar, Desktop)
        FosaComun_Consultar.loader()
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub _loadCheats()
        Desktop.Controls.Add(Principal)
        f.LoadValuesUser(name_user, name_username, nivel)
    End Sub

    Private Sub ArchivoToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs)
        f.DesktopClean(Desktop)
        _loadCheats()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Application.Restart()
    End Sub

    Private Sub NuevaSeccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaSeccionToolStripMenuItem.Click
        Espacios_NuevaSeccion.Show()
    End Sub

    Private Sub AgregarLugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarLugarToolStripMenuItem.Click
        Espacios_NuevaSeccion_Lugar._loader()
        Espacios_NuevaSeccion_Lugar.Show()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Espacios_Agregar.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem3.Click
        f.AddForm_Desktop(Espacios_Consultas, Desktop)
        Espacios_Consultas._loader()
    End Sub

    Private Sub GestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionToolStripMenuItem.Click
        If f.is_admin Then
            f.AddForm_Desktop(users_consultar, Desktop)
            Espacios_Consultas._loader()
        Else
            f.Mensaje("No tiene permisos para acceso a este modulo", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        If f.is_admin Then
            users_add.Show()
        Else
            f.Mensaje("No tiene permisos para acceso a este modulo", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click
        f.DesktopClean(Desktop)
        _loadCheats()
    End Sub

    Private Sub GESTIONARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GESTIONARToolStripMenuItem.Click
        f.AddForm_Desktop(FosaComun_Consultar, Desktop)
        FosaComun_Consultar.loader()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        FosaComun_Add.Show()
        FosaComun_Add._loader()
    End Sub

    Private Sub PapeleraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PapeleraToolStripMenuItem.Click
        f.Papelera()
    End Sub
End Class