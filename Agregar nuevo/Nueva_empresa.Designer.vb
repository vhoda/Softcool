<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nueva_empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nueva_empresa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rut_empresa = New System.Windows.Forms.TextBox()
        Me.nombre_empresa = New System.Windows.Forms.TextBox()
        Me.direccion_empresa = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.agregar_empresa = New System.Windows.Forms.Button()
        Me.link_eliminar_empresa = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut empresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección empresa"
        '
        'rut_empresa
        '
        Me.rut_empresa.Location = New System.Drawing.Point(135, 96)
        Me.rut_empresa.Name = "rut_empresa"
        Me.rut_empresa.Size = New System.Drawing.Size(190, 20)
        Me.rut_empresa.TabIndex = 4
        '
        'nombre_empresa
        '
        Me.nombre_empresa.Location = New System.Drawing.Point(135, 122)
        Me.nombre_empresa.Name = "nombre_empresa"
        Me.nombre_empresa.Size = New System.Drawing.Size(190, 20)
        Me.nombre_empresa.TabIndex = 5
        '
        'direccion_empresa
        '
        Me.direccion_empresa.Location = New System.Drawing.Point(135, 148)
        Me.direccion_empresa.Name = "direccion_empresa"
        Me.direccion_empresa.Size = New System.Drawing.Size(190, 20)
        Me.direccion_empresa.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.softcool.My.Resources.Resources.empresa
        Me.PictureBox1.Location = New System.Drawing.Point(37, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'agregar_empresa
        '
        Me.agregar_empresa.Location = New System.Drawing.Point(135, 190)
        Me.agregar_empresa.Name = "agregar_empresa"
        Me.agregar_empresa.Size = New System.Drawing.Size(190, 37)
        Me.agregar_empresa.TabIndex = 8
        Me.agregar_empresa.Text = "Agregar empresa"
        Me.agregar_empresa.UseVisualStyleBackColor = True
        '
        'link_eliminar_empresa
        '
        Me.link_eliminar_empresa.AutoSize = True
        Me.link_eliminar_empresa.Location = New System.Drawing.Point(255, 9)
        Me.link_eliminar_empresa.Name = "link_eliminar_empresa"
        Me.link_eliminar_empresa.Size = New System.Drawing.Size(86, 13)
        Me.link_eliminar_empresa.TabIndex = 9
        Me.link_eliminar_empresa.TabStop = True
        Me.link_eliminar_empresa.Text = "Eliminar empresa"
        '
        'Nueva_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 252)
        Me.Controls.Add(Me.link_eliminar_empresa)
        Me.Controls.Add(Me.agregar_empresa)
        Me.Controls.Add(Me.rut_empresa)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.direccion_empresa)
        Me.Controls.Add(Me.nombre_empresa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Nueva_empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva empresa"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rut_empresa As System.Windows.Forms.TextBox
    Friend WithEvents nombre_empresa As System.Windows.Forms.TextBox
    Friend WithEvents direccion_empresa As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents agregar_empresa As System.Windows.Forms.Button
    Friend WithEvents link_eliminar_empresa As System.Windows.Forms.LinkLabel
End Class
