Public Class inicio_seccion
    Public metodo As New controlador

    Private Sub contraseña_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles contraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            ingresar.PerformClick()
        End If
    End Sub

    Private Sub contraseña_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles contraseña.KeyPress
        If InStr(1, "0123456789,-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub nombre_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            contraseña.Focus()
        End If
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
        If InStr(1, "0123456789,-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Principal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then

        End If
    End Sub

    Private Sub ingresar_Click(sender As System.Object, e As System.EventArgs) Handles ingresar.Click
        metodo.user_pass(nombre.Text, contraseña.Text)
    End Sub


End Class