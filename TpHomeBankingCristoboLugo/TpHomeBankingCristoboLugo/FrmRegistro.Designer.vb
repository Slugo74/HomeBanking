<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDocumento = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.CmdRegistrarse = New System.Windows.Forms.Button()
        Me.ImgContraseña = New System.Windows.Forms.PictureBox()
        Me.TxtErrores = New System.Windows.Forms.TextBox()
        Me.cmbMail = New System.Windows.Forms.ComboBox()
        Me.calFecha = New System.Windows.Forms.MonthCalendar()
        CType(Me.ImgContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "D.N.I"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Nac."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contraseña"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(108, 4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(272, 23)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(108, 33)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(272, 23)
        Me.TxtApellido.TabIndex = 8
        '
        'TxtDocumento
        '
        Me.TxtDocumento.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDocumento.Location = New System.Drawing.Point(108, 62)
        Me.TxtDocumento.Name = "TxtDocumento"
        Me.TxtDocumento.Size = New System.Drawing.Size(272, 23)
        Me.TxtDocumento.TabIndex = 9
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(108, 91)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(272, 23)
        Me.TxtFecha.TabIndex = 10
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(108, 120)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(145, 23)
        Me.TxtCorreo.TabIndex = 11
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(108, 149)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(272, 23)
        Me.TxtUsuario.TabIndex = 12
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(108, 178)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.TxtContraseña.Size = New System.Drawing.Size(241, 23)
        Me.TxtContraseña.TabIndex = 13
        '
        'CmdRegistrarse
        '
        Me.CmdRegistrarse.Location = New System.Drawing.Point(259, 207)
        Me.CmdRegistrarse.Name = "CmdRegistrarse"
        Me.CmdRegistrarse.Size = New System.Drawing.Size(203, 23)
        Me.CmdRegistrarse.TabIndex = 14
        Me.CmdRegistrarse.Text = "Registrarse"
        Me.CmdRegistrarse.UseVisualStyleBackColor = True
        '
        'ImgContraseña
        '
        Me.ImgContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgContraseña.Image = Global.TpHomeBankingCristoboLugo.My.Resources.Resources.descarga
        Me.ImgContraseña.Location = New System.Drawing.Point(355, 178)
        Me.ImgContraseña.Name = "ImgContraseña"
        Me.ImgContraseña.Size = New System.Drawing.Size(25, 23)
        Me.ImgContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgContraseña.TabIndex = 15
        Me.ImgContraseña.TabStop = False
        '
        'TxtErrores
        '
        Me.TxtErrores.BackColor = System.Drawing.SystemColors.Window
        Me.TxtErrores.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtErrores.ForeColor = System.Drawing.Color.Red
        Me.TxtErrores.Location = New System.Drawing.Point(13, 236)
        Me.TxtErrores.Multiline = True
        Me.TxtErrores.Name = "TxtErrores"
        Me.TxtErrores.Size = New System.Drawing.Size(627, 239)
        Me.TxtErrores.TabIndex = 16
        Me.TxtErrores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbMail
        '
        Me.cmbMail.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMail.FormattingEnabled = True
        Me.cmbMail.Items.AddRange(New Object() {"@gmail.com", "@hotmail.com", "@outlook.com", "@alumno.huergo.edu.ar", "@live.com"})
        Me.cmbMail.Location = New System.Drawing.Point(259, 120)
        Me.cmbMail.Name = "cmbMail"
        Me.cmbMail.Size = New System.Drawing.Size(121, 23)
        Me.cmbMail.TabIndex = 17
        Me.cmbMail.Text = "Seleccione"
        '
        'calFecha
        '
        Me.calFecha.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calFecha.Location = New System.Drawing.Point(392, 4)
        Me.calFecha.MaxSelectionCount = 1
        Me.calFecha.Name = "calFecha"
        Me.calFecha.TabIndex = 18
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 484)
        Me.Controls.Add(Me.calFecha)
        Me.Controls.Add(Me.cmbMail)
        Me.Controls.Add(Me.TxtErrores)
        Me.Controls.Add(Me.ImgContraseña)
        Me.Controls.Add(Me.CmdRegistrarse)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtDocumento)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRegistro"
        Me.Text = "Registro"
        CType(Me.ImgContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents CmdRegistrarse As System.Windows.Forms.Button
    Friend WithEvents ImgContraseña As System.Windows.Forms.PictureBox
    Friend WithEvents TxtErrores As TextBox
    Friend WithEvents cmbMail As ComboBox
    Friend WithEvents calFecha As MonthCalendar
End Class
