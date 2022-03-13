<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puerto
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Puerto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbufferin = New System.Windows.Forms.TextBox()
        Me.txtbufferout = New System.Windows.Forms.TextBox()
        Me.cboPuertos = New System.Windows.Forms.ComboBox()
        Me.btnEnviarDato = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnDeterminarConexion = New System.Windows.Forms.Button()
        Me.Conectar = New System.Windows.Forms.Button()
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.spPuertos = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbufferin)
        Me.GroupBox1.Controls.Add(Me.txtbufferout)
        Me.GroupBox1.Controls.Add(Me.cboPuertos)
        Me.GroupBox1.Controls.Add(Me.btnEnviarDato)
        Me.GroupBox1.Controls.Add(Me.btnConectar)
        Me.GroupBox1.Controls.Add(Me.btnDeterminarConexion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comunicador Puerto Hardware"
        '
        'txtbufferin
        '
        Me.txtbufferin.Location = New System.Drawing.Point(88, 121)
        Me.txtbufferin.Name = "txtbufferin"
        Me.txtbufferin.Size = New System.Drawing.Size(121, 20)
        Me.txtbufferin.TabIndex = 4
        '
        'txtbufferout
        '
        Me.txtbufferout.Location = New System.Drawing.Point(88, 82)
        Me.txtbufferout.Name = "txtbufferout"
        Me.txtbufferout.Size = New System.Drawing.Size(121, 20)
        Me.txtbufferout.TabIndex = 5
        '
        'cboPuertos
        '
        Me.cboPuertos.FormattingEnabled = True
        Me.cboPuertos.Location = New System.Drawing.Point(88, 45)
        Me.cboPuertos.Name = "cboPuertos"
        Me.cboPuertos.Size = New System.Drawing.Size(121, 21)
        Me.cboPuertos.TabIndex = 2
        '
        'btnEnviarDato
        '
        Me.btnEnviarDato.Location = New System.Drawing.Point(6, 121)
        Me.btnEnviarDato.Name = "btnEnviarDato"
        Me.btnEnviarDato.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviarDato.TabIndex = 5
        Me.btnEnviarDato.Text = "Enviar dato"
        Me.btnEnviarDato.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(6, 82)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 3
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnDeterminarConexion
        '
        Me.btnDeterminarConexion.Location = New System.Drawing.Point(6, 44)
        Me.btnDeterminarConexion.Name = "btnDeterminarConexion"
        Me.btnDeterminarConexion.Size = New System.Drawing.Size(75, 23)
        Me.btnDeterminarConexion.TabIndex = 1
        Me.btnDeterminarConexion.Text = "Determinar"
        Me.btnDeterminarConexion.UseVisualStyleBackColor = True
        '
        'Conectar
        '
        Me.Conectar.Location = New System.Drawing.Point(12, 177)
        Me.Conectar.Name = "Conectar"
        Me.Conectar.Size = New System.Drawing.Size(224, 41)
        Me.Conectar.TabIndex = 1
        Me.Conectar.Text = "Conectar"
        Me.Conectar.UseVisualStyleBackColor = True
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 200
        '
        'Puerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 230)
        Me.Controls.Add(Me.Conectar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Puerto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Puerto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbufferin As System.Windows.Forms.TextBox
    Friend WithEvents txtbufferout As System.Windows.Forms.TextBox
    Friend WithEvents cboPuertos As System.Windows.Forms.ComboBox
    Friend WithEvents btnEnviarDato As System.Windows.Forms.Button
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents btnDeterminarConexion As System.Windows.Forms.Button
    Friend WithEvents Conectar As System.Windows.Forms.Button
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents spPuertos As System.IO.Ports.SerialPort
End Class
