Public Class Form1
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim random As New Random
        Dim listarandom(8) As Integer
        Dim random1 As Integer = random.Next(1, 8)

        For index = 0 To 7
            listarandom(index) = index + 1
        Next

        For j = random1 To 8
            btn1.Text = listarandom(random1)
            btn2.Text = listarandom(random1 + 1)
            btn3.Text = listarandom(random1 + 2)
            btn4.Text = listarandom(random1 + 3)
            btn5.Text = listarandom(random1 + 4)
            btn6.Text = listarandom(random1 + 5)
            btn7.Text = listarandom(random1 + 6)
            btn8.Text = listarandom(random1 + 7)
        Next




        'Else
        'finallyRandom = True
        'End If
        '
        'nd While
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim win As Boolean = False
        If (btn1.Text = 1 And btn2.Text = 2 And btn3.Text = 3 And btn4.Text = 4 And btn5.Text = 5 And btn6.Text = 6 And btn7.Text = 7 And btn8.Text = 8 And win = True) Then
            MsgBox("Ganaste bebeto")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click

    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btnEmpty.Text = "" Then
            btnEmpty.Text = btn8.Text
            btn8.Text = ""
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub
End Class
