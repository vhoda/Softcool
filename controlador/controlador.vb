Public Class controlador
    Public revisar_signo As New negocio
    Public modific As New negocio
    Public mensaje As New vista
    Public paquete As New capa_datos
    Private numero As Integer

    Public Sub nivel(Temp1 As String, sensor As Integer)
        Dim bandera As Boolean
        If (IsNumeric(Temp1)) Then
            If (Temp1 <= 100) Then
                revisar_signo.verificar_signo(Temp1, sensor)
            Else
                bandera = True
                mensaje.errores_valores(bandera)
            End If
        Else
            bandera = False
            mensaje.errores_valores(bandera)
        End If
    End Sub


    Public Sub escanear_puerto(cboPuertos As String)
        If (cboPuertos = "") Then
            modific.modificar_puerto(cboPuertos)
        End If
    End Sub



    Public Sub validar_conectar_puerto(btnConectar As String, cbopuertos As String)
        Dim bandera As Boolean
        Dim igual As Boolean
        Dim com As String
        com = "COM"
        numero = 0
        bandera = False
        igual = True

        If (btnConectar = "Conectar") Then
            If (cbopuertos <> "") Then
                While (igual = True)

                    If (cbopuertos = com & numero) Then
                        bandera = True
                        modific.mensaje_puerto(bandera)
                        igual = False
                    End If

                    If numero >= 50 Then
                        mensaje.inmovilizar(bandera)
                        igual = False
                    End If
                    numero = numero + 1
                End While

            Else
                bandera = True
                mensaje.eroor_al_conectar(bandera)

            End If
            numero = 0
        End If

        If (btnConectar = "Desconectar") Then
            bandera = False
            modific.mensaje_puerto(bandera)
            modific.timer(bandera)
        End If
    End Sub

    Public Sub dato(dato As String)
        Dim bandera As Boolean
        bandera = False
        If Not IsNumeric(dato) Then
            If dato.Contains("f") Then
                mensaje.errores_valores(bandera)
            Else
                numero = 4
            End If
        End If
        If IsNumeric(dato) And numero = 0 Then
            mensaje.enviar_principal(dato, numero)
        End If
        If IsNumeric(dato) And numero = 1 Then
            mensaje.enviar_principal(dato, numero)
        End If
        If IsNumeric(dato) And numero = 2 Then
            mensaje.enviar_principal(dato, numero)
        End If
        If IsNumeric(dato) And numero = 3 Then
            mensaje.enviar_principal(dato, numero)
        End If
        If numero = 4 Then
            If dato = "cerrado 0" Then
                mensaje.enviar_principal(dato, numero)
            End If
            If dato = "cerrado 35" Then
                mensaje.enviar_principal(dato, numero)
            End If
            If dato = "cerrado 73" Then
                mensaje.enviar_principal(dato, numero)
            End If
            If dato = "cerrado 100" Then
                mensaje.enviar_principal(dato, numero)
            End If
        End If
        numero = numero + 1
        If numero = 5 Then
            numero = 0
        End If
    End Sub

    Public Sub conectar_bd(btnconectar As String, base As String, sevr As String, usuario As String, clave As String)
        If btnconectar = "Conectar" And base <> "" And sevr <> "" And usuario <> "" And clave <> "" Then
            If base = "Softcool" And sevr = "WIN-9SMVGL48ODF" And usuario = "sa" And clave = "123" Then
                paquete.conectar(base, sevr, usuario, clave)
            Else
                mensaje.error_conectar_bd(numero:=1)
            End If
        Else
            mensaje.error_conectar_bd(numero:=2)
        End If
    End Sub

    Public Sub captura_datos(iniciar As Integer, camara As String, combo As String)
        If iniciar = "1" Then
            mensaje.errores_valores(iniciar)
        End If
        If iniciar = "2" Then
            mensaje.errores_valores(iniciar)
        End If
        If iniciar = "3" Then
            ''al negocio a verificar con bdd .. si todo anda bien 
            paquete.verificar_en_bdd(iniciar, camara, combo)
        End If

    End Sub

    Public Sub user_pass(usuario As String, pass As String)
        Dim bandera As Boolean
        If usuario = "" Then
            bandera = True
            mensaje.campos_vacios(bandera, num:=1)
        End If

        If pass = "" Then
            bandera = True
            mensaje.campos_vacios(bandera, num:=2)
        End If

        If usuario = "" And pass = "" Then
            bandera = True
            mensaje.campos_vacios(bandera, num:=3)
        End If


        If usuario <> "" And pass <> "" Then
            bandera = False
            paquete.verificar_usuario(bandera, usuario, pass)
        End If
    End Sub

    Public Sub buscar_caracteres_erroneos(dato As String, vari As String)
        If dato <> "" Then
            If Char.IsLetter(dato) Then
                If vari = "nombre" Then
                    Agregar_usuario.apellido.Focus()
                End If
                If vari = "apellido" Then
                    Agregar_usuario.usuario.Focus()
                End If
                If vari = "usuario" Then
                    Agregar_usuario.clave.Focus()
                End If
                If vari = "clave" Then
                    Agregar_usuario.tipo.Focus()
                End If
                If vari = "tipo" Then
                    Agregar_usuario.Agregar.PerformClick()
                End If
            Else
                Dim bandera As Boolean
                bandera = False
                mensaje.caracteres_erroneos_mensaje(bandera, vari)
            End If
        Else
            Dim bandera As Boolean
            bandera = False
            mensaje.caracteres_erroneos_mensaje(bandera, vari)
        End If
    End Sub

    Public Sub verificar_cajas_vacias(nombre As String, apellido As String, usuario As String, clave As String, tipo As String, rut_empresa As String)
        Dim dato As Boolean
        Dim vari As String

        If nombre = "" Then
            dato = False
            vari = "nombre"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If apellido = "" Then
            dato = False
            vari = "apellido"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If usuario = "" Then
            dato = False
            vari = "usuario"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If
        If clave = "" Then
            dato = False
            vari = "clave"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If tipo = "" Then
            dato = False
            vari = "tipo"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If rut_empresa = "" Then
            dato = False
            vari = "rut_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If tipo = "admindb" Or tipo = "admin" Or tipo = "operador" Then
            If nombre <> "" And apellido <> "" And usuario <> "" And clave <> "" And tipo <> "" And rut_empresa <> "" Then
                paquete.agregar_usuario(nombre, apellido, usuario, clave, tipo, rut_empresa)
            End If
        Else
            mensaje.errores_al_grabar(numero:=18)
        End If
    End Sub


    Public Sub buscar_usuario(usuario As String)
        If usuario = "" Then
            mensaje.campos_vacios(bandera:=True, num:=3)
        End If

        If usuario <> "" Then
            paquete.buscar_usuario(usuario)
        End If
    End Sub


    Public Sub verificar_datos_usuario_modificar(nombre As String, apellido As String, usuario As String, clave As String, tipo As String, estado As String, cambio As String)
        If cambio = "Modificar" Then
            Dim bandera As Boolean
            bandera = True
            paquete.modificar_usuario(nombre, apellido, usuario, clave, tipo, estado, bandera)
        End If

        If cambio = "Eliminar" Then
            Dim bandera As Boolean
            bandera = False
            estado = "desabilitado"
            paquete.modificar_usuario(nombre, apellido, usuario, clave, tipo, estado, bandera)
        End If
    End Sub

    Public Sub buscar_datos_de_camara(numero As String)
        If numero <> "" Then
            If IsNumeric(numero) Then
                paquete.buscar_datos_camara(Val(numero))
            Else
                Dim num As Integer = 1
                Dim bandera As Boolean = True
                mensaje.error_numerico(bandera)
            End If
        End If
    End Sub

    Public Sub verificar_nuevo_producto(numero_camara As String, tipo_camara As String, estado_camara As String, tipo_producto As String, temperatura_ideal As String, estado_producto As String, codigo_producto As String)

        If numero_camara <> "" Then
            If IsNumeric(numero_camara) Then
            Else
                mensaje.error_numerico(bandera:=True)
            End If
        End If

        If numero_camara = "" Then
            If IsNumeric(numero_camara) Then
            Else
                mensaje.error_numerico(bandera:=True)
            End If
            mensaje.errores_verificacion_nuevo_producto(numero:=1)
        ElseIf tipo_camara = "" Then
            mensaje.errores_verificacion_nuevo_producto(numero:=2)
        ElseIf estado_camara = "" Then
            mensaje.errores_verificacion_nuevo_producto(numero:=3)
        ElseIf tipo_producto = "" Then
            mensaje.errores_verificacion_nuevo_producto(numero:=4)
        ElseIf temperatura_ideal = "" Then
            mensaje.errores_verificacion_nuevo_producto(numero:=5)
        ElseIf estado_producto = "" Then
            mensaje.errores_verificacion_nuevo_producto(numero:=6)
        ElseIf codigo_producto = "" Then
            mensaje.errores_verificacion_nuevo_producto(numero:=7)
        Else
            If estado_camara = "procesando" Then
                mensaje.errores_verificacion_nuevo_producto(numero:=8)
            Else
                paquete.ingresar_nuevo_producto(numero_camara, tipo_camara, estado_camara, tipo_producto, temperatura_ideal, estado_producto, codigo_producto)
            End If
        End If
    End Sub


    Public Sub nueva_camara(tipo_camara As String)
        If tipo_camara = "" Then
            mensaje.dato_vacio()
        End If

        If tipo_camara <> "" Then
            paquete.agregar_camara(tipo_camara)
        End If
    End Sub

    Public Sub verificar_datos(numero_camara As Integer)
            paquete.eliminar_camara(numero_camara)
    End Sub


    Public Sub verificar_datos_camara_modificar(id_camara As Integer, tipo_camara As String, estado_camara As String)
        If tipo_camara = "" Then
            mensaje.errores_al_grabar(numero:=22)
        End If

        If estado_camara = "" Then
            mensaje.errores_al_grabar(numero:=21)
        End If

    End Sub


    Public Sub verificar_datos_camara_modificados(numero_camara As Integer, tipo_camara As String, estado_camara As String)
        If tipo_camara = "" Then
            mensaje.errores_al_grabar(numero:=19)
        End If
        If estado_camara = "" Then
            mensaje.errores_al_grabar(numero:=20)
        End If

        If tipo_camara <> "" And estado_camara <> "" Then
            paquete.actualizar_datos_camara(numero_camara, tipo_camara, estado_camara)
        End If

    End Sub


    Public Sub verificar_camra(numero As String)
        If numero <> "" Then
            paquete.buscar_producto_de_camara(Val(numero))
        End If

    End Sub


    Public Sub numeric_pierde_focus(numeric As Integer)
        If IsNumeric(numeric) Then

        Else
            mensaje.temperatura_ideal_error()
        End If
    End Sub



    Public Sub eliminar_checked(numero_camara As String)
        If numero_camara = "" Then
            mensaje.modificaciones_visual_eliminar_camara(numero:=2)
        End If
        If numero_camara <> "" And Eliminarcamara.eliminar.Checked = True Then
            mensaje.modificaciones_visual_eliminar_camara(numero:=3)
            verificar_datos(Val(numero_camara))
        End If
    End Sub



    Public Sub modificar_checked(numero_camara As String)
        If numero_camara = "" Then
            mensaje.modificaciones_visual_eliminar_camara(numero:=5)
            
        End If

        If numero_camara <> "" And Eliminarcamara.modificar.Checked = True Then
            mensaje.modificaciones_visual_eliminar_camara(numero:=4)
            paquete.modificar_camara(Val(numero_camara))
        End If
    End Sub


    Public Sub verificar_cod_producto(dato As String)

        If dato = "" Then
            mensaje.checked(numero:=13)
        End If

        If dato <> "" Then
            paquete.datos_trazabilidad(dato)
        End If
    End Sub

    Public Sub cajas_nueva_empresa(rut_empresa As String, nombre_empresa As String, direccion As String)
        Dim dato As Boolean
        Dim vari As String

        If rut_empresa = "" Then
            dato = False
            vari = "rut_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If nombre_empresa = "" Then
            dato = False
            vari = "Nombre_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If direccion = "" Then
            dato = False
            vari = "Dirección_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If
        


        If rut_empresa <> "" And nombre_empresa <> "" And direccion <> "" Then
            paquete.agregar_empresa(rut_empresa, nombre_empresa, direccion)
        End If

    End Sub


    Public Sub verificar_eliminar_empresa(rut As String, nombre As String, direccion As String, estado As String)
        Dim dato As Boolean
        Dim vari As String

        If rut = "" Then
            dato = False
            vari = "rut_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If nombre = "" Then
            dato = False
            vari = "Nombre_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If direccion = "" Then
            dato = False
            vari = "Dirección_empresa"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If

        If estado = "" Then
            dato = False
            vari = "estado"
            mensaje.caracteres_erroneos_mensaje(dato, vari)
        End If



        If rut <> "" And nombre <> "" And direccion <> "" And estado <> "" Then
            paquete.modificar_empresa(rut, nombre, direccion, estado)
        End If

    End Sub
End Class
