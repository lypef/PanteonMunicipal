<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inhumanacion_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inhumanacion_details))
        Me.Pdf = New AxAcroPDFLib.AxAcroPDF()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtFechaRegistro = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtFechaDefunsion = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFechaNacimiento = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTipoTumba = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtNoTumba = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPerpetuidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtZona = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSexo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTelefonoResponsable = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtDireccionResponsable = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtNombreResponsable = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pdf
        '
        Me.Pdf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pdf.Enabled = True
        Me.Pdf.Location = New System.Drawing.Point(3, 20)
        Me.Pdf.Name = "Pdf"
        Me.Pdf.OcxState = CType(resources.GetObject("Pdf.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Pdf.Size = New System.Drawing.Size(519, 352)
        Me.Pdf.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Pdf)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 375)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACTA DE DEFUNCION"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(12, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1028, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtFechaRegistro)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TxtFechaDefunsion)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtFechaNacimiento)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.TxtTipoTumba)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.TxtNoTumba)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtPerpetuidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtZona)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtSexo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 393)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1031, 124)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DIFUNTO"
        '
        'TxtFechaRegistro
        '
        Me.TxtFechaRegistro.AutoSize = True
        Me.TxtFechaRegistro.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaRegistro.Location = New System.Drawing.Point(501, 20)
        Me.TxtFechaRegistro.Name = "TxtFechaRegistro"
        Me.TxtFechaRegistro.Size = New System.Drawing.Size(158, 21)
        Me.TxtFechaRegistro.TabIndex = 22
        Me.TxtFechaRegistro.Text = "2019-11-03 00:00:00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(404, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 21)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "F. Registro:"
        '
        'TxtFechaDefunsion
        '
        Me.TxtFechaDefunsion.AutoSize = True
        Me.TxtFechaDefunsion.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaDefunsion.Location = New System.Drawing.Point(473, 86)
        Me.TxtFechaDefunsion.Name = "TxtFechaDefunsion"
        Me.TxtFechaDefunsion.Size = New System.Drawing.Size(186, 21)
        Me.TxtFechaDefunsion.TabIndex = 20
        Me.TxtFechaDefunsion.Text = "2020-11-03 00:00:00 AM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(371, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "F. Defunsion:"
        '
        'TxtFechaNacimiento
        '
        Me.TxtFechaNacimiento.AutoSize = True
        Me.TxtFechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaNacimiento.Location = New System.Drawing.Point(146, 86)
        Me.TxtFechaNacimiento.Name = "TxtFechaNacimiento"
        Me.TxtFechaNacimiento.Size = New System.Drawing.Size(186, 21)
        Me.TxtFechaNacimiento.TabIndex = 16
        Me.TxtFechaNacimiento.Text = "2020-11-03 00:00:00 AM"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "F. Nacimiento:"
        '
        'TxtTipoTumba
        '
        Me.TxtTipoTumba.AutoSize = True
        Me.TxtTipoTumba.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoTumba.Location = New System.Drawing.Point(866, 50)
        Me.TxtTipoTumba.Name = "TxtTipoTumba"
        Me.TxtTipoTumba.Size = New System.Drawing.Size(73, 21)
        Me.TxtTipoTumba.TabIndex = 14
        Me.TxtTipoTumba.Text = "Concreto"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(788, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 21)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "T. Tumba:"
        '
        'TxtNoTumba
        '
        Me.TxtNoTumba.AutoSize = True
        Me.TxtNoTumba.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoTumba.Location = New System.Drawing.Point(655, 50)
        Me.TxtNoTumba.Name = "TxtNoTumba"
        Me.TxtNoTumba.Size = New System.Drawing.Size(64, 21)
        Me.TxtNoTumba.TabIndex = 12
        Me.TxtNoTumba.Text = "848484"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(543, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 21)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "No. Tumba: #"
        '
        'TxtPerpetuidad
        '
        Me.TxtPerpetuidad.AutoSize = True
        Me.TxtPerpetuidad.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPerpetuidad.Location = New System.Drawing.Point(461, 50)
        Me.TxtPerpetuidad.Name = "TxtPerpetuidad"
        Me.TxtPerpetuidad.Size = New System.Drawing.Size(64, 21)
        Me.TxtPerpetuidad.TabIndex = 10
        Me.TxtPerpetuidad.Text = "848484"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(309, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "No. Perpetuidad: #"
        '
        'TxtZona
        '
        Me.TxtZona.AutoSize = True
        Me.TxtZona.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtZona.Location = New System.Drawing.Point(225, 50)
        Me.TxtZona.Name = "TxtZona"
        Me.TxtZona.Size = New System.Drawing.Size(63, 21)
        Me.TxtZona.TabIndex = 8
        Me.TxtZona.Text = "Zonna1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Zona:"
        '
        'TxtSexo
        '
        Me.TxtSexo.AutoSize = True
        Me.TxtSexo.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.Location = New System.Drawing.Point(65, 50)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(79, 21)
        Me.TxtSexo.TabIndex = 6
        Me.TxtSexo.Text = "Femenino"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sexo:"
        '
        'TxtNombre
        '
        Me.TxtNombre.AutoSize = True
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(87, 20)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(307, 21)
        Me.TxtNombre.TabIndex = 4
        Me.TxtNombre.Text = "Nombre completo de difunto con apellidos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 523)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(747, 124)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESPONSABLE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(98, 92)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(286, 21)
        Me.Label25.TabIndex = 14
        Me.Label25.Text = "Telefono, puede ser uno o mas numeros"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(14, 92)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(78, 21)
        Me.Label26.TabIndex = 13
        Me.Label26.Text = "Telefono:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(98, 59)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(281, 21)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Direccion completa, con calle y numero"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(9, 59)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(83, 21)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Direccion:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(98, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(307, 21)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Nombre completo de difunto con apellidos"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(17, 29)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(75, 21)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "Nombre:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtTelefonoResponsable)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TxtDireccionResponsable)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.TxtNombreResponsable)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 523)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1031, 124)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RESPONSABLE"
        '
        'TxtTelefonoResponsable
        '
        Me.TxtTelefonoResponsable.AutoSize = True
        Me.TxtTelefonoResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefonoResponsable.Location = New System.Drawing.Point(98, 92)
        Me.TxtTelefonoResponsable.Name = "TxtTelefonoResponsable"
        Me.TxtTelefonoResponsable.Size = New System.Drawing.Size(286, 21)
        Me.TxtTelefonoResponsable.TabIndex = 14
        Me.TxtTelefonoResponsable.Text = "Telefono, puede ser uno o mas numeros"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 92)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 21)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Telefono:"
        '
        'TxtDireccionResponsable
        '
        Me.TxtDireccionResponsable.AutoSize = True
        Me.TxtDireccionResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccionResponsable.Location = New System.Drawing.Point(98, 59)
        Me.TxtDireccionResponsable.Name = "TxtDireccionResponsable"
        Me.TxtDireccionResponsable.Size = New System.Drawing.Size(281, 21)
        Me.TxtDireccionResponsable.TabIndex = 6
        Me.TxtDireccionResponsable.Text = "Direccion completa, con calle y numero"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(14, 59)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 21)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Direccion:"
        '
        'TxtNombreResponsable
        '
        Me.TxtNombreResponsable.AutoSize = True
        Me.TxtNombreResponsable.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreResponsable.Location = New System.Drawing.Point(87, 29)
        Me.TxtNombreResponsable.Name = "TxtNombreResponsable"
        Me.TxtNombreResponsable.Size = New System.Drawing.Size(307, 21)
        Me.TxtNombreResponsable.TabIndex = 4
        Me.TxtNombreResponsable.Text = "Nombre completo de difunto con apellidos"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 21)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Nombre:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AxAcroPDF1)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Black", 7.854546!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(543, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(500, 375)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "IDENTIFICACION INE"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(3, 20)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(494, 352)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(815, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "2020-11-03 00:00:00 AM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(697, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "F. Vencimiento:"
        '
        'Inhumanacion_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 721)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inhumanacion_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inhumanacion_details"
        Me.TopMost = True
        CType(Me.Pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Pdf As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Public WithEvents TxtFechaRegistro As Label
    Public WithEvents TxtFechaDefunsion As Label
    Public WithEvents TxtFechaNacimiento As Label
    Public WithEvents TxtTipoTumba As Label
    Public WithEvents TxtNoTumba As Label
    Public WithEvents TxtPerpetuidad As Label
    Public WithEvents TxtZona As Label
    Public WithEvents TxtSexo As Label
    Public WithEvents TxtNombre As Label
    Public WithEvents TxtTelefonoResponsable As Label
    Public WithEvents TxtDireccionResponsable As Label
    Public WithEvents TxtNombreResponsable As Label
    Friend WithEvents GroupBox5 As GroupBox
    Public WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Public WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
