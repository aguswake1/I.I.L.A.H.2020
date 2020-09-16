Public Class Form1
    Private Sub Button9_Click(sender As Object, e As EventArgs)
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

        '      While (listarandom.Count <> 0)
        '     randomNum = random.Next(0, listarandom.Count)
        '    num = listarandom.Item(randomNum)
        '   botones(randomNum).Text = num.ToString()
        '  botones(randomNum).BackColor = Color.MediumSeaGreen
        ' listarandom.Remove(num)

        ' End While

        '  For k = 0 To botones.Length - 1
        'If (botones(k).Text = "") Then
        'botones(k).BackColor = Color.White
        ' End If
        'Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim win As Boolean = False

        'Cargo botones de color verde (correcto)
        If (btn1.Text = 1 And btn2.Text = 2 And btn3.Text = 3 And btn4.Text = 4 And btn5.Text = 5 And btn6.Text = 6 And btn7.Text = 7 And btn8.Text = 8) Then
            btn1.BackColor = Color.MediumSeaGreen
            btn2.BackColor = Color.MediumSeaGreen
            btn3.BackColor = Color.MediumSeaGreen
            btn4.BackColor = Color.MediumSeaGreen
            btn5.BackColor = Color.MediumSeaGreen
            btn6.BackColor = Color.MediumSeaGreen
            btn7.BackColor = Color.MediumSeaGreen
            btn8.BackColor = Color.MediumSeaGreen
        End If

        'Validación para ganar
        If (btn1.Text = 1 And btn2.Text = 2 And btn3.Text = 3 And btn4.Text = 4 And btn5.Text = 5 And btn6.Text = 6 And btn7.Text = 7 And btn8.Text = 8 And win = True) Then
            MsgBox("Ganaste bebeto")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click
        'Que sucede cuando se cliquea el botón "Empty"
        If btn8.Text = "" Then
            btn8.Text = btnEmpty.Text
            btn8.BackColor = Color.MediumSeaGreen
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
        ElseIf btn6.Text = "" Then
            btn6.Text = btnEmpty.Text
            btn6.BackColor = Color.MediumSeaGreen
            btnEmpty.Text = ""
            btnEmpty.BackColor = Color.White
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn8.Text
            btnEmpty.BackColor = Color.MediumSeaGreen
            btn8.Text = ""
            btn8.BackColor = Color.White
        ElseIf btn7.Text = "" Then
            btn7.Text = btn8.Text
            btn7.BackColor = Color.MediumSeaGreen
            btn8.Text = ""
            btn8.BackColor = Color.White
        ElseIf btn5.Text = "" Then
            btn5.Text = btn8.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn8.Text = ""
            btn8.BackColor = Color.White
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If btn8.Text = "" Then
            btn8.Text = btn7.Text
            btn8.BackColor = Color.MediumSeaGreen
            btn7.Text = ""
            btn7.BackColor = Color.White
        ElseIf btn4.Text = "" Then
            btn4.Text = btn7.Text
            btn4.BackColor = Color.MediumSeaGreen
            btn7.Text = ""
            btn7.BackColor = Color.White
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn6.Text
            btnEmpty.BackColor = Color.MediumSeaGreen
            btn6.Text = ""
            btn6.BackColor = Color.White
        ElseIf btn5.Text = "" Then
            btn5.Text = btn6.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn6.Text = ""
            btn6.BackColor = Color.White
        ElseIf btn3.Text = "" Then
            btn3.Text = btn6.Text
            btn3.BackColor = Color.MediumSeaGreen
            btn6.Text = ""
            btn6.BackColor = Color.White
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If btn8.Text = "" Then
            btn8.Text = btn5.Text
            btn8.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn6.Text = "" Then
            btn6.Text = btn5.Text
            btn6.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn4.Text = "" Then
            btn4.Text = btn5.Text
            btn4.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        ElseIf btn2.Text = "" Then
            btn2.Text = btn5.Text
            btn2.BackColor = Color.MediumSeaGreen
            btn5.Text = ""
            btn5.BackColor = Color.White
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If btn7.Text = "" Then
            btn7.Text = btn4.Text
            btn7.BackColor = Color.MediumSeaGreen
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn5.Text = "" Then
            btn5.Text = btn4.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn4.Text = ""
            btn4.BackColor = Color.White
        ElseIf btn1.Text = "" Then
            btn1.Text = btn4.Text
            btn1.BackColor = Color.MediumSeaGreen
            btn4.Text = ""
            btn4.BackColor = Color.White
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn6.Text = "" Then
            btn6.Text = btn3.Text
            btn6.BackColor = Color.MediumSeaGreen
            btn3.Text = ""
            btn3.BackColor = Color.White
        ElseIf btn2.Text = "" Then
            btn2.Text = btn3.Text
            btn2.BackColor = Color.MediumSeaGreen
            btn3.Text = ""
            btn3.BackColor = Color.White
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn1.Text = "" Then
            btn1.Text = btn2.Text
            btn1.BackColor = Color.MediumSeaGreen
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn3.Text = "" Then
            btn3.Text = btn2.Text
            btn3.BackColor = Color.MediumSeaGreen
            btn2.Text = ""
            btn2.BackColor = Color.White
        ElseIf btn5.Text = "" Then
            btn5.Text = btn2.Text
            btn5.BackColor = Color.MediumSeaGreen
            btn2.Text = ""
            btn2.BackColor = Color.White
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn2.Text = "" Then
            btn2.Text = btn1.Text
            btn2.BackColor = Color.MediumSeaGreen
            btn1.Text = ""
            btn1.BackColor = Color.White
        ElseIf btn4.Text = "" Then
            btn4.Text = btn1.Text
            btn4.BackColor = Color.MediumSeaGreen
            btn1.Text = ""
            btn1.BackColor = Color.White
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
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

        '      While (listarandom.Count <> 0)
        '     randomNum = random.Next(0, listarandom.Count)
        '    num = listarandom.Item(randomNum)
        '   botones(randomNum).Text = num.ToString()
        '  botones(randomNum).BackColor = Color.MediumSeaGreen
        ' listarandom.Remove(num)

        ' End While

        '  For k = 0 To botones.Length - 1
        'If (botones(k).Text = "") Then
        'botones(k).BackColor = Color.White
        ' End If
        'Next
    End Sub
End Class
