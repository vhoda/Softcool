<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_camara
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_camara))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.agrega_camara = New System.Windows.Forms.Button()
        Me.tipo_de_camara = New System.Windows.Forms.TextBox()
        Me.link_eliminar_camara = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de camara a agregar"
        '
        'agrega_camara
        '
        Me.agrega_camara.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.agrega_camara.ImageKey = "(ninguno)"
        Me.agrega_camara.Location = New System.Drawing.Point(32, 118)
        Me.agrega_camara.Name = "agrega_camara"
        Me.agrega_camara.Size = New System.Drawing.Size(249, 41)
        Me.agrega_camara.TabIndex = 4
        Me.agrega_camara.Text = "Agregar camara"
        Me.agrega_camara.UseVisualStyleBackColor = True
        '
        'tipo_de_camara
        '
        Me.tipo_de_camara.Location = New System.Drawing.Point(32, 73)
        Me.tipo_de_camara.Name = "tipo_de_camara"
        Me.tipo_de_camara.Size = New System.Drawing.Size(249, 20)
        Me.tipo_de_camara.TabIndex = 5
        '
        'link_eliminar_camara
        '
        Me.link_eliminar_camara.AutoSize = True
        Me.link_eliminar_camara.Location = New System.Drawing.Point(219, 9)
        Me.link_eliminar_camara.Name = "link_eliminar_camara"
        Me.link_eliminar_camara.Size = New System.Drawing.Size(81, 13)
        Me.link_eliminar_camara.TabIndex = 6
        Me.link_eliminar_camara.TabStop = True
        Me.link_eliminar_camara.Text = "Eliminar camara"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.softcool.My.Resources.Resources.agregar_
        Me.PictureBox1.Location = New System.Drawing.Point(162, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Agregar_camara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 187)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.link_eliminar_camara)
        Me.Controls.Add(Me.tipo_de_camara)
        Me.Controls.Add(Me.agrega_camara)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agregar_camara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar camara"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents agrega_camara As System.Windows.Forms.Button
    Friend WithEvents tipo_de_camara As System.Windows.Forms.TextBox
    Friend WithEvents link_eliminar_camara As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
