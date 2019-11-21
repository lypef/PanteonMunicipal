<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users_add
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
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._Layout = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtAdmin = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me._Layout.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GUARDAR, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 142)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(761, 91)
        Me.TableLayoutPanel4.TabIndex = 29
        '
        'GUARDAR
        '
        Me.GUARDAR.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GUARDAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GUARDAR.Location = New System.Drawing.Point(383, 3)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(375, 85)
        Me.GUARDAR.TabIndex = 14
        Me.GUARDAR.Text = "AGREGAR"
        Me.GUARDAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 18.32727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(374, 85)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "CERRAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(761, 32)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "NUEVO USUARIO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtUsername, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Txtnombre, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtPassword, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtAdmin, 3, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 55)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(761, 73)
        Me.TableLayoutPanel3.TabIndex = 10
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
        Me.Label4.Size = New System.Drawing.Size(184, 36)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "USERNAME"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(193, 39)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(184, 31)
        Me.TxtPassword.TabIndex = 3
        '
        'Txtnombre
        '
        Me.Txtnombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtnombre.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnombre.Location = New System.Drawing.Point(383, 39)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(184, 31)
        Me.Txtnombre.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(573, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 36)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ADMIN ?"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtUsername
        '
        Me.TxtUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(3, 39)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(184, 31)
        Me.TxtUsername.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 36)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "PASSWORD"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 36)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NOMBRE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_Layout
        '
        Me._Layout.ColumnCount = 1
        Me._Layout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me._Layout.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me._Layout.Controls.Add(Me.Label5, 0, 0)
        Me._Layout.Controls.Add(Me.TableLayoutPanel4, 0, 14)
        Me._Layout.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Layout.Location = New System.Drawing.Point(0, 0)
        Me._Layout.Name = "_Layout"
        Me._Layout.RowCount = 15
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
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me._Layout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me._Layout.Size = New System.Drawing.Size(767, 236)
        Me._Layout.TabIndex = 14
        '
        'TxtAdmin
        '
        Me.TxtAdmin.AutoCompleteCustomSource.AddRange(New String() {"SI", "NO"})
        Me.TxtAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtAdmin.Font = New System.Drawing.Font("Segoe UI", 11.78182!)
        Me.TxtAdmin.FormattingEnabled = True
        Me.TxtAdmin.Items.AddRange(New Object() {"SI", "NO"})
        Me.TxtAdmin.Location = New System.Drawing.Point(573, 39)
        Me.TxtAdmin.Name = "TxtAdmin"
        Me.TxtAdmin.Size = New System.Drawing.Size(185, 33)
        Me.TxtAdmin.TabIndex = 20
        '
        'users_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 236)
        Me.Controls.Add(Me._Layout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "users_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "users_add"
        Me.TopMost = True
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me._Layout.ResumeLayout(False)
        Me._Layout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents GUARDAR As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents TxtUsername As TextBox
    Friend WithEvents Label8 As Label
    Public WithEvents Txtnombre As TextBox
    Public WithEvents TxtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAdmin As ComboBox
    Friend WithEvents _Layout As TableLayoutPanel
End Class
