<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCuenta
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
        Me.TxtCotizacionCompra = New System.Windows.Forms.TextBox()
        Me.TxtCotizacionVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtSaldoActualDolares = New System.Windows.Forms.TextBox()
        Me.TxtSaldoActualPesos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbVenta = New System.Windows.Forms.CheckBox()
        Me.CbCompra = New System.Windows.Forms.CheckBox()
        Me.CmdEfectuar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ImgFoto = New System.Windows.Forms.PictureBox()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmdConfirmar = New System.Windows.Forms.Button()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.CmdPlazo = New System.Windows.Forms.Button()
        Me.CmdUVA = New System.Windows.Forms.Button()
        Me.CmdTransferencias = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCotizacionCompra)
        Me.GroupBox1.Controls.Add(Me.TxtCotizacionVenta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotizacion"
        '
        'TxtCotizacionCompra
        '
        Me.TxtCotizacionCompra.Location = New System.Drawing.Point(94, 49)
        Me.TxtCotizacionCompra.Name = "TxtCotizacionCompra"
        Me.TxtCotizacionCompra.ReadOnly = True
        Me.TxtCotizacionCompra.Size = New System.Drawing.Size(100, 20)
        Me.TxtCotizacionCompra.TabIndex = 3
        Me.TxtCotizacionCompra.Text = "$63"
        '
        'TxtCotizacionVenta
        '
        Me.TxtCotizacionVenta.Location = New System.Drawing.Point(94, 23)
        Me.TxtCotizacionVenta.Name = "TxtCotizacionVenta"
        Me.TxtCotizacionVenta.ReadOnly = True
        Me.TxtCotizacionVenta.Size = New System.Drawing.Size(100, 20)
        Me.TxtCotizacionVenta.TabIndex = 2
        Me.TxtCotizacionVenta.Text = "$67,50"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Compra"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Venta"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSaldoActualDolares)
        Me.GroupBox2.Controls.Add(Me.TxtSaldoActualPesos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 79)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Saldos Actuales"
        '
        'TxtSaldoActualDolares
        '
        Me.TxtSaldoActualDolares.Location = New System.Drawing.Point(94, 49)
        Me.TxtSaldoActualDolares.Name = "TxtSaldoActualDolares"
        Me.TxtSaldoActualDolares.ReadOnly = True
        Me.TxtSaldoActualDolares.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoActualDolares.TabIndex = 7
        '
        'TxtSaldoActualPesos
        '
        Me.TxtSaldoActualPesos.Location = New System.Drawing.Point(94, 23)
        Me.TxtSaldoActualPesos.Name = "TxtSaldoActualPesos"
        Me.TxtSaldoActualPesos.ReadOnly = True
        Me.TxtSaldoActualPesos.Size = New System.Drawing.Size(100, 20)
        Me.TxtSaldoActualPesos.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo en dólares:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Saldo en pesos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtCantidad)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.CbVenta)
        Me.GroupBox3.Controls.Add(Me.CbCompra)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operacion"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(188, 32)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad a operar"
        '
        'CbVenta
        '
        Me.CbVenta.AutoSize = True
        Me.CbVenta.Location = New System.Drawing.Point(6, 52)
        Me.CbVenta.Name = "CbVenta"
        Me.CbVenta.Size = New System.Drawing.Size(54, 17)
        Me.CbVenta.TabIndex = 4
        Me.CbVenta.Text = "Venta"
        Me.CbVenta.UseVisualStyleBackColor = True
        '
        'CbCompra
        '
        Me.CbCompra.AutoSize = True
        Me.CbCompra.Location = New System.Drawing.Point(6, 29)
        Me.CbCompra.Name = "CbCompra"
        Me.CbCompra.Size = New System.Drawing.Size(62, 17)
        Me.CbCompra.TabIndex = 5
        Me.CbCompra.Text = "Compra"
        Me.CbCompra.UseVisualStyleBackColor = True
        '
        'CmdEfectuar
        '
        Me.CmdEfectuar.Location = New System.Drawing.Point(312, 104)
        Me.CmdEfectuar.Name = "CmdEfectuar"
        Me.CmdEfectuar.Size = New System.Drawing.Size(133, 31)
        Me.CmdEfectuar.TabIndex = 3
        Me.CmdEfectuar.Text = "Efectuar Operacion"
        Me.CmdEfectuar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ImgFoto)
        Me.GroupBox4.Controls.Add(Me.TxtImporte)
        Me.GroupBox4.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox4.Controls.Add(Me.TxtTotal)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(433, 160)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Importes a Debitar"
        '
        'ImgFoto
        '
        Me.ImgFoto.Image = Global.TpHomeBankingCristoboLugo.My.Resources.Resources.DolarCapo
        Me.ImgFoto.Location = New System.Drawing.Point(233, 33)
        Me.ImgFoto.Name = "ImgFoto"
        Me.ImgFoto.Size = New System.Drawing.Size(185, 107)
        Me.ImgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImgFoto.TabIndex = 6
        Me.ImgFoto.TabStop = False
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(120, 33)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(100, 20)
        Me.TxtImporte.TabIndex = 5
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Location = New System.Drawing.Point(120, 76)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(100, 20)
        Me.TxtImpuesto.TabIndex = 4
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(120, 120)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Total a debitar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Impuesto PAIS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Importe"
        '
        'CmdConfirmar
        '
        Me.CmdConfirmar.Location = New System.Drawing.Point(99, 369)
        Me.CmdConfirmar.Name = "CmdConfirmar"
        Me.CmdConfirmar.Size = New System.Drawing.Size(184, 23)
        Me.CmdConfirmar.TabIndex = 5
        Me.CmdConfirmar.Text = "Confirmar Operacion"
        Me.CmdConfirmar.UseVisualStyleBackColor = True
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(12, 369)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(81, 23)
        Me.CmdSalir.TabIndex = 6
        Me.CmdSalir.Text = "Cerrar Sesion"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'CmdPlazo
        '
        Me.CmdPlazo.Location = New System.Drawing.Point(370, 369)
        Me.CmdPlazo.Name = "CmdPlazo"
        Me.CmdPlazo.Size = New System.Drawing.Size(75, 23)
        Me.CmdPlazo.TabIndex = 7
        Me.CmdPlazo.Text = "Plazo Fijo"
        Me.CmdPlazo.UseVisualStyleBackColor = True
        '
        'CmdUVA
        '
        Me.CmdUVA.Location = New System.Drawing.Point(289, 369)
        Me.CmdUVA.Name = "CmdUVA"
        Me.CmdUVA.Size = New System.Drawing.Size(75, 23)
        Me.CmdUVA.TabIndex = 8
        Me.CmdUVA.Text = "UVAs"
        Me.CmdUVA.UseVisualStyleBackColor = True
        '
        'CmdTransferencias
        '
        Me.CmdTransferencias.Location = New System.Drawing.Point(312, 141)
        Me.CmdTransferencias.Name = "CmdTransferencias"
        Me.CmdTransferencias.Size = New System.Drawing.Size(133, 23)
        Me.CmdTransferencias.TabIndex = 9
        Me.CmdTransferencias.Text = "Transferencias"
        Me.CmdTransferencias.UseVisualStyleBackColor = True
        '
        'FrmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TpHomeBankingCristoboLugo.My.Resources.Resources.Fondo_del_Banco
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(457, 404)
        Me.Controls.Add(Me.CmdTransferencias)
        Me.Controls.Add(Me.CmdUVA)
        Me.Controls.Add(Me.CmdPlazo)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.CmdConfirmar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CmdEfectuar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCuenta"
        Me.Text = "FrmCuenta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ImgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCotizacionCompra As TextBox
    Friend WithEvents TxtCotizacionVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtSaldoActualDolares As TextBox
    Friend WithEvents TxtSaldoActualPesos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbVenta As CheckBox
    Friend WithEvents CbCompra As CheckBox
    Friend WithEvents CmdEfectuar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ImgFoto As PictureBox
    Friend WithEvents TxtImporte As TextBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CmdConfirmar As Button
    Friend WithEvents CmdSalir As Button
    Friend WithEvents CmdPlazo As Button
    Friend WithEvents CmdUVA As Button
    Friend WithEvents CmdTransferencias As Button
End Class
