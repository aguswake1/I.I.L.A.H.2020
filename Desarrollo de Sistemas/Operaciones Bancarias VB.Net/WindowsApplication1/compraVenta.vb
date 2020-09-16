Imports System.IO
Public Class compraVenta
    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg, msg2, msgEmpty, style, title
        Dim precioDolarConImpuesto = txtValorVenta.Text + (txtValorVenta.Text * 30) / 100

        'Personalización del messagebox
        msg = "Por favor, seleccione la operación que desea realizar."
        msg2 = "No puede seleccionar las dos operaciones al mismo tiempo."
        msgEmpty = "Ingrese la cantidad de dólares que desea comprar o vender."
        style = vbOKOnly
        title = "Error"

        If txtOperacion.Text = "" Then
            MsgBox(msgEmpty, style, title)
        ElseIf (CheckBoxCompra.Checked = False And CheckBoxVenta.Checked = False And IsNumeric(txtOperacion.Text) = True) Then
            MsgBox(msg, style, title)
        ElseIf (CheckBoxCompra.Checked = True And CheckBoxVenta.Checked = True And IsNumeric(txtOperacion.Text) = True) Then
            MsgBox(msg2, style, title)
            CheckBoxCompra.Checked = False
            CheckBoxVenta.Checked = False
        ElseIf IsNumeric(txtOperacion.Text) = False Then
            MsgBox("No puede ingresar letras.", style, title)
            txtOperacion.Text = ""
        ElseIf (CheckBoxCompra.Checked = True And CheckBoxVenta.Checked = False And IsNumeric(txtOperacion.Text) = True And Decimal.Parse(txtSaldoPesos.Text) >= Decimal.Parse(txtOperacion.Text) * Decimal.Parse(precioDolarConImpuesto)) Then
            TxtImporte.Text = Decimal.Parse(txtOperacion.Text) * Decimal.Parse(txtValorVenta.Text)
            txtImpuesto.Text = "30%"
            txtTotal.Text = Decimal.Parse(txtOperacion.Text) * Decimal.Parse(precioDolarConImpuesto)
            Button1.Enabled = False
            Button2.Enabled = True
            lblReiniciar.Visible = True
            Label9.Visible = True
            CheckBoxVenta.Enabled = False
            txtOperacion.Enabled = False
        ElseIf (CheckBoxCompra.Checked = False And CheckBoxVenta.Checked = True And txtOperacion.Text <> "" And IsNumeric(txtOperacion.Text) = True And Decimal.Parse(txtSaldoDolares.Text) >= Decimal.Parse(txtOperacion.Text)) Then
            TxtImporte.Text = Decimal.Parse(txtOperacion.Text) * Decimal.Parse(txtValorCompra.Text)
            txtImpuesto.Text = "No hay impuestos agregados."
            txtTotal.Text = TxtImporte.Text
            Button1.Enabled = False
            Button2.Enabled = True
            lblReiniciar.Visible = True
            Label9.Visible = True
            CheckBoxCompra.Enabled = False
            txtOperacion.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listoide(50) As String
        Dim index As Integer = 0

        'Muestro el DNI en el label correspondiente
        comprobante.Label6.Text = Me.Text

        'Muestro las distintas descripciones correspondientes a la operación que se haya realizado
        If (txtImpuesto.Text = "30%") Then
            comprobante.Label11.Text = "Descripción de la operación:" & vbCrLf &
                                        "Usted está comprando " + txtOperacion.Text + " dólares, por lo que se le cobrará" & vbCrLf &
                                        "(sumado con los impuestos) " + txtTotal.Text + " pesos."

            comprobante.Label9.Text = Decimal.Parse(txtSaldoPesos.Text) - Decimal.Parse(txtTotal.Text)
            comprobante.Label10.Text = Decimal.Parse(txtSaldoDolares.Text) + Decimal.Parse(txtOperacion.Text)

            'Actualizo cuenta bancaria
            Dim leer As New StreamReader("cuentasBanco.txt")
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                Dim tupla = linea.Split(",")
                If (Me.Text = tupla(0)) Then
                    If "ARS" = tupla(1) Then
                        tupla(2) = comprobante.Label9.Text
                    ElseIf "U$D" = tupla(1) Then
                        tupla(2) = comprobante.Label10.Text
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
            actualizarCuenta.WriteLine(Me.Text + ",ARS," + comprobante.Label9.Text)
            actualizarCuenta.WriteLine(Me.Text + ",U$D," + comprobante.Label10.Text)
            actualizarCuenta.Close()

        ElseIf (txtImpuesto.Text = "No hay impuestos agregados.") Then
            comprobante.Label11.Text = "Descripción de la operación:" & vbCrLf &
                                        "Usted está vendiendo " + txtOperacion.Text + " dólares, por lo que se le otorgarán" & vbCrLf &
                                        txtTotal.Text + " pesos."
            comprobante.Label9.Text = Decimal.Parse(txtSaldoPesos.Text) + Decimal.Parse(txtTotal.Text)
            comprobante.Label10.Text = Decimal.Parse(txtSaldoDolares.Text) - Decimal.Parse(txtOperacion.Text)

            'Actualizo cuenta bancaria
            Dim leer As New StreamReader("cuentasBanco.txt")
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                Dim tupla = linea.Split(",")
                If (Me.Text = tupla(0)) Then
                    If "ARS" = tupla(1) Then
                        tupla(2) = comprobante.Label9.Text
                    ElseIf "U$D" = tupla(1) Then
                        tupla(2) = comprobante.Label10.Text
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
            actualizarCuenta.WriteLine(Me.Text + ",ARS," + comprobante.Label9.Text)
            actualizarCuenta.WriteLine(Me.Text + ",U$D," + comprobante.Label10.Text)
            actualizarCuenta.Close()
        End If

        'Reseteo la operación
        CheckBoxCompra.Checked = False
        CheckBoxVenta.Checked = False
        Button1.Enabled = True
        Button2.Enabled = False
        TxtImporte.Text = ""
        txtImpuesto.Text = ""
        txtOperacion.Text = ""
        txtTotal.Text = ""
        lblReiniciar.Visible = False
        Label9.Visible = False
        txtOperacion.Enabled = True
        CheckBoxCompra.Enabled = True
        CheckBoxVenta.Enabled = True

        'Cambio de formularios
        Me.Hide()
        comprobante.Show()
    End Sub

    Private Sub lblReiniciar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblReiniciar.LinkClicked
        Button1.Enabled = True
        Button2.Enabled = False
        TxtImporte.Text = ""
        txtImpuesto.Text = ""
        txtOperacion.Text = ""
        txtTotal.Text = ""
        CheckBoxCompra.Checked = False
        CheckBoxVenta.Checked = False
        CheckBoxCompra.Enabled = True
        CheckBoxVenta.Enabled = True
        Label9.Visible = False
        lblReiniciar.Visible = False
        txtOperacion.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = True
        Button2.Enabled = False
        TxtImporte.Text = ""
        txtImpuesto.Text = ""
        txtOperacion.Text = ""
        txtTotal.Text = ""
        CheckBoxCompra.Checked = False
        CheckBoxVenta.Checked = False
        CheckBoxCompra.Enabled = True
        CheckBoxVenta.Enabled = True
        Label9.Visible = False
        lblReiniciar.Visible = False
        txtOperacion.Enabled = True
        Me.Hide()
        frmElegir.Show()
    End Sub
    Private Sub txtOperacion_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOperacion.Validating
        Dim precioDolarConImpuesto = txtValorVenta.Text + (txtValorVenta.Text * 30) / 100

        If (CheckBoxCompra.Checked = False And CheckBoxVenta.Checked = True And txtOperacion.Text <> "" And IsNumeric(txtOperacion.Text)) = True Then
            If (Decimal.Parse(txtSaldoDolares.Text) >= Decimal.Parse(txtOperacion.Text)) Then
                Me.EP.SetError(sender, "")
            Else
                Me.EP.SetError(sender, "No cuenta con el dinero suficiente para realizar la operación.")
            End If
        ElseIf (CheckBoxCompra.Checked = True And CheckBoxVenta.Checked = False And IsNumeric(txtOperacion.Text) = True) Then
            If Decimal.Parse(txtSaldoPesos.Text) >= Decimal.Parse(txtOperacion.Text) * Decimal.Parse(precioDolarConImpuesto) Then
                Me.EP.SetError(sender, "")
            Else
                Me.EP.SetError(sender, "No cuenta con el dinero suficiente para realizar la operación.")
            End If
        End If
    End Sub
End Class