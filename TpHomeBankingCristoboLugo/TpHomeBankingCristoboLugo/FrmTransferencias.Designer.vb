<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransferencias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCuentas = New System.Windows.Forms.ComboBox()
        Me.CmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDolares = New System.Windows.Forms.TextBox()
        Me.TxtPesos = New System.Windows.Forms.TextBox()
        Me.CmdEfectuar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbP = New System.Windows.Forms.RadioButton()
        Me.RbD = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbCuentas)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cuentas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero De Cuenta"
        '
        'CmbCuentas
        '
        Me.CmbCuentas.FormattingEnabled = True
        Me.CmbCuentas.Location = New System.Drawing.Point(115, 22)
        Me.CmbCuentas.Name = "CmbCuentas"
        Me.CmbCuentas.Size = New System.Drawing.Size(211, 21)
        Me.CmbCuentas.TabIndex = 2
        '
        'CmdSalir
        '
        Me.CmdSalir.Location = New System.Drawing.Point(12, 226)
        Me.CmdSalir.Name = "CmdSalir"
        Me.CmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.CmdSalir.TabIndex = 1
        Me.CmdSalir.Text = "Salir"
        Me.CmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtDolares)
        Me.GroupBox2.Controls.Add(Me.TxtPesos)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 78)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cuentas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cuenta en Pesos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Cuenta en Dolares"
        '
        'TxtDolares
        '
        Me.TxtDolares.Location = New System.Drawing.Point(107, 48)
        Me.TxtDolares.Name = "TxtDolares"
        Me.TxtDolares.ReadOnly = True
        Me.TxtDolares.Size = New System.Drawing.Size(219, 20)
        Me.TxtDolares.TabIndex = 3
        '
        'TxtPesos
        '
        Me.TxtPesos.Location = New System.Drawing.Point(107, 22)
        Me.TxtPesos.Name = "TxtPesos"
        Me.TxtPesos.ReadOnly = True
        Me.TxtPesos.Size = New System.Drawing.Size(219, 20)
        Me.TxtPesos.TabIndex = 4
        '
        'CmdEfectuar
        '
        Me.CmdEfectuar.Location = New System.Drawing.Point(269, 226)
        Me.CmdEfectuar.Name = "CmdEfectuar"
        Me.CmdEfectuar.Size = New System.Drawing.Size(75, 23)
        Me.CmdEfectuar.TabIndex = 3
        Me.CmdEfectuar.Text = "Efectuar"
        Me.CmdEfectuar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.RbD)
        Me.GroupBox3.Controls.Add(Me.RbP)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(332, 67)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles"
        '
        'RbP
        '
        Me.RbP.AutoSize = True
        Me.RbP.Location = New System.Drawing.Point(6, 19)
        Me.RbP.Name = "RbP"
        Me.RbP.Size = New System.Drawing.Size(54, 17)
        Me.RbP.TabIndex = 0
        Me.RbP.TabStop = True
        Me.RbP.Text = "Pesos"
        Me.RbP.UseVisualStyleBackColor = True
        '
        'RbD
        '
        Me.RbD.AutoSize = True
        Me.RbD.Location = New System.Drawing.Point(6, 42)
        Me.RbD.Name = "RbD"
        Me.RbD.Size = New System.Drawing.Size(61, 17)
        Me.RbD.TabIndex = 1
        Me.RbD.TabStop = True
        Me.RbD.Text = "Dolares"
        Me.RbD.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtMonto)
        Me.GroupBox4.Location = New System.Drawing.Point(73, 19)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(253, 40)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "¿Cuanto Desea Transferir?"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(6, 14)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(241, 20)
        Me.TxtMonto.TabIndex = 0
        '
        'FrmTransferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 258)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CmdEfectuar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTransferencias"
        Me.Text = "FrmTransferencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbCuentas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmdSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDolares As TextBox
    Friend WithEvents TxtPesos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CmdEfectuar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents RbD As RadioButton
    Friend WithEvents RbP As RadioButton
End Class
