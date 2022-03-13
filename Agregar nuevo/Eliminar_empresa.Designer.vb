<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eliminar_empresa))
        Me.data = New System.Windows.Forms.DataGridView()
        Me.RutempresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreempresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionempresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoempresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datos_empresa = New softcool.datos_empresa()
        Me.EmpresaTableAdapter = New softcool.datos_empresaTableAdapters.empresaTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rut = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.modi = New System.Windows.Forms.GroupBox()
        CType(Me.data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datos_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.modi.SuspendLayout()
        Me.SuspendLayout()
        '
        'data
        '
        Me.data.AllowUserToAddRows = False
        Me.data.AllowUserToDeleteRows = False
        Me.data.AutoGenerateColumns = False
        Me.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RutempresaDataGridViewTextBoxColumn, Me.NombreempresaDataGridViewTextBoxColumn, Me.DireccionempresaDataGridViewTextBoxColumn, Me.EstadoempresaDataGridViewTextBoxColumn})
        Me.data.DataSource = Me.EmpresaBindingSource
        resources.ApplyResources(Me.data, "data")
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'RutempresaDataGridViewTextBoxColumn
        '
        Me.RutempresaDataGridViewTextBoxColumn.DataPropertyName = "rut_empresa"
        resources.ApplyResources(Me.RutempresaDataGridViewTextBoxColumn, "RutempresaDataGridViewTextBoxColumn")
        Me.RutempresaDataGridViewTextBoxColumn.Name = "RutempresaDataGridViewTextBoxColumn"
        Me.RutempresaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreempresaDataGridViewTextBoxColumn
        '
        Me.NombreempresaDataGridViewTextBoxColumn.DataPropertyName = "nombre_empresa"
        resources.ApplyResources(Me.NombreempresaDataGridViewTextBoxColumn, "NombreempresaDataGridViewTextBoxColumn")
        Me.NombreempresaDataGridViewTextBoxColumn.Name = "NombreempresaDataGridViewTextBoxColumn"
        Me.NombreempresaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionempresaDataGridViewTextBoxColumn
        '
        Me.DireccionempresaDataGridViewTextBoxColumn.DataPropertyName = "direccion_empresa"
        resources.ApplyResources(Me.DireccionempresaDataGridViewTextBoxColumn, "DireccionempresaDataGridViewTextBoxColumn")
        Me.DireccionempresaDataGridViewTextBoxColumn.Name = "DireccionempresaDataGridViewTextBoxColumn"
        Me.DireccionempresaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoempresaDataGridViewTextBoxColumn
        '
        Me.EstadoempresaDataGridViewTextBoxColumn.DataPropertyName = "estado_empresa"
        resources.ApplyResources(Me.EstadoempresaDataGridViewTextBoxColumn, "EstadoempresaDataGridViewTextBoxColumn")
        Me.EstadoempresaDataGridViewTextBoxColumn.Name = "EstadoempresaDataGridViewTextBoxColumn"
        Me.EstadoempresaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.Datos_empresa
        '
        'Datos_empresa
        '
        Me.Datos_empresa.DataSetName = "datos_empresa"
        Me.Datos_empresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'rut
        '
        resources.ApplyResources(Me.rut, "rut")
        Me.rut.Name = "rut"
        '
        'nombre
        '
        resources.ApplyResources(Me.nombre, "nombre")
        Me.nombre.Name = "nombre"
        '
        'direccion
        '
        resources.ApplyResources(Me.direccion, "direccion")
        Me.direccion.Name = "direccion"
        '
        'Actualizar
        '
        resources.ApplyResources(Me.Actualizar, "Actualizar")
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'estado
        '
        Me.estado.FormattingEnabled = True
        Me.estado.Items.AddRange(New Object() {resources.GetString("estado.Items"), resources.GetString("estado.Items1")})
        resources.ApplyResources(Me.estado, "estado")
        Me.estado.Name = "estado"
        '
        'modi
        '
        Me.modi.Controls.Add(Me.Actualizar)
        Me.modi.Controls.Add(Me.Label1)
        Me.modi.Controls.Add(Me.Label2)
        Me.modi.Controls.Add(Me.Label3)
        Me.modi.Controls.Add(Me.Label4)
        Me.modi.Controls.Add(Me.rut)
        Me.modi.Controls.Add(Me.nombre)
        Me.modi.Controls.Add(Me.direccion)
        Me.modi.Controls.Add(Me.estado)
        resources.ApplyResources(Me.modi, "modi")
        Me.modi.Name = "modi"
        Me.modi.TabStop = False
        '
        'Eliminar_empresa
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.modi)
        Me.Controls.Add(Me.data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Eliminar_empresa"
        CType(Me.data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datos_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.modi.ResumeLayout(False)
        Me.modi.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents data As System.Windows.Forms.DataGridView
    Friend WithEvents Datos_empresa As softcool.datos_empresa
    Friend WithEvents EmpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresaTableAdapter As softcool.datos_empresaTableAdapters.empresaTableAdapter
    Friend WithEvents RutempresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreempresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionempresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoempresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rut As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents Actualizar As System.Windows.Forms.Button
    Friend WithEvents estado As System.Windows.Forms.ComboBox
    Friend WithEvents modi As System.Windows.Forms.GroupBox
End Class
