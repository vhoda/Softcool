<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Informes))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.listado_x_camara = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Trazabili = New System.Windows.Forms.RadioButton()
        Me.temp_product_y_cam = New System.Windows.Forms.RadioButton()
        Me.Graficas_rendimiento_camara = New System.Windows.Forms.RadioButton()
        Me.Temp_actual = New System.Windows.Forms.RadioButton()
        Me.temp_prome_por_camara = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(335, 30)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 6
        Me.MonthCalendar1.Visible = False
        '
        'listado_x_camara
        '
        Me.listado_x_camara.AutoSize = True
        Me.listado_x_camara.Location = New System.Drawing.Point(22, 59)
        Me.listado_x_camara.Name = "listado_x_camara"
        Me.listado_x_camara.Size = New System.Drawing.Size(115, 17)
        Me.listado_x_camara.TabIndex = 8
        Me.listado_x_camara.TabStop = True
        Me.listado_x_camara.Text = "Listado por camara"
        Me.listado_x_camara.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Trazabili)
        Me.GroupBox1.Controls.Add(Me.temp_product_y_cam)
        Me.GroupBox1.Controls.Add(Me.Graficas_rendimiento_camara)
        Me.GroupBox1.Controls.Add(Me.Temp_actual)
        Me.GroupBox1.Controls.Add(Me.temp_prome_por_camara)
        Me.GroupBox1.Controls.Add(Me.listado_x_camara)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 180)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione tipo de informe "
        '
        'Trazabili
        '
        Me.Trazabili.AutoSize = True
        Me.Trazabili.Location = New System.Drawing.Point(22, 151)
        Me.Trazabili.Name = "Trazabili"
        Me.Trazabili.Size = New System.Drawing.Size(82, 17)
        Me.Trazabili.TabIndex = 10
        Me.Trazabili.TabStop = True
        Me.Trazabili.Text = "Trazabilidad"
        Me.Trazabili.UseVisualStyleBackColor = True
        '
        'temp_product_y_cam
        '
        Me.temp_product_y_cam.AutoSize = True
        Me.temp_product_y_cam.Location = New System.Drawing.Point(22, 105)
        Me.temp_product_y_cam.Name = "temp_product_y_cam"
        Me.temp_product_y_cam.Size = New System.Drawing.Size(243, 17)
        Me.temp_product_y_cam.TabIndex = 12
        Me.temp_product_y_cam.TabStop = True
        Me.temp_product_y_cam.Text = "Temperatura promedio  por producto y camara"
        Me.temp_product_y_cam.UseVisualStyleBackColor = True
        '
        'Graficas_rendimiento_camara
        '
        Me.Graficas_rendimiento_camara.AutoSize = True
        Me.Graficas_rendimiento_camara.Location = New System.Drawing.Point(22, 128)
        Me.Graficas_rendimiento_camara.Name = "Graficas_rendimiento_camara"
        Me.Graficas_rendimiento_camara.Size = New System.Drawing.Size(187, 17)
        Me.Graficas_rendimiento_camara.TabIndex = 11
        Me.Graficas_rendimiento_camara.TabStop = True
        Me.Graficas_rendimiento_camara.Text = "Grafias de desempeño por camara"
        Me.Graficas_rendimiento_camara.UseVisualStyleBackColor = True
        '
        'Temp_actual
        '
        Me.Temp_actual.AutoSize = True
        Me.Temp_actual.Location = New System.Drawing.Point(22, 36)
        Me.Temp_actual.Name = "Temp_actual"
        Me.Temp_actual.Size = New System.Drawing.Size(117, 17)
        Me.Temp_actual.TabIndex = 10
        Me.Temp_actual.TabStop = True
        Me.Temp_actual.Text = "Temperatura actual"
        Me.Temp_actual.UseVisualStyleBackColor = True
        '
        'temp_prome_por_camara
        '
        Me.temp_prome_por_camara.AutoSize = True
        Me.temp_prome_por_camara.Location = New System.Drawing.Point(22, 82)
        Me.temp_prome_por_camara.Name = "temp_prome_por_camara"
        Me.temp_prome_por_camara.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.temp_prome_por_camara.Size = New System.Drawing.Size(162, 17)
        Me.temp_prome_por_camara.TabIndex = 9
        Me.temp_prome_por_camara.TabStop = True
        Me.temp_prome_por_camara.Text = "Informe promedio por camara"
        Me.temp_prome_por_camara.UseVisualStyleBackColor = True
        '
        'Informes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 210)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Informes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents listado_x_camara As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents temp_product_y_cam As System.Windows.Forms.RadioButton
    Friend WithEvents Graficas_rendimiento_camara As System.Windows.Forms.RadioButton
    Friend WithEvents Temp_actual As System.Windows.Forms.RadioButton
    Friend WithEvents temp_prome_por_camara As System.Windows.Forms.RadioButton
    Friend WithEvents Trazabili As System.Windows.Forms.RadioButton
End Class
