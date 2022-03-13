Imports System.Data.SqlClient

Public Class Principal
    Dim sensor As Integer
    Public metodo As New controlador
    Public agregar As New capa_datos
    Public progres As New vista
    Dim dt As New DataSet
    Dim da2 As New SqlDataAdapter

    Private Sub Temp1_TextChanged(sender As System.Object, e As System.EventArgs) Handles Temp1.TextChanged
        sensor = 1
        metodo.nivel(Temp1.Text, sensor)
    End Sub

    Private Sub Temp2_TextChanged(sender As System.Object, e As System.EventArgs) Handles Temp2.TextChanged
        sensor = 2
        metodo.nivel(Temp2.Text, sensor)
    End Sub

    Private Sub Temp3_TextChanged(sender As System.Object, e As System.EventArgs) Handles Temp3.TextChanged
        sensor = 3
        metodo.nivel(Temp3.Text, sensor)
    End Sub

    Private Sub Temp4_TextChanged(sender As System.Object, e As System.EventArgs) Handles Temp4.TextChanged
        sensor = 4
        metodo.nivel(Temp4.Text, sensor)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    
    Private Sub ConectarBddToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConectarBddToolStripMenuItem.Click
        bdd.ShowDialog()
    End Sub

    Private Sub ConectarPuertoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConectarPuertoToolStripMenuItem.Click
        Puerto.Show()
        Puerto.Visible = True
    End Sub

    Private Sub Puerta_TextChanged(sender As System.Object, e As System.EventArgs) Handles Puerta.TextChanged
        progres.progreso_puerta(Puerta.Text)
    End Sub

    Public Sub InformesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformesToolStripMenuItem.Click
        Informes.ShowDialog()
    End Sub

    
    Private Sub iniciar_Click(sender As System.Object, e As System.EventArgs) Handles iniciar.Click
        Dim captura_datos As Integer
        If iniciar.Text = "Parar" Then
            Dim bandera As Boolean
            bandera = True
            progres.Parar(bandera)
        Else
            If Camara.Text = "" And ComboBox1.Text = "" Then
                captura_datos = 1
                metodo.captura_datos(captura_datos, Camara.Text, ComboBox1.Text)
            End If
            If Temp1.Text = "" Then
                captura_datos = 2
                metodo.captura_datos(captura_datos, Camara.Text, ComboBox1.Text)
            End If
            If Camara.Text <> "" And ComboBox1.Text <> "" And Temp1.Text <> "" Then
                captura_datos = 3
                metodo.captura_datos(captura_datos, Camara.Text, ComboBox1.Text)
            End If
        End If
    End Sub

    Private Sub grabar_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub grabar_Tick_1(sender As System.Object, e As System.EventArgs) Handles grabar.Tick
        If grabar.Enabled = True Then
            Dim bandera As Boolean
            bandera = True
            agregar.grabar(bandera, Camara.Text)
        End If
    End Sub

    

    Public Sub Principal_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            inicio.Close()
        End If
    End Sub


    Private Sub Principal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SoftcoolDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter1.Fill(Me.SoftcoolDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'SoftcoolDataSet.camara' Puede moverla o quitarla según sea necesario.
        Me.CamaraTableAdapter1.Fill(Me.SoftcoolDataSet.camara)
        Dim bandera As Boolean
        progres.abrir_ventana(bandera = False)
        iniciar.Enabled = False
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        Agregar_usuario.ShowDialog()
    End Sub

    Public Sub ActivadorPuertoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActivadorPuertoToolStripMenuItem.Click

    End Sub

    Private Sub TipoProductoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TipoProductoToolStripMenuItem.Click
        Nuevo_tipo_producto.ShowDialog()
    End Sub

    Private Sub CamaraToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CamaraToolStripMenuItem.Click
        Agregar_camara.ShowDialog()
    End Sub

    Private Sub Camara_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Camara.KeyDown
        If e.KeyCode = Keys.Enter Then

        Else
            MsgBox("seleccione item dentro del menu")
            Camara.Text = ""
        End If
    End Sub

    

    Private Sub Camara_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Camara.KeyPress
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

    Private Sub ComboBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
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

 

    Private Sub Camara_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Camara.SelectedIndexChanged
        metodo.verificar_camra(Camara.Text)
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        Nueva_empresa.ShowDialog()
    End Sub
End Class
