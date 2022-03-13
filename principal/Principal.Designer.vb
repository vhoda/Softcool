<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivadorPuertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CamaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivadorBddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarBddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectarPuertoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nom_usuario = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.trabajando = New System.Windows.Forms.PictureBox()
        Me.iniciar = New System.Windows.Forms.Button()
        Me.progrespuerta = New System.Windows.Forms.ProgressBar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftcoolDataSet = New softcool.SoftcoolDataSet()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nivel_temperatura4 = New softcool.nivel_temperatura()
        Me.Nivel_temperatura3 = New softcool.nivel_temperatura()
        Me.Nivel_temperatura2 = New softcool.nivel_temperatura()
        Me.Nivel_temperatura1 = New softcool.nivel_temperatura()
        Me.Puerta = New System.Windows.Forms.TextBox()
        Me.Temp4 = New System.Windows.Forms.TextBox()
        Me.Temp3 = New System.Windows.Forms.TextBox()
        Me.Temp2 = New System.Windows.Forms.TextBox()
        Me.Temp1 = New System.Windows.Forms.TextBox()
        Me.Camara = New System.Windows.Forms.ComboBox()
        Me.CamaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conexion_prueba1 = New softcool.conexion()
        Me.CamaraBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CamaraBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CamaraTableAdapter = New softcool.conexionTableAdapters.camaraTableAdapter()
        Me.ProductoTableAdapter = New softcool.conexionTableAdapters.productoTableAdapter()
        Me.grabar = New System.Windows.Forms.Timer(Me.components)
        Me.CamaraTableAdapter1 = New softcool.SoftcoolDataSetTableAdapters.camaraTableAdapter()
        Me.ProductoTableAdapter1 = New softcool.SoftcoolDataSetTableAdapters.productoTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.trabajando, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Conexion_prueba1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamaraBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamaraBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.InformesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivadorPuertoToolStripMenuItem, Me.ActivadorBddToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AbrirToolStripMenuItem.Text = "&Archivo"
        '
        'ActivadorPuertoToolStripMenuItem
        '
        Me.ActivadorPuertoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.CamaraToolStripMenuItem, Me.TipoProductoToolStripMenuItem, Me.EmpresaToolStripMenuItem})
        Me.ActivadorPuertoToolStripMenuItem.Name = "ActivadorPuertoToolStripMenuItem"
        Me.ActivadorPuertoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActivadorPuertoToolStripMenuItem.Text = "&Nuevo"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsuarioToolStripMenuItem.Text = "&Usuario"
        '
        'CamaraToolStripMenuItem
        '
        Me.CamaraToolStripMenuItem.Name = "CamaraToolStripMenuItem"
        Me.CamaraToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CamaraToolStripMenuItem.Text = "&Camara"
        '
        'TipoProductoToolStripMenuItem
        '
        Me.TipoProductoToolStripMenuItem.Name = "TipoProductoToolStripMenuItem"
        Me.TipoProductoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TipoProductoToolStripMenuItem.Text = "&Tipo Producto"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ActivadorBddToolStripMenuItem
        '
        Me.ActivadorBddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConectarBddToolStripMenuItem, Me.ConectarPuertoToolStripMenuItem})
        Me.ActivadorBddToolStripMenuItem.Name = "ActivadorBddToolStripMenuItem"
        Me.ActivadorBddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ActivadorBddToolStripMenuItem.Text = "&Abrir"
        '
        'ConectarBddToolStripMenuItem
        '
        Me.ConectarBddToolStripMenuItem.Name = "ConectarBddToolStripMenuItem"
        Me.ConectarBddToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ConectarBddToolStripMenuItem.Text = "Conectar &Bdd"
        '
        'ConectarPuertoToolStripMenuItem
        '
        Me.ConectarPuertoToolStripMenuItem.Name = "ConectarPuertoToolStripMenuItem"
        Me.ConectarPuertoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ConectarPuertoToolStripMenuItem.Text = "Conectar &Puerto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nom_usuario)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.trabajando)
        Me.GroupBox1.Controls.Add(Me.iniciar)
        Me.GroupBox1.Controls.Add(Me.progrespuerta)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Nivel_temperatura4)
        Me.GroupBox1.Controls.Add(Me.Nivel_temperatura3)
        Me.GroupBox1.Controls.Add(Me.Nivel_temperatura2)
        Me.GroupBox1.Controls.Add(Me.Nivel_temperatura1)
        Me.GroupBox1.Controls.Add(Me.Puerta)
        Me.GroupBox1.Controls.Add(Me.Temp4)
        Me.GroupBox1.Controls.Add(Me.Temp3)
        Me.GroupBox1.Controls.Add(Me.Temp2)
        Me.GroupBox1.Controls.Add(Me.Temp1)
        Me.GroupBox1.Controls.Add(Me.Camara)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recopilador"
        '
        'nom_usuario
        '
        Me.nom_usuario.AutoSize = True
        Me.nom_usuario.Location = New System.Drawing.Point(502, 25)
        Me.nom_usuario.Name = "nom_usuario"
        Me.nom_usuario.Size = New System.Drawing.Size(10, 13)
        Me.nom_usuario.TabIndex = 22
        Me.nom_usuario.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(450, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Usuario:"
        '
        'trabajando
        '
        Me.trabajando.Image = Global.softcool.My.Resources.Resources.gears_anim
        Me.trabajando.Location = New System.Drawing.Point(449, 43)
        Me.trabajando.Name = "trabajando"
        Me.trabajando.Size = New System.Drawing.Size(172, 77)
        Me.trabajando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.trabajando.TabIndex = 20
        Me.trabajando.TabStop = False
        Me.trabajando.Visible = False
        '
        'iniciar
        '
        Me.iniciar.Location = New System.Drawing.Point(331, 132)
        Me.iniciar.Name = "iniciar"
        Me.iniciar.Size = New System.Drawing.Size(290, 47)
        Me.iniciar.TabIndex = 19
        Me.iniciar.Text = "Iniciar Captura"
        Me.iniciar.UseVisualStyleBackColor = True
        '
        'progrespuerta
        '
        Me.progrespuerta.Location = New System.Drawing.Point(330, 70)
        Me.progrespuerta.Name = "progrespuerta"
        Me.progrespuerta.Size = New System.Drawing.Size(113, 55)
        Me.progrespuerta.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductoBindingSource2, "tipo", True))
        Me.ComboBox1.DataSource = Me.ProductoBindingSource1
        Me.ComboBox1.DisplayMember = "tipo"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "tipo"
        '
        'ProductoBindingSource2
        '
        Me.ProductoBindingSource2.DataMember = "producto"
        Me.ProductoBindingSource2.DataSource = Me.SoftcoolDataSet
        '
        'SoftcoolDataSet
        '
        Me.SoftcoolDataSet.DataSetName = "SoftcoolDataSet"
        Me.SoftcoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "producto"
        Me.ProductoBindingSource1.DataSource = Me.SoftcoolDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Tipo Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Camara N°"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(330, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Estado Puerta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Temp 4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Temp 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Temp 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Temp 1"
        '
        'Nivel_temperatura4
        '
        Me.Nivel_temperatura4.Location = New System.Drawing.Point(281, 69)
        Me.Nivel_temperatura4.Name = "Nivel_temperatura4"
        Me.Nivel_temperatura4.Size = New System.Drawing.Size(43, 110)
        Me.Nivel_temperatura4.TabIndex = 9
        '
        'Nivel_temperatura3
        '
        Me.Nivel_temperatura3.Location = New System.Drawing.Point(232, 70)
        Me.Nivel_temperatura3.Name = "Nivel_temperatura3"
        Me.Nivel_temperatura3.Size = New System.Drawing.Size(43, 110)
        Me.Nivel_temperatura3.TabIndex = 8
        '
        'Nivel_temperatura2
        '
        Me.Nivel_temperatura2.Location = New System.Drawing.Point(183, 70)
        Me.Nivel_temperatura2.Name = "Nivel_temperatura2"
        Me.Nivel_temperatura2.Size = New System.Drawing.Size(43, 110)
        Me.Nivel_temperatura2.TabIndex = 7
        '
        'Nivel_temperatura1
        '
        Me.Nivel_temperatura1.Location = New System.Drawing.Point(133, 70)
        Me.Nivel_temperatura1.Name = "Nivel_temperatura1"
        Me.Nivel_temperatura1.Size = New System.Drawing.Size(44, 110)
        Me.Nivel_temperatura1.TabIndex = 6
        '
        'Puerta
        '
        Me.Puerta.Enabled = False
        Me.Puerta.Location = New System.Drawing.Point(330, 43)
        Me.Puerta.Name = "Puerta"
        Me.Puerta.Size = New System.Drawing.Size(113, 20)
        Me.Puerta.TabIndex = 5
        '
        'Temp4
        '
        Me.Temp4.Enabled = False
        Me.Temp4.Location = New System.Drawing.Point(281, 43)
        Me.Temp4.Name = "Temp4"
        Me.Temp4.Size = New System.Drawing.Size(43, 20)
        Me.Temp4.TabIndex = 4
        '
        'Temp3
        '
        Me.Temp3.Enabled = False
        Me.Temp3.Location = New System.Drawing.Point(232, 43)
        Me.Temp3.Name = "Temp3"
        Me.Temp3.Size = New System.Drawing.Size(43, 20)
        Me.Temp3.TabIndex = 3
        '
        'Temp2
        '
        Me.Temp2.Enabled = False
        Me.Temp2.Location = New System.Drawing.Point(183, 43)
        Me.Temp2.Name = "Temp2"
        Me.Temp2.Size = New System.Drawing.Size(43, 20)
        Me.Temp2.TabIndex = 2
        '
        'Temp1
        '
        Me.Temp1.Enabled = False
        Me.Temp1.Location = New System.Drawing.Point(133, 43)
        Me.Temp1.Name = "Temp1"
        Me.Temp1.Size = New System.Drawing.Size(44, 20)
        Me.Temp1.TabIndex = 1
        '
        'Camara
        '
        Me.Camara.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CamaraBindingSource, "id_camara", True))
        Me.Camara.DataSource = Me.CamaraBindingSource2
        Me.Camara.DisplayMember = "id_camara"
        Me.Camara.FormattingEnabled = True
        Me.Camara.Location = New System.Drawing.Point(6, 70)
        Me.Camara.Name = "Camara"
        Me.Camara.Size = New System.Drawing.Size(121, 21)
        Me.Camara.TabIndex = 0
        Me.Camara.ValueMember = "id_camara"
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
        'CamaraBindingSource2
        '
        Me.CamaraBindingSource2.DataMember = "camara"
        Me.CamaraBindingSource2.DataSource = Me.SoftcoolDataSet
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.Conexion_prueba1
        '
        'CamaraBindingSource1
        '
        Me.CamaraBindingSource1.DataMember = "camara"
        Me.CamaraBindingSource1.DataSource = Me.Conexion_prueba1
        '
        'grilla
        '
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(12, 225)
        Me.grilla.Name = "grilla"
        Me.grilla.Size = New System.Drawing.Size(852, 217)
        Me.grilla.TabIndex = 2
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(645, 27)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(219, 192)
        Me.AxShockwaveFlash1.TabIndex = 3
        Me.AxShockwaveFlash1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(653, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 4
        '
        'CamaraTableAdapter
        '
        Me.CamaraTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'grabar
        '
        Me.grabar.Interval = 10000
        '
        'CamaraTableAdapter1
        '
        Me.CamaraTableAdapter1.ClearBeforeFill = True
        '
        'ProductoTableAdapter1
        '
        Me.ProductoTableAdapter1.ClearBeforeFill = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 454)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Softcool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.trabajando, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Conexion_prueba1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamaraBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamaraBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActivadorPuertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Puerta As System.Windows.Forms.TextBox
    Friend WithEvents Temp4 As System.Windows.Forms.TextBox
    Friend WithEvents Temp3 As System.Windows.Forms.TextBox
    Friend WithEvents Temp2 As System.Windows.Forms.TextBox
    Friend WithEvents Temp1 As System.Windows.Forms.TextBox
    Friend WithEvents Camara As System.Windows.Forms.ComboBox
    Friend WithEvents Nivel_temperatura4 As softcool.nivel_temperatura
    Friend WithEvents Nivel_temperatura3 As softcool.nivel_temperatura
    Friend WithEvents Nivel_temperatura2 As softcool.nivel_temperatura
    Friend WithEvents Nivel_temperatura1 As softcool.nivel_temperatura
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents ActivadorBddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarBddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConectarPuertoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CamaraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents progrespuerta As System.Windows.Forms.ProgressBar
    Friend WithEvents Conexion_prueba1 As softcool.conexion
    Friend WithEvents CamaraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CamaraTableAdapter As softcool.conexionTableAdapters.camaraTableAdapter
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As softcool.conexionTableAdapters.productoTableAdapter
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents iniciar As System.Windows.Forms.Button
    Friend WithEvents grabar As System.Windows.Forms.Timer
    Friend WithEvents trabajando As System.Windows.Forms.PictureBox
    Friend WithEvents CamaraBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SoftcoolDataSet As softcool.SoftcoolDataSet
    Friend WithEvents CamaraBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CamaraTableAdapter1 As softcool.SoftcoolDataSetTableAdapters.camaraTableAdapter
    Friend WithEvents ProductoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter1 As softcool.SoftcoolDataSetTableAdapters.productoTableAdapter
    Friend WithEvents ProductoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents nom_usuario As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
