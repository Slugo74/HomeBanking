Imports System.Text.RegularExpressions
Public Class FrmRegistro
    Dim email = "^([0-9a-zA-z]([-.\w][0-9a-zA-Z])@([0-9a-zA-z][-\w]*[0-9a-zA-Z].)+[a-zA-Z]{2,9})$"
    Private Sub CmdRegistrarse_Click(sender As Object, e As EventArgs) Handles CmdRegistrarse.Click
        Dim errores As Integer
        TxtErrores.Text = ""
        If TxtNombre.Text = "" Then
            TxtErrores.AppendText("No escribio un nombre")
            errores = errores + 1
        End If
        If TxtApellido.Text = "" Then
            TxtErrores.AppendText("
No escribio un apellido")
            errores = errores + 1
        End If
        If TxtDocumento.Text = "" Then
            TxtErrores.AppendText("
No ingreso un documento")
            errores = errores + 1
        End If
        If TxtFecha.Text = "" Then
            TxtErrores.AppendText("
No ingreso una fecha")
            errores += 1
        End If
        If cmbMail.SelectedIndex = -1 Then
            TxtErrores.AppendText("
No selecciono su mail")
            errores = errores + 1
        End If
        If TxtCorreo.Text = "" Or Regex.IsMatch(TxtCorreo.Text, email) Then
            TxtErrores.AppendText("
El email es invalido")
            errores = errores + 1
        End If
        If TxtUsuario.Text = "" Then
            TxtErrores.AppendText("
No ingreso un usuario")
            errores = errores + 1
        End If
        If TxtContraseña.Text = "" Then
            TxtErrores.AppendText("
No ingreso una contraseña")
            errores = errores + 1
        End If
        If errores = 0 Then
            FileOpen(1, "DatosDeUsuario.txt", OpenMode.Append)
            Write(1, TxtNombre.Text,
                  TxtApellido.Text,
                  TxtDocumento.Text,
                  TxtFecha.Text,
                  TxtCorreo.Text + cmbMail.SelectedItem.ToString(),
                  TxtUsuario.Text,
                  TxtContraseña.Text,
                  "$100000",
                  "U$S1000")
            FileClose(1)
            FrmLogin.Show()
            Me.Close()
        Else
            TxtErrores.AppendText("
Total de errores:" + errores.ToString())
        End If
        TxtErrores.ReadOnly = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles ImgContraseña.Click
        Dim caracter As String
        caracter = TxtContraseña.PasswordChar.ToString()
        If TxtContraseña.PasswordChar = "$" Then
            TxtContraseña.PasswordChar = ""
        End If
        If TxtContraseña.PasswordChar = caracter Then
            TxtContraseña.PasswordChar = "$"
        End If
    End Sub

    Private Sub FrmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calFecha.DateChanged
        TxtFecha.Text = calFecha.SelectionStart.ToString("dd/MM/yyyy")
    End Sub

    Private Sub TxtErrores_TextChanged(sender As Object, e As EventArgs) Handles TxtErrores.TextChanged

    End Sub
End Class