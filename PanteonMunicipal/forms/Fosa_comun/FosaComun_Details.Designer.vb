<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FosaComun_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FosaComun_Details))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me._pdf = New AxAcroPDFLib.AxAcroPDF()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtUbicacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFuneraria = New System.Windows.Forms.Label()
        Me.TxtFolio = New System.Windows.Forms.Label()
        Me.TxtSexo = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me._pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSexo)
        Me.GroupBox2.Controls.Add(Me._pdf)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtUbicacion)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtFuneraria)
        Me.GroupBox2.Controls.Add(Me.TxtFolio)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(614, 709)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NUEVO CUERPO A FOSA COMUN"
        '
        '_pdf
        '
        Me._pdf.Enabled = True
        Me._pdf.Location = New System.Drawing.Point(12, 23)
        Me._pdf.Name = "_pdf"
        Me._pdf.OcxState = CType(resources.GetObject("_pdf.OcxState"), System.Windows.Forms.AxHost.State)
        Me._pdf.Size = New System.Drawing.Size(587, 428)
        Me._pdf.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(17, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(582, 47)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtUbicacion
        '
        Me.TxtUbicacion.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUbicacion.Location = New System.Drawing.Point(17, 552)
        Me.TxtUbicacion.Multiline = True
        Me.TxtUbicacion.Name = "TxtUbicacion"
        Me.TxtUbicacion.Size = New System.Drawing.Size(582, 86)
        Me.TxtUbicacion.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 528)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "UBICACION DEL CUERPO"
        '
        'TxtFuneraria
        '
        Me.TxtFuneraria.AutoSize = True
        Me.TxtFuneraria.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFuneraria.Location = New System.Drawing.Point(13, 497)
        Me.TxtFuneraria.Name = "TxtFuneraria"
        Me.TxtFuneraria.Size = New System.Drawing.Size(100, 21)
        Me.TxtFuneraria.TabIndex = 5
        Me.TxtFuneraria.Text = "FUNERARIA:"
        '
        'TxtFolio
        '
        Me.TxtFolio.AutoSize = True
        Me.TxtFolio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFolio.Location = New System.Drawing.Point(13, 460)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(79, 21)
        Me.TxtFolio.TabIndex = 3
        Me.TxtFolio.Text = "N. FOLIO:"
        '
        'TxtSexo
        '
        Me.TxtSexo.AutoSize = True
        Me.TxtSexo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.Location = New System.Drawing.Point(331, 460)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(53, 21)
        Me.TxtSexo.TabIndex = 33
        Me.TxtSexo.Text = "SEXO:"
        '
        'FosaComun_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 709)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FosaComun_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FosaComun_Details"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me._pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Public WithEvents TxtUbicacion As TextBox
    Friend WithEvents Label8 As Label
    Public WithEvents _pdf As AxAcroPDFLib.AxAcroPDF
    Public WithEvents TxtFuneraria As Label
    Public WithEvents TxtFolio As Label
    Public WithEvents TxtSexo As Label
End Class
