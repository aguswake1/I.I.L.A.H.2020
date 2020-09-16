Imports System.IO

Public Class frmLogin
    Dim bool As Boolean

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frmRegistro.Show()

    End Sub

    Private Sub btnLoginIngresar_Click(sender As Object, e As EventArgs) Handles btnLoginIngresar.Click
        Dim msg, style, title
        Dim leer As New StreamReader("datos.txt")
        Dim boolAlRescate As Boolean = False

        'Personalización del messagebox
        msg = "Usuario o contraseña incorrecta." & vbCrLf &
              "Por favor intente nuevamente."
        style = vbOKOnly
        title = "Error"

        'Se lee el archivo datos.txt y se fija si el usuario y la contraseña son correctos
        While leer.Peek <> -1
            Dim linea As String = leer.ReadLine()
            Dim tupla = linea.Split(",")
            If (txtLoginUsuario.Text = tupla(4) And txtLoginContraseña.Text = tupla(5)) Then
                boolAlRescate = True
                Me.Hide()
                compraVenta.Text = tupla(2)
                comprobante.Label2.Text = tupla(0)
                comprobante.Label4.Text = tupla(1)
                frmElegir.Show()
                frmConfirmarPFT.lblCorreo.Text = tupla(3)
                frmCONFIRMARUVA.lblCorreo.Text = tupla(3)
            End If
        End While
        leer.Close()

        If boolAlRescate Then
            Dim leer1 As New StreamReader("cuentasBanco.txt")

            'Leer archivo datos.txt buscando a partir del DNI, los valores de la cuenta
            'TextBox4.Text (Pesos argentinos) | TextBox6.Text (Dólares)
            While leer1.Peek <> -1
                Dim linea As String = leer1.ReadLine()
                Dim tupla = linea.Split(",")
                If (compraVenta.Text = tupla(0)) Then
                    If (tupla(1) = "U$D") Then
                        compraVenta.txtSaldoDolares.Text = tupla(2)
                    ElseIf (tupla(1) = "ARS") Then
                        compraVenta.txtSaldoPesos.Text = tupla(2)
                    End If
                End If
            End While
            leer1.Close()
        End If


        If (boolAlRescate = False) Then
            MsgBox(msg, style, title)
            txtLoginContraseña.Text = ""
            txtLoginUsuario.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'Visibilidad o invisibilidad de la contraseña según las preferencias del usuario
        If CheckBox1.Checked = True Then
            txtLoginContraseña.PasswordChar = ""
        Else
            txtLoginContraseña.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Modo nocturno activado o desactivado
        If bool = False Then
            Label1.ForeColor = Color.White
            Label2.ForeColor = Color.White
            Me.BackColor = Color.Black
            bool = True
        Else
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Me.BackColor = Color.White
            bool = False
        End If
    End Sub
End Class