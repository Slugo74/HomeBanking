<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPlazo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSaldoD = New System.Windows.Forms.TextBox()
        Me.TxtSaldoP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSellado = New System.Windows.Forms.TextBox()
        Me.TxtCuenta = New System.Windows.Forms.TextBox()
        Me.TxtGanancias = New System.Windows.Forms.TextBox()
        Me.TxtAviso = New System.Windows.Forms.TextBox()
        Me.TxtAccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMontoF = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtVencimiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbPlazo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MthcalCalendario = New System.Windows.Forms.MonthCalendar()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdEfectuar = New System.Windows.Forms.Button()
        Me.CmdSimular = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSaldoD)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoP)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta"
        '
        'TxtSaldoD
        '
        Me.TxtSaldoD.Location = New System.Drawing.Point(85, 62)
        Me.TxtSaldoD.Name = "TxtSaldoD"
        Me.TxtSaldoD.ReadOnly = True
        Me.TxtSaldoD.Size = New System.Drawing.Size(158, 20)
        Me.TxtSaldoD.TabIndex = 1
        '
        'TxtSaldoP
        '
        Me.TxtSaldoP.Location = New System.Drawing.Point(85, 22)
        Me.TxtSaldoP.Name = "TxtSaldoP"
        Me.TxtSaldoP.ReadOnly = True
        Me.TxtSaldoP.Size = New System.Drawing.Size(158, 20)
        Me.TxtSaldoP.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo Dolares"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Saldo Pesos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtSellado)
        Me.GroupBox2.Controls.Add(Me.TxtCuenta)
        Me.GroupBox2.Controls.Add(Me.TxtGanancias)
        Me.GroupBox2.Controls.Add(Me.TxtAviso)
        Me.GroupBox2.Controls.Add(Me.TxtAccion)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtMontoF)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtVencimiento)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CmbPlazo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtMonto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(267, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 270)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(244, 51)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Dias"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Impuesto a las ganancias"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Sellado a la constitucion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Desde"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Aviso antes del vencimiento"
        '
        'TxtSellado
        '
        Me.TxtSellado.Location = New System.Drawing.Point(148, 205)
        Me.TxtSellado.Name = "TxtSellado"
        Me.TxtSellado.ReadOnly = True
        Me.TxtSellado.Size = New System.Drawing.Size(124, 20)
        Me.TxtSellado.TabIndex = 13
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Location = New System.Drawing.Point(148, 179)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.ReadOnly = True
        Me.TxtCuenta.Size = New System.Drawing.Size(124, 20)
        Me.TxtCuenta.TabIndex = 12
        '
        'TxtGanancias
        '
        Me.TxtGanancias.Location = New System.Drawing.Point(148, 231)
        Me.TxtGanancias.Name = "TxtGanancias"
        Me.TxtGanancias.ReadOnly = True
        Me.TxtGanancias.Size = New System.Drawing.Size(124, 20)
        Me.TxtGanancias.TabIndex = 11
        '
        'TxtAviso
        '
        Me.TxtAviso.Location = New System.Drawing.Point(148, 153)
        Me.TxtAviso.Name = "TxtAviso"
        Me.TxtAviso.ReadOnly = True
        Me.TxtAviso.Size = New System.Drawing.Size(124, 20)
        Me.TxtAviso.TabIndex = 10
        '
        'TxtAccion
        '
        Me.TxtAccion.Location = New System.Drawing.Point(148, 127)
        Me.TxtAccion.Name = "TxtAccion"
        Me.TxtAccion.ReadOnly = True
        Me.TxtAccion.Size = New System.Drawing.Size(124, 20)
        Me.TxtAccion.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Accion al Vencimiento"
        '
        'TxtMontoF
        '
        Me.TxtMontoF.Location = New System.Drawing.Point(148, 101)
        Me.TxtMontoF.Name = "TxtMontoF"
        Me.TxtMontoF.ReadOnly = True
        Me.TxtMontoF.Size = New System.Drawing.Size(124, 20)
        Me.TxtMontoF.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Monto Final"
        '
        'TxtVencimiento
        '
        Me.TxtVencimiento.Location = New System.Drawing.Point(148, 75)
        Me.TxtVencimiento.Name = "TxtVencimiento"
        Me.TxtVencimiento.ReadOnly = True
        Me.TxtVencimiento.Size = New System.Drawing.Size(124, 20)
        Me.TxtVencimiento.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Vencimiento"
        '
        'CmbPlazo
        '
        Me.CmbPlazo.FormattingEnabled = True
        Me.CmbPlazo.Items.AddRange(New Object() {"30", "45", "60", "90", "120", "180", "365"})
        Me.CmbPlazo.Location = New System.Drawing.Point(148, 48)
        Me.CmbPlazo.Name = "CmbPlazo"
        Me.CmbPlazo.Size = New System.Drawing.Size(90, 21)
        Me.CmbPlazo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Plazo deseado"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(148, 22)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(124, 20)
        Me.TxtMonto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Monto Inicial"
        '
        'MthcalCalendario
        '
        Me.MthcalCalendario.Location = New System.Drawing.Point(12, 114)
        Me.MthcalCalendario.Name = "MthcalCalendario"
        Me.MthcalCalendario.TabIndex = 0
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(12, 288)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(92, 23)
        Me.CmdSalir.TabIndex = 2
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdEfectuar
        '
        Me.CmdEfectuar.Location = New System.Drawing.Point(409, 288)
        Me.CmdEfectuar.Name = "CmdEfectuar"
        Me.CmdEfectuar.Size = New System.Drawing.Size(130, 23)
        Me.CmdEfectuar.TabIndex = 3
        Me.CmdEfectuar.Text = "Efectuar Plazo"
        Me.CmdEfectuar.UseVisualStyleBackColor = True
        '
        'CmdSimular
        '
        Me.CmdSimular.Location = New System.Drawing.Point(276, 288)
        Me.CmdSimular.Name = "CmdSimular"
        Me.CmdSimular.Size = New System.Drawing.Size(75, 23)
        Me.CmdSimular.TabIndex = 4
        Me.CmdSimular.Text = "Simular"
        Me.CmdSimular.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TpHomeBankingCristoboLugo.My.Resources.Resources.Fotito_del_banquito
        Me.PictureBox1.Location = New System.Drawing.Point(551, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 298)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FrmPlazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CmdSimular)
        Me.Controls.Add(Me.CmdEfectuar)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.MthcalCalendario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmPlazo"
        Me.Text = "FrmPlazo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSaldoD As TextBox
    Friend WithEvents TxtSaldoP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtMontoF As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtVencimiento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbPlazo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MthcalCalendario As MonthCalendar
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtSellado As TextBox
    Friend WithEvents TxtCuenta As TextBox
    Friend WithEvents TxtGanancias As TextBox
    Friend WithEvents TxtAviso As TextBox
    Friend WithEvents TxtAccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdEfectuar As Button
    Friend WithEvents CmdSimular As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
