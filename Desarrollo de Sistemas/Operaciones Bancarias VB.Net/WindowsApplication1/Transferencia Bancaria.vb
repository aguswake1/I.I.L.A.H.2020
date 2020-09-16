Imports System.IO

Public Class frmTB
    Dim auxiliarValidación As Integer = 0
    Private Sub frmTB_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Dim leer As New StreamReader("cuentasBanco.txt")

        'Leer archivo datos.txt buscando a partir del DNI, los valores de la cuenta
        While leer.Peek <> -1
            Dim linea As String = leer.ReadLine()
            Dim tupla = linea.Split(",")
            If (compraVenta.Text = tupla(0)) Then
                If (tupla(1) = "U$D") Then
                    txtSaldoDolares.Text = tupla(2)
                ElseIf (tupla(1) = "ARS") Then
                    txtSaldoPesos.Text = tupla(2)
                End If
            End If
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtDNIajeno.ReadOnly = True
        txtTransferencia.ReadOnly = True
        cbCuentas.Enabled = True
        txtDNIajeno.Text = ""
        txtTransferencia.Text = ""
        Button1.Enabled = False
        Me.epDNI.SetError(sender, "")
        Me.epMonto.SetError(sender, "")
        cbCuentas.SelectedItem = ""
        Me.Hide()
        frmElegir.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listoide(50) As String
        Dim index As Integer = 0
        Dim tipoCuenta = cbCuentas.SelectedItem
        Dim auxSuma, auxResta As Decimal

        Try
            'Muestro las distintas descripciones correspondientes a la operación que se haya realizado
            If (cbCuentas.SelectedItem = "U$D") Then
                frmComprTransf.lblca.Text = "CA U$D"
                'Actualizo cuenta bancaria
                Dim leer As New StreamReader("cuentasBanco.txt")
                While leer.Peek <> -1
                    Dim linea As String = leer.ReadLine()
                    Dim tupla = linea.Split(",")
                    If (txtDNIajeno.Text = tupla(0) And "U$D" = tupla(1)) Then
                        auxSuma = Decimal.Parse(tupla(2)) + Decimal.Parse(txtTransferencia.Text)
                    ElseIf (compraVenta.Text = tupla(0) And "U$D" = tupla(1)) Then
                        auxResta = Decimal.Parse(tupla(2)) - Decimal.Parse(txtTransferencia.Text)
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
                actualizarCuenta.WriteLine(txtDNIajeno.Text + ",U$D," + auxSuma.ToString())
                actualizarCuenta.WriteLine(compraVenta.Text + ",U$D," + auxResta.ToString())
                actualizarCuenta.Close()

            ElseIf (cbCuentas.SelectedItem = "ARS") Then
                frmComprTransf.lblca.Text = "CA ARS"
                'Actualizo cuenta bancaria
                Dim leer As New StreamReader("cuentasBanco.txt")
                While leer.Peek <> -1
                    Dim linea As String = leer.ReadLine()
                    Dim tupla = linea.Split(",")
                    If (txtDNIajeno.Text = tupla(0) And "ARS" = tupla(1)) Then
                        auxSuma = Decimal.Parse(tupla(2)) + Decimal.Parse(txtTransferencia.Text)
                    ElseIf (compraVenta.Text = tupla(0) And "ARS" = tupla(1)) Then
                        auxResta = Decimal.Parse(tupla(2)) - Decimal.Parse(txtTransferencia.Text)
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
                actualizarCuenta.WriteLine(txtDNIajeno.Text + ",ARS," + auxSuma.ToString())
                actualizarCuenta.WriteLine(compraVenta.Text + ",ARS," + auxResta.ToString())
                actualizarCuenta.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim numeroAleatorio As New Random(CInt(Date.Now.Ticks And Integer.MaxValue))
        frmComprTransf.lblRandom.Text = System.Convert.ToString(numeroAleatorio.Next)

        frmComprTransf.lblImporte.Text = txtTransferencia.Text
        frmComprTransf.lblfechahora.Text = String.Format("{0:G}", DateTime.Now)
        frmComprTransf.lblmot.Text = cbmot.SelectedItem

        'Reseteo la operación
        txtDNIajeno.ReadOnly = True
        txtTransferencia.ReadOnly = True
        cbCuentas.Enabled = True
        txtDNIajeno.Text = ""
        txtTransferencia.Text = ""
        Button1.Enabled = False
        Me.epDNI.SetError(sender, "")
        Me.epMonto.SetError(sender, "")
        cbCuentas.SelectedItem = ""
        cbmot.SelectedItem = ""

        'Cambio de formularios
        Me.Hide()
        frmComprTransf.Show()
    End Sub
    Private Sub txtDNIajeno_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDNIajeno.Validating
        Try
            If (DirectCast(sender, TextBox).Text.Length <> 8 Or IsNumeric(txtDNIajeno.Text) = False Or Val(txtDNIajeno.Text) - Int(Val(txtDNIajeno.Text)) <> 0) Then
                Me.epDNI.SetError(sender, "Dato incorrecto, revise lo que ingresó")
            Else
                Me.epDNI.SetError(sender, "")
                txtDNIajeno.ReadOnly = True
                auxiliarValidación = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtTransferencia_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTransferencia.Validating
        Try
            If cbCuentas.SelectedItem = "U$D" Then
                If (IsNumeric(txtTransferencia.Text) = False Or txtTransferencia.Text.Length > 4 Or Int(txtTransferencia.Text) > Int(txtSaldoDolares.Text)) Then
                    Me.epMonto.SetError(sender, "Dato incorrecto, revise lo que ingresó")
                Else
                    Me.epMonto.SetError(sender, "")
                    txtTransferencia.ReadOnly = True
                    auxiliarValidación += 1
                End If
            ElseIf cbCuentas.SelectedItem = "ARS" Then
                If (IsNumeric(txtTransferencia.Text) = False Or Val(txtTransferencia.Text) - Int(Val(txtTransferencia.Text)) <> 0 Or DirectCast(sender, TextBox).Text.Length > 5 Or txtTransferencia.Text > txtSaldoPesos.Text) Then
                    Me.epMonto.SetError(sender, "Dato incorrecto, revise lo que ingresó")
                ElseIf (DirectCast(sender, TextBox).Text.Length <= 5) Then
                    Me.epMonto.SetError(sender, "")
                    txtTransferencia.ReadOnly = True
                    auxiliarValidación += 1
                End If
            End If
            If (txtTransferencia.ReadOnly = True And txtDNIajeno.ReadOnly = True And auxiliarValidación = 2) Then
                Button1.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbCuentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCuentas.SelectedIndexChanged
        If cbCuentas.SelectedItem = "U$D" Or cbCuentas.SelectedItem = "ARS" Then
            txtDNIajeno.ReadOnly = False
            txtTransferencia.ReadOnly = False
            cbCuentas.Enabled = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        txtDNIajeno.ReadOnly = True
        txtTransferencia.ReadOnly = True
        cbCuentas.Enabled = True
        txtDNIajeno.Text = ""
        txtTransferencia.Text = ""
        Button1.Enabled = False
        Me.epDNI.SetError(sender, "")
        Me.epMonto.SetError(sender, "")
        cbCuentas.SelectedItem = ""
    End Sub
End Class