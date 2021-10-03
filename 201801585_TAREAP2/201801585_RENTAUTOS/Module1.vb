Module Module1
    Public Const Phonda As Double = 250
    Public Const PmercedesBenz As Double = 450
    Public Const Ptoyota As Double = 325
    Public Const Pmazda As Double = 300

    Public Vnombre(5) As String
    Public Vnit(5) As String
    Public Vmarca(5) As String
    Public Vplaca(5) As String
    Public Vdias(5) As Double
    Public VprecioParcial(5) As Double
    Public Vdescuento(5) As Double
    Public Vrecargo(5) As Double
    Public Vefectivo(5) As Double
    Public Vtarjeta(5) As Double
    Public Vtotal(5) As Double
    Public indice As Byte = 0

    Public parcial As Double
    Function Fparcial(ByVal marca As String, ByVal dias As Double) As Double
        Select Case marca
            Case "Honda"
                Fparcial = dias * Phonda
            Case "MercedesBenz"
                Fparcial = dias * PmercedesBenz
            Case "Toyota"
                Fparcial = dias * Ptoyota
            Case "Mazda"
                Fparcial = dias * Pmazda
            Case Else
                Fparcial = 0
        End Select
        Return Fparcial
    End Function
    Function Fdescuento(ByVal parcial As Double) As Double
        If Form1.chbEfectivo.Checked And Form1.chbTarjeta.Checked = False Then
            Fdescuento = parcial * 0.05 * -1
        Else
            Fdescuento = 0
        End If
        Return Fdescuento
    End Function

    Function Frecargo(ByVal parcial As Double) As Double
        If Form1.chbEfectivo.Checked = False And Form1.chbTarjeta.Checked Then
            Frecargo = parcial * 0.025
        Else
            Frecargo = 0
        End If
        Return Frecargo
    End Function

    Function Ftotal(ByVal parcial As Double, ByVal desc As Double, ByVal recargo As Double) As Double
        Ftotal = parcial + recargo + desc
        Return Ftotal
    End Function

    Function Fefectivo(ByVal total As Double, ByVal porcentaje As Double) As Double
        If Form1.chbEfectivo.Checked Then
            Fefectivo = total * porcentaje
        Else
            Fefectivo = 0
        End If

        Return Fefectivo
    End Function

    Function Ftarjeta(ByVal total As Double, ByVal porcentaje As Double) As Double
        If Form1.chbTarjeta.Checked Then
            Ftarjeta = total * porcentaje
        Else
            Ftarjeta = 0
        End If

        Return Ftarjeta
    End Function

    Sub Imprimir()
        Form1.ltbNombre.Items.Add(Vnombre(indice))
        Form1.ltbNit.Items.Add(Vnit(indice))
        Form1.ltbMarca.Items.Add(Vmarca(indice))
        Form1.ltbPlaca.Items.Add(Vmarca(indice))
        Form1.ltbDias.Items.Add(Vdias(indice))
        Form1.ltbPrecioParcial.Items.Add(VprecioParcial(indice))
        Form1.ltbDescuento.Items.Add(Vdescuento(indice))
        Form1.ltbRecargo.Items.Add(Vrecargo(indice))
        Form1.ltbEfectivo.Items.Add(Vefectivo(indice))
        Form1.ltbTarjeta.Items.Add(Vtarjeta(indice))
        Form1.ltbTotal.Items.Add(Vtotal(indice))
        indice = indice + 1
    End Sub

    Sub Lvectores()
        ReDim Vnombre(5), Vnit(5), Vmarca(5), Vplaca(5), Vdias(5), VprecioParcial(5), Vdescuento(5), Vrecargo(5), Vefectivo(5), Vtarjeta(5), Vtotal(5)
        Form1.ltbNombre.Items.Clear()
        Form1.ltbNit.Items.Clear()
        Form1.ltbMarca.Items.Clear()
        Form1.ltbPlaca.Items.Clear()
        Form1.ltbDias.Items.Clear()
        Form1.ltbPrecioParcial.Items.Clear()
        Form1.ltbDescuento.Items.Clear()
        Form1.ltbRecargo.Items.Clear()
        Form1.ltbEfectivo.Items.Clear()
        Form1.ltbTarjeta.Items.Clear()
        Form1.ltbTotal.Items.Clear()
        indice = 0
    End Sub

    Sub Lentradas()
        Form1.txtNombre.Clear()
        Form1.txtNit.Clear()
        Form1.cmbMarca.Text = ""
        Form1.txtPlaca.Clear()
        Form1.txtDias.Clear()
        Form1.chbEfectivo.Checked = False
        Form1.chbTarjeta.Checked = False
        Form1.txtEfectivo.Clear()
        Form1.txtTarjeta.Clear()
        Form1.txtNombre.Focus()

    End Sub
End Module
