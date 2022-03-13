Imports System.IO
Public Class Puerto
    Public metodo_escanear As New controlador
    Public connectar As New controlador
    Public validar As New vista
    Public timer As New negocio

    Public strBufferOut As String
    Public strBufferIn As String
    Dim conection As Boolean

    

    Private Sub Puerto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnConectar.Enabled = False
        btnEnviarDato.Enabled = False
        tmrTimer.Enabled = False
        strBufferOut = ""
        strBufferIn = ""
        txtbufferout.Enabled = False
        txtbufferin.Enabled = False

    End Sub

    Private Sub btnDeterminarConexion_Click(sender As System.Object, e As System.EventArgs) Handles btnDeterminarConexion.Click
        cboPuertos.Text = ""
        metodo_escanear.escanear_puerto(cboPuertos.Text)
    End Sub

    Private Sub btnConectar_Click(sender As System.Object, e As System.EventArgs) Handles btnConectar.Click
        connectar.validar_conectar_puerto(btnConectar.Text, cboPuertos.Text)

    End Sub

    Private Sub tmrTimer_Tick(sender As System.Object, e As System.EventArgs) Handles tmrTimer.Tick
        conection = True
        If (tmrTimer.Enabled = True) Then
            timer.timer(conection)
        End If

    End Sub

    Private Sub btnEnviarDato_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviarDato.Click
        conection = True
        timer.enviar_dato(conection)
    End Sub

    Private Sub txtbufferin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbufferin.KeyPress
        If InStr(1, "0123456789,abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtbufferin_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbufferin.TextChanged
        connectar.dato(txtbufferin.Text)
    End Sub

    Private Sub cboPuertos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cboPuertos.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtbufferout_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbufferout.KeyPress
        If InStr(1, "0123456789,abcdefghijklmnñopqrstuvwxyz" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    Private Sub Conectar_Click(sender As System.Object, e As System.EventArgs) Handles Conectar.Click
        Me.Visible = False
    End Sub
End Class