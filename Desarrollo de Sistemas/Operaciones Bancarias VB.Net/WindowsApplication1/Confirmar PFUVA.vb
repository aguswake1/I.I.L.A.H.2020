Imports System.IO

Public Class frmCONFIRMARUVA

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listoide(50) As String
        Dim index As Integer = 0
        Dim antiguoDinero, dolares, dineroFinal As Integer

        'Actualizo cuenta bancaria
        Dim leer As New StreamReader("cuentasBanco.txt")
        While leer.Peek <> -1
            Dim linea As String = leer.ReadLine()
            Dim tupla = linea.Split(",")
            If (compraVenta.Text = tupla(0)) Then
                If "ARS" = tupla(1) Then
                    antiguoDinero = tupla(2)
                ElseIf "U$D" = tupla(1) Then
                    dolares = tupla(2)
                End If
            Else
                listoide(index) = linea
                index += 1
            End If
        End While
        leer.Close()

        Using File As New IO.StreamWriter("cuentasBanco.txt")
            File.Flush()
        End Using

        Dim actualizarCuenta As New StreamWriter("cuentasBanco.txt", True)

        If listoide(0) <> Nothing Then
            For i As Integer = 0 To listoide.Length - 1
                If listoide(i) <> Nothing Then
                    actualizarCuenta.WriteLine(listoide(i))
                End If
            Next
        End If

        dineroFinal = antiguoDinero - lblMontoInicial.Text + lblganancia.Text

        actualizarCuenta.WriteLine(compraVenta.Text + ",ARS," + dineroFinal.ToString)
        actualizarCuenta.WriteLine(compraVenta.Text + ",U$D," + dolares.ToString)
        actualizarCuenta.Close()

        Me.Hide()
        frmPFT.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmPFUVA.cbPlazo.SelectedItem = ""
        frmPFUVA.mtbMonto.Text = ""
        Me.Hide()
        frmPFUVA.Show()
    End Sub
End Class