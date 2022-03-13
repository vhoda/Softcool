Imports System.Data.SqlClient
Module Conector_bdd
    Public miconexion As SqlConnection
    Dim micomandosql As SqlCommand
    Public da As SqlDataAdapter
    Public vista As New vista

    Function coneccion(ByVal Servidor As String, ByVal BasedeDatos As String, ByVal usuario As String, ByVal clave As String)

        miconexion = New SqlConnection
        Dim Sql As String
        Dim dt As New DataSet

        Sql = "select * from temperatura"
        Try
            'forma tradicional con autenticacion de windows
            ' miconexion = New SqlConnection("Data Source=" + Servidor + ";Initial Catalog=" + BasedeDatos + "; Integrated Security=True")

            miconexion = New SqlConnection("Data Source=" + Servidor + ";Initial Catalog=" + BasedeDatos + ";User ID=" + usuario + ";Password=" + clave)
            da = New SqlDataAdapter(Sql, miconexion)
            da.Fill(dt)
           

        Catch excepcion As Exception

            ' MessageBox.Show("Error en la conexion: ")
            '+ excepcion.ToString()
        Finally
            miconexion.Close()

        End Try

        Return dt

    End Function


End Module
