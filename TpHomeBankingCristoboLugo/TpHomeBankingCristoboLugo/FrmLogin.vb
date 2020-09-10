Public Class FrmLogin
    ' Dim nombreUsuario As String
    ' Dim apellidoUsuario As String
    ' Dim dniUsuario As String
    ' Dim fechaUsuario As String
    ' Dim correoUsuario As String
    ' Dim usuario As String
    ' Dim contraseña As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LblUsuario.Click

    End Sub

    Private Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
        FileOpen(1, "DatosDeUsuario.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, nombre)
            Input(1, apellido)
            Input(1, dni)
            Input(1, fecha)
            Input(1, correo)
            Input(1, usuario)
            Input(1, contraseña)
            Input(1, saldoPesos)
            Input(1, saldoDolares)
            If txtUsuario.Text = usuario And txtContraseña.Text = contraseña Then
                FileClose(1)
                txtUsuario.Text = ""
                txtContraseña.Text = ""
                FrmCuenta.Show()
                Dim dialogResult2 = MessageBox.Show("Iniciacion Exitosa")
                Me.Hide()
                Exit Sub
            End If
        End While
        MessageBox.Show("Ese usuario no se reconoce")
        FileClose(1)
    End Sub

    Private Sub LblRegistrarse_Click(sender As Object, e As EventArgs) Handles LblRegistrarse.Click
        FrmRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub ImgContraseña_Click(sender As Object, e As EventArgs) Handles ImgContraseña.Click
        Dim caracter As String
        caracter = txtContraseña.PasswordChar.ToString()
        If txtContraseña.PasswordChar = "$" Then

            txtContraseña.PasswordChar = ""
        End If
        If txtContraseña.PasswordChar = caracter Then
            txtContraseña.PasswordChar = "$"
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text = ""
        txtContraseña.Text = ""
    End Sub
End Class
