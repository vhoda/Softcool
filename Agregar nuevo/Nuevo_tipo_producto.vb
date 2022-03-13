Public Class Nuevo_tipo_producto
    Public controlador As New controlador
    Public vista As New vista

    Public paquete As New capa_datos

    Private Sub numeric_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles numeric.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub numeric_LostFocus(sender As Object, e As System.EventArgs) Handles numeric.LostFocus
        controlador.numeric_pierde_focus(numeric:=Val(numeric.Text))
    End Sub

    Private Sub numeric_MouseWheel(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles numeric.MouseWheel
        If numeric.Text = "" Then
            numeric.Text = "0"
        End If
        If IsNumeric(numeric.Text) Then
            Dim temp As Integer = e.Delta = SystemInformation.MouseWheelScrollLines / 100
            numeric.Text = numeric.Text - temp
        Else
            vista.temperatura_ideal_error()
        End If
    End Sub

    Private Sub Nuevo_tipo_producto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'Conexion_prueba1.camara' Puede moverla o quitarla según sea necesario.
        Me.CamaraTableAdapter.Fill(Me.Conexion_prueba1.camara)
        'TODO: esta línea de código carga datos en la tabla 'Conexion_prueba1.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.Conexion_prueba1.producto)
        vista.inicio_nuevo_producto()
       
    End Sub

    Private Sub numero_camara_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles numero_camara.KeyDown
        If e.KeyCode = Keys.Enter Then
            tipo_producto.Focus()
            controlador.buscar_datos_de_camara(numero_camara.Text)
        End If
    End Sub

    Private Sub numero_camara_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles numero_camara.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub numero_camara_LostFocus(sender As Object, e As System.EventArgs) Handles numero_camara.LostFocus
        controlador.buscar_datos_de_camara(numero_camara.Text)
    End Sub

    Private Sub camara_de_tipo_TextChanged(sender As System.Object, e As System.EventArgs) Handles camara_de_tipo.TextChanged
        vista.foto(camara_de_tipo.Text)
    End Sub

    Private Sub numero_camara_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles numero_camara.SelectedIndexChanged
        controlador.buscar_datos_de_camara(numero_camara.Text)
    End Sub

    Private Sub cofigo_del_producto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cofigo_del_producto.KeyPress
        If InStr(1, "0123456789,-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub agregar_producto_Click(sender As System.Object, e As System.EventArgs) Handles agregar_producto.Click
        controlador.verificar_nuevo_producto(numero_camara.Text, camara_de_tipo.Text, Estado_de_proceso.Text, tipo_producto.Text, numeric.Text, bueno.Text, cofigo_del_producto.Text)
    End Sub

   
    Public Sub finalizar_proceso_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles finalizar_proceso.LinkClicked
        vista.cambiar_estado_proceso(bandera:=True, numero_camara:=Val(numero_camara.Text))
    End Sub

    Private Sub tipo_producto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tipo_producto.KeyPress
        If InStr(1, "abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
End Class