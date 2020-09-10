<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.LblRegistrarse = New System.Windows.Forms.Label()
        Me.ImgContraseña = New System.Windows.Forms.PictureBox()
        CType(Me.ImgContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(12, 9)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(96, 29)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(12, 47)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(136, 29)
        Me.LblPassword.TabIndex = 1
        Me.LblPassword.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContraseña.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(169, 47)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtContraseña.Size = New System.Drawing.Size(168, 29)
        Me.txtContraseña.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(169, 12)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(167, 29)
        Me.txtUsuario.TabIndex = 1
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAceptar.Location = New System.Drawing.Point(17, 79)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(105, 36)
        Me.CmdAceptar.TabIndex = 3
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = True
        '
        'LblRegistrarse
        '
        Me.LblRegistrarse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRegistrarse.AutoSize = True
        Me.LblRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblRegistrarse.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistrarse.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LblRegistrarse.Location = New System.Drawing.Point(256, 96)
        Me.LblRegistrarse.Name = "LblRegistrarse"
        Me.LblRegistrarse.Size = New System.Drawing.Size(81, 19)
        Me.LblRegistrarse.TabIndex = 4
        Me.LblRegistrarse.Text = "Registrarse"
        '
        'ImgContraseña
        '
        Me.ImgContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgContraseña.Image = Global.TpHomeBankingCristoboLugo.My.Resources.Resources.descarga
        Me.ImgContraseña.Location = New System.Drawing.Point(169, 92)
        Me.ImgContraseña.Name = "ImgContraseña"
        Me.ImgContraseña.Size = New System.Drawing.Size(25, 23)
        Me.ImgContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgContraseña.TabIndex = 16
        Me.ImgContraseña.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 132)
        Me.Controls.Add(Me.ImgContraseña)
        Me.Controls.Add(Me.LblRegistrarse)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsuario)
        Me.Name = "FrmLogin"
        Me.Text = "Iniciar Sesion"
        CType(Me.ImgContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblUsuario As System.Windows.Forms.Label
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents LblRegistrarse As System.Windows.Forms.Label
    Friend WithEvents ImgContraseña As PictureBox
End Class
