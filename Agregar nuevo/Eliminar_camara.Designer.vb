<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminarcamara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminarcamara))
        Me.numero_camara = New System.Windows.Forms.ComboBox()
        Me.CamaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conexion_prueba1 = New softcool.conexion()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.eliminar = New System.Windows.Forms.RadioButton()
        Me.modificar = New System.Windows.Forms.RadioButton()
        Me.grilla_eliminar = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CamaraTableAdapter = New softcool.conexionTableAdapters.camaraTableAdapter()
        Me.datos_a_modificar = New System.Windows.Forms.GroupBox()
        Me.estado_camara = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tipo_camara = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c_numero_camara = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.realizar = New System.Windows.Forms.Button()
        CType(Me.CamaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conexion_prueba1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datos_a_modificar.SuspendLayout()
        Me.SuspendLayout()
        '
        'numero_camara
        '
        Me.numero_camara.DataSource = Me.CamaraBindingSource
        Me.numero_camara.DisplayMember = "id_camara"
        Me.numero_camara.FormattingEnabled = True
        Me.numero_camara.Location = New System.Drawing.Point(29, 53)
        Me.numero_camara.Name = "numero_camara"
        Me.numero_camara.Size = New System.Drawing.Size(121, 21)
        Me.numero_camara.TabIndex = 0
        Me.numero_camara.ValueMember = "id_camara"
        '
        'CamaraBindingSource
        '
        Me.CamaraBindingSource.DataMember = "camara"
        Me.CamaraBindingSource.DataSource = Me.Conexion_prueba1
        '
        'Conexion_prueba1
        '
        Me.Conexion_prueba1.DataSetName = "conexion_prueba1"
        Me.Conexion_prueba1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero de la camara"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Location = New System.Drawing.Point(165, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 49)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.softcool.My.Resources.Resources.eliminar
        Me.PictureBox2.Location = New System.Drawing.Point(198, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.softcool.My.Resources.Resources.editar
        Me.PictureBox1.Location = New System.Drawing.Point(82, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'eliminar
        '
        Me.eliminar.AutoSize = True
        Me.eliminar.Location = New System.Drawing.Point(139, 22)
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
        Me.modificar.Location = New System.Drawing.Point(6, 22)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(70, 17)
        Me.modificar.TabIndex = 0
        Me.modificar.TabStop = True
        Me.modificar.Text = "Ver datos"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'grilla_eliminar
        '
        Me.grilla_eliminar.AllowUserToAddRows = False
        Me.grilla_eliminar.AllowUserToDeleteRows = False
        Me.grilla_eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_eliminar.Location = New System.Drawing.Point(29, 114)
        Me.grilla_eliminar.Name = "grilla_eliminar"
        Me.grilla_eliminar.ReadOnly = True
        Me.grilla_eliminar.Size = New System.Drawing.Size(491, 116)
        Me.grilla_eliminar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Edite los datos de la camara seleeccionada"
        '
        'CamaraTableAdapter
        '
        Me.CamaraTableAdapter.ClearBeforeFill = True
        '
        'datos_a_modificar
        '
        Me.datos_a_modificar.Controls.Add(Me.estado_camara)
        Me.datos_a_modificar.Controls.Add(Me.Label5)
        Me.datos_a_modificar.Controls.Add(Me.tipo_camara)
        Me.datos_a_modificar.Controls.Add(Me.Label4)
        Me.datos_a_modificar.Controls.Add(Me.c_numero_camara)
        Me.datos_a_modificar.Controls.Add(Me.label3)
        Me.datos_a_modificar.Location = New System.Drawing.Point(29, 237)
        Me.datos_a_modificar.Name = "datos_a_modificar"
        Me.datos_a_modificar.Size = New System.Drawing.Size(491, 86)
        Me.datos_a_modificar.TabIndex = 6
        Me.datos_a_modificar.TabStop = False
        Me.datos_a_modificar.Text = "Datos para ser modificados"
        '
        'estado_camara
        '
        Me.estado_camara.FormattingEnabled = True
        Me.estado_camara.Items.AddRange(New Object() {"desabilitada", "habilitada"})
        Me.estado_camara.Location = New System.Drawing.Point(355, 49)
        Me.estado_camara.Name = "estado_camara"
        Me.estado_camara.Size = New System.Drawing.Size(112, 21)
        Me.estado_camara.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado de la camara"
        '
        'tipo_camara
        '
        Me.tipo_camara.Location = New System.Drawing.Point(189, 49)
        Me.tipo_camara.Name = "tipo_camara"
        Me.tipo_camara.Size = New System.Drawing.Size(112, 20)
        Me.tipo_camara.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de camara"
        '
        'c_numero_camara
        '
        Me.c_numero_camara.Enabled = False
        Me.c_numero_camara.Location = New System.Drawing.Point(9, 51)
        Me.c_numero_camara.Name = "c_numero_camara"
        Me.c_numero_camara.Size = New System.Drawing.Size(112, 20)
        Me.c_numero_camara.TabIndex = 1
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 34)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Id camara"
        '
        'realizar
        '
        Me.realizar.Enabled = False
        Me.realizar.Location = New System.Drawing.Point(411, 44)
        Me.realizar.Name = "realizar"
        Me.realizar.Size = New System.Drawing.Size(109, 37)
        Me.realizar.TabIndex = 7
        Me.realizar.Text = "actualizar"
        Me.realizar.UseVisualStyleBackColor = True
        '
        'Eliminarcamara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 347)
        Me.Controls.Add(Me.realizar)
        Me.Controls.Add(Me.datos_a_modificar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grilla_eliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numero_camara)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Eliminarcamara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar camara"
        CType(Me.CamaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conexion_prueba1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datos_a_modificar.ResumeLayout(False)
        Me.datos_a_modificar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numero_camara As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents eliminar As System.Windows.Forms.RadioButton
    Friend WithEvents modificar As System.Windows.Forms.RadioButton
    Friend WithEvents grilla_eliminar As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Conexion_prueba1 As softcool.conexion
    Friend WithEvents CamaraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CamaraTableAdapter As softcool.conexionTableAdapters.camaraTableAdapter
    Friend WithEvents datos_a_modificar As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tipo_camara As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c_numero_camara As System.Windows.Forms.TextBox
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents realizar As System.Windows.Forms.Button
    Friend WithEvents estado_camara As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
