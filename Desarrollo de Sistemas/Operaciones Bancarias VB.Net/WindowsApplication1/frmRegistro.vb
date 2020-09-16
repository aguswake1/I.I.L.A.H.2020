Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmRegistro
    Dim bool As Boolean


    Function IsEmail(ByVal email As String) As Boolean
        'Validación de Email
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Dim y As Boolean = True
        Dim a As Boolean = True
        Dim r As Boolean = True
        Dim j As Boolean = True
        Dim k As Boolean = True
        Dim b As Boolean = True
        Dim d As Boolean = True
        Dim s As Boolean = True
        Dim cantCaracteresDNI As Integer
        Dim caracteresDNI As String
        Dim cantCaracteres As Integer
        Dim caracteres As String
        Dim nombre = txtNombre.Text
        Dim apellido = txtApellido.Text
        Dim nacimiento = DTP.Value
        Dim correo = txtCorreo.Text
        Dim usuario = txtUsuario.Text
        Dim contraseña = txtContraseña.Text
        Dim f As Integer = 0
        Dim dni = txtDNI.Text

        'A continuación defino contadores
        caracteresDNI = txtDNI.Text
        cantCaracteresDNI = Len(caracteresDNI)
        caracteres = txtContraseña.Text
        cantCaracteres = Len(caracteres)

        'Validación Nombre
        If txtNombre.Text = "" Or txtNombre.Text = " " Or IsNumeric(txtNombre.Text) = True Then
            Label8.Visible = True
            y = False
        Else
            Label8.Visible = False
            y = True
        End If

        'Validación Apellido
        If txtApellido.Text = "" Or txtApellido.Text = " " Or IsNumeric(txtApellido.Text) = True Then
            Label9.Visible = True
            a = False
        Else
            Label9.Visible = False
            a = True
        End If

        'Validación DNI
        If cantCaracteresDNI <> 8 Or IsNumeric(txtDNI.Text) = False Then
            Label10.Visible = True
            r = False
        Else
            Label10.Visible = False
            r = True
        End If

        'Validación email
        If Not (IsEmail(txtCorreo.Text)) Then
            Label12.Visible = True
            j = False
        Else
            Label12.Visible = False
            j = True
        End If

        'Validación usuario
        If txtUsuario.Text = "" Or txtUsuario.Text = " " Then
            Label13.Visible = True
            k = False
        Else
            Label13.Visible = False
            k = True
        End If   


        'Validaciones de contraseña

        If (cantCaracteres < 8 Or txtContraseña.Text = txtContraseña.Text.ToLower) Then
            Label14.Visible = True
            s = False
        Else
            For i As Integer = 0 To cantCaracteres - 1
                If IsNumeric(txtContraseña.Text(i)) = False Then
                    Label14.Visible = True
                    s = False
                Else
                    Label14.Visible = False
                    s = True
                    Exit For
                End If
            Next
        End If

        If y And r And j And a And k And d And s Then

            'Escribir en datos.txt los datos del registro.
            Dim escribir As New StreamWriter("datos.txt", True)
            escribir.WriteLine(txtNombre.Text + "," + txtApellido.Text + "," + txtDNI.Text + "," + txtCorreo.Text + "," + txtUsuario.Text + "," + txtContraseña.Text)
            escribir.Close()
            'Escribir en cuentasBanco.txt usando como identificador el DNI del cliente, 1.000 dólares y 100.000 pesos argentinos base
            Dim escribirCuenta As New StreamWriter("cuentasBanco.txt", True)
            escribirCuenta.WriteLine(txtDNI.Text + "," + "U$D" + "," + "1000")
            escribirCuenta.WriteLine(txtDNI.Text + "," + "ARS" + "," + "100000")
            escribirCuenta.Close()
            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Visibilidad o invisibilidad de la contraseña según las preferencias del usuario
        If CheckBox1.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Modo nocturno activado o desactivado
        If bool = False Then
            Me.BackColor = Color.Black
            Label.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Label3.ForeColor = Color.White
            Label4.ForeColor = Color.White
            Label5.ForeColor = Color.White
            Label6.ForeColor = Color.White
            Label7.ForeColor = Color.White
            GroupBox1.ForeColor = Color.White
            bool = True
        Else

            Me.BackColor = Color.White
            Label.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label6.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
            GroupBox1.ForeColor = Color.Black
            bool = False
        End If

    End Sub
    Private Sub aquí_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles aquí.LinkClicked
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class