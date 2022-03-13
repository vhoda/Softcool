<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bdd))
        Me.btnconectar = New System.Windows.Forms.Button()
        Me.serv = New System.Windows.Forms.TextBox()
        Me.base = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnconectar
        '
        Me.btnconectar.Location = New System.Drawing.Point(156, 197)
        Me.btnconectar.Name = "btnconectar"
        Me.btnconectar.Size = New System.Drawing.Size(75, 23)
        Me.btnconectar.TabIndex = 0
        Me.btnconectar.Text = "Conectar"
        Me.btnconectar.UseVisualStyleBackColor = True
        '
        'serv
        '
        Me.serv.Location = New System.Drawing.Point(200, 72)
        Me.serv.Name = "serv"
        Me.serv.Size = New System.Drawing.Size(184, 20)
        Me.serv.TabIndex = 1
        Me.serv.Text = "WIN-9SMVGL48ODF"
        '
        'base
        '
        Me.base.Location = New System.Drawing.Point(9, 72)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(185, 20)
        Me.base.TabIndex = 2
        Me.base.Text = "Softcool"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.contraseña)
        Me.GroupBox1.Controls.Add(Me.usuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.base)
        Me.GroupBox1.Controls.Add(Me.btnconectar)
        Me.GroupBox1.Controls.Add(Me.serv)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 234)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conectar a base de datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usuario"
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(200, 146)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(184, 20)
        Me.contraseña.TabIndex = 6
        Me.contraseña.Text = "123"
        Me.contraseña.UseSystemPasswordChar = True
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(9, 146)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(185, 20)
        Me.usuario.TabIndex = 5
        Me.usuario.Text = "sa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Direccion de servidor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Base de datos"
        '
        'bdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 256)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bdd"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnconectar As System.Windows.Forms.Button
    Friend WithEvents serv As System.Windows.Forms.TextBox
    Friend WithEvents base As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents contraseña As System.Windows.Forms.TextBox
    Friend WithEvents usuario As System.Windows.Forms.TextBox
End Class
