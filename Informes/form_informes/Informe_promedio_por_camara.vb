Public Class Informe_promedio_por_camara
    Public fecha As Date

    Public vista As New vista
    Private Sub Informe_promedio_por_camara_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SoftcoolDataSet.temperatura_promedio_x_camara' Puede moverla o quitarla según sea necesario.
        Try
            Me.temperatura_promedio_x_camaraTableAdapter.Fill(Me.SoftcoolDataSet.temperatura_promedio_x_camara, fecha_inicio:=fecha)
            Me.ReportViewer1.RefreshReport()
            vista.checked(numero:=3)
        Catch ex As Exception
            vista.checked(numero:=4)
        End Try



    End Sub


End Class