<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inhumanacion_edit
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.TxtZona = New System.Windows.Forms.TextBox()
        Me.TxtPerpetuidad = New System.Windows.Forms.TextBox()
        Me.TxtNoTumba = New System.Windows.Forms.TextBox()
        Me.TxtTipoTumba = New System.Windows.Forms.TextBox()
        Me.TxtFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtFechaDefunsion = New System.Windows.Forms.DateTimePicker()
        Me.TxtFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombreResponsable = New System.Windows.Forms.TextBox()
        Me.TxtDireccionResponsable = New System.Windows.Forms.TextBox()
        Me.TxtTelefonoResponsable = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTelefonoResponsable)
        Me.GroupBox4.Controls.Add(Me.TxtDireccionResponsable)
        Me.GroupBox4.Controls.Add(Me.TxtNombreResponsable)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(2, 385)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(757, 153)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESPONSABLE"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(91, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 21)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Telefono:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(82, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 21)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Direccion:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(90, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 21)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtFechaRegistro)
        Me.GroupBox2.Controls.Add(Me.TxtFechaDefunsion)
        Me.GroupBox2.Controls.Add(Me.TxtFechaNacimiento)
        Me.GroupBox2.Controls.Add(Me.TxtTipoTumba)
        Me.GroupBox2.Controls.Add(Me.TxtNoTumba)
        Me.GroupBox2.Controls.Add(Me.TxtPerpetuidad)
        Me.GroupBox2.Controls.Add(Me.TxtZona)
        Me.GroupBox2.Controls.Add(Me.TxtSexo)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 367)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIFUNTO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(65, 295)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 21)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "F. Registro:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(53, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "F. Defunsion:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(43, 221)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "F. Nacimiento:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(77, 332)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 21)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "T. Tumba:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(50, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "No. Tumba: #"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "No. Perpetuidad: #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Zona:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sexo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(12, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(362, 55)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.Location = New System.Drawing.Point(379, 544)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(380, 55)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(163, 33)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(574, 27)
        Me.TxtNombre.TabIndex = 22
        '
        'TxtSexo
        '
        Me.TxtSexo.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.Location = New System.Drawing.Point(162, 73)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(574, 27)
        Me.TxtSexo.TabIndex = 23
        '
        'TxtZona
        '
        Me.TxtZona.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZona.Location = New System.Drawing.Point(162, 110)
        Me.TxtZona.Name = "TxtZona"
        Me.TxtZona.Size = New System.Drawing.Size(574, 27)
        Me.TxtZona.TabIndex = 24
        '
        'TxtPerpetuidad
        '
        Me.TxtPerpetuidad.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPerpetuidad.Location = New System.Drawing.Point(162, 147)
        Me.TxtPerpetuidad.Name = "TxtPerpetuidad"
        Me.TxtPerpetuidad.Size = New System.Drawing.Size(574, 27)
        Me.TxtPerpetuidad.TabIndex = 25
        '
        'TxtNoTumba
        '
        Me.TxtNoTumba.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoTumba.Location = New System.Drawing.Point(162, 184)
        Me.TxtNoTumba.Name = "TxtNoTumba"
        Me.TxtNoTumba.Size = New System.Drawing.Size(574, 27)
        Me.TxtNoTumba.TabIndex = 26
        '
        'TxtTipoTumba
        '
        Me.TxtTipoTumba.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoTumba.Location = New System.Drawing.Point(162, 329)
        Me.TxtTipoTumba.Name = "TxtTipoTumba"
        Me.TxtTipoTumba.Size = New System.Drawing.Size(574, 27)
        Me.TxtTipoTumba.TabIndex = 27
        '
        'TxtFechaNacimiento
        '
        Me.TxtFechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 9.818182!)
        Me.TxtFechaNacimiento.Location = New System.Drawing.Point(162, 221)
        Me.TxtFechaNacimiento.Name = "TxtFechaNacimiento"
        Me.TxtFechaNacimiento.Size = New System.Drawing.Size(574, 27)
        Me.TxtFechaNacimiento.TabIndex = 28
        '
        'TxtFechaDefunsion
        '
        Me.TxtFechaDefunsion.Font = New System.Drawing.Font("Segoe UI", 9.818182!)
        Me.TxtFechaDefunsion.Location = New System.Drawing.Point(162, 258)
        Me.TxtFechaDefunsion.Name = "TxtFechaDefunsion"
        Me.TxtFechaDefunsion.Size = New System.Drawing.Size(574, 27)
        Me.TxtFechaDefunsion.TabIndex = 29
        '
        'TxtFechaRegistro
        '
        Me.TxtFechaRegistro.Font = New System.Drawing.Font("Segoe UI", 9.818182!)
        Me.TxtFechaRegistro.Location = New System.Drawing.Point(162, 295)
        Me.TxtFechaRegistro.Name = "TxtFechaRegistro"
        Me.TxtFechaRegistro.Size = New System.Drawing.Size(574, 27)
        Me.TxtFechaRegistro.TabIndex = 30
        '
        'TxtNombreResponsable
        '
        Me.TxtNombreResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreResponsable.Location = New System.Drawing.Point(172, 27)
        Me.TxtNombreResponsable.Name = "TxtNombreResponsable"
        Me.TxtNombreResponsable.Size = New System.Drawing.Size(573, 27)
        Me.TxtNombreResponsable.TabIndex = 31
        '
        'TxtDireccionResponsable
        '
        Me.TxtDireccionResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccionResponsable.Location = New System.Drawing.Point(171, 67)
        Me.TxtDireccionResponsable.Name = "TxtDireccionResponsable"
        Me.TxtDireccionResponsable.Size = New System.Drawing.Size(573, 27)
        Me.TxtDireccionResponsable.TabIndex = 32
        '
        'TxtTelefonoResponsable
        '
        Me.TxtTelefonoResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoResponsable.Location = New System.Drawing.Point(171, 107)
        Me.TxtTelefonoResponsable.Name = "TxtTelefonoResponsable"
        Me.TxtTelefonoResponsable.Size = New System.Drawing.Size(573, 27)
        Me.TxtTelefonoResponsable.TabIndex = 33
        '
        'Inhumanacion_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 619)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inhumanacion_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inhumanacion_edit"
        Me.TopMost = True
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Public WithEvents TxtTelefonoResponsable As TextBox
    Public WithEvents TxtDireccionResponsable As TextBox
    Public WithEvents TxtNombreResponsable As TextBox
    Public WithEvents TxtFechaRegistro As DateTimePicker
    Public WithEvents TxtFechaDefunsion As DateTimePicker
    Public WithEvents TxtFechaNacimiento As DateTimePicker
    Public WithEvents TxtTipoTumba As TextBox
    Public WithEvents TxtNoTumba As TextBox
    Public WithEvents TxtPerpetuidad As TextBox
    Public WithEvents TxtZona As TextBox
    Public WithEvents TxtSexo As TextBox
    Public WithEvents TxtNombre As TextBox
End Class
