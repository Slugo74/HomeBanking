Public Class FrmTransferencias
    Dim falsoNombre As String
    Dim falsoApellido As String
    Dim falsoDni As String
    Dim falsaFecha As String
    Dim falsoCorreo As String
    Dim falsoUsuario As String
    Dim falsaContraseña As String
    Dim falsoSaldoD As String
    Dim falsoSaldoP As String
    Private Sub FrmTransferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = dni
        TxtPesos.Text = saldoPesos
        TxtDolares.Text = saldoDolares
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
            If falsoDni <> dni Then
                CmbCuentas.Items.Add(falsoDni)
            End If
        End While
        FileClose(1)
    End Sub

    Private Sub CmdSalir_Click(sender As Object, e As EventArgs) Handles CmdSalir.Click
        FrmCuenta.Show()
        Me.Close()
    End Sub

    Private Sub CmdEfectuar_Click(sender As Object, e As EventArgs) Handles CmdEfectuar.Click
        Dim dniTransferencia = CmbCuentas.Text
        Dim auxPesos = Int(Mid(saldoPesos, 2))
        Dim auxDolares = Int(Mid(saldoDolares, 4))
        Dim monto = Int(TxtMonto.Text)
        If RbD.Checked = True And monto > auxDolares Then
            MessageBox.Show("El monto supera la cantidad de dolares de su cuenta", "¡Atencion!")
            Exit Sub
        End If
        If RbP.Checked = True And monto > auxPesos Then
            MessageBox.Show("El monto supera la cantidad de pesos de su cuenta", "¡Atencion!")
            Exit Sub
        End If
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
            If falsoDni = dniTransferencia Then
                If RbD.Checked = True Then
                    Dim nuevoSaldo = Int(Mid(falsoSaldoD, 4))
                    nuevoSaldo = nuevoSaldo + monto
                    WriteLine(2, falsoNombre,
                          falsoApellido,
                          falsoDni,
                          falsaFecha,
                          falsoCorreo,
                          falsoUsuario,
                          falsaContraseña,
                          falsoSaldoP,
                          "U$S" + nuevoSaldo.ToString())
                End If
                If RbP.Checked = True Then
                    Dim nuevoSaldo = Int(Mid(falsoSaldoP, 2))
                    nuevoSaldo = nuevoSaldo + monto
                    WriteLine(2, falsoNombre,
                              falsoApellido,
                              falsoDni,
                              falsaFecha,
                              falsoCorreo,
                              falsoUsuario,
                              falsaContraseña,
                              "$" + nuevoSaldo.ToString(),
                              falsoSaldoD)
                End If
            End If
            If falsoDni = dni Then
                If RbD.Checked = True Then
                    auxDolares = auxDolares - monto
                    WriteLine(2, falsoNombre,
                          falsoApellido,
                          falsoDni,
                          falsaFecha,
                          falsoCorreo,
                          falsoUsuario,
                          falsaContraseña,
                          falsoSaldoP,
                          "U$S" + auxDolares.ToString())
                End If
                If RbP.Checked = True Then
                    auxPesos = auxPesos - monto
                    WriteLine(2, falsoNombre,
                          falsoApellido,
                          falsoDni,
                          falsaFecha,
                          falsoCorreo,
                          falsoUsuario,
                          falsaContraseña,
                          "$" + auxPesos.ToString(),
                          falsoSaldoD)
                End If
            End If
            FileClose(2)
        End While
        FileClose(1)
        saldoPesos = "$" + auxPesos.ToString()
        saldoDolares = "U$S" + auxDolares.ToString()
        TxtPesos.Text = saldoPesos
        TxtDolares.Text = saldoDolares
        Kill("DatosDeUsuario.txt")
        My.Computer.FileSystem.RenameFile("TextoAuxiliar.txt", "DatosDeUsuario.txt")
    End Sub
End Class