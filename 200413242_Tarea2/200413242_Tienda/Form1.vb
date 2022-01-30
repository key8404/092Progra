Public Class Form1
    Const PrecioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12
    Dim pagoSinIva As Double = 0
    Dim valorIva As Double = 0
    Dim pagoConIva As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0



    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        pagoSinIva = (Val(TxtArroz.Text) * PrecioArroz) + (Val(TxtFrijol.Text) * precioFrijol) + (Val(TxtAzucar.Text) * precioAzucar)
        valorIva = pagoSinIva * IVA
        pagoConIva = pagoSinIva + valorIva
        descuento = pagoConIva * 0.025
        pagofinal = pagoConIva - descuento

        LblR1.Text = pagoSinIva
        LblR2.Text = valorIva
        LblR3.Text = pagoConIva
        LblR4.Text = descuento
        LblR5.Text = pagofinal

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtArroz.Text = ""
        TxtFrijol.Text = ""
        TxtAzucar.Text = ""
        LblR1.Text = ""
        LblR2.Text = ""
        LblR3.Text = ""
        LblR4.Text = ""
        LblR5.Text = ""

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub TxtArroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtFrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtAzucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAzucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
