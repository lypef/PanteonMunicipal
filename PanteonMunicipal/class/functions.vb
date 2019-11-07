Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class functions

    Dim Db As New Conexion
    Dim RaizData As String = "C:\PanteonData\"
    Dim RaizData_actadefuncion As String = "actas_defuncion\"

    Public Sub ExistData()
        If Directory.Exists(RaizData) = False Then
            My.Computer.FileSystem.CreateDirectory(RaizData)
        End If

        If Directory.Exists(RaizData + RaizData_actadefuncion) = False Then
            My.Computer.FileSystem.CreateDirectory(RaizData + RaizData_actadefuncion)
        End If
    End Sub

    Public Sub FormModelo(ByVal form As Form)
        form.Text = "Panteon Municipal"
        form.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Function EncriptMD5(ByVal password As String) As String
        Dim PasConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(password.Replace(" ", ""))

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return PasConMd5
    End Function

    Public Function login(ByVal TxtUsername As TextBox, ByVal TxtPassword As TextBox) As Boolean
        Dim r = False

        If String.IsNullOrWhiteSpace(TxtUsername.Text) = False And String.IsNullOrWhiteSpace(TxtPassword.Text) = False Then
            Dim dato = Db.Consult("select * from users where username = '" + TxtUsername.Text + "' and password = '" + EncriptMD5(TxtPassword.Text) + "' ")

            If dato.hasrows Then

                Do While dato.Read()
                    'userID = dato.GetString(0)
                    r = True
                Loop
            Else
                Mensaje("Credencial incorrecta", MsgBoxStyle.Critical)
            End If
        Else
            Mensaje("No valores vacios", MsgBoxStyle.Exclamation)
        End If

        Return r
    End Function

    Public Sub Mensaje(txt As String, alert As Int32)
        MsgBox(txt, MsgBoxStyle.OkOnly + alert, "Panteon Municipal | Notificaciones")
    End Sub

    Public Sub AddForm_Desktop(ByVal form As Form, ByVal Desktop As Panel)
        Desktop.Controls.Clear()
        Desktop.BorderStyle = BorderStyle.None
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Width = Desktop.Width
        form.Height = Desktop.Height
        Desktop.Controls.Add(form)
        form.Show()
    End Sub

    Public Sub DesktopClean(ByVal Desktop As Panel)
        Desktop.Controls.Clear()
        Desktop.BorderStyle = BorderStyle.None
    End Sub

    Public Function DifundoAdd(
        ByVal TxtNombre As TextBox,
        ByVal TxtSexo As TextBox,
        ByVal TxtZona As TextBox,
        ByVal TxtPerpetuidad As TextBox,
        ByVal TxtNoTumba As TextBox,
        ByVal TxtFechaNacimiento As DateTimePicker,
        ByVal TxtFechaDefunsion As DateTimePicker,
        ByVal TxtFechaRegistro As DateTimePicker,
        ByVal TxtTipoTumba As TextBox,
        ByVal TxtAdjuntar As TextBox,
        ByVal TxtNombreResponsable As TextBox,
        ByVal TxtDireccionResponsable As TextBox,
        ByVal TxtTelefonoResponsable As TextBox
    )
        Dim url_pdf As String
        Dim r As Boolean = False

        If String.IsNullOrEmpty(TxtAdjuntar.Text) = False Then
            url_pdf = DateTime.Now.ToString.Replace(":", "").Replace(" ", "").Replace("/", "") + ".pdf"
            My.Computer.FileSystem.CopyFile(TxtAdjuntar.Text, RaizData + RaizData_actadefuncion + url_pdf)
        End If



        If Db.Ejecutar("INSERT INTO `inhumaciones` (`id`, `TxtNombre`, `TxtSexo`, `TxtZona`, `TxtPerpetuidad`, `TxtNoTumba`, `TxtFechaNacimiento`, `TxtFechaDefunsion`, `TxtFechaRegistro`, `TxtTipoTumba`, `TxtAdjuntar`, `TxtNombreResponsable`, `TxtDireccionResponsable`, `TxtTelefonoResponsable`) VALUES (NULL, '" + TxtNombre.Text + "', '" + TxtSexo.Text + "', '" + TxtZona.Text + "', '" + TxtPerpetuidad.Text + "', '" + TxtNoTumba.Text + "', '" + FechaFormatDB(TxtFechaNacimiento) + "', '" + FechaFormatDB(TxtFechaDefunsion) + "', '" + FechaFormatDB(TxtFechaRegistro) + "', '" + TxtTipoTumba.Text + "', '" + url_pdf + "', '" + TxtNombreResponsable.Text + "', '" + TxtDireccionResponsable.Text + "', '" + TxtTelefonoResponsable.Text + "');") Then
            TxtNombre.Text = ""
            TxtSexo.Text = ""
            TxtZona.Text = ""
            TxtPerpetuidad.Text = ""
            TxtNoTumba.Text = ""
            TxtFechaNacimiento.Value = DateTime.Now
            TxtFechaDefunsion.Value = DateTime.Now
            TxtFechaRegistro.Value = DateTime.Now
            TxtTipoTumba.Text = ""
            TxtAdjuntar.Text = ""
            TxtNombreResponsable.Text = ""
            TxtDireccionResponsable.Text = ""
            TxtTelefonoResponsable.Text = ""
            r = True
            Mensaje("Inhumacion agregada", MessageBoxIcon.Information)
        Else
            Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
        End If
        Return r
    End Function

    Public Function FechaFormatDB(ByVal d As DateTimePicker) As String
        Return d.Value.Date.ToString("yyyy-MM-dd")
    End Function

    Public Function TimeFormatDB(ByVal d As DateTimePicker) As String
        Return d.Text
    End Function


    Public Sub OpenFileDialog(ByVal txt As TextBox)
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo PDF|*.pdf"
        If file.ShowDialog() = DialogResult.OK Then
            Dim fs As FileStream = New System.IO.FileStream(file.FileName, FileMode.Open, FileAccess.Read)
            fs.Close()
        End If
        txt.Text = file.FileName.Replace("\", "/")
        txt.Enabled = False
    End Sub

    Public Sub DataGridView_Model(ByVal d As DataGridView)
        d.AllowUserToAddRows = False
        d.RowHeadersVisible = False
        d.ClearSelection()
        d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        d.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ActiveCaption
        d.DefaultCellStyle.SelectionBackColor = Color.Maroon
        d.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        d.RowTemplate.Height = 24
        d.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        d.DefaultCellStyle.Font = New Font("Segoe UI", 22.0F, GraphicsUnit.Pixel)
        d.AllowUserToResizeRows = False
        d.ReadOnly = True
        d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        d.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Public Sub Inhumanaciones_Consultas(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("difunto", "DIFUNTO")
        t.Columns.Add("perpetuidad", "PERPETUIDAD")
        t.Columns.Add("notumba", "NO. TUMBA")
        t.Columns.Add("f_defunsion", "FECHA DEFUNCION")
        t.Columns.Add("responsable", "RESPONSABLE")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5))
            Loop
        End If
        DataGridView_Model(t)
    End Sub

    Public Sub Exhumanaciones_Consultas(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "FOLIO")
        t.Columns.Add("finado", "FINADO")
        t.Columns.Add("orden", "NO. ORDEN")
        t.Columns.Add("fecha", "FECHA Y HORA")
        t.Columns.Add("situacion", "SITUACION")
        t.Columns.Add("solicitante", "SOLICITANTE")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3).ToString.Replace("0:00:00", dato.GetString(4)), dato.GetString(5), dato.GetString(6))
            Loop
        End If
        DataGridView_Model(t)
    End Sub

    Public Sub GenReport(ByVal t As DataGridView, cadena As String, rotate As Boolean)
        Dim filename = RaizData + "\report_tmp.pdf"

        Dim doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER)
        If rotate Then
            doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER.Rotate)
        End If

        Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create))
        doc.AddTitle("REPORTE")
        doc.AddCreator("ItSH")
        doc.Open()

        'If File.Exists(My.Settings.report_image) Then
        'Dim fs = New FileStream(My.Settings.report_image, FileMode.Open, FileAccess.Read)
        'Dim imagen = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), iTextSharp.text.BaseColor.WHITE)
        'imagen.ScaleToFit(140, 140)
        'imagen.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
        'Dim logo = New iTextSharp.text.Chunk(imagen, 375, -98)
        'If rotate Then
        'logo = New iTextSharp.text.Chunk(imagen, 500, -98)
        'End If
        'doc.Add(logo)
        'End If

        Dim _standardFontTitle = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFontSubTitle = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFont = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFontCell = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)

        doc.Add(New iTextSharp.text.Paragraph("SISTEM DEFUNSION", _standardFontTitle))
        doc.Add(New iTextSharp.text.Paragraph("DOCUMENTO: " + cadena.ToUpper, _standardFontSubTitle))
        doc.Add(New iTextSharp.text.Paragraph("FECHA Y HORA DE GENERACION: " + DateTime.Now.ToString, _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("DIRECCION: " + "DIRECCION PENDIENTE", _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("RFC: " + "XAXX010101000", _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("USUARIO QUE GENERO: " + "USUARIO", _standardFont))

        doc.Add(iTextSharp.text.Chunk.NEWLINE)

        Dim tabla = New iTextSharp.text.pdf.PdfPTable(t.ColumnCount)
        tabla.WidthPercentage = 100

        'Adding Header row
        For Each column As DataGridViewColumn In t.Columns
            Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(column.HeaderText.ToUpper, _standardFontTitle))
            tabla.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In t.Rows
            For Each cell As DataGridViewCell In row.Cells
                If String.IsNullOrEmpty(cell.Value) = False Then
                    Dim tmp = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(cell.Value.ToString(), _standardFontCell))
                    tabla.AddCell(tmp)
                End If
            Next
        Next

        Dim ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("CONCEPTO", _standardFont))
        ClId.BorderWidth = 0
        ClId.BorderWidthBottom = 0.75F


        tabla.AddCell(ClId)

        ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("ssssss", _standardFont))
        ClId.BorderWidth = 0
        tabla.AddCell(ClId)

        doc.Add(tabla)

        Dim _FontFooter = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim footer = New iTextSharp.text.Paragraph("www.laschoapas.gob.mx", _FontFooter)
        footer.Alignment = 1
        doc.Add(footer)

        doc.Close()
        writer.Close()
        Dim prc = New System.Diagnostics.Process()
        prc.StartInfo.FileName = filename
        prc.Start()
    End Sub

    Public Sub InhumanacionDetails(ByVal item As String)
        Dim dato = Db.Consult("SELECT * FROM inhumaciones WHERE id = '" + item + "' ")

        If dato.Read() Then
            Dim form As New Inhumanacion_details
            form.Pdf.src = RaizData + RaizData_actadefuncion + dato.GetString(10)

            form.TxtNombre.Text = dato.GetString(1)
            form.TxtSexo.Text = dato.GetString(2)
            form.TxtZona.Text = dato.GetString(3)
            form.TxtPerpetuidad.Text = dato.GetString(4)
            form.TxtNoTumba.Text = dato.GetString(5)
            form.TxtFechaNacimiento.Text = dato.GetString(6)
            form.TxtFechaDefunsion.Text = dato.GetString(7)
            form.TxtFechaRegistro.Text = dato.GetString(8)
            form.TxtTipoTumba.Text = dato.GetString(9)
            form.TxtNombreResponsable.Text = dato.GetString(11)
            form.TxtDireccionResponsable.Text = dato.GetString(12)
            form.TxtTelefonoResponsable.Text = dato.GetString(13)


            form.Show()
        End If

    End Sub

    Public Sub InhumanacionEdit(ByVal item As String)
        Dim dato = Db.Consult("SELECT * FROM inhumaciones WHERE id = '" + item + "' ")

        If dato.Read() Then
            Dim form As New Inhumanacion_edit
            form.item = item
            form.TxtNombre.Text = dato.GetString(1)
            form.TxtSexo.Text = dato.GetString(2)
            form.TxtZona.Text = dato.GetString(3)
            form.TxtPerpetuidad.Text = dato.GetString(4)
            form.TxtNoTumba.Text = dato.GetString(5)
            form.TxtFechaNacimiento.Text = dato.GetString(6)
            form.TxtFechaDefunsion.Text = dato.GetString(7)
            form.TxtFechaRegistro.Text = dato.GetString(8)
            form.TxtTipoTumba.Text = dato.GetString(9)
            form.TxtNombreResponsable.Text = dato.GetString(11)
            form.TxtDireccionResponsable.Text = dato.GetString(12)
            form.TxtTelefonoResponsable.Text = dato.GetString(13)
            form.Show()
        End If

    End Sub

    Public Sub ExhumacionEdit(ByVal item As String)
        Dim dato = Db.Consult("SELECT * FROM exhumaciones WHERE TxtFolio = '" + item + "' ")

        If dato.Read() Then
            Dim form As New ExhumacionEdit
            form.item = item
            form.TxtFinado.Text = dato.GetString(1)
            form.TxtNoOrden.Text = dato.GetString(2)
            form.TxtFecha.Value = Date.Parse(dato.GetString(3))
            form.TxtHora.Value = Date.Parse(dato.GetString(4))
            form.TxtFolio.Text = dato.GetString(0)
            form.TxtSolicitando.Text = dato.GetString(6)

            Dim cont As Int32 = 0
            Dim situacion As String = dato.GetString(5)

            For Each i As Object In form.TxtSituacion.Items
                If i = situacion Then
                    form.TxtSituacion.SelectedIndex = cont
                End If
                cont = cont + 1
            Next

            form.Show()
        End If

    End Sub

    Public Sub InhumanacionPagosEdit(ByVal item As String)
        Dim dato = Db.Consult("SELECT * FROM inhumaciones_pagos WHERE id = '" + item + "' ")

        If dato.Read() Then
            Dim form As New Inhumanacion_pagos_edit
            form.item = item
            form.TxtDescripcion.Text = dato.GetString(2)
            form.TxtConcepto.Text = dato.GetString(3)
            form.Txtpago.Text = dato.GetString(4).ToString.Replace(",", ".")
            form.TxtPresidente.Text = dato.GetString(5)
            form.Show()
        End If

    End Sub

    Public Function Inhumanaciondelete(ByVal item As Int32) As Boolean
        Return Db.Ejecutar("delete from inhumaciones where id = " + item.ToString + " ")
    End Function

    Public Function Exhumanaciondelete(ByVal item As String) As Boolean
        Return Db.Ejecutar("delete from exhumaciones where TxtFolio = '" + item.ToString + "' ")
    End Function

    Public Function InhumanaciondeletePagos(ByVal item As Int32) As Boolean
        Return Db.Ejecutar("delete from inhumaciones_pagos where id = " + item.ToString + " ")
    End Function

    Public Function InhumanacionUpdate(
        ByVal TxtNombre As TextBox,
        ByVal TxtSexo As TextBox,
        ByVal TxtZona As TextBox,
        ByVal TxtPerpetuidad As TextBox,
        ByVal TxtNoTumba As TextBox,
        ByVal TxtFechaNacimiento As DateTimePicker,
        ByVal TxtFechaDefunsion As DateTimePicker,
        ByVal TxtFechaRegistro As DateTimePicker,
        ByVal TxtTipoTumba As TextBox,
        ByVal TxtNombreResponsable As TextBox,
        ByVal TxtDireccionResponsable As TextBox,
        ByVal TxtTelefonoResponsable As TextBox,
        ByVal item As Int32
    )
        Dim r As Boolean = False

        If Db.Ejecutar("update `inhumaciones` set `TxtNombre` = '" + TxtNombre.Text + "', `TxtSexo` = '" + TxtSexo.Text + "', `TxtZona` = '" + TxtZona.Text + "', `TxtPerpetuidad` = '" + TxtPerpetuidad.Text + "', `TxtNoTumba` = '" + TxtNoTumba.Text + "', `TxtFechaNacimiento` = '" + FechaFormatDB(TxtFechaNacimiento) + "', `TxtFechaDefunsion` = '" + FechaFormatDB(TxtFechaDefunsion) + "', `TxtFechaRegistro` = '" + FechaFormatDB(TxtFechaRegistro) + "', `TxtTipoTumba` = '" + TxtTipoTumba.Text + "', `TxtNombreResponsable` = '" + TxtNombreResponsable.Text + "', `TxtDireccionResponsable` = '" + TxtDireccionResponsable.Text + "', `TxtTelefonoResponsable` = '" + TxtTelefonoResponsable.Text + "' where id = '" + item.ToString + "';") Then
            r = True
            Mensaje("Inhumacion actualizada", MessageBoxIcon.Information)
        Else
            Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
        End If
        Return r
    End Function

    Public Function ExhumacionUpdate(
        ByVal TxtFinado As TextBox,
        ByVal TxtNoOrden As TextBox,
        ByVal TxtFecha As DateTimePicker,
        ByVal TxtHora As DateTimePicker,
        ByVal TxtFolio As TextBox,
        ByVal TxtSituacion As ComboBox,
        ByVal TxtSolicitando As TextBox,
        ByVal item As String
    )
        Dim r As Boolean = False

        If Db.Ejecutar("UPDATE `exhumaciones` SET `TxtFolio` = '" + TxtFolio.Text + "', `TxtFinado` = '" + TxtFinado.Text + "', `TxtNoOrden` = '" + TxtNoOrden.Text + "', `TxtFecha` = '" + FechaFormatDB(TxtFecha) + "', `TxtHora` = '" + TxtHora.Text + "', `TxtSituacion` = '" + TxtSituacion.Text + "', `TxtSolicitando` = '" + TxtSolicitando.Text + "' WHERE `exhumaciones`.`TxtFolio` = '" + item + "';") Then
            TxtFinado.Text = ""
            TxtNoOrden.Text = ""
            TxtFecha.Value = DateTime.Now
            TxtHora.Value = DateTime.Now
            TxtFolio.Text = ""
            TxtSituacion.SelectedIndex = 0
            TxtSolicitando.Text = ""
            r = True
            Mensaje("Exhumacion actualizada", MessageBoxIcon.Information)
        Else
            Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
        End If
        Return r
    End Function

    Public Function InhumanacionPagosUpdate(
        ByVal TxtDescripcion As TextBox,
        ByVal TxtConcepto As TextBox,
        ByVal Txtpago As TextBox,
        ByVal TxtPresidente As TextBox,
        ByVal item As Int32
    )
        Dim r As Boolean = False

        If IsDecimal(Txtpago) Then
            If Db.Ejecutar("UPDATE `inhumaciones_pagos` SET `descripcion` = '" + TxtDescripcion.Text + "', `concepto` = '" + TxtConcepto.Text + "', `monto` = '" + Txtpago.Text + "', `preseidente` = '" + TxtPresidente.Text + "'  where id = '" + item.ToString + "';") Then
                r = True
                Mensaje("Pago actualizado", MessageBoxIcon.Information)
            Else
                Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
            End If
        Else
            Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
        End If


        Return r
    End Function

    Public Sub InhumanacionPagar(ByVal item As String)
        Dim dato = Db.Consult("SELECT * FROM inhumaciones WHERE id = '" + item + "' ")

        If dato.Read() Then
            Dim form As New Inhumanacion_pagar
            form.id = item
            form.TxtNombre.Text = dato.GetString(1)
            form.TxtDireccionResponsable.Text = dato.GetString(12)
            form.TxtNombreResponsable.Text = dato.GetString(11)
            form.Show()
        End If

    End Sub

    Public Function Inhumacion_Pagos_Add(
        ByVal inhumanacion As Int32,
        ByVal TxtDescripcion As TextBox,
        ByVal TxtConcepto As TextBox,
        ByVal Txtpago As TextBox,
        ByVal TxtPresidente As TextBox)

        Dim r As Boolean = False

        If (IsDecimal(Txtpago)) Then
            If Db.Ejecutar("INSERT INTO `inhumaciones_pagos` (`inhumanacion`, `descripcion`, `concepto`, `monto`, `preseidente`) VALUES ('" + inhumanacion.ToString + "', '" + TxtDescripcion.Text + "', '" + TxtConcepto.Text + "', '" + Txtpago.Text + "', '" + TxtPresidente.Text + "');") Then
                r = True
                Mensaje("Inhumacion agregada", MessageBoxIcon.Information)
            Else
                Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
            End If
        Else
            Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
        End If

        Return r
    End Function

    Public Function IsDecimal(ByVal numero As TextBox) As Boolean
        Try
            Return Decimal.Parse(numero.Text)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub ReportInhumanacionPagop(ByVal id As Int32)
        Dim details As String = ""
        Dim t As New DataGridView

        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult("SELECT p.id, P.descripcion, p.concepto, p.fecha, p.monto, p.preseidente, i.TxtNombre, i.TxtSexo, i.TxtZona, i.TxtNoTumba, i.TxtTipoTumba, i.TxtNombreResponsable FROM inhumaciones_pagos p, inhumaciones i WHERE p.inhumanacion = i.id  and p.id = '" + id.ToString + "' ")

        t.Columns.Add("id", "FOLIO")
        t.Columns.Add("descripcion", "DESCRIPCION")
        t.Columns.Add("concepto", "CONCEPTO")
        t.Columns.Add("fecha", "F. PAGO")
        t.Columns.Add("monto", "MONTO")
        t.Columns.Add("preseidente", "presidente")

        If dato.HasRows Then
            Do While dato.Read()
                details += vbLf + "RESPONSABLE: " + dato.GetString(11)
                details += vbLf + "DIFUNTO: " + dato.GetString(6)
                details += vbLf + "SEXO: " + dato.GetString(7)
                details += vbLf + "ZONA: " + dato.GetString(8)
                details += vbLf + "NO. TUMBA: " + dato.GetString(9)
                details += vbLf + "TIPO TUMBA: " + dato.GetString(10)
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), "$ " + dato.GetString(4), dato.GetString(5))
            Loop
        End If
        DataGridView_Model(t)

        'Se genera report
        Dim filename = RaizData + "\report_tmp.pdf"

        Dim doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER)


        Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create))
        doc.AddTitle("REPORTE")
        doc.AddCreator("ItSH")
        doc.Open()

        Dim _standardFontTitle = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFontSubTitle = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFont = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)
        Dim _standardFontCell = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)

        doc.Add(New iTextSharp.text.Paragraph("SISTEM DEFUNSION", _standardFontTitle))
        doc.Add(New iTextSharp.text.Paragraph("DOCUMENTO: COMPROBANTE DE PAGO", _standardFontSubTitle))
        doc.Add(New iTextSharp.text.Paragraph("FECHA Y HORA DE GENERACION: " + DateTime.Now.ToString, _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("DIRECCION: " + "DIRECCION PENDIENTE", _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("RFC: " + "XAXX010101000", _standardFont))
        doc.Add(New iTextSharp.text.Paragraph("USUARIO QUE GENERO: " + "USUARIO", _standardFont))

        doc.Add(iTextSharp.text.Chunk.NEWLINE)

        Dim tabla = New iTextSharp.text.pdf.PdfPTable(t.ColumnCount)
        tabla.WidthPercentage = 100

        'Adding Header row
        For Each column As DataGridViewColumn In t.Columns
            Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(column.HeaderText.ToUpper, _standardFontTitle))
            tabla.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In t.Rows
            For Each cell As DataGridViewCell In row.Cells
                If String.IsNullOrEmpty(cell.Value) = False Then
                    Dim tmp = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(cell.Value.ToString(), _standardFontCell))
                    tabla.AddCell(tmp)
                End If
            Next
        Next

        Dim ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("CONCEPTO", _standardFont))
        ClId.BorderWidth = 0
        ClId.BorderWidthBottom = 0.75F


        tabla.AddCell(ClId)

        ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("ssssss", _standardFont))
        ClId.BorderWidth = 0
        tabla.AddCell(ClId)

        doc.Add(tabla)

        Dim _FontDetails = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim footer_details = New iTextSharp.text.Paragraph(details, _FontDetails)
        doc.Add(footer_details)

        Dim _FontFooter = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)
        Dim footer = New iTextSharp.text.Paragraph("www.laschoapas.gob.mx", _FontFooter)
        footer.Alignment = 1
        doc.Add(footer)

        doc.Close()
        writer.Close()
        Dim prc = New System.Diagnostics.Process()
        prc.StartInfo.FileName = filename
        prc.Start()
    End Sub

    Public Function InhumanacionPago_ReturnLastID() As Integer
        Dim r As Integer = 0

        Dim dato = Db.Consult("SELECT id FROM inhumaciones_pagos ORDER by ID DESC LIMIT 1;")

        If dato.Read() Then
            r = Integer.Parse(dato.GetString(0))
        End If

        Return r
    End Function

    Public Sub Inhumanaciones_Pagos(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("difunto", "DIFUNTO")
        t.Columns.Add("responsable", "RESPONSABLE")
        t.Columns.Add("descripcion", "DESCRIPCION")
        t.Columns.Add("perpetuidad", "CONCEPTO")
        t.Columns.Add("notumba", "MONTO")
        t.Columns.Add("f_defunsion", "FECHA")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
            Loop
        End If
        DataGridView_Model(t)
    End Sub

    Public Function ExhumacionAdd(
        ByVal TxtFinado As TextBox,
        ByVal TxtNoOrden As TextBox,
        ByVal TxtFecha As DateTimePicker,
        ByVal TxtHora As DateTimePicker,
        ByVal TxtFolio As TextBox,
        ByVal TxtSituacion As ComboBox,
        ByVal TxtSolicitando As TextBox
    )
        Dim r As Boolean = False

        If Db.Ejecutar("INSERT INTO `exhumaciones` (`TxtFolio`, `TxtFinado`, `TxtNoOrden`, `TxtFecha`, `TxtHora`, `TxtSituacion`, `TxtSolicitando`) VALUES ('" + TxtFolio.Text + "', '" + TxtFinado.Text + "', '" + TxtNoOrden.Text + "', '" + FechaFormatDB(TxtFecha) + "', '" + TimeFormatDB(TxtHora) + "', '" + TxtSituacion.Text + "', '" + TxtSolicitando.Text + "');") Then
            TxtFinado.Text = ""
            TxtNoOrden.Text = ""
            TxtFecha.Value = DateTime.Now
            TxtHora.Value = DateTime.Now
            TxtFolio.Text = ""
            TxtSituacion.SelectedIndex = 0
            TxtSolicitando.Text = ""
            r = True
            Mensaje("Exhumacion agregada", MessageBoxIcon.Information)
        Else
            Mensaje("No es posible realizar la operacion en este momento", MessageBoxIcon.Warning)
        End If
        Return r
    End Function

End Class
