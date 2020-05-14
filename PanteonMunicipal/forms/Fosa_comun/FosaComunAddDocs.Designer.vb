<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FosaComunAddDocs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FosaComunAddDocs))
        Me.Combo = New System.Windows.Forms.ComboBox()
        Me.__Pdf = New AxAcroPDFLib.AxAcroPDF()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.__Pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combo
        '
        Me.Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo.Font = New System.Drawing.Font("Segoe UI", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo.Items.AddRange(New Object() {"SITUACION", "1.- INHUMANACION", "2.- FOSA COMUN"})
        Me.Combo.Location = New System.Drawing.Point(12, 12)
        Me.Combo.Name = "Combo"
        Me.Combo.Size = New System.Drawing.Size(531, 40)
        Me.Combo.TabIndex = 7
        '
        '__Pdf
        '
        Me.__Pdf.Enabled = True
        Me.__Pdf.Location = New System.Drawing.Point(12, 58)
        Me.__Pdf.Name = "__Pdf"
        Me.__Pdf.OcxState = CType(resources.GetObject("__Pdf.OcxState"), System.Windows.Forms.AxHost.State)
        Me.__Pdf.Size = New System.Drawing.Size(531, 418)
        Me.__Pdf.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 482)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 130)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NUEVO DOCUMENTO"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!)
        Me.Button2.Location = New System.Drawing.Point(6, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(519, 41)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "AGREGAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!)
        Me.Button1.Location = New System.Drawing.Point(477, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de documento"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.2!)
        Me.TextBox1.Location = New System.Drawing.Point(6, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(465, 29)
        Me.TextBox1.TabIndex = 0
        '
        'FosaComunAddDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 624)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.__Pdf)
        Me.Controls.Add(Me.Combo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FosaComunAddDocs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOCUMENTOS"
        CType(Me.__Pdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Combo As ComboBox
    Friend WithEvents __Pdf As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
