<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class users_consultar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Table, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1528, 660)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button6, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button5, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 598)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1522, 59)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(3, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(501, 53)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "GENERAR REPORTE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1017, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(502, 53)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "ACTUALIZAR"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(510, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(501, 53)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "ELIMINAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Table
        '
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(3, 3)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(1522, 589)
        Me.Table.TabIndex = 4
        '
        'users_consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 660)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "users_consultar"
        Me.Text = "users_consultar"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Table As DataGridView
End Class
