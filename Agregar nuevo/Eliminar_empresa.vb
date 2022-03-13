Public Class Eliminar_empresa
    Public controlador As New controlador
    Public Sub Eliminar_empresa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Datos_empresa.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Datos_empresa.empresa)
        Width = 595
        Height = 201
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles data.CellContentClick
        rut.Text = data.CurrentRow.Cells.Item(0).Value.ToString
        nombre.Text = data.CurrentRow.Cells.Item(1).Value.ToString
        direccion.Text = data.CurrentRow.Cells.Item(2).Value.ToString
        estado.Text = data.CurrentRow.Cells.Item(3).Value.ToString
        modi.Visible = True
        Width = 595
        Height = 369
    End Sub

    Private Sub Actualizar_Click(sender As System.Object, e As System.EventArgs) Handles Actualizar.Click
        controlador.verificar_eliminar_empresa(rut.Text, nombre.Text, direccion.Text, estado.Text)
    End Sub

    Private Sub nombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
        If InStr(1, "0123456789,-/&abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub direccion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles direccion.KeyPress
        If InStr(1, "0123456789,-/#abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub estado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles estado.KeyPress
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class