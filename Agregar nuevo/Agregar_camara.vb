Public Class Agregar_camara
    Public controlador As New controlador
    
    Private Sub tipo_de_camara_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tipo_de_camara.KeyDown
        If e.KeyCode = Keys.Enter Then
            agrega_camara.Focus()
            agrega_camara.PerformClick()
        End If
    End Sub

    Private Sub tipo_de_camara_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tipo_de_camara.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub agrega_camara_Click(sender As System.Object, e As System.EventArgs) Handles agrega_camara.Click
        controlador.nueva_camara(tipo_de_camara.Text)
    End Sub


    Private Sub link_eliminar_camara_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_eliminar_camara.LinkClicked
        Eliminarcamara.ShowDialog()
    End Sub
End Class