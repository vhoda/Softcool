<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombre_usuario = New System.Windows.Forms.TextBox()
        Me.grilla_usuario = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grupo_que_hacer = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.eliminar = New System.Windows.Forms.RadioButton()
        Me.modificar = New System.Windows.Forms.RadioButton()
        Me.realizar = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.grupo_dato_usuario = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Buscar = New System.Windows.Forms.Button()
        CType(Me.grilla_usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_que_hacer.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_dato_usuario.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de usuario"
        '
        'nombre_usuario
        '
        Me.nombre_usuario.Location = New System.Drawing.Point(46, 51)
        Me.nombre_usuario.Name = "nombre_usuario"
        Me.nombre_usuario.Size = New System.Drawing.Size(201, 20)
        Me.nombre_usuario.TabIndex = 1
        '
        'grilla_usuario
        '
        Me.grilla_usuario.AllowUserToAddRows = False
        Me.grilla_usuario.AllowUserToDeleteRows = False
        Me.grilla_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_usuario.Location = New System.Drawing.Point(46, 94)
        Me.grilla_usuario.Name = "grilla_usuario"
        Me.grilla_usuario.ReadOnly = True
        Me.grilla_usuario.Size = New System.Drawing.Size(479, 150)
        Me.grilla_usuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Clave"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(369, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Estado"
        '
        'grupo_que_hacer
        '
        Me.grupo_que_hacer.Controls.Add(Me.PictureBox3)
        Me.grupo_que_hacer.Controls.Add(Me.PictureBox2)
        Me.grupo_que_hacer.Controls.Add(Me.eliminar)
        Me.grupo_que_hacer.Controls.Add(Me.modificar)
        Me.grupo_que_hacer.Location = New System.Drawing.Point(47, 250)
        Me.grupo_que_hacer.Name = "grupo_que_hacer"
        Me.grupo_que_hacer.Size = New System.Drawing.Size(292, 49)
        Me.grupo_que_hacer.TabIndex = 10
        Me.grupo_que_hacer.TabStop = False
        Me.grupo_que_hacer.Text = "Que desea hacer "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.softcool.My.Resources.Resources.eliminar
        Me.PictureBox3.Location = New System.Drawing.Point(229, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.softcool.My.Resources.Resources.editar
        Me.PictureBox2.Location = New System.Drawing.Point(81, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'eliminar
        '
        Me.eliminar.AutoSize = True
        Me.eliminar.Location = New System.Drawing.Point(162, 19)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(61, 17)
        Me.eliminar.TabIndex = 1
        Me.eliminar.TabStop = True
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.AutoSize = True
        Me.modificar.Location = New System.Drawing.Point(7, 20)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(68, 17)
        Me.modificar.TabIndex = 0
        Me.modificar.TabStop = True
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'realizar
        '
        Me.realizar.Location = New System.Drawing.Point(450, 264)
        Me.realizar.Name = "realizar"
        Me.realizar.Size = New System.Drawing.Size(75, 23)
        Me.realizar.TabIndex = 11
        Me.realizar.Text = "VER"
        Me.realizar.UseVisualStyleBackColor = True
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(21, 33)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 12
        '
        'apellido
        '
        Me.apellido.Location = New System.Drawing.Point(20, 73)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(100, 20)
        Me.apellido.TabIndex = 13
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(192, 33)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(100, 20)
        Me.usuario.TabIndex = 14
        '
        'clave
        '
        Me.clave.Location = New System.Drawing.Point(192, 72)
        Me.clave.Name = "clave"
        Me.clave.Size = New System.Drawing.Size(100, 20)
        Me.clave.TabIndex = 15
        '
        'grupo_dato_usuario
        '
        Me.grupo_dato_usuario.Controls.Add(Me.PictureBox4)
        Me.grupo_dato_usuario.Controls.Add(Me.tipo)
        Me.grupo_dato_usuario.Controls.Add(Me.estado)
        Me.grupo_dato_usuario.Controls.Add(Me.apellido)
        Me.grupo_dato_usuario.Controls.Add(Me.clave)
        Me.grupo_dato_usuario.Controls.Add(Me.nombre)
        Me.grupo_dato_usuario.Controls.Add(Me.usuario)
        Me.grupo_dato_usuario.Controls.Add(Me.Label6)
        Me.grupo_dato_usuario.Controls.Add(Me.Label3)
        Me.grupo_dato_usuario.Controls.Add(Me.Label7)
        Me.grupo_dato_usuario.Controls.Add(Me.Label2)
        Me.grupo_dato_usuario.Controls.Add(Me.Label4)
        Me.grupo_dato_usuario.Controls.Add(Me.Label5)
        Me.grupo_dato_usuario.Location = New System.Drawing.Point(47, 305)
        Me.grupo_dato_usuario.Name = "grupo_dato_usuario"
        Me.grupo_dato_usuario.Size = New System.Drawing.Size(478, 114)
        Me.grupo_dato_usuario.TabIndex = 18
        Me.grupo_dato_usuario.TabStop = False
        Me.grupo_dato_usuario.Text = "Editar datos del usuario"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.softcool.My.Resources.Resources.Lock
        Me.PictureBox4.Location = New System.Drawing.Point(298, 72)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox4.TabIndex = 19
        Me.PictureBox4.TabStop = False
        '
        'tipo
        '
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"admin", "operador", "adminbd"})
        Me.tipo.Location = New System.Drawing.Point(372, 33)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(100, 21)
        Me.tipo.TabIndex = 18
        '
        'estado
        '
        Me.estado.FormattingEnabled = True
        Me.estado.Items.AddRange(New Object() {"habilitado", "desabilitado"})
        Me.estado.Location = New System.Drawing.Point(372, 72)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(100, 21)
        Me.estado.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.softcool.My.Resources.Resources.lupa
        Me.PictureBox1.Location = New System.Drawing.Point(253, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(410, 47)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(115, 23)
        Me.Buscar.TabIndex = 3
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Eliminar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 432)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grupo_dato_usuario)
        Me.Controls.Add(Me.realizar)
        Me.Controls.Add(Me.grupo_que_hacer)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.grilla_usuario)
        Me.Controls.Add(Me.nombre_usuario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Eliminar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar usuario"
        CType(Me.grilla_usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_que_hacer.ResumeLayout(False)
        Me.grupo_que_hacer.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_dato_usuario.ResumeLayout(False)
        Me.grupo_dato_usuario.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nombre_usuario As System.Windows.Forms.TextBox
    Friend WithEvents grilla_usuario As System.Windows.Forms.DataGridView
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grupo_que_hacer As System.Windows.Forms.GroupBox
    Friend WithEvents eliminar As System.Windows.Forms.RadioButton
    Friend WithEvents modificar As System.Windows.Forms.RadioButton
    Friend WithEvents realizar As System.Windows.Forms.Button
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents apellido As System.Windows.Forms.TextBox
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents clave As System.Windows.Forms.TextBox
    Friend WithEvents grupo_dato_usuario As System.Windows.Forms.GroupBox
    Friend WithEvents estado As System.Windows.Forms.ComboBox
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
