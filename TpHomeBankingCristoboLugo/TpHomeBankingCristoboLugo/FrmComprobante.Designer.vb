<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobante
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDocumento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPesos = New System.Windows.Forms.TextBox()
        Me.TxtDolares = New System.Windows.Forms.TextBox()
        Me.TxtOperacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(124, 13)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(124, 39)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.ReadOnly = True
        Me.TxtApellido.Size = New System.Drawing.Size(100, 20)
        Me.TxtApellido.TabIndex = 1
        '
        'TxtDocumento
        '
        Me.TxtDocumento.Location = New System.Drawing.Point(124, 65)
        Me.TxtDocumento.Name = "TxtDocumento"
        Me.TxtDocumento.ReadOnly = True
        Me.TxtDocumento.Size = New System.Drawing.Size(100, 20)
        Me.TxtDocumento.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Documento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cuenta en Dolares"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cuenta en Pesos"
        '
        'TxtPesos
        '
        Me.TxtPesos.Location = New System.Drawing.Point(124, 143)
        Me.TxtPesos.Name = "TxtPesos"
        Me.TxtPesos.ReadOnly = True
        Me.TxtPesos.Size = New System.Drawing.Size(100, 20)
        Me.TxtPesos.TabIndex = 8
        '
        'TxtDolares
        '
        Me.TxtDolares.Location = New System.Drawing.Point(124, 117)
        Me.TxtDolares.Name = "TxtDolares"
        Me.TxtDolares.ReadOnly = True
        Me.TxtDolares.Size = New System.Drawing.Size(100, 20)
        Me.TxtDolares.TabIndex = 9
        '
        'TxtOperacion
        '
        Me.TxtOperacion.Location = New System.Drawing.Point(124, 91)
        Me.TxtOperacion.Name = "TxtOperacion"
        Me.TxtOperacion.ReadOnly = True
        Me.TxtOperacion.Size = New System.Drawing.Size(100, 20)
        Me.TxtOperacion.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Operacion"
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Location = New System.Drawing.Point(65, 182)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(111, 23)
        Me.CmdAceptar.TabIndex = 12
        Me.CmdAceptar.Text = "Aceptar Cambios"
        Me.CmdAceptar.UseVisualStyleBackColor = True
        '
        'FrmComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 217)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtOperacion)
        Me.Controls.Add(Me.TxtDolares)
        Me.Controls.Add(Me.TxtPesos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDocumento)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Name = "FrmComprobante"
        Me.Text = "FrmComprobante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtDocumento As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPesos As TextBox
    Friend WithEvents TxtDolares As TextBox
    Friend WithEvents TxtOperacion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmdAceptar As Button
End Class
