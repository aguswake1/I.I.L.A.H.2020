Public Class frmElegir
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Me.Hide()
            compraVenta.Show()
        ElseIf RadioButton2.Checked = True Then
            Me.Hide()
            frmTipoPF.Show()
        ElseIf RadioButton4.Checked = True Then
            Me.Hide()
            frmTB.Show()
        End If
    End Sub
End Class