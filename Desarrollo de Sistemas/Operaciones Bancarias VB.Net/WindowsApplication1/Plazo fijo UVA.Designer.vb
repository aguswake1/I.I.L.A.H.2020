<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPFUVA
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
        Me.components = New System.ComponentModel.Container()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.mtbMonto = New System.Windows.Forms.MaskedTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbPlazo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mtbUVAficticio = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.EP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Location = New System.Drawing.Point(12, 159)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(199, 20)
        Me.dtpDate.TabIndex = 54
        '
        'mtbMonto
        '
        Me.mtbMonto.Location = New System.Drawing.Point(219, 81)
        Me.mtbMonto.Mask = "99999999"
        Me.mtbMonto.Name = "mtbMonto"
        Me.mtbMonto.Size = New System.Drawing.Size(54, 20)
        Me.mtbMonto.TabIndex = 53
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Linen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(5, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 25)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "<---"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cbPlazo
        '
        Me.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlazo.FormattingEnabled = True
        Me.cbPlazo.Items.AddRange(New Object() {"90 días", "120 días", "180 días", "365 días"})
        Me.cbPlazo.Location = New System.Drawing.Point(219, 43)
        Me.cbPlazo.Name = "cbPlazo"
        Me.cbPlazo.Size = New System.Drawing.Size(54, 21)
        Me.cbPlazo.TabIndex = 51
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(43, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 35)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Plazo en dias"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Monto"
        '
        'EP
        '
        Me.EP.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Estimación del valor UVA a futuro por parte del usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(122, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Simulación"
        '
        'mtbUVAficticio
        '
        Me.mtbUVAficticio.Location = New System.Drawing.Point(307, 135)
        Me.mtbUVAficticio.Mask = "99"
        Me.mtbUVAficticio.Name = "mtbUVAficticio"
        Me.mtbUVAficticio.Size = New System.Drawing.Size(18, 20)
        Me.mtbUVAficticio.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 28)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Valor UVA actual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      $54,9"
        '
        'frmPFUVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 246)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mtbUVAficticio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.mtbMonto)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbPlazo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPFUVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plazo fijo UVA"
        CType(Me.EP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtbMonto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EP As System.Windows.Forms.ErrorProvider
    Friend WithEvents mtbUVAficticio As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
