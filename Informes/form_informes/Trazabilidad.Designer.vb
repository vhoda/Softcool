<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trazabilidad
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trazabilidad))
        Me.TrazabilidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftcoolDataSet = New softcool.SoftcoolDataSet()
        Me.cod_producto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TrazabilidadTableAdapter = New softcool.SoftcoolDataSetTableAdapters.TrazabilidadTableAdapter()
        CType(Me.TrazabilidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrazabilidadBindingSource
        '
        Me.TrazabilidadBindingSource.DataMember = "Trazabilidad"
        Me.TrazabilidadBindingSource.DataSource = Me.SoftcoolDataSet
        '
        'SoftcoolDataSet
        '
        Me.SoftcoolDataSet.DataSetName = "SoftcoolDataSet"
        Me.SoftcoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cod_producto
        '
        Me.cod_producto.Location = New System.Drawing.Point(91, 49)
        Me.cod_producto.Name = "cod_producto"
        Me.cod_producto.Size = New System.Drawing.Size(209, 20)
        Me.cod_producto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo de producto"
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(320, 46)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 2
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cod_producto)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 111)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trazabilidad del siguiente producto:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TrazabilidadBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "softcool.Trazabilidad.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 129)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(970, 530)
        Me.ReportViewer1.TabIndex = 1
        '
        'TrazabilidadTableAdapter
        '
        Me.TrazabilidadTableAdapter.ClearBeforeFill = True
        '
        'Trazabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 671)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Trazabilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trazabilidad"
        CType(Me.TrazabilidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cod_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TrazabilidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoftcoolDataSet As softcool.SoftcoolDataSet
    Friend WithEvents TrazabilidadTableAdapter As softcool.SoftcoolDataSetTableAdapters.TrazabilidadTableAdapter
End Class
