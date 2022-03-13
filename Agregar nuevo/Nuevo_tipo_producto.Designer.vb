<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevo_tipo_producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo_tipo_producto))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numero_camara = New System.Windows.Forms.ComboBox()
        Me.CamaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conexion_prueba1 = New softcool.conexion()
        Me.numeric = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grupo_estado_ingreso = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.foto3 = New System.Windows.Forms.PictureBox()
        Me.foto2 = New System.Windows.Forms.PictureBox()
        Me.foto1 = New System.Windows.Forms.PictureBox()
        Me.malo = New System.Windows.Forms.RadioButton()
        Me.medio = New System.Windows.Forms.RadioButton()
        Me.bueno = New System.Windows.Forms.RadioButton()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cofigo_del_producto = New System.Windows.Forms.TextBox()
        Me.agregar_producto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tipo_producto = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New softcool.conexionTableAdapters.productoTableAdapter()
        Me.CamaraTableAdapter = New softcool.conexionTableAdapters.camaraTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.camara_de_tipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Estado_de_proceso = New System.Windows.Forms.TextBox()
        Me.finalizar_proceso = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.CamaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conexion_prueba1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_estado_ingreso.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Camara"
        '
        'numero_camara
        '
        Me.numero_camara.DataSource = Me.CamaraBindingSource
        Me.numero_camara.DisplayMember = "id_camara"
        Me.numero_camara.FormattingEnabled = True
        Me.numero_camara.Location = New System.Drawing.Point(169, 45)
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
        'numeric
        '
        Me.numeric.Location = New System.Drawing.Point(169, 151)
        Me.numeric.Minimum = New Decimal(New Integer() {55, 0, 0, -2147483648})
        Me.numeric.Name = "numeric"
        Me.numeric.Size = New System.Drawing.Size(121, 20)
        Me.numeric.TabIndex = 2
        Me.numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Temperatura ideal"
        '
        'grupo_estado_ingreso
        '
        Me.grupo_estado_ingreso.Controls.Add(Me.PictureBox4)
        Me.grupo_estado_ingreso.Controls.Add(Me.PictureBox3)
        Me.grupo_estado_ingreso.Controls.Add(Me.foto3)
        Me.grupo_estado_ingreso.Controls.Add(Me.foto2)
        Me.grupo_estado_ingreso.Controls.Add(Me.foto1)
        Me.grupo_estado_ingreso.Controls.Add(Me.malo)
        Me.grupo_estado_ingreso.Controls.Add(Me.medio)
        Me.grupo_estado_ingreso.Controls.Add(Me.bueno)
        Me.grupo_estado_ingreso.Location = New System.Drawing.Point(36, 195)
        Me.grupo_estado_ingreso.Name = "grupo_estado_ingreso"
        Me.grupo_estado_ingreso.Size = New System.Drawing.Size(295, 114)
        Me.grupo_estado_ingreso.TabIndex = 4
        Me.grupo_estado_ingreso.TabStop = False
        Me.grupo_estado_ingreso.Text = "Estado de ingreso"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.softcool.My.Resources.Resources.eliminar
        Me.PictureBox4.Location = New System.Drawing.Point(220, 82)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(34, 25)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.softcool.My.Resources.Resources.Bueno_verde
        Me.PictureBox3.Location = New System.Drawing.Point(220, 11)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(34, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'foto3
        '
        Me.foto3.Image = Global.softcool.My.Resources.Resources.Anchoa
        Me.foto3.Location = New System.Drawing.Point(7, 19)
        Me.foto3.Name = "foto3"
        Me.foto3.Size = New System.Drawing.Size(123, 89)
        Me.foto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.foto3.TabIndex = 5
        Me.foto3.TabStop = False
        '
        'foto2
        '
        Me.foto2.Image = Global.softcool.My.Resources.Resources.manzana_verde
        Me.foto2.Location = New System.Drawing.Point(6, 19)
        Me.foto2.Name = "foto2"
        Me.foto2.Size = New System.Drawing.Size(124, 74)
        Me.foto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.foto2.TabIndex = 4
        Me.foto2.TabStop = False
        '
        'foto1
        '
        Me.foto1.Image = Global.softcool.My.Resources.Resources.cutlet_icon
        Me.foto1.Location = New System.Drawing.Point(6, 19)
        Me.foto1.Name = "foto1"
        Me.foto1.Size = New System.Drawing.Size(124, 74)
        Me.foto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.foto1.TabIndex = 3
        Me.foto1.TabStop = False
        '
        'malo
        '
        Me.malo.AutoSize = True
        Me.malo.Location = New System.Drawing.Point(158, 91)
        Me.malo.Name = "malo"
        Me.malo.Size = New System.Drawing.Size(48, 17)
        Me.malo.TabIndex = 2
        Me.malo.TabStop = True
        Me.malo.Text = "Malo"
        Me.malo.UseVisualStyleBackColor = True
        '
        'medio
        '
        Me.medio.AutoSize = True
        Me.medio.Location = New System.Drawing.Point(158, 55)
        Me.medio.Name = "medio"
        Me.medio.Size = New System.Drawing.Size(54, 17)
        Me.medio.TabIndex = 1
        Me.medio.TabStop = True
        Me.medio.Text = "Medio"
        Me.medio.UseVisualStyleBackColor = True
        '
        'bueno
        '
        Me.bueno.AutoSize = True
        Me.bueno.Location = New System.Drawing.Point(158, 19)
        Me.bueno.Name = "bueno"
        Me.bueno.Size = New System.Drawing.Size(56, 17)
        Me.bueno.TabIndex = 0
        Me.bueno.TabStop = True
        Me.bueno.Text = "Bueno"
        Me.bueno.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(33, 326)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(85, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Codigo producto"
        '
        'cofigo_del_producto
        '
        Me.cofigo_del_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cofigo_del_producto.Location = New System.Drawing.Point(149, 315)
        Me.cofigo_del_producto.Name = "cofigo_del_producto"
        Me.cofigo_del_producto.Size = New System.Drawing.Size(182, 29)
        Me.cofigo_del_producto.TabIndex = 3
        '
        'agregar_producto
        '
        Me.agregar_producto.Location = New System.Drawing.Point(35, 363)
        Me.agregar_producto.Name = "agregar_producto"
        Me.agregar_producto.Size = New System.Drawing.Size(296, 41)
        Me.agregar_producto.TabIndex = 4
        Me.agregar_producto.Text = "Agregar"
        Me.agregar_producto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo producto"
        '
        'tipo_producto
        '
        Me.tipo_producto.DataSource = Me.ProductoBindingSource
        Me.tipo_producto.DisplayMember = "tipo"
        Me.tipo_producto.FormattingEnabled = True
        Me.tipo_producto.Location = New System.Drawing.Point(169, 124)
        Me.tipo_producto.Name = "tipo_producto"
        Me.tipo_producto.Size = New System.Drawing.Size(121, 21)
        Me.tipo_producto.TabIndex = 1
        Me.tipo_producto.ValueMember = "tipo"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.Conexion_prueba1
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'CamaraTableAdapter
        '
        Me.CamaraTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Camara de tipo"
        '
        'camara_de_tipo
        '
        Me.camara_de_tipo.Enabled = False
        Me.camara_de_tipo.Location = New System.Drawing.Point(169, 72)
        Me.camara_de_tipo.Name = "camara_de_tipo"
        Me.camara_de_tipo.Size = New System.Drawing.Size(121, 20)
        Me.camara_de_tipo.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estado de proceso"
        '
        'Estado_de_proceso
        '
        Me.Estado_de_proceso.Enabled = False
        Me.Estado_de_proceso.Location = New System.Drawing.Point(169, 98)
        Me.Estado_de_proceso.Name = "Estado_de_proceso"
        Me.Estado_de_proceso.Size = New System.Drawing.Size(121, 20)
        Me.Estado_de_proceso.TabIndex = 12
        '
        'finalizar_proceso
        '
        Me.finalizar_proceso.AutoSize = True
        Me.finalizar_proceso.Location = New System.Drawing.Point(190, 9)
        Me.finalizar_proceso.Name = "finalizar_proceso"
        Me.finalizar_proceso.Size = New System.Drawing.Size(146, 13)
        Me.finalizar_proceso.TabIndex = 13
        Me.finalizar_proceso.TabStop = True
        Me.finalizar_proceso.Text = "Finalizar proceso de producto"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.softcool.My.Resources.Resources.conversor_temperatura
        Me.PictureBox1.Location = New System.Drawing.Point(296, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.softcool.My.Resources.Resources.procesos
        Me.PictureBox2.Location = New System.Drawing.Point(299, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Nuevo_tipo_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 428)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.finalizar_proceso)
        Me.Controls.Add(Me.Estado_de_proceso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.camara_de_tipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tipo_producto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.agregar_producto)
        Me.Controls.Add(Me.cofigo_del_producto)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.grupo_estado_ingreso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numeric)
        Me.Controls.Add(Me.numero_camara)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Nuevo_tipo_producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo producto"
        CType(Me.CamaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conexion_prueba1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_estado_ingreso.ResumeLayout(False)
        Me.grupo_estado_ingreso.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numero_camara As System.Windows.Forms.ComboBox
    Friend WithEvents numeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grupo_estado_ingreso As System.Windows.Forms.GroupBox
    Friend WithEvents malo As System.Windows.Forms.RadioButton
    Friend WithEvents medio As System.Windows.Forms.RadioButton
    Friend WithEvents bueno As System.Windows.Forms.RadioButton
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents cofigo_del_producto As System.Windows.Forms.TextBox
    Friend WithEvents agregar_producto As System.Windows.Forms.Button
    Friend WithEvents foto1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tipo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents foto2 As System.Windows.Forms.PictureBox
    Friend WithEvents foto3 As System.Windows.Forms.PictureBox
    Friend WithEvents Conexion_prueba1 As softcool.conexion
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As softcool.conexionTableAdapters.productoTableAdapter
    Friend WithEvents CamaraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CamaraTableAdapter As softcool.conexionTableAdapters.camaraTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents camara_de_tipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Estado_de_proceso As System.Windows.Forms.TextBox
    Friend WithEvents finalizar_proceso As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
