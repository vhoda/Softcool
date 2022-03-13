Public Class Eliminar_usuario
    Public controlador As New controlador
    Public vista As New vista
    Private Sub Eliminar_usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        vista.load_eliminar_usuario()
    End Sub


    Public Sub realizar_Click(sender As System.Object, e As System.EventArgs) Handles realizar.Click
        vista.seleccionar_modificar_check()
        If modificar.Checked = True Then
            controlador.verificar_datos_usuario_modificar(nombre.Text, apellido.Text, usuario.Text, clave.Text, tipo.Text, estado.Text, cambio:="Modificar")
        End If
        If eliminar.Checked = True Then
            controlador.verificar_datos_usuario_modificar(nombre.Text, apellido.Text, usuario.Text, clave.Text, tipo.Text, estado.Text, cambio:="Eliminar")
        End If
    End Sub

    

    Private Sub Buscar_Click(sender As System.Object, e As System.EventArgs) Handles Buscar.Click
        controlador.buscar_usuario(nombre_usuario.Text)
    End Sub

    Private Sub nombre_usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles nombre_usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar.PerformClick()
        End If
    End Sub

    Private Sub nombre_usuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombre_usuario.KeyPress
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


    Private Sub modificar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles modificar.CheckedChanged
        vista.modificar_con_checked()
    End Sub

    Private Sub eliminar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles eliminar.CheckedChanged
        vista.eliminar_con_checked()
    End Sub

    Private Sub nombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub apellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles apellido.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub tipo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tipo.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub estado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles estado.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub clave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles clave.KeyPress
        If InStr(1, "0123456789,-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


End Class