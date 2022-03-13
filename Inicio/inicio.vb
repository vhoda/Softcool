Public Class inicio
    Dim numero As Integer = 0
    Public paquete As New capa_datos


    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        If ProgressBar1.Value = 100 Then
            Dim base As String = "Softcool"
            Dim sevr As String = "WIN-9SMVGL48ODF"
            Dim usuario As String = "sa"
            Dim clave As String = "123"
            paquete.conectar(base, sevr, usuario, clave)
        Else
            ProgressBar1.Value += 1

        End If
    End Sub
End Class