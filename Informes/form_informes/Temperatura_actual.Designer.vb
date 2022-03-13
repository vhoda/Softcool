<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Temperatura_actual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Temperatura_actual))
        Me.Ultimo_registro_tempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftcoolDataSet = New softcool.SoftcoolDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Ultimo_registro_tempTableAdapter = New softcool.SoftcoolDataSetTableAdapters.Ultimo_registro_tempTableAdapter()
        CType(Me.Ultimo_registro_tempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ultimo_registro_tempBindingSource
        '
        Me.Ultimo_registro_tempBindingSource.DataMember = "Ultimo_registro_temp"
        Me.Ultimo_registro_tempBindingSource.DataSource = Me.SoftcoolDataSet
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
        ReportDataSource1.Value = Me.Ultimo_registro_tempBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "softcool.temperatura_actu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(994, 671)
        Me.ReportViewer1.TabIndex = 0
        '
        'Ultimo_registro_tempTableAdapter
        '
        Me.Ultimo_registro_tempTableAdapter.ClearBeforeFill = True
        '
        'Temperatura_actual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 671)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Temperatura_actual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Temperatura_actual"
        CType(Me.Ultimo_registro_tempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftcoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Ultimo_registro_tempBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoftcoolDataSet As softcool.SoftcoolDataSet
    Friend WithEvents Ultimo_registro_tempTableAdapter As softcool.SoftcoolDataSetTableAdapters.Ultimo_registro_tempTableAdapter
End Class
