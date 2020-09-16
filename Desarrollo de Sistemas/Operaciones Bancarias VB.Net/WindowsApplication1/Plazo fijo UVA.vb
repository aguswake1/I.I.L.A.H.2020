Public Class frmPFUVA
    Dim listoide(50)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        frmTipoPF.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vacio As Boolean = True
        Dim convertir
        Dim fecha As String
        Dim fecha2 As Date
        Dim ganancia
        Dim saldo = compraVenta.txtSaldoPesos.Text
        Dim pregunta
        Dim valido As Boolean = True
        Dim unoPorciento As Decimal

        convertir = Replace(mtbMonto.Text, " ", "")
        pregunta = MsgBox("Al elegir que si, se simulará que ya transcurrió el plazo elegido, y al indicar que constituye el plazo fijo en el próximo formulario, se le depositará el dinero automáticamente", vbQuestion + vbYesNo + vbDefaultButton2, "Simulación")

        If (Integer.Parse(convertir) < 10000 Or Decimal.Parse(convertir) >= Decimal.Parse(saldo)) Then
            EP.SetError(mtbMonto, "Recuerde que el monto mínimo es de $10.000, si esto es correcto, puede que no tenga suficiente saldo para realizar la operación")
            valido = False
        End If

        If mtbUVAficticio.Text = "" Then
            valido = False
            MsgBox("Ingrese valor de UVA", vbOKOnly, "Dato incompleto")
        End If

        If cbPlazo.SelectedItem = "" Then
            valido = False
        End If

        If pregunta = vbYes And valido = True Then
            If cbPlazo.SelectedItem = "90 días" Then
                fecha2 = DateTime.Today.AddDays(90)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(91)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(92)
                End If

                unoPorciento = (convertir * 1) / 100
                ganancia = ((convertir / 54.9) * Decimal.Parse(mtbUVAficticio.Text)) + unoPorciento

                dtpDate.Value = fecha2

                frmCONFIRMARUVA.lblMontoInicial.Text = convertir / 54.9
                frmCONFIRMARUVA.lblFV.Text = fecha2
                frmCONFIRMARUVA.lblPlazo.Text = DateTime.Today
                frmCONFIRMARUVA.lblganancia.Text = ganancia

                'Cambio de formularios
                Me.Hide()
                frmCONFIRMARUVA.Show()

            ElseIf cbPlazo.SelectedItem = "120 días" Then
                fecha2 = DateTime.Today.AddDays(120)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(121)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(122)
                End If

                unoPorciento = (convertir * 1) / 100
                ganancia = (convertir / 54.9) * Decimal.Parse(mtbUVAficticio.Text) + unoPorciento


                dtpDate.Value = fecha2


                frmCONFIRMARUVA.lblMontoInicial.Text = convertir
                frmCONFIRMARUVA.lblFV.Text = fecha2
                frmCONFIRMARUVA.lblPlazo.Text = DateTime.Today
                frmCONFIRMARUVA.lblganancia.Text = ganancia

                'Cambio de formularios
                Me.Hide()
                frmCONFIRMARUVA.Show()

            ElseIf cbPlazo.SelectedItem = "180 días" Then
                fecha2 = DateTime.Today.AddDays(180)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(181)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(182)
                End If

                unoPorciento = (convertir * 1) / 100
                ganancia = (convertir / 54.9) * Decimal.Parse(mtbUVAficticio.Text) + unoPorciento


                dtpDate.Value = fecha2

                frmCONFIRMARUVA.lblMontoInicial.Text = convertir / 54.9
                frmCONFIRMARUVA.lblFV.Text = fecha2
                frmCONFIRMARUVA.lblPlazo.Text = DateTime.Today
                frmCONFIRMARUVA.lblganancia.Text = ganancia

                'Cambio de formularios
                Me.Hide()
                frmCONFIRMARUVA.Show()

            ElseIf cbPlazo.SelectedItem = "365 días" Then
                fecha2 = DateTime.Today.AddDays(365)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(366)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(367)
                End If

                unoPorciento = (convertir * 1) / 100
                ganancia = (convertir / 54.9) * Decimal.Parse(mtbUVAficticio.Text) + unoPorciento


                dtpDate.Value = fecha2

                frmCONFIRMARUVA.lblMontoInicial.Text = convertir / 54.9
                frmCONFIRMARUVA.lblFV.Text = fecha2
                frmCONFIRMARUVA.lblPlazo.Text = DateTime.Today
                frmCONFIRMARUVA.lblganancia.Text = ganancia

                'Cambio de formularios
                Me.Hide()
                frmCONFIRMARUVA.Show()
            End If
        End If
    End Sub

End Class