Public Class Nueva_empresa

    Public controlador As New controlador
    Private Sub agregar_empresa_Click(sender As System.Object, e As System.EventArgs) Handles agregar_empresa.Click
        controlador.cajas_nueva_empresa(rut_empresa.Text, nombre_empresa.Text, direccion_empresa.Text)
    End Sub

    Private Sub rut_empresa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles rut_empresa.KeyPress
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub nombre_empresa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombre_empresa.KeyPress
        If InStr(1, "0123456789,&/-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub direccion_empresa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles direccion_empresa.KeyPress
        If InStr(1, "0123456789,-/#abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


   

    Private Sub link_eliminar_empresa_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_eliminar_empresa.LinkClicked
        Eliminar_empresa.ShowDialog()
    End Sub
End Class