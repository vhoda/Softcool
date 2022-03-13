Public Class Eliminarcamara

    Public controlador As New controlador
    Public paquete As New capa_datos
    Public vista As New vista
    Private Sub Eliminar_camara_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Conexion_prueba1.camara' Puede moverla o quitarla según sea necesario.
        Me.CamaraTableAdapter.Fill(Me.Conexion_prueba1.camara)
        vista.modificaciones_visual_eliminar_camara(numero:=1)
    End Sub


    Private Sub numero_camara_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles numero_camara.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub eliminar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles eliminar.CheckedChanged
        controlador.eliminar_checked(numero_camara:=numero_camara.Text)
    End Sub


    Private Sub modificar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles modificar.CheckedChanged
        controlador.modificar_checked(numero_camara:=numero_camara.Text)
    End Sub

    Private Sub realizar_Click(sender As System.Object, e As System.EventArgs) Handles realizar.Click
        controlador.verificar_datos_camara_modificados(Val(numero_camara.Text), tipo_camara.Text, estado_camara.Text)
    End Sub

    Private Sub tipo_camara_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tipo_camara.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub estado_camara_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles estado_camara.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

 
End Class