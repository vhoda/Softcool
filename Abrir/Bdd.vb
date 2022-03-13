Imports System.Data.SqlClient
Public Class bdd
    Public conectar As New controlador
    Private Sub btnconectar_Click(sender As System.Object, e As System.EventArgs) Handles btnconectar.Click
        conectar.conectar_bd(btnconectar.Text, base.Text, serv.Text, usuario.Text, contraseña.Text)
    End Sub

    Private Sub base_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles base.KeyPress
        If InStr(1, "0123456789,/-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub serv_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles serv.KeyPress
        If InStr(1, "0123456789,/-abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    
 
    Private Sub bdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        usuario.Text = ""
        contraseña.Text = ""
    End Sub

    Private Sub usuario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles usuario.KeyPress
        If InStr(1, "0123456789,-/abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub contraseña_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles contraseña.KeyPress
        If InStr(1, "0123456789,-/abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub



 
End Class