Public Class graficas_por_camara
    Public fecha As Date
    Public vista As New vista
    Private Sub graficas_por_camara_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SoftcoolDataSet.rendimiento_por_camara' Puede moverla o quitarla según sea necesario.
        Try
            Me.rendimiento_por_camaraTableAdapter.Fill(Me.SoftcoolDataSet.rendimiento_por_camara, fecha_inicio:=fecha)
            Me.ReportViewer1.RefreshReport()
            vista.checked(numero:=1)
        Catch ex As Exception
            vista.checked(numero:=2)
        End Try
    End Sub
End Class