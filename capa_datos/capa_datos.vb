Imports System.Data.SqlClient

Public Class capa_datos
    Public planilla As New vista
    Dim bandera As Boolean
    Public dt As New DataSet


    Public Sub conectar(base As String, sevr As String, usuario As String, clave As String)
        Dim Servidor As String
        Dim BasedeDatos As String
        Dim err As String
        Servidor = sevr
        BasedeDatos = base
        coneccion(Servidor, BasedeDatos, usuario, clave)
        Try
            dt = coneccion(Servidor, BasedeDatos, usuario, clave)
            bandera = True
            err = ""
            planilla.mostrar_grilla(bandera, dt, err)
        Catch ex As Exception
            bandera = False
            err = "Servicio no levantado"
            planilla.mostrar_grilla(bandera, dt, err)
        End Try

    End Sub


    Public Sub verificar_en_bdd(inciar As Integer, camara As String, combo As String)
        Try
        Dim bandera As Boolean
        Dim resultado1 As String
        Dim datitos As SqlDataAdapter
        Dim Sql As String
        Dim dt As New DataSet

            Sql = "select producto.tipo from producto where id_producto= ( select camara.id_producto from camara where id_camara='" & camara & "')"
        datitos = New SqlDataAdapter(Sql, miconexion)
        datitos.Fill(dt)

        Dim dr As DataRow
        dr = dt.Tables(0).Rows(0)
            'Principal.grilla.DataSource = dt.Tables(0)

        resultado1 = dr("tipo").ToString

        If resultado1 = combo Then
            bandera = True
                planilla.verificacion(bandera)
        Else
            bandera = False
            planilla.verificacion(bandera)
            End If

         planilla.abrir_ventana(bandera = False)
        Catch ex As Exception
            planilla.error_bd_conectar(bandera:=True)
        End Try

    End Sub


    Public Sub grabar(bandera As Boolean, camara As Integer)
        Dim aceptacion As Boolean
        Dim resultado1 As String
        Dim resultado2 As String
        Dim id_usuario As String
        'si la camara tiene un producto en procesando = true y si tiene un producto finalizado = false

        If bandera = True Then
            Try
                Dim datitos As SqlDataAdapter
                Dim Sql As String
                Dim dt As New DataSet

                Sql = "select camara.estado_proceso from camara where id_camara= ('" & camara & "')"
                datitos = New SqlDataAdapter(Sql, miconexion)
                datitos.Fill(dt)

                Dim dr As DataRow
                dr = dt.Tables(0).Rows(0)
                'Principal.grilla.DataSource = dt.Tables(0)

                resultado1 = dr("estado_proceso").ToString

                If resultado1 = "finalizado" Then
                    bandera = False
                End If

                If resultado1 = "procesando" Then
                    bandera = True
                End If
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If

        If bandera = True Then
            Try
                If bandera = True Then
                    'ingresar datos de temperaturas.
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text

                    cmd.CommandText = "INSERT temperatura (temperatura1,temperatura2,temperatura3,temperatura4) VALUES ('" & Val(Principal.Temp1.Text) & " ', '" & Val(Principal.Temp2.Text) & "', '" & Val(Principal.Temp3.Text) & "', '" & Val(Principal.Temp4.Text) & "')"

                    cmd.Connection = miconexion

                    miconexion.Open()
                    cmd.ExecuteNonQuery()

                    dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
                    Principal.grilla.DataSource = dt.Tables(0)
                    miconexion.Close()
                    aceptacion = True
                End If
                planilla.abrir_ventana(bandera = False)
            Catch ex As Exception
                Principal.grabar.Enabled = False
                planilla.error_bd_conectar(bandera:=True)
                aceptacion = False
            End Try

            If aceptacion = True Then
                Try
                    Dim datitos As SqlDataAdapter
                    Dim Sql As String
                    Dim dt As New DataSet

                    Sql = "select camara.id_camara from camara where id_camara='" & Principal.Camara.Text & "'"
                    datitos = New SqlDataAdapter(Sql, miconexion)
                    datitos.Fill(dt)

                    Dim dr As DataRow
                    dr = dt.Tables(0).Rows(0)
                    Principal.grilla.DataSource = dt.Tables(0)

                    resultado1 = dr("id_camara").ToString
                    planilla.abrir_ventana(bandera = False)
                Catch ex As Exception
                    planilla.errores_al_grabar(numero:=1)

                End Try

                '------------------------------------------------------------
                '------------------------------------------------------------
                Try

                    Dim datitos As SqlDataAdapter
                    Dim Sql As String
                    Dim dt As New DataSet
                    Sql = "select max(temperatura.id_temperatura) from temperatura"
                    datitos = New SqlDataAdapter(Sql, miconexion)
                    datitos.Fill(dt)

                    Dim dr1 As DataRow
                    dr1 = dt.Tables(0).Rows(0)
                    Principal.grilla.DataSource = dt.Tables(0)
                    resultado2 = Principal.grilla.SelectedCells.Item(0).Value
                    planilla.abrir_ventana(bandera = False)
                Catch ex As Exception
                    planilla.errores_al_grabar(numero:=2)
                End Try

                '-----------------------------------------------------------
                '-FECHA Y HORA
                '-----------------------------------------------------------
                Dim hora As Date
                Dim fecha As Date

                fecha = Date.Now
                hora = TimeOfDay
                '-----------------------------------------------------------
                '----------------------------------------------------------
                'traemos el nombre del usuario que esta registrando en bdd


                Try
                    Dim usuario As String
                    usuario = Principal.nom_usuario.Text
                    Dim datitos As SqlDataAdapter
                    Dim Sql As String
                    Dim dt As New DataSet
                    Sql = "select Usuario_sistema.id_usuario from Usuario_sistema where Usuario='" & usuario & "'"
                    datitos = New SqlDataAdapter(Sql, miconexion)
                    datitos.Fill(dt)
                    Dim dr1 As DataRow
                    dr1 = dt.Tables(0).Rows(0)
                    id_usuario = dr1("id_usuario").ToString
                Catch ex As Exception
                    planilla.errores_al_grabar(numero:=24)
                End Try
                '------------------------------------------------------------------
                'registramos datos en la bdd
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "INSERT registro (id_camara,id_temperatura,fecha,hora,estado_puerta,id_usuario) VALUES ('" & Val(resultado1) & " ', '" & Val(resultado2) & "', '" & fecha & "', '" & hora & "', '" & Principal.Puerta.Text & "','" & id_usuario & "')"

                cmd.Connection = miconexion

                miconexion.Open()
                cmd.ExecuteNonQuery()

                dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
                Principal.grilla.DataSource = dt.Tables(0)
                miconexion.Close()
                aceptacion = True


            End If
            If aceptacion = True Then
                Try
                    Dim datitos As SqlDataAdapter
                    Dim Sql As String
                    Dim dt As New DataSet
                    Sql = "select temperatura.id_temperatura,temperatura1,temperatura.temperatura2,temperatura.temperatura3,temperatura.temperatura4,registro.estado_puerta from temperatura, registro where temperatura.id_temperatura= (select max(id_temperatura) from temperatura,camara where camara.id_camara= (select camara.id_camara from camara where camara.id_camara='" & camara & "'))"
                    datitos = New SqlDataAdapter(Sql, miconexion)
                    datitos.Fill(dt)
                    Dim dr As DataRow
                    dr = dt.Tables(0).Rows(0)
                    Principal.grilla.DataSource = dt.Tables(0)
                Catch ex As Exception
                    planilla.errores_al_grabar(numero:=3)
                End Try
            End If
        Else
            planilla.errores_al_grabar(numero:=17)
        End If
    End Sub


    Public Sub verificar_usuario(bandera As Boolean, usuario As String, clave As String)
        If bandera = False Then
            Try
                Dim datitos As SqlDataAdapter
                Dim Sql As String
                Dim dt As New DataSet
                Sql = "select id_usuario from Usuario_sistema where Usuario='" & usuario & "'and Clave ='" & clave & "'"
                datitos = New SqlDataAdapter(Sql, miconexion)
                datitos.Fill(dt)

                Dim dr1 As DataRow
                Dim resultado1 As String
                dr1 = dt.Tables(0).Rows(0)
                resultado1 = dr1("id_usuario").ToString
                Dim a As Boolean = True
                planilla.abrir_ventana(a)
                buscar_nivel_privilegios(Val(resultado1), usuario)
                'planilla.abrir_ventana(bandera = False)
            Catch ex As Exception
                bandera = False
                planilla.campos_vacios(bandera, num:=0)
            End Try


            Try
                Dim datitos As SqlDataAdapter
                Dim Sql As String
                Dim dt As New DataSet
                Sql = "select estado_empresa from Usuario_sistema, empresa where empresa.rut_empresa=Usuario_sistema.rut_empresa and Usuario='" & usuario & "'"
                datitos = New SqlDataAdapter(Sql, miconexion)
                datitos.Fill(dt)

                Dim dr1 As DataRow
                Dim resultado1 As String
                dr1 = dt.Tables(0).Rows(0)
                resultado1 = dr1("estado_empresa").ToString
                Dim a As Boolean = True
                planilla.estado_usuario(resultado1)
                'planilla.abrir_ventana(bandera = False)
            Catch ex As Exception
                bandera = False
                planilla.campos_vacios(bandera, num:=0)
            End Try

            'buscamos si el usuario esta habilitado o desabilitado en el sistema 
            'si esta desabilitado es por que se le elimino del sistema, no puede ingresar.
            Try
                Dim datitos As SqlDataAdapter
                Dim Sql As String
                Dim dt As New DataSet
                Sql = "select estado_usuario from Usuario_sistema where Usuario='" & usuario & "'and Clave ='" & clave & "'"
                datitos = New SqlDataAdapter(Sql, miconexion)
                datitos.Fill(dt)

                Dim dr1 As DataRow
                Dim resultado1 As String
                dr1 = dt.Tables(0).Rows(0)
                resultado1 = dr1("estado_usuario").ToString
                planilla.estado_usuario(resultado1)
                Principal.grilla.ClearSelection()
            Catch ex As Exception
                bandera = False
                'planilla.campos_vacios(bandera)
            End Try
        End If
    End Sub


    Public Sub buscar_nivel_privilegios(id_usuario As Integer, nombre As String)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select  privilegios.nivel_privilegio from Usuario_sistema,perfil,privilegios where Usuario_sistema.id_usuario='" & id_usuario & "'and Usuario_sistema.id_usuario=perfil.id_usuario and perfil.id_perfil=privilegios.id_perfil"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            dr1 = dt.Tables(0).Rows(0)
            resultado1 = dr1("nivel_privilegio").ToString
            planilla.vista_privilegios(resultado1, nombre:=nombre)
        Catch ex As Exception
            Dim falla_busqueda As String
            falla_busqueda = "Nose pudo encontrar privilegios del usuario"
            planilla.vista_privilegios(falla_busqueda, nombre:=nombre)
        End Try
    End Sub


    Public Sub agregar_usuario(nombre As String, apellido As String, usuario As String, clave As String, tipo As String, rut_empresa As String)
        Dim agregado As Boolean
        Dim num_id As Integer
        Dim privilegio As String
        Dim aceptacion_usuario As Boolean
        Try

            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select  max(Usuario)  from Usuario_sistema where Usuario='" & usuario & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)
            Dim dr1 As DataRow
            Dim respuesta As String
            dr1 = dt.Tables(0).Rows(0)
            Principal.grilla.DataSource = dt.Tables(0)
            respuesta = Principal.grilla.SelectedCells.Item(0).ToString
            respuesta = dr1("column1").ToString
            If respuesta = "" Then
                aceptacion_usuario = True
            Else
                aceptacion_usuario = False
                planilla.agregado(usuario, aceptacion_usuario)
            End If
            Principal.grilla.DataSource = Nothing
        Catch ex As Exception
            'sql no levantado'
            MsgBox(ex)
        End Try



        If aceptacion_usuario = True Then

            Try
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text
                Dim estado_usuario As String
                estado_usuario = "habilitado"
                cmd.CommandText = "INSERT Usuario_sistema(nombre,apellido,usuario,clave,tipo_usuario,estado_usuario,rut_empresa) VALUES ('" & nombre & "','" & apellido & "','" & usuario & "', '" & clave & "', '" & tipo & "',  '" & estado_usuario & "','" & rut_empresa & "' )"
                cmd.Connection = miconexion

                miconexion.Open()
                cmd.ExecuteNonQuery()

                dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
                'Principal.grilla.DataSource = dt.Tables(0)
                miconexion.Close()
                agregado = True
                Principal.grilla.DataSource = Nothing
            Catch ex As Exception
                MsgBox(ex)
            End Try

            If agregado = True Then
                Try
                    'seleccionamos el ultimo registro id_usuario agregado a la bdd
                    Dim datitos As SqlDataAdapter
                    Dim Sql As String
                    Dim dt As New DataSet
                    Sql = "select max(Usuario_sistema.id_usuario) from usuario_sistema"
                    datitos = New SqlDataAdapter(Sql, miconexion)
                    datitos.Fill(dt)

                    Dim dr1 As DataRow
                    dr1 = dt.Tables(0).Rows(0)
                    Principal.grilla.DataSource = dt.Tables(0)
                    num_id = Principal.grilla.SelectedCells.Item(0).Value
                    'finalizamos la busqueda del ultimo registro
                    agregado = True
                    Principal.grilla.DataSource = Nothing
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
            'iniciamos la agregacion en tabla perfil 
            If agregado = True Then
                Try

                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text

                    cmd.CommandText = "INSERT perfil(nombre_perfil,id_usuario) VALUES ('" & tipo & "','" & num_id & "')"
                    cmd.Connection = miconexion

                    miconexion.Open()
                    cmd.ExecuteNonQuery()

                    dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
                    'Principal.grilla.DataSource = dt.Tables(0)
                    miconexion.Close()
                    agregado = True
                    Principal.grilla.DataSource = Nothing
                    'terminamos de agregar en perfil
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If

            If agregado = True Then

                Try
                    ' agregamos los privilegios standares del cargo
                    If tipo = "admindb" Then
                        privilegio = "alto"
                    End If
                    If tipo = "admin" Then
                        privilegio = "medio"
                    End If
                    If tipo = "operador" Then
                        privilegio = "bajo"
                    End If
                    'buscamos el ultimo id_ del ultimo perfil agregado
                    Dim datitos As SqlDataAdapter
                    Dim Sql As String
                    Dim dt As New DataSet
                    Sql = "select max(perfil.id_perfil) from perfil"
                    datitos = New SqlDataAdapter(Sql, miconexion)
                    datitos.Fill(dt)
                    Dim dr1 As DataRow
                    dr1 = dt.Tables(0).Rows(0)
                    Principal.grilla.DataSource = dt.Tables(0)
                    num_id = Principal.grilla.SelectedCells.Item(0).Value
                    agregado = True
                    Principal.grilla.DataSource = Nothing
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
            If agregado = True Then
                Try
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "INSERT privilegios(nivel_privilegio,id_perfil) VALUES ('" & privilegio & "','" & num_id & "')"
                    cmd.Connection = miconexion
                    miconexion.Open()
                    cmd.ExecuteNonQuery()
                    dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
                    'Principal.grilla.DataSource = dt.Tables(0)
                    miconexion.Close()
                    Dim bandera As Boolean
                    bandera = True
                    planilla.agregado(usuario, bandera)
                    agregado = True
                    Principal.grilla.DataSource = Nothing
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
        End If
        Principal.grilla.DataSource = Nothing
    End Sub


    Public Sub buscar_usuario(usuario As String)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select  Nombre, Apellido, Usuario, Clave, tipo_usuario, estado_usuario from Usuario_sistema where usuario='" & usuario & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)
            Dim dr1 As DataRow
            dr1 = dt.Tables(0).Rows(0)
            Eliminar_usuario.grilla_usuario.DataSource = dt.Tables(0)
            Eliminar_usuario.grupo_que_hacer.Visible = True
            Eliminar_usuario.realizar.Visible = True

            Eliminar_usuario.nombre.Text = dr1("Nombre").ToString
            Eliminar_usuario.apellido.Text = dr1("Apellido").ToString
            Eliminar_usuario.usuario.Text = dr1("Usuario").ToString
            Eliminar_usuario.clave.Text = dr1("Clave").ToString
            Eliminar_usuario.tipo.Text = dr1("tipo_usuario").ToString
            Eliminar_usuario.estado.Text = dr1("estado_usuario").ToString
            Eliminar_usuario.grilla_usuario.Visible = True
            Eliminar_usuario.Height = 345
        Catch ex As Exception
            planilla.errores_al_grabar(numero:=4)
        End Try

    End Sub


    Public Sub modificar_usuario(nombre As String, apellido As String, usuario As String, clave As String, tipo As String, estado As String, cambio As Boolean)
        If cambio = True Then
            'modificar
            Try
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "UPDATE Usuario_sistema set Nombre='" & nombre & "', Apellido='" & apellido & "', Clave='" & clave & "', tipo_usuario='" & tipo & "' , estado_usuario='" & estado & "' where Usuario='" & usuario & "'"

                cmd.Connection = miconexion

                miconexion.Open()
                cmd.ExecuteNonQuery()

               buscar_usuario(usuario)
                miconexion.Close()
                Eliminar_usuario.modificar.Checked = False
                Eliminar_usuario.eliminar.Checked = False
            Catch ex As Exception
                planilla.errores_al_grabar(numero:=5)
            End Try

        End If

        If cambio = False Then
            'eliminar (se modifica el estado del usuario solamente )
            Try
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "UPDATE Usuario_sistema set estado_usuario='" & estado & "' where Usuario='" & usuario & "'"

                cmd.Connection = miconexion

                miconexion.Open()
                cmd.ExecuteNonQuery()

                buscar_usuario(usuario)
                miconexion.Close()

            Catch ex As Exception
                planilla.errores_al_grabar(numero:=6)
            End Try

        End If
    End Sub


    Public Sub buscar_datos_camara(numero As Integer)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select  tipo_camara, estado_proceso from camara where id_camara='" & numero & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)
            Dim dr1 As DataRow
            dr1 = dt.Tables(0).Rows(0)
            Eliminar_usuario.grilla_usuario.DataSource = dt.Tables(0)

            Nuevo_tipo_producto.camara_de_tipo.Text = dr1("tipo_camara").ToString
            Nuevo_tipo_producto.Estado_de_proceso.Text = dr1("estado_proceso").ToString
            If Nuevo_tipo_producto.camara_de_tipo.Text <> "" And Nuevo_tipo_producto.Estado_de_proceso.Text <> "" Then
                planilla.problemas_al_buscar_camara(numero:=1)
            Else
                planilla.problemas_al_buscar_camara(numero:=2)

            End If
        Catch ex As Exception
            planilla.problemas_al_buscar_camara(numero:=3)
        End Try
        Eliminar_usuario.grilla_usuario.DataSource = Nothing
    End Sub


    Public Sub ingresar_nuevo_producto(numero_camara As String, tipo_camara As String, estado_camara As String, tipo_producto As String, temperatura_ideal As String, estado_producto As String, codigo_producto As String)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT producto(id_producto,tipo,temperatura_normal,estado,pertenecio) VALUES ('" & codigo_producto & "','" & tipo_producto & "','" & temperatura_ideal & "','" & estado_producto & "','" & numero_camara & "')"
            cmd.Connection = miconexion
            miconexion.Open()
            cmd.ExecuteNonQuery()
            dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
            miconexion.Close()
            planilla.mensaje_exito_carga_producto(tipo_producto:=tipo_producto)
        Catch ex As Exception
            planilla.errores_al_grabar(numero:=7)
        End Try

        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE camara set id_producto='" & codigo_producto & "', estado_proceso='" & "procesando" & "' where id_camara='" & numero_camara & "'"

            cmd.Connection = miconexion

            miconexion.Open()
            cmd.ExecuteNonQuery()
            miconexion.Close()
            planilla.actualizacion_nuevo_producto(numero_camara)
          
        Catch ex As Exception
            planilla.errores_al_grabar(numero:=8)

        End Try
    End Sub

    Public Sub cambiar_estado_camara(num_camara As Integer)
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text

            cmd.CommandText = "UPDATE camara set  estado_proceso='" & "finalizado" & "' where id_camara='" & num_camara & "'"

            cmd.Connection = miconexion

            miconexion.Open()
            cmd.ExecuteNonQuery()
            miconexion.Close()
            planilla.actualizar_modificacion_camara(num_camara)
            
        Catch ex As Exception
            planilla.errores_al_grabar(numero:=9)
        End Try
    End Sub


    Public Sub agregar_camara(dato As String)
        Dim captura As String
        Dim numero As Integer
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select max(camara.id_camara) from camara"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            dr1 = dt.Tables(0).Rows(0)
            Principal.grilla.DataSource = dt.Tables(0)
            captura = Principal.grilla.SelectedCells.Item(0).Value
            numero = Integer.Parse(captura)
            Principal.grilla.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex)
        End Try

        Try
            numero = numero + 1
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT camara(id_camara,tipo_camara,id_producto,estado_proceso,estado_camara) VALUES ('" & numero & "','" & dato & "','" & "000000000" & "','" & "finalizado" & "', '" & "habilitada" & "')"
            cmd.Connection = miconexion
            miconexion.Open()
            cmd.ExecuteNonQuery()
            dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
            miconexion.Close()
            planilla.camara_agregada()
            Principal.CamaraTableAdapter1.Fill(Principal.SoftcoolDataSet.camara)
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Principal.grilla.DataSource = Nothing
    End Sub


    Public Sub eliminar_camara(numero_camara As Integer)

        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select max(id_camara) from camara where id_camara='" & numero_camara & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            dr1 = dt.Tables(0).Rows(0)
            Principal.grilla.DataSource = dt.Tables(0)
            resultado1 = Principal.grilla.SelectedCells.Item(0).ToString
            resultado1 = dr1("column1").ToString
            If resultado1 = "" Then
                planilla.errores_al_grabar(numero:=10)
            Else
                realizar_eliminacion(bandera:=True, numero_camara:=numero_camara)
            End If
            Principal.grilla.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex)
        End Try


        
    End Sub

    Public Sub realizar_eliminacion(bandera As Boolean, numero_camara As Integer)
        Dim estado_camara As Boolean = False
        If bandera = True Then
            Try
                Dim datitos As SqlDataAdapter
                Dim Sql As String
                Dim dt As New DataSet
                Sql = "select estado_camara, estado_proceso from camara where id_camara='" & numero_camara & "'"
                datitos = New SqlDataAdapter(Sql, miconexion)
                datitos.Fill(dt)

                Dim dr1 As DataRow
                Dim resultado1 As String
                Dim resultado2 As String
                dr1 = dt.Tables(0).Rows(0)
                resultado1 = dr1("estado_camara").ToString
                resultado2 = dr1("estado_proceso").ToString

                If resultado1 = "desabilitada" Then
                    planilla.errores_al_grabar(numero:=11)
                End If

                If resultado2 = "procesando" Then
                    planilla.errores_al_grabar(numero:=12)
                End If

                If resultado1 <> "desabilitada" And resultado2 <> "procesando" Then
                    estado_camara = True
                End If

            Catch ex As Exception
                MsgBox(ex)
            End Try

        End If

        If estado_camara = True Then
            Try
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text

                cmd.CommandText = "UPDATE camara set  estado_camara='" & "desabilitada" & "' where id_camara='" & numero_camara & "'"

                cmd.Connection = miconexion

                miconexion.Open()
                cmd.ExecuteNonQuery()
                miconexion.Close()
                planilla.elimino_camara(numero_camara)
               
            Catch ex As Exception
                planilla.errores_al_grabar(numero:=13)

            End Try
        End If
    End Sub


    Public Sub modificar_camara(numero_camara As Integer)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select max(id_camara) from camara where id_camara='" & numero_camara & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            dr1 = dt.Tables(0).Rows(0)
            Principal.grilla.DataSource = dt.Tables(0)
            resultado1 = Principal.grilla.SelectedCells.Item(0).ToString
            resultado1 = dr1("column1").ToString
            Principal.grilla.DataSource = Nothing
            If resultado1 = "" Then
                planilla.errores_al_grabar(numero:=14)
               
            Else
                traer_datos_camara(numero_camara)
            End If
            Principal.grilla.DataSource = Nothing
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Public Sub traer_datos_camara(numero_camara As Integer)
        Try

            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select * from camara where id_camara='" & numero_camara & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            dr1 = dt.Tables(0).Rows(0)
            Eliminarcamara.grilla_eliminar.DataSource = dt.Tables(0)
            planilla.mostrar_camara_a_modificar(dr1)

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub



    Public Sub actualizar_datos_camara(numero_camara As Integer, tipo_camara As String, estado_camara As String)
        Dim resultado1 As String
        Try
            Dim bandera As Boolean = True
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select estado_proceso, tipo_camara from camara where id_camara='" & numero_camara & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            dr1 = dt.Tables(0).Rows(0)
            resultado1 = dr1("estado_proceso").ToString
            Dim resultado2 As String
            resultado2 = dr1("tipo_camara").ToString

            If resultado1 = "procesando" And estado_camara = "desabilitada" Then
                planilla.errores_al_grabar(numero:=15)
                bandera = False
            End If
            If resultado1 = "procesando" And resultado2 <> tipo_camara Then
                planilla.errores_al_grabar(numero:=16)
                bandera = False
            End If

            If bandera = True Then
                Try
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "UPDATE camara set  estado_camara='" & estado_camara & "', tipo_camara='" & tipo_camara & "' where id_camara='" & numero_camara & "'"
                    cmd.Connection = miconexion
                    miconexion.Open()
                    cmd.ExecuteNonQuery()
                    miconexion.Close()
                    planilla.pantalla_eliminar_camara()
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Public Sub buscar_producto_de_camara(numero_camara As Integer)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select id_camara from camara where id_camara='" & numero_camara & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            dr1 = dt.Tables(0).Rows(0)
            resultado1 = dr1("id_camara").ToString
            If resultado1 = "" Then
                planilla.errores_al_grabar(numero:=14)

            Else
                estado_actual_camara(numero_camara)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Public Sub estado_actual_camara(numero_camara As Integer)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select estado_proceso, estado_camara, id_producto from camara where id_camara='" & numero_camara & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            Dim resultado2 As String
            Dim resultado3 As String
            dr1 = dt.Tables(0).Rows(0)
            resultado1 = dr1("estado_proceso").ToString
            resultado2 = dr1("estado_camara").ToString
            resultado3 = dr1("id_producto").ToString
            Dim bandera As Boolean

            If resultado2 = "desabilitada" Then
                bandera = True
                planilla.problemas_busqueda_principal(numero:=1)
            Else
                bandera = False
            End If

            If resultado1 = "finalizado" And bandera = False Then
                planilla.problemas_busqueda_principal(numero:=2)
            End If

            If resultado3 = "000000000" And bandera = False Then
                planilla.problemas_busqueda_principal(numero:=3)
            End If


            If resultado1 = "procesando" And resultado2 = "habilitada" And resultado3 <> "000000000" Then
                planilla.problemas_busqueda_principal(numero:=4)
                buscar_producto_en_camara(bandera:=True, id_producto:=resultado3)
            End If

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub


    Public Sub buscar_producto_en_camara(bandera As Boolean, id_producto As String)
        If bandera = True Then
            Try
                Dim datitos As SqlDataAdapter
                Dim Sql As String
                Dim dt As New DataSet
                Sql = "select tipo from producto where id_producto='" & id_producto & "'"
                datitos = New SqlDataAdapter(Sql, miconexion)
                datitos.Fill(dt)

                Dim dr1 As DataRow
                Dim resultado1 As String
                dr1 = dt.Tables(0).Rows(0)
                resultado1 = dr1("tipo").ToString
                Principal.ComboBox1.Text = resultado1
                planilla.problemas_busqueda_principal(numero:=5)
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub


    Public Sub datos_trazabilidad(dato As String)
        Try
            Trazabilidad.TrazabilidadTableAdapter.Fill(Trazabilidad.SoftcoolDataSet.Trazabilidad, id_producto:=dato)
            Trazabilidad.ReportViewer1.RefreshReport()
            planilla.checked(numero:=11)
        Catch ex As Exception
            planilla.checked(numero:=12)
        End Try

    End Sub


    Public Sub agregar_empresa(rut As String, nombre As String, direccion As String)
        Dim bandera As Boolean

        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select max(rut_empresa) from empresa where rut_empresa='" & rut & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            dr1 = dt.Tables(0).Rows(0)
            
            resultado1 = dr1("column1").ToString
            If resultado1 <> "" Then
                planilla.errores_al_grabar(numero:=25)
                bandera = False
            Else
                bandera = True
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try


        If bandera = True Then
            Try
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "INSERT empresa(rut_empresa,nombre_empresa,direccion_empresa,estado_empresa) VALUES ('" & rut & "','" & nombre & "','" & direccion & "','" & "habilitada" & "')"
                cmd.Connection = miconexion
                miconexion.Open()
                cmd.ExecuteNonQuery()
                dt = coneccion(bdd.serv.Text, bdd.base.Text, bdd.usuario.Text, bdd.contraseña.Text)
                miconexion.Close()
                planilla.empresa_agregada()
            Catch ex As Exception
                MsgBox("no se pudo agregar camara")
            End Try
        End If
    End Sub



    Public Sub modificar_empresa(rut As String, nombre As String, direccion As String, estado As String)
        Try
            Dim datitos As SqlDataAdapter
            Dim Sql As String
            Dim dt As New DataSet
            Sql = "select max(rut_empresa) from empresa where rut_empresa='" & rut & "'"
            datitos = New SqlDataAdapter(Sql, miconexion)
            datitos.Fill(dt)

            Dim dr1 As DataRow
            Dim resultado1 As String
            dr1 = dt.Tables(0).Rows(0)

            resultado1 = dr1("column1").ToString
            If resultado1 = "" Then
                planilla.errores_al_grabar(numero:=25)
                bandera = False
            Else
                bandera = True
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try

        If bandera = True Then
            Try
                Dim cmd As New System.Data.SqlClient.SqlCommand
                cmd.CommandType = System.Data.CommandType.Text
                cmd.CommandText = "UPDATE empresa set  nombre_empresa='" & nombre & "', direccion_empresa='" & direccion & "', estado_empresa='" & estado & "' where rut_empresa='" & rut & "'"
                cmd.Connection = miconexion
                miconexion.Open()
                cmd.ExecuteNonQuery()
                miconexion.Close()
                Eliminar_empresa.EmpresaTableAdapter.Fill(Eliminar_empresa.Datos_empresa.empresa)
                planilla.modifi_empresa()
            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If


    End Sub
End Class

