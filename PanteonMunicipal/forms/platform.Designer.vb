<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class platform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(platform))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Desktop = New System.Windows.Forms.Panel()
        Me.Principal = New System.Windows.Forms.TableLayoutPanel()
        Me.log_hoy = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.total_hoy = New System.Windows.Forms.Label()
        Me.totaleles = New System.Windows.Forms.TableLayoutPanel()
        Me.f_comun = New System.Windows.Forms.Label()
        Me.exhumanaciones = New System.Windows.Forms.Label()
        Me.t_inhumanaciones = New System.Windows.Forms.Label()
        Me.l_asignados = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.name_user = New System.Windows.Forms.Label()
        Me.name_username = New System.Windows.Forms.Label()
        Me.nivel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhumacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExhumacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FosaComunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdquisicionDeEspacioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LugaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaSeccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarLugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.INFORMACION_DE_USUARIO = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Desktop.SuspendLayout()
        Me.Principal.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.totaleles.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.78182!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ArchivoToolStripMenuItem, Me.InhumacionToolStripMenuItem, Me.ExhumacionToolStripMenuItem, Me.FosaComunToolStripMenuItem, Me.AdquisicionDeEspacioToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1400, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Desktop
        '
        Me.Desktop.BackgroundImage = Global.PanteonMunicipal.My.Resources.Resources._2d0ea7dc_29bb_4e43_9e58_147e14f41527
        Me.Desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Desktop.Controls.Add(Me.Principal)
        Me.Desktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Desktop.Location = New System.Drawing.Point(0, 40)
        Me.Desktop.Name = "Desktop"
        Me.Desktop.Size = New System.Drawing.Size(1400, 924)
        Me.Desktop.TabIndex = 2
        '
        'Principal
        '
        Me.Principal.BackColor = System.Drawing.Color.Transparent
        Me.Principal.ColumnCount = 1
        Me.Principal.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Principal.Controls.Add(Me.log_hoy, 0, 2)
        Me.Principal.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.Principal.Controls.Add(Me.TableLayoutPanel1, 0, 4)
        Me.Principal.Controls.Add(Me.INFORMACION_DE_USUARIO, 0, 3)
        Me.Principal.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Principal.Location = New System.Drawing.Point(0, 0)
        Me.Principal.Name = "Principal"
        Me.Principal.RowCount = 5
        Me.Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.Principal.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.Principal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.Principal.Size = New System.Drawing.Size(1400, 924)
        Me.Principal.TabIndex = 1
        '
        'log_hoy
        '
        Me.log_hoy.AutoSize = True
        Me.log_hoy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log_hoy.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log_hoy.ForeColor = System.Drawing.Color.White
        Me.log_hoy.Location = New System.Drawing.Point(3, 457)
        Me.log_hoy.Name = "log_hoy"
        Me.log_hoy.Size = New System.Drawing.Size(1394, 343)
        Me.log_hoy.TabIndex = 6
        Me.log_hoy.Text = resources.GetString("log_hoy.Text")
        Me.log_hoy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.total_hoy, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.totaleles, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 223)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1394, 231)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'total_hoy
        '
        Me.total_hoy.AutoSize = True
        Me.total_hoy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.total_hoy.Font = New System.Drawing.Font("Segoe UI Semibold", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_hoy.ForeColor = System.Drawing.Color.White
        Me.total_hoy.Location = New System.Drawing.Point(3, 118)
        Me.total_hoy.Name = "total_hoy"
        Me.total_hoy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.total_hoy.Size = New System.Drawing.Size(1388, 113)
        Me.total_hoy.TabIndex = 5
        Me.total_hoy.Text = "INGRESOS HOY $ 0.0 MXN"
        Me.total_hoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totaleles
        '
        Me.totaleles.BackColor = System.Drawing.Color.Transparent
        Me.totaleles.ColumnCount = 4
        Me.totaleles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.totaleles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.totaleles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.totaleles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.totaleles.Controls.Add(Me.f_comun, 3, 0)
        Me.totaleles.Controls.Add(Me.exhumanaciones, 2, 0)
        Me.totaleles.Controls.Add(Me.t_inhumanaciones, 1, 0)
        Me.totaleles.Controls.Add(Me.l_asignados, 0, 0)
        Me.totaleles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.totaleles.Location = New System.Drawing.Point(3, 3)
        Me.totaleles.Name = "totaleles"
        Me.totaleles.RowCount = 1
        Me.totaleles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.totaleles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.totaleles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.totaleles.Size = New System.Drawing.Size(1388, 112)
        Me.totaleles.TabIndex = 0
        '
        'f_comun
        '
        Me.f_comun.AutoSize = True
        Me.f_comun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.f_comun.Font = New System.Drawing.Font("Segoe UI Semibold", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f_comun.ForeColor = System.Drawing.Color.White
        Me.f_comun.Location = New System.Drawing.Point(1044, 0)
        Me.f_comun.Name = "f_comun"
        Me.f_comun.Size = New System.Drawing.Size(341, 112)
        Me.f_comun.TabIndex = 3
        Me.f_comun.Text = "TOTAL INHUMANACIONES"
        Me.f_comun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exhumanaciones
        '
        Me.exhumanaciones.AutoSize = True
        Me.exhumanaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.exhumanaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exhumanaciones.ForeColor = System.Drawing.Color.White
        Me.exhumanaciones.Location = New System.Drawing.Point(697, 0)
        Me.exhumanaciones.Name = "exhumanaciones"
        Me.exhumanaciones.Size = New System.Drawing.Size(341, 112)
        Me.exhumanaciones.TabIndex = 2
        Me.exhumanaciones.Text = "TOTAL, FOSA COMUN"
        Me.exhumanaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't_inhumanaciones
        '
        Me.t_inhumanaciones.AutoSize = True
        Me.t_inhumanaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.t_inhumanaciones.Font = New System.Drawing.Font("Segoe UI Semibold", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t_inhumanaciones.ForeColor = System.Drawing.Color.White
        Me.t_inhumanaciones.Location = New System.Drawing.Point(350, 0)
        Me.t_inhumanaciones.Name = "t_inhumanaciones"
        Me.t_inhumanaciones.Size = New System.Drawing.Size(341, 112)
        Me.t_inhumanaciones.TabIndex = 1
        Me.t_inhumanaciones.Text = "EXHUMACIONES REGISTRADAS"
        Me.t_inhumanaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_asignados
        '
        Me.l_asignados.AutoSize = True
        Me.l_asignados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.l_asignados.Font = New System.Drawing.Font("Segoe UI Semibold", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l_asignados.ForeColor = System.Drawing.Color.White
        Me.l_asignados.Location = New System.Drawing.Point(3, 0)
        Me.l_asignados.Name = "l_asignados"
        Me.l_asignados.Size = New System.Drawing.Size(341, 112)
        Me.l_asignados.TabIndex = 0
        Me.l_asignados.Text = "LUGARES ASIGNADOS"
        Me.l_asignados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.name_user, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.name_username, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.nivel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 850)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1394, 71)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'name_user
        '
        Me.name_user.AutoSize = True
        Me.name_user.Dock = System.Windows.Forms.DockStyle.Fill
        Me.name_user.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_user.ForeColor = System.Drawing.Color.White
        Me.name_user.Location = New System.Drawing.Point(3, 30)
        Me.name_user.Name = "name_user"
        Me.name_user.Size = New System.Drawing.Size(458, 41)
        Me.name_user.TabIndex = 6
        Me.name_user.Text = "LUGARES ASIGNADOS"
        Me.name_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_username
        '
        Me.name_username.AutoSize = True
        Me.name_username.Dock = System.Windows.Forms.DockStyle.Fill
        Me.name_username.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_username.ForeColor = System.Drawing.Color.White
        Me.name_username.Location = New System.Drawing.Point(467, 30)
        Me.name_username.Name = "name_username"
        Me.name_username.Size = New System.Drawing.Size(458, 41)
        Me.name_username.TabIndex = 5
        Me.name_username.Text = "LUGARES ASIGNADOS"
        Me.name_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nivel
        '
        Me.nivel.AutoSize = True
        Me.nivel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nivel.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nivel.ForeColor = System.Drawing.Color.White
        Me.nivel.Location = New System.Drawing.Point(931, 30)
        Me.nivel.Name = "nivel"
        Me.nivel.Size = New System.Drawing.Size(460, 41)
        Me.nivel.TabIndex = 4
        Me.nivel.Text = "LUGARES ASIGNADOS"
        Me.nivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.70909!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NOMBRE DE USUARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.70909!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(467, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USUARIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.70909!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(931, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(460, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NIVEL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1394, 214)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.PanteonMunicipal.My.Resources.Resources._2
        Me.Label6.Location = New System.Drawing.Point(931, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(460, 214)
        Me.Label6.TabIndex = 9
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.PanteonMunicipal.My.Resources.Resources._1
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(458, 214)
        Me.Label4.TabIndex = 7
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 36)
        Me.ToolStripMenuItem1.Text = "ARCHIVO"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 36)
        Me.ToolStripMenuItem2.Text = "Salir"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ArchivoToolStripMenuItem.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(154, 36)
        Me.ArchivoToolStripMenuItem.Text = "PRINCIPAL"
        '
        'InhumacionToolStripMenuItem
        '
        Me.InhumacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.PagosToolStripMenuItem})
        Me.InhumacionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.70909!)
        Me.InhumacionToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InhumacionToolStripMenuItem.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.InhumacionToolStripMenuItem.Name = "InhumacionToolStripMenuItem"
        Me.InhumacionToolStripMenuItem.Size = New System.Drawing.Size(196, 36)
        Me.InhumacionToolStripMenuItem.Text = "INHUMACION"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'ExhumacionToolStripMenuItem
        '
        Me.ExhumacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultasToolStripMenuItem1})
        Me.ExhumacionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.70909!)
        Me.ExhumacionToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ExhumacionToolStripMenuItem.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.ExhumacionToolStripMenuItem.Name = "ExhumacionToolStripMenuItem"
        Me.ExhumacionToolStripMenuItem.Size = New System.Drawing.Size(198, 36)
        Me.ExhumacionToolStripMenuItem.Text = "EXHUMACION"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultasToolStripMenuItem1
        '
        Me.ConsultasToolStripMenuItem1.Name = "ConsultasToolStripMenuItem1"
        Me.ConsultasToolStripMenuItem1.Size = New System.Drawing.Size(197, 36)
        Me.ConsultasToolStripMenuItem1.Text = "Consultas"
        '
        'FosaComunToolStripMenuItem
        '
        Me.FosaComunToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.70909!)
        Me.FosaComunToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FosaComunToolStripMenuItem.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.FosaComunToolStripMenuItem.Name = "FosaComunToolStripMenuItem"
        Me.FosaComunToolStripMenuItem.Size = New System.Drawing.Size(198, 36)
        Me.FosaComunToolStripMenuItem.Text = "FOSA COMUN"
        '
        'AdquisicionDeEspacioToolStripMenuItem
        '
        Me.AdquisicionDeEspacioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem3, Me.LugaresToolStripMenuItem})
        Me.AdquisicionDeEspacioToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.70909!)
        Me.AdquisicionDeEspacioToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AdquisicionDeEspacioToolStripMenuItem.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.AdquisicionDeEspacioToolStripMenuItem.Name = "AdquisicionDeEspacioToolStripMenuItem"
        Me.AdquisicionDeEspacioToolStripMenuItem.Size = New System.Drawing.Size(326, 36)
        Me.AdquisicionDeEspacioToolStripMenuItem.Text = "ADQUISICION DE ESPACIO"
        '
        'ConsultasToolStripMenuItem3
        '
        Me.ConsultasToolStripMenuItem3.Name = "ConsultasToolStripMenuItem3"
        Me.ConsultasToolStripMenuItem3.Size = New System.Drawing.Size(197, 36)
        Me.ConsultasToolStripMenuItem3.Text = "Consultas"
        '
        'LugaresToolStripMenuItem
        '
        Me.LugaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaSeccionToolStripMenuItem, Me.AgregarLugarToolStripMenuItem})
        Me.LugaresToolStripMenuItem.Name = "LugaresToolStripMenuItem"
        Me.LugaresToolStripMenuItem.Size = New System.Drawing.Size(197, 36)
        Me.LugaresToolStripMenuItem.Text = "Lugares"
        '
        'NuevaSeccionToolStripMenuItem
        '
        Me.NuevaSeccionToolStripMenuItem.Name = "NuevaSeccionToolStripMenuItem"
        Me.NuevaSeccionToolStripMenuItem.Size = New System.Drawing.Size(249, 36)
        Me.NuevaSeccionToolStripMenuItem.Text = "Nueva seccion"
        '
        'AgregarLugarToolStripMenuItem
        '
        Me.AgregarLugarToolStripMenuItem.Name = "AgregarLugarToolStripMenuItem"
        Me.AgregarLugarToolStripMenuItem.Size = New System.Drawing.Size(249, 36)
        Me.AgregarLugarToolStripMenuItem.Text = "Agregar lugar"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.GestionToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.70909!)
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.UsuariosToolStripMenuItem.Image = Global.PanteonMunicipal.My.Resources.Resources.iconfinder_abstract_symbol_09_1571981__2_
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(155, 36)
        Me.UsuariosToolStripMenuItem.Text = "USUARIOS"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(175, 36)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(175, 36)
        Me.GestionToolStripMenuItem.Text = "Gestion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.PanteonMunicipal.My.Resources.Resources._3
        Me.Label5.Location = New System.Drawing.Point(467, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(458, 214)
        Me.Label5.TabIndex = 8
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'INFORMACION_DE_USUARIO
        '
        Me.INFORMACION_DE_USUARIO.AutoSize = True
        Me.INFORMACION_DE_USUARIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.INFORMACION_DE_USUARIO.Font = New System.Drawing.Font("Segoe UI Semibold", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INFORMACION_DE_USUARIO.ForeColor = System.Drawing.Color.White
        Me.INFORMACION_DE_USUARIO.Location = New System.Drawing.Point(3, 800)
        Me.INFORMACION_DE_USUARIO.Name = "INFORMACION_DE_USUARIO"
        Me.INFORMACION_DE_USUARIO.Size = New System.Drawing.Size(1394, 47)
        Me.INFORMACION_DE_USUARIO.TabIndex = 4
        Me.INFORMACION_DE_USUARIO.Text = "INFORMACION DE USUARIO"
        Me.INFORMACION_DE_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'platform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 964)
        Me.Controls.Add(Me.Desktop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "platform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "platform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Desktop.ResumeLayout(False)
        Me.Principal.ResumeLayout(False)
        Me.Principal.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.totaleles.ResumeLayout(False)
        Me.totaleles.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InhumacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExhumacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FosaComunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdquisicionDeEspacioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Desktop As Panel
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LugaresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaSeccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarLugarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents totaleles As TableLayoutPanel
    Friend WithEvents f_comun As Label
    Friend WithEvents exhumanaciones As Label
    Friend WithEvents t_inhumanaciones As Label
    Friend WithEvents l_asignados As Label
    Friend WithEvents Principal As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents name_user As Label
    Friend WithEvents name_username As Label
    Friend WithEvents nivel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents log_hoy As Label
    Friend WithEvents total_hoy As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents INFORMACION_DE_USUARIO As Label
End Class
