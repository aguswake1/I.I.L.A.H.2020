<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTB
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
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDNIajeno = New System.Windows.Forms.TextBox()
        Me.txtTransferencia = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSaldoDolares = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSaldoPesos = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.epDNI = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epMonto = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbmot = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.epDNI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbCuentas
        '
        Me.cbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCuentas.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Items.AddRange(New Object() {"", "ARS", "U$D"})
        Me.cbCuentas.Location = New System.Drawing.Point(16, 75)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(100, 23)
        Me.cbCuentas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DNI de la persona a la que le desea transferir"
        '
        'txtDNIajeno
        '
        Me.txtDNIajeno.Location = New System.Drawing.Point(16, 176)
        Me.txtDNIajeno.Name = "txtDNIajeno"
        Me.txtDNIajeno.ReadOnly = True
        Me.txtDNIajeno.Size = New System.Drawing.Size(100, 20)
        Me.txtDNIajeno.TabIndex = 3
        '
        'txtTransferencia
        '
        Me.txtTransferencia.Location = New System.Drawing.Point(16, 263)
        Me.txtTransferencia.Name = "txtTransferencia"
        Me.txtTransferencia.ReadOnly = True
        Me.txtTransferencia.Size = New System.Drawing.Size(100, 20)
        Me.txtTransferencia.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(285, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSaldoDolares)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSaldoPesos)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(186, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 100)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos Actuales"
        '
        'txtSaldoDolares
        '
        Me.txtSaldoDolares.Location = New System.Drawing.Point(120, 63)
        Me.txtSaldoDolares.Name = "txtSaldoDolares"
        Me.txtSaldoDolares.ReadOnly = True
        Me.txtSaldoDolares.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoDolares.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Saldo en pesos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Saldo en dólares:"
        '
        'txtSaldoPesos
        '
        Me.txtSaldoPesos.Location = New System.Drawing.Point(120, 25)
        Me.txtSaldoPesos.Name = "txtSaldoPesos"
        Me.txtSaldoPesos.ReadOnly = True
        Me.txtSaldoPesos.Size = New System.Drawing.Size(100, 20)
        Me.txtSaldoPesos.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Linen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(31, 18)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "<---"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'epDNI
        '
        Me.epDNI.ContainerControl = Me
        '
        'epMonto
        '
        Me.epMonto.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(282, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Desestimar Operación"
        '
        'cbmot
        '
        Me.cbmot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbmot.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmot.FormattingEnabled = True
        Me.cbmot.Items.AddRange(New Object() {"ALQ - Alquileres", "CUO - Cuotas", "EXP - Expensas", "FAC - Facturas", "OIN - Operaciones inmoviliarias", "OIH - Operaciones inmoviliarias habituales", "PRE - Préstamos", "SEG - Seguros", "HON - Honorarios", "HAB - Haberes", "BRH - Bienes registrables habitualistas", "BRN - Bienes registrables no habitualistas", "SON - Suscripción obligaciones negociables", "HON - Honorarios", "APC - Aportes de capital", "VAR - Varios"})
        Me.cbmot.Location = New System.Drawing.Point(16, 336)
        Me.cbmot.Name = "cbmot"
        Me.cbmot.Size = New System.Drawing.Size(229, 23)
        Me.cbmot.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 21)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Motivo:"
        '
        'frmTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(426, 370)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbmot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTransferencia)
        Me.Controls.Add(Me.txtDNIajeno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCuentas)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencia Bancaria"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.epDNI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCuentas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDNIajeno As System.Windows.Forms.TextBox
    Friend WithEvents txtTransferencia As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSaldoDolares As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoPesos As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents epDNI As System.Windows.Forms.ErrorProvider
    Friend WithEvents epMonto As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbmot As System.Windows.Forms.ComboBox
End Class
