<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_por_camara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listado_por_camara))
        Me.temp_x_camaraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftcoolDataSet = New softcool.SoftcoolDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.temp_x_camaraTableAdapter = New softcool.SoftcoolDataSetTableAdapters.temp_x_camaraTableAdapter()
        CType(Me.temp_x_camaraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'temp_x_camaraBindingSource
        '
        Me.temp_x_camaraBindingSource.DataMember = "temp_x_camara"
        Me.temp_x_camaraBindingSource.DataSource = Me.SoftcoolDataSet
        '
        'SoftcoolDataSet
        '
        Me.SoftcoolDataSet.DataSetName = "SoftcoolDataSet"
        Me.SoftcoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.temp_x_camaraBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "softcool.temperatura_x_camara.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(984, 661)
        Me.ReportViewer1.TabIndex = 0
        '
        'temp_x_camaraTableAdapter
        '
        Me.temp_x_camaraTableAdapter.ClearBeforeFill = True
        '
        'listado_por_camara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "listado_por_camara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listado_por_camara"
        CType(Me.temp_x_camaraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents temp_x_camaraBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoftcoolDataSet As softcool.SoftcoolDataSet
    Friend WithEvents temp_x_camaraTableAdapter As softcool.SoftcoolDataSetTableAdapters.temp_x_camaraTableAdapter
End Class
