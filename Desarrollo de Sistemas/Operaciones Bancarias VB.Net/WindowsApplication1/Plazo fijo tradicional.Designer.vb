<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPFT
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
        Me.cbPlazo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.EPmontoInicial = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mtbMonto = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.EPmontoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPlazo
        '
        Me.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlazo.FormattingEnabled = True
        Me.cbPlazo.Items.AddRange(New Object() {"30 días (18%)", "45 días (18%)", "60 días (19%)", "90 días (19%)", "120 días (21,50%)", "180 días (23,50%)", "365 días (26,50%)"})
        Me.cbPlazo.Location = New System.Drawing.Point(206, 39)
        Me.cbPlazo.Name = "cbPlazo"
        Me.cbPlazo.Size = New System.Drawing.Size(107, 21)
        Me.cbPlazo.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Monto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Plazo en dias"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Linen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(122, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Linen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 25)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "<---"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'EPmontoInicial
        '
        Me.EPmontoInicial.ContainerControl = Me
        '
        'mtbMonto
        '
        Me.mtbMonto.Location = New System.Drawing.Point(206, 77)
        Me.mtbMonto.Mask = "99999999"
        Me.mtbMonto.Name = "mtbMonto"
        Me.mtbMonto.Size = New System.Drawing.Size(54, 20)
        Me.mtbMonto.TabIndex = 46
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Location = New System.Drawing.Point(61, 130)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(199, 20)
        Me.dtpDate.TabIndex = 47
        '
        'frmPFT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(325, 221)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.mtbMonto)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbPlazo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPFT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plazo fijo tradicional."
        CType(Me.EPmontoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents EPmontoInicial As System.Windows.Forms.ErrorProvider
    Friend WithEvents mtbMonto As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
End Class
