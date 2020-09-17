Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Function endgame()
        'Validación para ganar
        If (btn1.Text = "1" And btn2.Text = "2" And btn3.Text = "3" And btn4.Text = "4" And btn5.Text = "5" And btn6.Text = "6" And btn7.Text = "7" And btn8.Text = "8" And btn1.Enabled = True) Then
            MsgBox("Felicidades!, Ganaste O.O")
            End
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click
        endgame3x3()


        'Que sucede cuando se cliquea el botón "Empty"
        If btn8.Text = "" And btnEmpty.Text = "8" Then
            btn8.Text = btnEmpty.Text
            btn8.BackColor = Color.MediumSeaGreen
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
        ElseIf btn8.Text = "" And btnEmpty.Text <> "8" Then
            btn8.Text = btnEmpty.Text
            btn8.BackColor = Color.Red
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
        ElseIf btn6.Text = "" And btnEmpty.Text = "6" Then
            btn6.Text = btnEmpty.Text
            btn6.BackColor = Color.MediumSeaGreen
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
        ElseIf btn6.Text = "" And btnEmpty.Text <> "6" Then
            btn6.Text = btnEmpty.Text
            btn6.BackColor = Color.Red
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        recorrerBotones()
        endgame3x3()
        'Que sucede cuando se cliquea el botón 8
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn8.Text
            btnEmpty.BackColor = Color.Red
            btn8.Text = ""
            btn8.BackColor = Color.White
        ElseIf btn7.Text = "" And btn8.Text = "7" Then
            btn7.Text = btn8.Text
            btn7.BackColor = Color.MediumSeaGreen
            btn8.Text = ""
            btn8.BackColor = Color.White
        ElseIf btn7.Text = "" And btn8.Text <> "7" Then
            btn7.Text = btn8.Text
            btn7.BackColor = Color.Red
            btn8.Text = ""
            btn8.BackColor = Color.White
        ElseIf btn5.Text = "" And btn8.Text = "5" Then
            btn5.Text = btn8.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn8.Text = ""
            btn8.BackColor = Color.White
        ElseIf btn5.Text = "" And btn8.Text <> "5" Then
            btn5.Text = btn8.Text
            btn5.BackColor = Color.Red
            btn8.Text = ""
            btn8.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        recorrerBotones()
        endgame3x3()
        'Que sucede cuando se cliquea el botón 7
        If btn8.Text = "" And btn7.Text = "8" Then
            btn8.Text = btn7.Text
            btn8.BackColor = Color.MediumSeaGreen
            btn7.Text = ""
            btn7.BackColor = Color.White
        ElseIf btn8.Text = "" And btn7.Text <> "8" Then
            btn8.Text = btn7.Text
            btn8.BackColor = Color.Red
            btn7.Text = ""
            btn7.BackColor = Color.White
        ElseIf btn4.Text = "" And btn7.Text = "4" Then
            btn4.Text = btn7.Text
            btn4.BackColor = Color.MediumSeaGreen
            btn7.Text = ""
            btn7.BackColor = Color.White
        ElseIf btn4.Text = "" And btn7.Text <> "4" Then
            btn4.Text = btn7.Text
            btn4.BackColor = Color.Red
            btn7.Text = ""
            btn7.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        recorrerBotones()
        endgame3x3()
        'Que sucede cuando se cliquea el botón 6
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn6.Text
            btnEmpty.BackColor = Color.Red
            btn6.Text = ""
            btn6.BackColor = Color.White
        ElseIf btn5.Text = "" And btn6.Text = "5" Then
            btn5.Text = btn6.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn6.Text = ""
            btn6.BackColor = Color.White
        ElseIf btn5.Text = "" And btn6.Text <> "5" Then
            btn5.Text = btn6.Text
            btn5.BackColor = Color.Red
            btn6.Text = ""
            btn6.BackColor = Color.White
        ElseIf btn3.Text = "" And btn6.Text = "3" Then
            btn3.Text = btn6.Text
            btn3.BackColor = Color.MediumSeaGreen
            btn6.Text = ""
            btn6.BackColor = Color.White
        ElseIf btn3.Text = "" And btn6.Text <> "3" Then
            btn3.Text = btn6.Text
            btn3.BackColor = Color.Red
            btn6.Text = ""
            btn6.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        recorrerBotones()
        endgame3x3()
        'Que sucede cuando se cliquea el botón 5
        If btn8.Text = "" And btn5.Text = "8" Then
            btn8.Text = btn5.Text
            btn8.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn8.Text = "" And btn5.Text <> "8" Then
            btn8.Text = btn5.Text
            btn8.BackColor = Color.Red
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn6.Text = "" And btn5.Text = "6" Then
            btn6.Text = btn5.Text
            btn6.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn6.Text = "" And btn5.Text <> "6" Then
            btn6.Text = btn5.Text
            btn6.BackColor = Color.Red
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn4.Text = "" And btn5.Text = "4" Then
            btn4.Text = btn5.Text
            btn4.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn4.Text = "" And btn5.Text <> "4" Then
            btn4.Text = btn5.Text
            btn4.BackColor = Color.Red
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn2.Text = "" And btn5.Text = "2" Then
            btn2.Text = btn5.Text
            btn2.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn2.Text = "" And btn5.Text <> "2" Then
            btn2.Text = btn5.Text
            btn2.BackColor = Color.Red
            btn5.Text = ""
            btn5.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        endgame3x3()
        recorrerBotones()
        'Que sucede cuando se cliquea el botón 4
        If btn7.Text = "" And btn4.Text = "7" Then
            btn7.Text = btn4.Text
            btn7.BackColor = Color.MediumSeaGreen
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn7.Text = "" And btn4.Text <> "7" Then
            btn7.Text = btn4.Text
            btn7.BackColor = Color.Red
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn5.Text = "" And btn4.Text = "5" Then
            btn5.Text = btn4.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn5.Text = "" And btn4.Text <> "5" Then
            btn5.Text = btn4.Text
            btn5.BackColor = Color.Red
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn1.Text = "" And btn4.Text = "1" Then
            btn1.Text = btn4.Text
            btn1.BackColor = Color.MediumSeaGreen
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn1.Text = "" And btn4.Text <> "1" Then
            btn1.Text = btn4.Text
            btn1.BackColor = Color.Red
            btn4.Text = ""
            btn4.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        endgame3x3()
        recorrerBotones()
        'Que sucede cuando se cliquea el botón 3
        If btn6.Text = "" And btn3.Text = "6" Then
            btn6.Text = btn3.Text
            btn6.BackColor = Color.MediumSeaGreen
            btn3.Text = ""
            btn3.BackColor = Color.White
        ElseIf btn6.Text = "" And btn3.Text <> "6" Then
            btn6.Text = btn3.Text
            btn6.BackColor = Color.Red
            btn3.Text = ""
            btn3.BackColor = Color.White
        ElseIf btn2.Text = "" And btn3.Text = "2" Then
            btn2.Text = btn3.Text
            btn2.BackColor = Color.MediumSeaGreen
            btn3.Text = ""
            btn3.BackColor = Color.White
        ElseIf btn2.Text = "" And btn3.Text <> "2" Then
            btn2.Text = btn3.Text
            btn2.BackColor = Color.Red
            btn3.Text = ""
            btn3.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        endgame3x3()
        recorrerBotones()
        'Que sucede cuando se cliquea el botón 2
        If btn1.Text = "" And btn2.Text = "1" Then
            btn1.Text = btn2.Text
            btn1.BackColor = Color.MediumSeaGreen
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn1.Text = "" And btn2.Text <> "1" Then
            btn1.Text = btn2.Text
            btn1.BackColor = Color.Red
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn3.Text = "" And btn2.Text = "3" Then
            btn3.Text = btn2.Text
            btn3.BackColor = Color.MediumSeaGreen
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn3.Text = "" And btn2.Text <> "3" Then
            btn3.Text = btn2.Text
            btn3.BackColor = Color.Red
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn5.Text = "" And btn2.Text = "5" Then
            btn5.Text = btn2.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn5.Text = "" And btn2.Text <> "5" Then
            btn5.Text = btn2.Text
            btn5.BackColor = Color.Red
            btn2.Text = ""
            btn2.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        endgame3x3()
        recorrerBotones()

        'Que sucede cuando se cliquea el botón 1
        If btn2.Text = "" And btn1.Text = "2" Then
            btn2.Text = btn1.Text
            btn2.BackColor = Color.MediumSeaGreen
            btn1.Text = ""
            btn1.BackColor = Color.White
        ElseIf btn2.Text = "" And btn1.Text <> "2" Then
            btn2.Text = btn1.Text
            btn2.BackColor = Color.Red
            btn1.Text = ""
            btn1.BackColor = Color.White
        ElseIf btn4.Text = "" And btn1.Text = "4" Then
            btn4.Text = btn1.Text
            btn4.BackColor = Color.MediumSeaGreen
            btn1.Text = ""
            btn1.BackColor = Color.White
        ElseIf btn4.Text = "" And btn1.Text <> "4" Then
            btn4.Text = btn1.Text
            btn4.BackColor = Color.Red
            btn1.Text = ""
            btn1.BackColor = Color.White
        End If
        endgame()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim numero As String
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btnEmpty}


        Me.Hide()
        For Each boton As Button In botones

            boton.Enabled = False
            If (boton.Name <> "btnEmpty") Then
                numero = boton.Name.Substring(3)
                boton.Text = numero
                boton.BackColor = Color.MediumSeaGreen
            End If
        Next
        JugarToolStripMenuItem.Enabled = True
        Form2.Show()

    End Sub
    Function endgame3x3()
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btnEmpty}

        'Validación para ganar
        Dim num As String
        Dim cont As Integer = 0

        For Each boton As Button In botones
            num = boton.Name.Substring(3)
            If (boton.Text = num) Then
                cont += 1
            End If
        Next


        If (cont = botones.Length - 1) Then
            MsgBox("Felicidades!, Ganaste O.O")
            End
        End If
    End Function
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        'Opción salir
        Dim salir
        salir = MsgBox("¿Desea Salir?", vbYesNo)
        If salir = 6 Then
            End
        End If
    End Sub

    Private Sub MezclarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MezclarToolStripMenuItem.Click
        Dim random As New Random
        Dim listarandom As New ArrayList()
        Dim randomNum, num As Integer
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btnEmpty}

        btnEmpty.Text = ""
        btnEmpty.BackColor = Color.White

        'Genero números Random

        For index = 1 To 8
            listarandom.Add(index)
        Next

        For j = 0 To botones.Length - 2
            randomNum = random.Next(0, listarandom.Count)
            num = listarandom.Item(randomNum)
            botones(j).Text = num.ToString()
            listarandom.Remove(num)
        Next

        recorrerBotones()

    End Sub
    Function recorrerBotones()
        Dim numero As String
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btnEmpty}

        For Each boton As Button In botones
            If (boton.Name <> "btnEmpty") Then
                numero = boton.Name.Substring(3)

                If boton.Text <> numero Then
                    boton.BackColor = Color.Red
                Else
                    boton.BackColor = Color.MediumSeaGreen

                End If
            End If
        Next
    End Function
    Private Sub JugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem.Click
        Dim random As New Random
        Dim listarandom As New ArrayList()
        Dim randomNum, num As Integer
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btnEmpty}

        btnEmpty.Text = ""
        btnEmpty.BackColor = Color.White


        'Genero números Random en los botones

        For index = 1 To 8
            listarandom.Add(index)
        Next

        For j = 0 To botones.Length - 2
            randomNum = random.Next(0, listarandom.Count)
            num = listarandom.Item(randomNum)
            botones(j).Text = num.ToString()
            listarandom.Remove(num)
        Next

        recorrerBotones()

        For Each boton As Button In botones
            boton.Enabled = True
        Next

        JugarToolStripMenuItem.Enabled = False
    End Sub
End Class
