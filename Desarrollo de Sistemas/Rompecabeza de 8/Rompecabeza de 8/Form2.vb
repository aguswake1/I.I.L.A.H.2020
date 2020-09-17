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

                If boton.Text <> numero Then
                    boton.BackColor = Color.Red
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
            MsgBox("Felicidades!, Ganaste O.O")
            End
        End If
    End Function


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        recorrerBotones()
        endgame4x4()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        recorrerBotones()
        endgame4x4()
    End Sub
End Class