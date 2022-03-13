Public Class Informes

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If listado_x_camara.Checked = True Then
            listado_por_camara.fecha = MonthCalendar1.SelectionRange.End.Date
            listado_por_camara.ShowDialog()
        End If

        If Graficas_rendimiento_camara.Checked = True Then
            graficas_por_camara.fecha = MonthCalendar1.SelectionRange.End.Date
            graficas_por_camara.ShowDialog()
        End If

        If temp_prome_por_camara.Checked = True Then
            Informe_promedio_por_camara.fecha = MonthCalendar1.SelectionRange.End.Date
            Informe_promedio_por_camara.ShowDialog()
        End If


        If temp_product_y_cam.Checked = True Then
            Temperatura_tipo_producto_camara.fecha = MonthCalendar1.SelectionRange.End.Date
            Temperatura_tipo_producto_camara.ShowDialog()
        End If
    End Sub



    Private Sub Informes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Width = 341
        MonthCalendar1.Visible = False
    End Sub

    Private Sub Temp_actual_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Temp_actual.CheckedChanged
        Width = 341
        Temperatura_actual.Show()
    End Sub
    
    Private Sub listado_x_camara_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles listado_x_camara.CheckedChanged
        Width = 551
        MonthCalendar1.Visible = True
    End Sub

    Private Sub temp_prome_por_camara_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles temp_prome_por_camara.CheckedChanged
        Width = 551
        MonthCalendar1.Visible = True
    End Sub
    Private Sub Trazabili_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Trazabili.CheckedChanged
        Width = 341
        MonthCalendar1.Visible = False
        Trazabilidad.Show()
    End Sub

  
    Private Sub temp_product_y_cam_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles temp_product_y_cam.CheckedChanged
        Width = 551
        MonthCalendar1.Visible = True
    End Sub

    Private Sub Graficas_rendimiento_camara_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Graficas_rendimiento_camara.CheckedChanged
        Width = 551
        MonthCalendar1.Visible = True
    End Sub

    

End Class