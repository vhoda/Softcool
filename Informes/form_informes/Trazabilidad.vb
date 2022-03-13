Public Class Trazabilidad
    Public vista As New vista
    Public controlador As New controlador
    Private Sub Buscar_Click(sender As System.Object, e As System.EventArgs) Handles Buscar.Click
        controlador.verificar_cod_producto(dato:=cod_producto.Text)
    End Sub

    Private Sub Trazabilidad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        vista.checked(numero:=11)
    End Sub

    Private Sub cod_producto_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cod_producto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar.PerformClick()
        End If
    End Sub

    Private Sub cod_producto_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cod_producto.KeyPress
        If InStr(1, "0123456789,-/abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

   
End Class