<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUVA
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSaldoD = New System.Windows.Forms.TextBox()
        Me.TxtSaldoP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblValorUba = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtMontoUVA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtGanancias = New System.Windows.Forms.TextBox()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.TxtSellado = New System.Windows.Forms.TextBox()
        Me.TxtDesde = New System.Windows.Forms.TextBox()
        Me.TxtAviso = New System.Windows.Forms.TextBox()
        Me.TxtAccion = New System.Windows.Forms.TextBox()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdSimular = New System.Windows.Forms.Button()
        Me.CmdEfectuar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.GroupBox1.Size = New System.Drawing.Size(214, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuenta"
        '
        'TxtSaldoD
        '
        Me.TxtSaldoD.Location = New System.Drawing.Point(85, 47)
        Me.TxtSaldoD.Name = "TxtSaldoD"
        Me.TxtSaldoD.ReadOnly = True
        Me.TxtSaldoD.Size = New System.Drawing.Size(123, 20)
        Me.TxtSaldoD.TabIndex = 1
        '
        'TxtSaldoP
        '
        Me.TxtSaldoP.Location = New System.Drawing.Point(85, 24)
        Me.TxtSaldoP.Name = "TxtSaldoP"
        Me.TxtSaldoP.ReadOnly = True
        Me.TxtSaldoP.Size = New System.Drawing.Size(123, 20)
        Me.TxtSaldoP.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo Dolares"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saldo Pesos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblValorUba)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(232, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(134, 78)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valor UVA"
        '
        'LblValorUba
        '
        Me.LblValorUba.AutoSize = True
        Me.LblValorUba.Font = New System.Drawing.Font("Cambria", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValorUba.Location = New System.Drawing.Point(37, 25)
        Me.LblValorUba.Name = "LblValorUba"
        Me.LblValorUba.Size = New System.Drawing.Size(59, 43)
        Me.LblValorUba.TabIndex = 3
        Me.LblValorUba.Text = "54"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "$"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TxtMontoUVA)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TxtGanancias)
        Me.GroupBox3.Controls.Add(Me.TxtPlazo)
        Me.GroupBox3.Controls.Add(Me.TxtSellado)
        Me.GroupBox3.Controls.Add(Me.TxtDesde)
        Me.GroupBox3.Controls.Add(Me.TxtAviso)
        Me.GroupBox3.Controls.Add(Me.TxtAccion)
        Me.GroupBox3.Controls.Add(Me.TxtMonto)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 231)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Valor expresado en UVA"
        '
        'TxtMontoUVA
        '
        Me.TxtMontoUVA.Location = New System.Drawing.Point(151, 201)
        Me.TxtMontoUVA.Name = "TxtMontoUVA"
        Me.TxtMontoUVA.ReadOnly = True
        Me.TxtMontoUVA.Size = New System.Drawing.Size(197, 20)
        Me.TxtMontoUVA.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(320, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Dias"
        '
        'TxtGanancias
        '
        Me.TxtGanancias.Location = New System.Drawing.Point(151, 175)
        Me.TxtGanancias.Name = "TxtGanancias"
        Me.TxtGanancias.ReadOnly = True
        Me.TxtGanancias.Size = New System.Drawing.Size(197, 20)
        Me.TxtGanancias.TabIndex = 13
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Location = New System.Drawing.Point(151, 45)
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(163, 20)
        Me.TxtPlazo.TabIndex = 3
        '
        'TxtSellado
        '
        Me.TxtSellado.Location = New System.Drawing.Point(151, 149)
        Me.TxtSellado.Name = "TxtSellado"
        Me.TxtSellado.ReadOnly = True
        Me.TxtSellado.Size = New System.Drawing.Size(197, 20)
        Me.TxtSellado.TabIndex = 12
        '
        'TxtDesde
        '
        Me.TxtDesde.Location = New System.Drawing.Point(151, 123)
        Me.TxtDesde.Name = "TxtDesde"
        Me.TxtDesde.ReadOnly = True
        Me.TxtDesde.Size = New System.Drawing.Size(197, 20)
        Me.TxtDesde.TabIndex = 11
        '
        'TxtAviso
        '
        Me.TxtAviso.Location = New System.Drawing.Point(151, 97)
        Me.TxtAviso.Name = "TxtAviso"
        Me.TxtAviso.ReadOnly = True
        Me.TxtAviso.Size = New System.Drawing.Size(197, 20)
        Me.TxtAviso.TabIndex = 10
        '
        'TxtAccion
        '
        Me.TxtAccion.Location = New System.Drawing.Point(151, 71)
        Me.TxtAccion.Name = "TxtAccion"
        Me.TxtAccion.ReadOnly = True
        Me.TxtAccion.Size = New System.Drawing.Size(197, 20)
        Me.TxtAccion.TabIndex = 9
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(151, 19)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(197, 20)
        Me.TxtMonto.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Impuesto a las ganancias"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sellado a la Constitucion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Desde"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Aviso antes del vencimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Accion al vencimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Plazo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Monto"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(377, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 3
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(377, 306)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 4
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdSimular
        '
        Me.CmdSimular.Enabled = False
        Me.CmdSimular.Location = New System.Drawing.Point(458, 306)
        Me.CmdSimular.Name = "CmdSimular"
        Me.CmdSimular.Size = New System.Drawing.Size(86, 23)
        Me.CmdSimular.TabIndex = 5
        Me.CmdSimular.Text = "Simular"
        Me.CmdSimular.UseVisualStyleBackColor = True
        '
        'CmdEfectuar
        '
        Me.CmdEfectuar.Location = New System.Drawing.Point(550, 306)
        Me.CmdEfectuar.Name = "CmdEfectuar"
        Me.CmdEfectuar.Size = New System.Drawing.Size(75, 23)
        Me.CmdEfectuar.TabIndex = 6
        Me.CmdEfectuar.Text = "Efectuar"
        Me.CmdEfectuar.UseVisualStyleBackColor = True
        '
        'FrmUVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 341)
        Me.Controls.Add(Me.CmdEfectuar)
        Me.Controls.Add(Me.CmdSimular)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmUVA"
        Me.Text = "FrmUVA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSaldoD As TextBox
    Friend WithEvents TxtSaldoP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblValorUba As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtGanancias As TextBox
    Friend WithEvents TxtPlazo As TextBox
    Friend WithEvents TxtSellado As TextBox
    Friend WithEvents TxtDesde As TextBox
    Friend WithEvents TxtAviso As TextBox
    Friend WithEvents TxtAccion As TextBox
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdSimular As Button
    Friend WithEvents CmdEfectuar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtMontoUVA As TextBox
End Class
