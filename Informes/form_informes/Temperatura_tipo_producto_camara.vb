Public Class Temperatura_tipo_producto_camara
  
   
    Public fecha As Date
    Public vista As New vista
    Private Sub Temperatura_tipo_producto_camara_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SoftcoolDataSet.Temp_promedio_x_producto_y_camara' Puede moverla o quitarla según sea necesario.
        Try
            Me.Temp_promedio_x_producto_y_camaraTableAdapter.Fill(Me.SoftcoolDataSet.Temp_promedio_x_producto_y_camara, fecha_inicio:=fecha)
            Me.ReportViewer1.RefreshReport()
            vista.checked(numero:=9)
        Catch ex As Exception
            vista.checked(numero:=10)
        End Try




    End Sub
End Class