Public Class FrmCuenta
    Dim cantidad As String
    Dim fechaPlazo As String
    Dim duracionPlazo As String
    Dim montoPlazo As String
    Dim dniPlazo As String
    Dim feriado As String
    Private Sub FrmCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdConfirmar.Enabled = False
        fechaDeHoy = Date.Today.ToString("dd/MM/yyyy")
        TxtSaldoActualPesos.Text = saldoPesos
        TxtSaldoActualDolares.Text = saldoDolares
        Me.Text = dni
        FileOpen(1, "PlazosFijos.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, fechaPlazo)
            Input(1, duracionPlazo)
            Input(1, montoPlazo)
            Input(1, dniPlazo)
            If dniPlazo = dni Then
                If (Convert.ToDateTime(fechaPlazo).AddDays(Convert.ToInt32(duracionPlazo))).ToString() = DateTime.Today.ToString("dd/MM/yyyy") Then

                End If
            End If
        End While
        FileClose(1)
    End Sub

    Private Sub CmdEfectuar_Click(sender As Object, e As EventArgs) Handles CmdEfectuar.Click
        If CbCompra.Checked And CbVenta.Checked Then
            Dim dialogResult = MessageBox.Show("Por favor, seleccione SOLO uno. Gracias")
            Exit Sub
        End If
        If Not CbCompra.Checked And Not CbVenta.Checked Then
            Dim dialogResult = MessageBox.Show("Por favor, seleccione AL MENOS uno. Gracias")
            Exit Sub
        End If
        If TxtCantidad.Text = "" Then
            MessageBox.Show("Escriba alguna cantidad. gracias")
            Exit Sub
        End If
        TxtImporte.Text = ""
        TxtImpuesto.Text = ""
        TxtTotal.Text = ""
        cantidad = TxtCantidad.Text
        If CbCompra.Checked Then
            TxtImpuesto.Enabled = True
            Dim importe = Mid(TxtCotizacionVenta.Text, 2)
            TxtImporte.Text = TxtCantidad.Text * importe
            importe = TxtImporte.Text
            TxtImpuesto.Text = importe * 30 / 100
            Dim impuesto = TxtImpuesto.Text
            TxtTotal.Text = Convert.ToDouble(importe) + Convert.ToDouble(impuesto)
            Dim total = TxtTotal.Text
            saldoDolares = (Convert.ToDouble(Mid(saldoDolares, 4)) + Convert.ToDouble(TxtCantidad.Text)).ToString()
            saldoPesos = (Convert.ToDouble(Mid(saldoPesos, 2)) - Convert.ToDouble(total)).ToString()
            operacion = CbCompra.Text
        End If
        If CbVenta.Checked Then
            TxtImpuesto.Enabled = False
            Dim importe = Mid(TxtCotizacionCompra.Text, 2)
            TxtImporte.Text = TxtCantidad.Text * importe
            TxtTotal.Text = TxtImporte.Text
            Dim total = TxtTotal.Text
            saldoDolares = (Convert.ToDouble(Mid(saldoDolares, 4)) - Convert.ToDouble(TxtCantidad.Text)).ToString()
            saldoPesos = (Convert.ToDouble(Mid(saldoPesos, 2)) + Convert.ToDouble(total)).ToString()
            operacion = CbVenta.Text
        End If
        CmdConfirmar.Enabled = True
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        nombre = ""
        apellido = ""
        dni = ""
        fecha = ""
        correo = ""
        usuario = ""
        contraseña = ""
        saldoPesos = ""
        saldoDolares = ""
        operacion = ""
        FrmLogin.Show()
        Me.Close()
    End Sub

    Private Sub CmdConfirmar_Click(sender As Object, e As EventArgs) Handles CmdConfirmar.Click
        FrmComprobante.Show()
        Me.Close()
    End Sub

    Private Sub CmdPlazo_Click(sender As Object, e As EventArgs) Handles CmdPlazo.Click
        FrmPlazo.Show()
        Me.Close()
    End Sub

    Private Sub CmdUVA_Click(sender As Object, e As EventArgs) Handles CmdUVA.Click
        FrmUVA.Show()
        Me.Close()
    End Sub

    Private Sub CmdTransferencias_Click(sender As Object, e As EventArgs) Handles CmdTransferencias.Click
        FrmTransferencias.Show()
        Me.Close()
    End Sub
End Class