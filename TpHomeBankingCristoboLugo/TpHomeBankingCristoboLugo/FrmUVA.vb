Imports System.Math
Public Class FrmUVA
    Dim falsoNombre As String
    Dim falsoApellido As String
    Dim falsoDni As String
    Dim falsaFecha As String
    Dim falsoCorreo As String
    Dim falsoUsuario As String
    Dim falsaContraseña As String
    Dim falsoSaldoD As String
    Dim falsoSaldoP As String
    Private Sub FrmUVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = dni
        TxtSaldoD.Text = saldoDolares
        TxtSaldoP.Text = saldoPesos
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        FrmCuenta.Show()
        Me.Close()
    End Sub
    Private Sub TxtPlazo_TextChanged(sender As Object, e As EventArgs) Handles TxtPlazo.TextChanged
        Dim valorUVA, monto As Integer
        valorUVA = Int(LblValorUba.Text)
        Try
            monto = Int(TxtMonto.Text)
            Convert.ToInt32(TxtPlazo.Text)
            Dim fechaCobro = DateTime.Today.AddDays(TxtPlazo.Text)
            MonthCalendar1.SetDate(fechaCobro)
            TxtAccion.Text = "Acreditar en cuenta"
            TxtAviso.Text = correo
            TxtDesde.Text = "CA N°" + dni
            TxtSellado.Text = "$0"
            TxtGanancias.Text = "$0"
            TxtMontoUVA.Text = Round((monto / valorUVA), 0).ToString()
        Catch ex As Exception
            If TxtPlazo.Text <> "" Then
                MessageBox.Show("Ingrese numeros por favor", "¡Atencion!")
            End If
        End Try
    End Sub
    Private Sub TxtMonto_TextChanged(sender As Object, e As EventArgs) Handles TxtMonto.TextChanged
        Try
            Dim monto = Convert.ToInt32(TxtMonto.Text)
            If monto > Convert.ToInt32(Mid(saldoPesos, 2)) Then
                MessageBox.Show("Ingreso un monto superior al de su cuenta", "¡Atencion!")
                Exit Sub
            End If
        Catch ex As Exception
            If TxtMonto.Text <> "" Then
                MessageBox.Show("Ingrese numeros por favor", "¡Atencion!")
            End If
        End Try
    End Sub
    Private Sub CmdEfectuar_Click(sender As Object, e As EventArgs) Handles CmdEfectuar.Click
        Dim monto = Convert.ToInt32(TxtMonto.Text)
        Dim plazo = Convert.ToInt32(TxtPlazo.Text)
        Dim valorUVA = Convert.ToDouble(TxtMontoUVA.Text)
        If monto < 10000 Then
            MessageBox.Show("Ingreso un monto inferior a  $10000", "¡Atencion!")
            Exit Sub
        End If
        If plazo < 90 Or plazo > 365 Then
            MessageBox.Show("No puede dejar dinero por menos de 90 dias, ni mas de 365. intente de nuevo", "¡Atencion!")
        End If
        FileOpen(1, "PlazosUVA.txt", OpenMode.Append)
        WriteLine(1, valorUVA,
                  DateTime.Today.ToString("dd/MM/yyyy"),
                  plazo,
                  dni)
        FileClose(1)
        MessageBox.Show("Se efectuo su plazo fijo en UVA. Si quiere simular su ganancia, se libera el boton")
        CmdSimular.Enabled = True
    End Sub
    Private Sub CmdSimular_Click(sender As Object, e As EventArgs) Handles CmdSimular.Click
        Dim numero = Convert.ToInt32((20 * Rnd()) + 1)
        Dim monto = Convert.ToInt32(TxtMonto.Text)
        Dim montoUVA = Convert.ToInt32(TxtMontoUVA.Text)
        MessageBox.Show("Se va a simular su plazo fijo en UVA. Como no se sabe el valor futuro, se usara el UVA a un valor de " + (valorUVA + numero).ToString())
        Dim auxSaldo = Int(Mid(saldoPesos, 2))
        auxSaldo -= monto
        Dim resultado = Int(montoUVA * (Int(valorUVA) + numero))
        auxSaldo += resultado
        saldoPesos = auxSaldo.ToString()
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
                          ("$" + saldoPesos),
                          saldoDolares)
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
        saldoPesos = "$" + saldoPesos
        TxtSaldoP.Text = saldoPesos
        Kill("DatosDeUsuario.txt")
        My.Computer.FileSystem.RenameFile("TextoAuxiliar.txt", "DatosDeUsuario.txt")
    End Sub
End Class