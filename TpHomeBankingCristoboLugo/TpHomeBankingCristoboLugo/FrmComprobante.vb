Public Class FrmComprobante
    Dim falsoNombre As String
    Dim falsoApellido As String
    Dim falsoDni As String
    Dim falsaFecha As String
    Dim falsoCorreo As String
    Dim falsoUsuario As String
    Dim falsaContraseña As String
    Dim falsoSaldoD As String
    Dim falsoSaldoP As String
    Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
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
                          ("U$S" + saldoDolares))
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
        saldoDolares = "U$S" + saldoDolares
        saldoPesos = "$" + saldoPesos
        Kill("DatosDeUsuario.txt")
        My.Computer.FileSystem.RenameFile("TextoAuxiliar.txt", "DatosDeUsuario.txt")
        FrmCuenta.Show()
        Me.Close()
    End Sub

    Private Sub FrmComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNombre.Text = nombre
        TxtApellido.Text = apellido
        TxtDocumento.Text = dni
        TxtOperacion.Text = operacion + " de Dolares"
        TxtDolares.Text = saldoDolares
        TxtPesos.Text = saldoPesos
    End Sub
End Class