<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExhumacionesDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExhumacionesDetails))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.solicitado = New System.Windows.Forms.Label()
        Me.TxtSolicitando = New System.Windows.Forms.Label()
        Me.TxtSituacion = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.Label()
        Me.TxtNoOrden = New System.Windows.Forms.Label()
        Me.motivo = New System.Windows.Forms.Label()
        Me._pdf = New AxAcroPDFLib.AxAcroPDF()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtFolio = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me._pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.solicitado)
        Me.GroupBox2.Controls.Add(Me.TxtSolicitando)
        Me.GroupBox2.Controls.Add(Me.TxtSituacion)
        Me.GroupBox2.Controls.Add(Me.TxtFecha)
        Me.GroupBox2.Controls.Add(Me.TxtNoOrden)
        Me.GroupBox2.Controls.Add(Me.motivo)
        Me.GroupBox2.Controls.Add(Me._pdf)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtFolio)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(612, 710)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLES EXHUMACION"
        '
        'solicitado
        '
        Me.solicitado.AutoSize = True
        Me.solicitado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solicitado.Location = New System.Drawing.Point(12, 624)
        Me.solicitado.Name = "solicitado"
        Me.solicitado.Size = New System.Drawing.Size(79, 21)
        Me.solicitado.TabIndex = 38
        Me.solicitado.Text = "N. FOLIO:"
        '
        'TxtSolicitando
        '
        Me.TxtSolicitando.AutoSize = True
        Me.TxtSolicitando.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSolicitando.Location = New System.Drawing.Point(12, 592)
        Me.TxtSolicitando.Name = "TxtSolicitando"
        Me.TxtSolicitando.Size = New System.Drawing.Size(79, 21)
        Me.TxtSolicitando.TabIndex = 37
        Me.TxtSolicitando.Text = "N. FOLIO:"
        '
        'TxtSituacion
        '
        Me.TxtSituacion.AutoSize = True
        Me.TxtSituacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSituacion.Location = New System.Drawing.Point(12, 560)
        Me.TxtSituacion.Name = "TxtSituacion"
        Me.TxtSituacion.Size = New System.Drawing.Size(79, 21)
        Me.TxtSituacion.TabIndex = 36
        Me.TxtSituacion.Text = "N. FOLIO:"
        '
        'TxtFecha
        '
        Me.TxtFecha.AutoSize = True
        Me.TxtFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(12, 528)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(79, 21)
        Me.TxtFecha.TabIndex = 35
        Me.TxtFecha.Text = "N. FOLIO:"
        '
        'TxtNoOrden
        '
        Me.TxtNoOrden.AutoSize = True
        Me.TxtNoOrden.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoOrden.Location = New System.Drawing.Point(12, 496)
        Me.TxtNoOrden.Name = "TxtNoOrden"
        Me.TxtNoOrden.Size = New System.Drawing.Size(79, 21)
        Me.TxtNoOrden.TabIndex = 34
        Me.TxtNoOrden.Text = "N. FOLIO:"
        '
        'motivo
        '
        Me.motivo.AutoSize = True
        Me.motivo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.motivo.Location = New System.Drawing.Point(12, 656)
        Me.motivo.Name = "motivo"
        Me.motivo.Size = New System.Drawing.Size(79, 21)
        Me.motivo.TabIndex = 33
        Me.motivo.Text = "N. FOLIO:"
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
        Me.Button1.Location = New System.Drawing.Point(411, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 47)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtFolio
        '
        Me.TxtFolio.AutoSize = True
        Me.TxtFolio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFolio.Location = New System.Drawing.Point(12, 464)
        Me.TxtFolio.Name = "TxtFolio"
        Me.TxtFolio.Size = New System.Drawing.Size(79, 21)
        Me.TxtFolio.TabIndex = 3
        Me.TxtFolio.Text = "N. FOLIO:"
        '
        'ExhumacionesDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 710)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExhumacionesDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExhumacionesDetails"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me._pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents _pdf As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Button1 As Button
    Public WithEvents TxtFolio As Label
    Public WithEvents solicitado As Label
    Public WithEvents TxtSolicitando As Label
    Public WithEvents TxtSituacion As Label
    Public WithEvents TxtFecha As Label
    Public WithEvents TxtNoOrden As Label
    Public WithEvents motivo As Label
End Class
