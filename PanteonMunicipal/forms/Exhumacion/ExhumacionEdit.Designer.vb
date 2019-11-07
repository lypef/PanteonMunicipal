<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExhumacionEdit
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._Layout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtHora = New System.Windows.Forms.DateTimePicker()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFolio = New System.Windows.Forms.TextBox()
        Me.TxtNoOrden = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFinado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtSituacion = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSolicitando = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me._Layout.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Layout
        '
        Me._Layout.ColumnCount = 1
        Me._Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._Layout.Controls.Add(Me.Label1, 0, 6)
        Me._Layout.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me._Layout.Controls.Add(Me.TxtFinado, 0, 2)
        Me._Layout.Controls.Add(Me.Label9, 0, 1)
        Me._Layout.Controls.Add(Me.Label5, 0, 0)
        Me._Layout.Controls.Add(Me.TableLayoutPanel1, 0, 4)
        Me._Layout.Controls.Add(Me.Label6, 0, 7)
        Me._Layout.Controls.Add(Me.TxtSolicitando, 0, 8)
        Me._Layout.Controls.Add(Me.TableLayoutPanel2, 0, 11)
        Me._Layout.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Layout.Location = New System.Drawing.Point(0, 0)
        Me._Layout.Name = "_Layout"
        Me._Layout.RowCount = 12
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me._Layout.Size = New System.Drawing.Size(611, 456)
        Me._Layout.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(605, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "SOLICITANTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TxtHora, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtFecha, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtFolio, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtNoOrden, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 117)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(605, 73)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'TxtHora
        '
        Me.TxtHora.CalendarFont = New System.Drawing.Font("Segoe UI", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtHora.Font = New System.Drawing.Font("Segoe UI", 11.78182!)
        Me.TxtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TxtHora.Location = New System.Drawing.Point(305, 39)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(145, 31)
        Me.TxtHora.TabIndex = 4
        '
        'TxtFecha
        '
        Me.TxtFecha.CalendarFont = New System.Drawing.Font("Segoe UI", 11.12727!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtFecha.Font = New System.Drawing.Font("Segoe UI", 11.78182!)
        Me.TxtFecha.Location = New System.Drawing.Point(154, 39)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(145, 31)
        Me.TxtFecha.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 36)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "HORA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 36)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "FECHA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFolio
        '
        Me.TxtFolio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFolio.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFolio.Location = New System.Drawing.Point(456, 39)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(146, 31)
        Me.TxtFolio.TabIndex = 5
        '
        'TxtNoOrden
        '
        Me.TxtNoOrden.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNoOrden.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoOrden.Location = New System.Drawing.Point(3, 39)
        Me.TxtNoOrden.Name = "TxtNoOrden"
        Me.TxtNoOrden.Size = New System.Drawing.Size(145, 31)
        Me.TxtNoOrden.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(456, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 36)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "FOLIO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 36)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "NUMERO DE ORDEN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtFinado
        '
        Me.TxtFinado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFinado.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFinado.Location = New System.Drawing.Point(3, 80)
        Me.TxtFinado.Name = "TxtFinado"
        Me.TxtFinado.Size = New System.Drawing.Size(605, 31)
        Me.TxtFinado.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(605, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "FINADO"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(605, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EXHUMACION"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.46392!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtSituacion, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 196)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(605, 50)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TxtSituacion
        '
        Me.TxtSituacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtSituacion.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSituacion.Items.AddRange(New Object() {"SITUACION", "1.- INHUMANACION", "2.- FOSA COMUN"})
        Me.TxtSituacion.Location = New System.Drawing.Point(3, 3)
        Me.TxtSituacion.Name = "TxtSituacion"
        Me.TxtSituacion.Size = New System.Drawing.Size(599, 40)
        Me.TxtSituacion.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(605, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "NOMBRE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtSolicitando
        '
        Me.TxtSolicitando.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSolicitando.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSolicitando.Location = New System.Drawing.Point(3, 309)
        Me.TxtSolicitando.Name = "TxtSolicitando"
        Me.TxtSolicitando.Size = New System.Drawing.Size(605, 31)
        Me.TxtSolicitando.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GUARDAR, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 346)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(605, 107)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(305, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(297, 101)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ACTUALIZAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GUARDAR
        '
        Me.GUARDAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GUARDAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDAR.Location = New System.Drawing.Point(3, 3)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(296, 101)
        Me.GUARDAR.TabIndex = 11
        Me.GUARDAR.Text = "CERRAR"
        Me.GUARDAR.UseVisualStyleBackColor = False
        '
        'ExhumacionEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 456)
        Me.Controls.Add(Me._Layout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExhumacionEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExhumacionEdit"
        Me._Layout.ResumeLayout(False)
        Me._Layout.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _Layout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Public WithEvents TxtHora As DateTimePicker
    Public WithEvents TxtFecha As DateTimePicker
    Public WithEvents TxtFolio As TextBox
    Public WithEvents TxtNoOrden As TextBox
    Public WithEvents TxtFinado As TextBox
    Public WithEvents TxtSituacion As ComboBox
    Public WithEvents TxtSolicitando As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents GUARDAR As Button
End Class
