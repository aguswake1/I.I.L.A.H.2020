Public Class frmPFT
    Dim listoide(50)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vacio As Boolean = True
        Dim convertir
        Dim fecha As String
        Dim fecha2 As Date
        Dim ganancia
        Dim saldo = compraVenta.txtSaldoPesos.Text
        Dim pregunta
        Dim valido As Boolean = True

        convertir = Replace(mtbMonto.Text, " ", "")
        pregunta = MsgBox("Al elegir que si, se simulará que ya transcurrió el plazo elegido, y al indicar que constituye el plazo fijo en el próximo formulario, se le depositará el dinero automáticamente", vbQuestion + vbYesNo + vbDefaultButton2, "Simulación")

        If (Integer.Parse(convertir) < 10000 Or Decimal.Parse(convertir) >= Decimal.Parse(saldo)) Then
            EPmontoInicial.SetError(mtbMonto, "Recuerde que el monto mínimo es de $10.000, si esto es correcto, puede que no tenga suficiente saldo para realizar la operación")
            valido = False
        End If

        If pregunta = vbYes And valido = True Then
            If cbPlazo.SelectedItem = "30 días (18%)" Then
                fecha2 = DateTime.Today.AddDays(30)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(31)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(32)
                End If

                ganancia = mtbMonto.Text * (18 / 100) * (30 / 365)


                dtpDate.Value = fecha2
                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today

                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()

            ElseIf cbPlazo.SelectedItem = "45 días (18%)" Then
                fecha2 = DateTime.Today.AddDays(45)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(46)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(47)
                End If

                ganancia = mtbMonto.Text * (18 / 100) * (45 / 365)


                dtpDate.Value = fecha2
                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today

                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()

            ElseIf cbPlazo.SelectedItem = "60 días (19%)" Then
                fecha2 = DateTime.Today.AddDays(60)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(61)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(62)
                End If

                ganancia = mtbMonto.Text * (19 / 100) * (60 / 365)


                dtpDate.Value = fecha2
                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today

                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()

            ElseIf cbPlazo.SelectedItem = "90 días (19%)" Then
                fecha2 = DateTime.Today.AddDays(90)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(91)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(92)
                End If

                ganancia = mtbMonto.Text * (19 / 100) * (90 / 365)


                dtpDate.Value = fecha2

                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today

                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()

            ElseIf cbPlazo.SelectedItem = "120 días (21,50%)" Then
                fecha2 = DateTime.Today.AddDays(120)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(121)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(122)
                End If

                ganancia = mtbMonto.Text * (21.5 / 100) * (120 / 365)


                dtpDate.Value = fecha2

                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today

                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()

            ElseIf cbPlazo.SelectedItem = "180 días (23,50%)" Then
                fecha2 = DateTime.Today.AddDays(180)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(181)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(182)
                End If

                ganancia = mtbMonto.Text * (23.5 / 100) * (180 / 365)


                dtpDate.Value = fecha2
                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today
                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()

            ElseIf cbPlazo.SelectedItem = "365 días (26,50%)" Then
                fecha2 = DateTime.Today.AddDays(365)
                fecha = (Format(fecha2, "ddd")).ToString

                If fecha = "dom." Then
                    fecha2 = DateTime.Today.AddDays(366)
                ElseIf fecha = "sáb." Then
                    fecha2 = DateTime.Today.AddDays(367)
                End If

                ganancia = mtbMonto.Text * (26.5 / 100) * (365 / 365)


                dtpDate.Value = fecha2
                frmConfirmarPFT.lblMontoFinal.Text = Int(ganancia) + Int(mtbMonto.Text)
                frmConfirmarPFT.lblMontoInicial.Text = convertir
                frmConfirmarPFT.lblFV.Text = fecha2
                frmConfirmarPFT.lblPlazo.Text = DateTime.Today

                'Cambio de formularios
                Me.Hide()
                frmConfirmarPFT.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        frmTipoPF.Show()
    End Sub
End Class