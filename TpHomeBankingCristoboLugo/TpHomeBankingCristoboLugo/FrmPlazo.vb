Public Class FrmPlazo
    Dim falsoNombre As String
    Dim falsoApellido As String
    Dim falsoDni As String
    Dim falsaFecha As String
    Dim falsoCorreo As String
    Dim falsoUsuario As String
    Dim falsaContraseña As String
    Dim falsoSaldoD As String
    Dim falsoSaldoP As String
    Dim feriado As String
    Private Sub FrmPlazo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = dni
        TxtSaldoP.Text = saldoPesos
        TxtSaldoD.Text = saldoDolares
    End Sub
    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        FrmCuenta.Show()
        Me.Close()
    End Sub

    Private Sub CmdSimular_Click(sender As Object, e As EventArgs) Handles CmdSimular.Click
        Dim auxSaldo As Integer
        auxSaldo = Mid(TxtSaldoP.Text, 2)
        MessageBox.Show(auxSaldo)
        auxSaldo = auxSaldo - Convert.ToInt32(TxtMonto.Text)
        auxSaldo = auxSaldo + Convert.ToInt32(TxtMontoF.Text)
        FileOpen(1, "DatosDeUsuario.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, falsoNombre)
            Input(1, falsoApellido)
            Input(1, falsoDni)
            Input(1, falsaFecha)
            Input(1, falsoCorreo)
            Input(1, falsoUsuario)
            Input(1, falsaContraseña)
            Input(1, falsoSaldoP)
            Input(1, falsoSaldoD)
            FileOpen(2, "TextoAuxiliar.txt", OpenMode.Append)
            If falsoDni = dni Then
                WriteLine(2, nombre,
                          apellido,
                          dni,
                          fecha,
                          correo,
                          usuario,
                          contraseña,
                          ("$" + auxSaldo.ToString()),
                          falsoSaldoD)
            Else
                WriteLine(2, falsoNombre,
                          falsoApellido,
                          falsoDni,
                          falsaFecha,
                          falsoCorreo,
                          falsoUsuario,
                          falsaContraseña,
                          falsoSaldoP,
                          falsoSaldoD)
            End If
            FileClose(2)
        End While
        FileClose(1)
        Kill("DatosDeUsuario.txt")
        My.Computer.FileSystem.RenameFile("TextoAuxiliar.txt", "DatosDeUsuario.txt")
        saldoPesos = "$" + auxSaldo.ToString()
        TxtSaldoP.Text = saldoPesos
    End Sub

    Private Sub CmbPlazo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbPlazo.SelectedIndexChanged
        fechaDeHoy = DateTime.Today
        fechaDeVencimiento = DateTime.Today.AddDays(Convert.ToDouble(CmbPlazo.Text))
        TxtVencimiento.Text = fechaDeVencimiento.ToString("dd/MM/yyyy")
        MthcalCalendario.SetDate(fechaDeVencimiento)
        interes = Convert.ToDouble(CmbPlazo.Text)
        If TxtMonto.Text = "" Then
            MessageBox.Show("No ingreso monto")
            Exit Sub
        ElseIf CmbPlazo.SelectedIndex = 0 Then
            MessageBox.Show("No ingreso plazo")
            Exit Sub
        ElseIf Convert.ToDouble(TxtMonto.Text) < 10000 Then
            MessageBox.Show("El monto ingresado es inferior al minimo de $10.000")
            Exit Sub
        ElseIf Convert.ToDouble(TxtMonto.Text) > Convert.ToDouble(Mid(TxtSaldoP.Text, 2)) Then
            MessageBox.Show("El monto ingresado es superior al que tiene en su cuenta")
            Exit Sub
        End If
        If interes = 30 Then
            interes = 26.35
        End If
        If interes = 45 Then
            interes = 26.9
        End If
        If interes = 60 Then
            interes = 28.05
        End If
        If interes = 90 Then
            interes = 28.5
        End If
        If interes = 120 Then
            interes = 28.8
        End If
        If interes = 180 Then
            interes = 29.1
        End If
        If interes = 365 Then
            interes = 29.1
        End If
        Try
            Convert.ToInt32(TxtMonto.Text)
        Catch ex As Exception
            MessageBox.Show("Ingrese Solo numeros enteros")
            TxtVencimiento.Text = ""
            TxtMontoF.Text = ""
            TxtAccion.Text = ""
            TxtAviso.Text = ""
            TxtCuenta.Text = ""
            TxtSellado.Text = ""
            TxtGanancias.Text = ""
            Exit Sub
        End Try
        montoFinal = Convert.ToDouble(TxtMonto.Text) * (interes / 100) * (Convert.ToDouble(CmbPlazo.Text) / 365)
        TxtMontoF.Text = (Convert.ToInt32(TxtMonto.Text) + montoFinal).ToString()
        TxtAccion.Text = "Acreditar en cuenta"
        TxtAviso.Text = correo
        TxtCuenta.Text = "CA $ N° " + dni
        TxtSellado.Text = "$ 0"
        TxtGanancias.Text = "$ 0"
    End Sub

    Private Sub CmdEfectuar_Click(sender As Object, e As EventArgs) Handles CmdEfectuar.Click
        Dim today As String
        Dim endDay As String
        today = DateTime.Today.ToString("ddd")
        If today = "sab." Or today = "dom." Then
            MessageBox.Show("No puede iniciar esta operatoria en fines de semana o feriados. Sin embargo, recuerda que puede simular los resultados", "¡Atencion!")
            Exit Sub
        End If
        today = DateTime.Today.ToString("dd/MM")
        endDay = TxtVencimiento.Text
        FileOpen(1, "Feriados.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, feriado)
            ' MessageBox.Show(feriado)
            If today = feriado Then
                MessageBox.Show("No puede iniciar esta operatoria en fines de semana o feriados. Sin embargo, recuerda que puede simular los resultados", "¡Atencion!")
                FileClose(1)
                Exit Sub
            End If
            If endDay = feriado Then
                MessageBox.Show("")
            End If
        End While
        FileClose(1)
        FileOpen(1, "PlazosFijos.txt", OpenMode.Append)
        WriteLine(1, DateTime.Today.ToString("dd/MM/yyyy"),
                  CmbPlazo.Text,
                  TxtMontoF.Text,
                  dni)
        FileClose(1)
        MessageBox.Show("Su plazo ha sido efectuado. Tendra que esperar el tiempo estipulado. Pero recuerde que puede simular los resultados con el boton 'Simular'", "Estimado cliente")
    End Sub
End Class