Public Class Form2
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim salir
        salir = MsgBox("¿Desea Salir?", vbYesNo)
        If salir = 6 Then
            End
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim numero As String
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btnEmpty}

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
        Form1.Show()
    End Sub

    Private Sub JugarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JugarToolStripMenuItem.Click
        Dim random As New Random
        Dim listarandom As New ArrayList()
        Dim randomNum, num As Integer
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btnEmpty}

        btnEmpty.Text = ""
        btnEmpty.BackColor = Color.White


        'Genero números Random en los botones

        For index = 1 To 15
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

    Private Sub MezclarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MezclarToolStripMenuItem.Click
        Dim random As New Random
        Dim listarandom As New ArrayList()
        Dim randomNum, num As Integer
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btnEmpty}

        btnEmpty.Text = ""
        btnEmpty.BackColor = Color.White


        'Genero números Random en los botones

        For index = 1 To 15
            listarandom.Add(index)
        Next

        For j = 0 To botones.Length - 2
            randomNum = random.Next(0, listarandom.Count)
            num = listarandom.Item(randomNum)
            botones(j).Text = num.ToString()
            listarandom.Remove(num)
        Next

        Dim numero As String

        recorrerBotones()




    End Sub
    Function recorrerBotones()
        Dim numero As String
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btnEmpty}

        For Each boton As Button In botones
            If (boton.Name <> "btnEmpty") Then
                numero = boton.Name.Substring(3)

                If boton.Text <> numero And boton.Text <> "" Then
                    boton.BackColor = Color.Red
                ElseIf boton.Text <> numero And boton.Text = "" Then
                    boton.BackColor = Color.White
                Else
                    boton.BackColor = Color.MediumSeaGreen

                End If
            End If
        Next
    End Function



    Function endgame4x4()
        Dim botones() As Button = {btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12, btn13, btn14, btn15, btnEmpty}

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
            MsgBox("Felicidades!, Ganaste O.O sos hacker?")
            End
        End If
    End Function


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'Que sucede cuando se cliquea el botón 1
        If btn2.Text = "" Then
            btn2.Text = btn1.Text
            btn1.Text = ""
            btn1.BackColor = Color.White
            btn2.BackColor = Color.Red
        ElseIf btn5.Text = "" Then
            btn5.Text = btn1.Text
            btn1.Text = ""
            btn1.BackColor = Color.White
            btn5.BackColor = Color.Red
        End If


        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        'Que sucede cuando se cliquea el botón 2
        If btn1.Text = "" Then
            btn1.Text = btn2.Text
            btn2.Text = ""
            btn2.BackColor = Color.White
            btn1.BackColor = Color.Red
        ElseIf btn3.Text = "" Then
            btn3.Text = btn2.Text
            btn2.Text = ""
            btn2.BackColor = Color.White
            btn3.BackColor = Color.Red
        ElseIf btn6.Text = "" Then
            btn6.Text = btn2.Text
            btn2.Text = ""
            btn2.BackColor = Color.White
            btn6.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'Que sucede cuando se cliquea el botón 3
        If btn7.Text = "" Then
            btn7.Text = btn3.Text
            btn3.Text = ""
            btn3.BackColor = Color.White
            btn7.BackColor = Color.Red
        ElseIf btn2.Text = "" Then
            btn2.Text = btn3.Text
            btn3.Text = ""
            btn3.BackColor = Color.White
            btn2.BackColor = Color.Red
        ElseIf btn4.Text = "" Then
            btn4.Text = btn3.Text
            btn3.Text = ""
            btn3.BackColor = Color.White
            btn4.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        'Que sucede cuando se cliquea el botón 4
        If btn3.Text = "" Then
            btn3.Text = btn4.Text
            btn4.Text = ""
            btn4.BackColor = Color.White
            btn3.BackColor = Color.Red
        ElseIf btn8.Text = "" Then
            btn8.Text = btn4.Text
            btn4.Text = ""
            btn4.BackColor = Color.White
            btn8.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        'Que sucede cuando se cliquea el botón 5
        If btn1.Text = "" Then
            btn1.Text = btn5.Text
            btn5.Text = ""
            btn5.BackColor = Color.White
            btn1.BackColor = Color.Red
        ElseIf btn6.Text = "" Then
            btn6.Text = btn5.Text
            btn5.Text = ""
            btn5.BackColor = Color.White
            btn6.BackColor = Color.Red
        ElseIf btn9.Text = "" Then
            btn9.Text = btn5.Text
            btn5.Text = ""
            btn5.BackColor = Color.White
            btn9.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        'Que sucede cuando se cliquea el botón 6
        If btn2.Text = "" Then
            btn2.Text = btn6.Text
            btn6.Text = ""
            btn6.BackColor = Color.White
            btn2.BackColor = Color.Red
        ElseIf btn5.Text = "" Then
            btn5.Text = btn6.Text
            btn6.Text = ""
            btn6.BackColor = Color.White
            btn5.BackColor = Color.Red
        ElseIf btn7.Text = "" Then
            btn7.Text = btn6.Text
            btn6.Text = ""
            btn6.BackColor = Color.White
            btn7.BackColor = Color.Red
        ElseIf btn10.Text = "" Then
            btn10.Text = btn6.Text
            btn6.Text = ""
            btn6.BackColor = Color.White
            btn10.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        'Que sucede cuando se cliquea el botón 7
        If btn8.Text = "" Then
            btn8.Text = btn7.Text
            btn7.Text = ""
            btn7.BackColor = Color.White
            btn8.BackColor = Color.Red
        ElseIf btn3.Text = "" Then
            btn3.Text = btn7.Text
            btn7.Text = ""
            btn7.BackColor = Color.White
            btn3.BackColor = Color.Red
        ElseIf btn6.Text = "" Then
            btn6.Text = btn7.Text
            btn7.Text = ""
            btn7.BackColor = Color.White
            btn6.BackColor = Color.Red
        ElseIf btn11.Text = "" Then
            btn11.Text = btn7.Text
            btn7.Text = ""
            btn7.BackColor = Color.White
            btn11.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        'Que sucede cuando se cliquea el botón 8
        If btn12.Text = "" Then
            btn12.Text = btn8.Text
            btn8.Text = ""
            btn8.BackColor = Color.White
            btn12.BackColor = Color.Red
        ElseIf btn4.Text = "" Then
            btn4.Text = btn8.Text
            btn8.Text = ""
            btn8.BackColor = Color.White
            btn4.BackColor = Color.Red
        ElseIf btn7.Text = "" Then
            btn7.Text = btn8.Text
            btn8.Text = ""
            btn8.BackColor = Color.White
            btn7.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        'Que sucede cuando se cliquea el botón 9
        If btn13.Text = "" Then
            btn13.Text = btn9.Text
            btn9.Text = ""
            btn9.BackColor = Color.White
            btn13.BackColor = Color.Red
        ElseIf btn5.Text = "" Then
            btn5.Text = btn9.Text
            btn9.Text = ""
            btn9.BackColor = Color.White
            btn5.BackColor = Color.Red
        ElseIf btn10.Text = "" Then
            btn10.Text = btn9.Text
            btn9.Text = ""
            btn9.BackColor = Color.White
            btn10.BackColor = Color.Red
        End If



        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click

        'Que sucede cuando se cliquea el botón 10
        If btn9.Text = "" Then
            btn9.Text = btn10.Text
            btn10.Text = ""
            btn10.BackColor = Color.White
            btn9.BackColor = Color.Red
        ElseIf btn14.Text = "" Then
            btn14.Text = btn10.Text
            btn10.Text = ""
            btn10.BackColor = Color.White
            btn14.BackColor = Color.Red
        ElseIf btn11.Text = "" Then
            btn11.Text = btn10.Text
            btn10.Text = ""
            btn10.BackColor = Color.White
            btn11.BackColor = Color.Red
        ElseIf btn6.Text = "" Then
            btn6.Text = btn10.Text
            btn10.Text = ""
            btn10.BackColor = Color.White
            btn6.BackColor = Color.Red
        End If


        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click

        'Que sucede cuando se cliquea el botón 11
        If btn7.Text = "" Then
            btn7.Text = btn11.Text
            btn11.Text = ""
            btn11.BackColor = Color.White
            btn7.BackColor = Color.Red
        ElseIf btn10.Text = "" Then
            btn10.Text = btn11.Text
            btn11.Text = ""
            btn11.BackColor = Color.White
            btn10.BackColor = Color.Red
        ElseIf btn12.Text = "" Then
            btn12.Text = btn11.Text
            btn11.Text = ""
            btn11.BackColor = Color.White
            btn12.BackColor = Color.Red
        ElseIf btn15.Text = "" Then
            btn15.Text = btn11.Text
            btn11.Text = ""
            btn11.BackColor = Color.White
            btn15.BackColor = Color.Red
        End If

        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click

        'Que sucede cuando se cliquea el botón 12
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn12.Text
            btn12.Text = ""
            btn12.BackColor = Color.White
            btnEmpty.BackColor = Color.Red
        ElseIf btn8.Text = "" Then
            btn8.Text = btn12.Text
            btn12.Text = ""
            btn12.BackColor = Color.White
            btn8.BackColor = Color.Red
        ElseIf btn11.Text = "" Then
            btn11.Text = btn12.Text
            btn12.Text = ""
            btn12.BackColor = Color.White
            btn11.BackColor = Color.Red
        End If


        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click


        'Que sucede cuando se cliquea el botón 13
        If btn14.Text = "" Then
            btn14.Text = btn13.Text
            btn13.Text = ""
            btn13.BackColor = Color.White
            btn14.BackColor = Color.Red
        ElseIf btn9.Text = "" Then
            btn9.Text = btn13.Text
            btn13.Text = ""
            btn13.BackColor = Color.White
            btn9.BackColor = Color.Red
        End If



        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click

        'Que sucede cuando se cliquea el botón 14
        If btn13.Text = "" Then
            btn13.Text = btn14.Text
            btn14.Text = ""
            btn14.BackColor = Color.White
            btn13.BackColor = Color.Red
        ElseIf btn10.Text = "" Then
            btn10.Text = btn14.Text
            btn14.Text = ""
            btn14.BackColor = Color.White
            btn10.BackColor = Color.Red
        ElseIf btn15.Text = "" Then
            btn15.Text = btn14.Text
            btn14.Text = ""
            btn14.BackColor = Color.White
            btn15.BackColor = Color.Red
        End If


        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click

        'Que sucede cuando se cliquea el botón 15
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn15.Text
            btn15.Text = ""
            btn15.BackColor = Color.White
            btnEmpty.BackColor = Color.Red
        ElseIf btn11.Text = "" Then
            btn11.Text = btn15.Text
            btn15.Text = ""
            btn15.BackColor = Color.White
            btn11.BackColor = Color.Red
        ElseIf btn14.Text = "" Then
            btn14.Text = btn15.Text
            btn15.Text = ""
            btn15.BackColor = Color.White
            btn14.BackColor = Color.Red
        End If


        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btnEmpty_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click
        'Que sucede cuando se cliquea el botón "Empty"
        If btn12.Text = "" Then
            btn12.Text = btnEmpty.Text
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
            btn12.BackColor = Color.Red
        ElseIf btn15.Text = "" Then
            btn15.Text = btnEmpty.Text
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
            btn15.BackColor = Color.Red
        End If
        recorrerBotones()
        endgame4x4()
    End Sub
End Class