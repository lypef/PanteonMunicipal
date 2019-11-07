<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inhumanacion_pagar
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtDireccionResponsable = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombreResponsable = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtpago = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPresidente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TxtPresidente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Txtpago)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtConcepto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TxtDireccionResponsable)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtNombreResponsable)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(547, 526)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INFORMACION DE PAGO"
        '
        'TxtDireccionResponsable
        '
        Me.TxtDireccionResponsable.AutoSize = True
        Me.TxtDireccionResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccionResponsable.Location = New System.Drawing.Point(104, 90)
        Me.TxtDireccionResponsable.Name = "TxtDireccionResponsable"
        Me.TxtDireccionResponsable.Size = New System.Drawing.Size(182, 21)
        Me.TxtDireccionResponsable.TabIndex = 14
        Me.TxtDireccionResponsable.Text = "TxtDireccionResponsable"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 21)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Domicilio:"
        '
        'TxtNombre
        '
        Me.TxtNombre.AutoSize = True
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(90, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(87, 21)
        Me.TxtNombre.TabIndex = 6
        Me.TxtNombre.Text = "TxtNombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Difunto:"
        '
        'TxtNombreResponsable
        '
        Me.TxtNombreResponsable.AutoSize = True
        Me.TxtNombreResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreResponsable.Location = New System.Drawing.Point(125, 28)
        Me.TxtNombreResponsable.Name = "TxtNombreResponsable"
        Me.TxtNombreResponsable.Size = New System.Drawing.Size(409, 21)
        Me.TxtNombreResponsable.TabIndex = 4
        Me.TxtNombreResponsable.Text = "Nombre completo de difunto con apellidos del encargado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Responsable:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.818182!)
        Me.TxtDescripcion.Location = New System.Drawing.Point(19, 148)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(515, 86)
        Me.TxtDescripcion.TabIndex = 16
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Font = New System.Drawing.Font("Segoe UI", 9.818182!)
        Me.TxtConcepto.Location = New System.Drawing.Point(19, 271)
        Me.TxtConcepto.Multiline = True
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(515, 86)
        Me.TxtConcepto.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Concepto"
        '
        'Txtpago
        '
        Me.Txtpago.Location = New System.Drawing.Point(145, 366)
        Me.Txtpago.Name = "Txtpago"
        Me.Txtpago.Size = New System.Drawing.Size(389, 24)
        Me.Txtpago.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 21)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Monto a pagar:"
        '
        'TxtPresidente
        '
        Me.TxtPresidente.Font = New System.Drawing.Font("Segoe UI", 9.818182!)
        Me.TxtPresidente.Location = New System.Drawing.Point(20, 421)
        Me.TxtPresidente.Name = "TxtPresidente"
        Me.TxtPresidente.Size = New System.Drawing.Size(514, 27)
        Me.TxtPresidente.TabIndex = 22
        Me.TxtPresidente.Text = "Fatima Yadira Soto Petic"
        Me.TxtPresidente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(168, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Preseidente(a) de panteones"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(277, 454)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(257, 52)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "REALIZAR PAGO"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(257, 52)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Inhumanacion_pagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 526)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inhumanacion_pagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inhumanacion_pagar"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents TxtDireccionResponsable As Label
    Friend WithEvents Label18 As Label
    Public WithEvents TxtNombre As Label
    Friend WithEvents Label4 As Label
    Public WithEvents TxtNombreResponsable As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPresidente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtpago As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
