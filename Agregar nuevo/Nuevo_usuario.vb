Public Class Agregar_usuario
    Public controlador As New controlador

    Private Sub apellido_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles apellido.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vari As String
            vari = "apellido"
            controlador.buscar_caracteres_erroneos(nombre.Text, vari)
            usuario.Focus()
        End If
    End Sub

    Private Sub apellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles apellido.KeyPress
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

    Private Sub nombre_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vari As String
            vari = "nombre"
            controlador.buscar_caracteres_erroneos(nombre.Text, vari)
            apellido.Focus()
        End If

    End Sub



    Private Sub nombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nombre.KeyPress
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

    Private Sub usuario_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles usuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vari As String
            vari = "usuario"
            controlador.buscar_caracteres_erroneos(nombre.Text, vari)
            clave.Focus()
        End If
    End Sub

    Private Sub usuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles usuario.KeyPress
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

    Private Sub clave_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles clave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vari As String
            vari = "clave"
            controlador.buscar_caracteres_erroneos(nombre.Text, vari)
            tipo.Focus()
        End If
    End Sub

    Private Sub clave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles clave.KeyPress
  
        If InStr(1, "0123456789,-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub Agregar_Click(sender As System.Object, e As System.EventArgs) Handles Agregar.Click
        controlador.verificar_cajas_vacias(nombre.Text, apellido.Text, usuario.Text, clave.Text, tipo.Text, rut_empresa.Text)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_modificar_usuario.LinkClicked
        If Eliminar_usuario.Visible = False Then
            Eliminar_usuario.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub tipo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim vari As String
            vari = "tipo"
            controlador.buscar_caracteres_erroneos(nombre.Text, vari)
            rut_empresa.Focus()
        End If
    End Sub

    Private Sub tipo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tipo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rut_empresa_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim vari As String
            vari = "rut_empresa"
            controlador.buscar_caracteres_erroneos(nombre.Text, vari)
            Agregar.Focus()
        End If
    End Sub

    Private Sub rut_empresa_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If InStr(1, "0123456789,-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    Private Sub Agregar_usuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Empresa._empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.Empresa._empresa)
    End Sub
End Class