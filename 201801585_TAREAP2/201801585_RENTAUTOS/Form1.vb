Public Class Form1

    Private Sub chbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbEfectivo.CheckedChanged
        If chbEfectivo.Checked = True Then
            txtEfectivo.Visible = True
            txtEfectivo.Focus()
        Else
            txtEfectivo.Clear()
            txtEfectivo.Visible = False
        End If
    End Sub

    Private Sub chbTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles chbTarjeta.CheckedChanged
        If chbTarjeta.Checked = True Then
            txtTarjeta.Visible = True
            txtTarjeta.Focus()
        Else
            txtTarjeta.Clear()
            txtTarjeta.Visible = False
        End If
    End Sub
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        If txtNombre.Text = "" Then
            MsgBox("Por favor ingrese el nombre del cliente",, "Error")
            txtNombre.Focus()
            Exit Sub
        End If
        If txtNit.Text = "" Or IsNumeric(txtNit.Text) = False Then
            MsgBox("Verifique el número de NIT por favor",, "Error")
            txtNit.Focus()
            Exit Sub
        End If
        If cmbMarca.Text = "" Then
            MsgBox("Seleccione la marca del carro por favor",, "Error")
            cmbMarca.Focus()
            Exit Sub
        End If
        If txtPlaca.Text = "" Then
            MsgBox("Digite la placa del carro por favor",, "Error")
            txtPlaca.Focus()
            Exit Sub
        End If
        If txtDias.Text = "" Or IsNumeric(txtDias.Text) = False Then
            MsgBox("Ingrese el número de Días que será rentado el vehiculo por favor",, "Error")
            txtDias.Focus()
            Exit Sub
        End If
        If chbEfectivo.Checked = False And chbTarjeta.Checked = False Then
            MsgBox("Seleccione al menos una forma de pago por favor",, "Error")
            Exit Sub
        End If
        If chbEfectivo.Checked And chbTarjeta.Checked = False And (IsNumeric(txtEfectivo.Text) = False Or txtEfectivo.Text = "") Then
            MsgBox("Ingrese el porcentaje del monto total a pagar con efectivo",, "Error")
            txtEfectivo.Focus()
            Exit Sub
        End If
        If chbTarjeta.Checked And chbEfectivo.Checked = False And (IsNumeric(txtTarjeta.Text) = False Or txtTarjeta.Text = "") Then
            MsgBox("Ingrese el porcentaje del monto total a pagar con tarjeta",, "Error")
            txtTarjeta.Focus()
            Exit Sub
        End If

        If chbEfectivo.Checked And chbTarjeta.Checked And (IsNumeric(txtEfectivo.Text) = False Or Val(txtEfectivo.Text) <= 0 Or Val(txtTarjeta.Text) <= 0) Then
            MsgBox("Ingrese un porcentaje mayor a cero para cada forma de pago",, "Error")
            Exit Sub
        ElseIf ((Val(txtEfectivo.Text) + Val(txtTarjeta.Text)) <> 100) Then
            MsgBox("Verifique que la suma de los porcentajes sea 100%",, "Error")
            Exit Sub
        End If

        If indice < 6 Then
            Vnombre(indice) = txtNombre.Text
            Vnit(indice) = txtNit.Text.ToString
            Vmarca(indice) = cmbMarca.Text
            Vplaca(indice) = txtPlaca.Text.ToString
            Vdias(indice) = Val(txtDias.Text)
            VprecioParcial(indice) = Fparcial(Vmarca(indice), Vdias(indice))
            Vdescuento(indice) = Fdescuento(VprecioParcial(indice))
            Vrecargo(indice) = Frecargo(VprecioParcial(indice))
            Vtotal(indice) = Ftotal(VprecioParcial(indice), Vdescuento(indice), Vrecargo(indice))
            Vefectivo(indice) = Fefectivo(Vtotal(indice), Val(txtEfectivo.Text) / 100)
            Vtarjeta(indice) = Ftarjeta(Vtotal(indice), Val(txtTarjeta.Text) / 100)
            Imprimir()
        Else
            MsgBox("Memoria llena, por favor limpiar vectores",, "Error")
        End If

    End Sub

    Private Sub btnLimpiarVectores_Click(sender As Object, e As EventArgs) Handles btnLimpiarVectores.Click
        If MsgBox("Desea limpiar los registros y memoria", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Lvectores()
        End If
    End Sub

    Private Sub btnLimpiarEntradas_Click(sender As Object, e As EventArgs) Handles btnLimpiarEntradas.Click
        If MsgBox("Desea limpiar las entradas", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Lentradas()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Desea salir", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class
