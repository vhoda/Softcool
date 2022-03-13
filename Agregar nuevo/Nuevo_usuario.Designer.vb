<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.usuario = New System.Windows.Forms.TextBox()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.link_modificar_usuario = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rut_empresa = New System.Windows.Forms.ComboBox()
        Me.EmpresaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Empresa = New softcool.empresa()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New softcool.empresaTableAdapters.empresaTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Clave"
        '
        'tipo
        '
        Me.tipo.DisplayMember = "tipo"
        Me.tipo.FormattingEnabled = True
        Me.tipo.Items.AddRange(New Object() {"admindb", "operador", "admin"})
        Me.tipo.Location = New System.Drawing.Point(117, 191)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(141, 21)
        Me.tipo.TabIndex = 4
        Me.tipo.ValueMember = "tipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tipo"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(117, 87)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(141, 20)
        Me.nombre.TabIndex = 0
        '
        'apellido
        '
        Me.apellido.Location = New System.Drawing.Point(117, 113)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(141, 20)
        Me.apellido.TabIndex = 1
        '
        'usuario
        '
        Me.usuario.Location = New System.Drawing.Point(117, 139)
        Me.usuario.Name = "usuario"
        Me.usuario.Size = New System.Drawing.Size(141, 20)
        Me.usuario.TabIndex = 2
        '
        'clave
        '
        Me.clave.Location = New System.Drawing.Point(117, 165)
        Me.clave.Name = "clave"
        Me.clave.Size = New System.Drawing.Size(141, 20)
        Me.clave.TabIndex = 3
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(25, 296)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(233, 40)
        Me.Agregar.TabIndex = 5
        Me.Agregar.Text = "Agregar Usuario"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'link_modificar_usuario
        '
        Me.link_modificar_usuario.AutoSize = True
        Me.link_modificar_usuario.Location = New System.Drawing.Point(184, 9)
        Me.link_modificar_usuario.Name = "link_modificar_usuario"
        Me.link_modificar_usuario.Size = New System.Drawing.Size(87, 13)
        Me.link_modificar_usuario.TabIndex = 6
        Me.link_modificar_usuario.TabStop = True
        Me.link_modificar_usuario.Text = "Modificar usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Rut empresa"
        '
        'rut_empresa
        '
        Me.rut_empresa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmpresaBindingSource1, "rut_empresa", True))
        Me.rut_empresa.DataSource = Me.EmpresaBindingSource
        Me.rut_empresa.DisplayMember = "rut_empresa"
        Me.rut_empresa.FormattingEnabled = True
        Me.rut_empresa.Location = New System.Drawing.Point(117, 219)
        Me.rut_empresa.Name = "rut_empresa"
        Me.rut_empresa.Size = New System.Drawing.Size(141, 21)
        Me.rut_empresa.TabIndex = 9
        Me.rut_empresa.ValueMember = "rut_empresa"
        '
        'EmpresaBindingSource1
        '
        Me.EmpresaBindingSource1.DataMember = "empresa"
        Me.EmpresaBindingSource1.DataSource = Me.Empresa
        '
        'Empresa
        '
        Me.Empresa.DataSetName = "empresa"
        Me.Empresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.Empresa
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'Agregar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 348)
        Me.Controls.Add(Me.rut_empresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.link_modificar_usuario)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.clave)
        Me.Controls.Add(Me.usuario)
        Me.Controls.Add(Me.apellido)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Agregar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar usuario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents apellido As System.Windows.Forms.TextBox
    Friend WithEvents usuario As System.Windows.Forms.TextBox
    Friend WithEvents clave As System.Windows.Forms.TextBox
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents link_modificar_usuario As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rut_empresa As System.Windows.Forms.ComboBox
    Friend WithEvents Empresa As softcool.empresa
    Friend WithEvents EmpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresaTableAdapter As softcool.empresaTableAdapters.empresaTableAdapter
    Friend WithEvents EmpresaBindingSource1 As System.Windows.Forms.BindingSource
End Class
