Public Class Temperatura_actual

  
    Public vista As New vista
    Private Sub Temperatura_actual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SoftcoolDataSet.Ultimo_registro_temp' Puede moverla o quitarla según sea necesario.
        Try
            Me.Ultimo_registro_tempTableAdapter.Fill(Me.SoftcoolDataSet.Ultimo_registro_temp)
            Me.ReportViewer1.RefreshReport()
            vista.checked(numero:=7)
        Catch ex As Exception
            vista.checked(numero:=8)
        End Try




    End Sub
End Class