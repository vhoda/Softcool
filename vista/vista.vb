Imports System.IO

Public Class vista


    Dim num_bd As Integer



    Public Sub progres(Temp1 As Integer, sensor As Integer)
        If Temp1 <= "100" Or Temp1 <= "-100" Then
            If (sensor = 1) Then
                Principal.Nivel_temperatura1.Value = Temp1
            End If
            If (sensor = 2) Then
                Principal.Nivel_temperatura2.Value = Temp1
            End If
            If (sensor = 3) Then
                Principal.Nivel_temperatura3.Value = Temp1
            End If
            If (sensor = 4) Then
                Principal.Nivel_temperatura4.Value = Temp1
            End If

        Else
            errores_valores(bandera:=True)
        End If


        If Temp1 >= 25 And Principal.Puerta.Text = "cerrado 100" Then
            Principal.AxShockwaveFlash1.Visible = True
            Principal.Label8.Visible = False
            Principal.AxShockwaveFlash1.LoadMovie(0, Path.GetFullPath("rueda.swf"))
        Else
            Principal.AxShockwaveFlash1.Visible = False
            Principal.Label8.Visible = True
            Principal.Label8.Text = "MOTOR DETENIDO"
        End If
    End Sub

    Public Sub progreso_puerta(porcentaje As String)

        If porcentaje = "cerrado 0" Then
            Principal.progrespuerta.Value = 0
        End If
        If porcentaje = "cerrado 35" Then
            Principal.progrespuerta.Value = 35
        End If
        If porcentaje = "cerrado 73" Then
            Principal.progrespuerta.Value = 73
        End If
        If porcentaje = "cerrado 100" Then
            Principal.progrespuerta.Value = 100
        End If

    End Sub

    Public Sub mostrar_puerto(bandera As Boolean)
        Dim numero As Integer
        If (bandera = True) Then
            Puerto.btnConectar.Enabled = True
            Puerto.btnDeterminarConexion.Enabled = True
            MsgBox("Seleccione el puerto a utilizar", MsgBoxStyle.Information, "Seleccione")
        Else
            numero = numero + 1
            If numero = 1 Then
                MsgBox("Puerto con problemas", MsgBoxStyle.Critical, "Error de comunicacion")
                Puerto.btnConectar.Enabled = False
                Puerto.btnEnviarDato.Enabled = False
                Puerto.cboPuertos.Items.Clear()
                Puerto.cboPuertos.Text = ("")
                MsgBox("Favor revisar administrador de dispositivos, seccion puertos COM y verifique si hay algún problema", MsgBoxStyle.Information, "Siga la siguiente indicación")
                Puerto.Close()
            End If
        End If

    End Sub

    Public Sub inmovilizar(selectindex As Boolean)
        Puerto.cboPuertos.Enabled = True
        Puerto.cboPuertos.Text = ("")
        MsgBox("Escribio sobre direccion de puerto Determine nuevamente", MsgBoxStyle.Exclamation, "Asegurese de no teclear")
    End Sub


    Public Sub eroor_al_conectar(conection As Boolean)
        MsgBox("Determine nuevamente el puerto a usar", MsgBoxStyle.Exclamation, "Siga las intrucciones")
    End Sub

    Public Sub mod_conectar_desconectar(band As Boolean)
        If (band = True) Then
            Puerto.btnConectar.Text = "Desconectar"
            Puerto.tmrTimer.Enabled = True
            Puerto.btnEnviarDato.Enabled = True
            Puerto.txtbufferout.Enabled = True
            Puerto.txtbufferin.Enabled = True
        End If

        If (band = False) Then
            Puerto.btnConectar.Text = "Conectar"
            Puerto.btnEnviarDato.Enabled = False
            Puerto.tmrTimer.Enabled = False
            Puerto.txtbufferin.Text = ""
            Puerto.txtbufferout.Text = ""
            Puerto.cboPuertos.Text = ""
            Puerto.txtbufferout.Enabled = False
            Puerto.txtbufferin.Enabled = False
            MsgBox("Puerto a sido desconectado", MsgBoxStyle.Information, "Desconexion con el puerto")
        End If
    End Sub

    Public Sub seleccionar_modificar_check()
        Eliminar_usuario.modificar.Checked = True
    End Sub

    Public Sub enviar_principal(dato As String, numero As Integer)

        If numero = 0 Then
            Principal.Temp1.Text = dato
        End If
        If numero = 1 Then
            Principal.Temp2.Text = dato
        End If
        If numero = 2 Then
            Principal.Temp3.Text = dato
        End If
        If numero = 3 Then
            Principal.Temp4.Text = dato
        End If
        If numero = 4 Then
            Principal.Puerta.Text = dato
        End If

    End Sub

    Public Sub errores_valores(bandera As Boolean)
        If bandera = False Then
            MsgBox("El modulo de transduccion TTL/UART ha fallado", MsgBoxStyle.Critical, "Comunicarse con personal tecnico")
        End If

        If bandera = True Then
            MsgBox("Valor execivo, revisar sensor", MsgBoxStyle.Critical, "Verificar en terreno")
        End If
    End Sub

    Public Sub errores_valores(iniciar As Integer)
        If iniciar = "1" Then
            MsgBox("Aun no se a conectado con la base de datos", MsgBoxStyle.Exclamation, "Verifique conexion")
        End If
        If iniciar = "2" Then
            MsgBox("A un no activa el puerto a trabajar", MsgBoxStyle.Exclamation, "Verifique puerto a trabajar")
        End If

    End Sub

    Public numero As Integer = 0
    Public Sub mostrar_grilla(bandera As Boolean, dt As DataSet, err As String)
        If bandera = True Then
            Principal.grilla.DataSource = dt.Tables(0)
            num_bd = num_bd + 1
            If Principal.Visible = True Then
                MsgBox("Base de datos conectada correctamente", MsgBoxStyle.Information, "Conexion establecida")
            End If
            Principal.ProductoTableAdapter.Fill(Principal.Conexion_prueba1.producto)
            Principal.CamaraTableAdapter.Fill(Principal.Conexion_prueba1.camara)
            bdd.Close()
            Principal.grilla.ClearSelection()
        End If

        If bandera = True And inicio.Visible = True Then
            inicio.Timer.Enabled = False
            inicio_seccion.Show()
            inicio.Hide()
        End If

        If bandera = False Then
            If numero = 0 Then
                numero = numero + 1
                MsgBox("Verificar Servicio sql :" & err, MsgBoxStyle.Critical, "Error con servidor de datos, se cerrala aplicacion")
                inicio.Close()
            Else
            End If

        End If
    End Sub

    Public Sub verificacion(bandera As Boolean)
        If bandera = True Then
            MsgBox("Exelente se comenzara a grabar datos", MsgBoxStyle.Information, "Paso libre")
            Principal.grabar.Enabled = True
            Principal.Camara.Enabled = False
            Principal.ComboBox1.Enabled = False
            Principal.iniciar.Text = "Parar"
            Principal.trabajando.Visible = True
        End If
        If bandera = False Then
            MsgBox("La camara que selecciono no trabaja con este tipo de producto ", MsgBoxStyle.Information, "Verificar producto V/S camara")
        End If
    End Sub

    Public Sub error_bd_conectar(bandera As Boolean)
        If bandera = True Then
            MsgBox("Conexion perdida con Base de datos", MsgBoxStyle.Critical, "Verifique servicio")
        End If
    End Sub


    Public Sub errores_al_grabar(numero As Integer)
        If numero = 1 Then
            MsgBox("Error al buscar camara", MsgBoxStyle.Exclamation, "Seleccion de camara")
        End If
        If numero = 2 Then
            MsgBox("Error al buscas maxima temperatura", MsgBoxStyle.Exclamation, "Seleccion de temperatura")
        End If
        If numero = 3 Then
            MsgBox("Nose se pudo actualizar ultimo registro de actividad", MsgBoxStyle.Exclamation, "Problemas de actualización")
        End If

        If numero = 4 Then
            MsgBox("Usuario no encontrado verifique lo digitado", MsgBoxStyle.Information, "Busqueda de usuario")
        End If
        If numero = 5 Then
            MsgBox("No se pudo modificar", MsgBoxStyle.Exclamation, "Prohibicion")
        End If
        If numero = 6 Then
            MsgBox("No se pudo Eliminar", MsgBoxStyle.Exclamation, "Prohibicion")
        End If

        If numero = 7 Then
            MsgBox("problema al ingresar nuevo producto a proceso", MsgBoxStyle.Critical, "Problemas")
        End If

        If numero = 8 Then
            MsgBox("problemas al actualizar la camara", MsgBoxStyle.Critical, "Problemas")
        End If

        If numero = 9 Then
            MsgBox("No se pudo finalizar el proceso del producto en la camara", MsgBoxStyle.Critical, "Problemas")
        End If

        If numero = 10 Then
            Principal.grilla.DataSource = Nothing
            MsgBox("La camara que indico no existe", MsgBoxStyle.Information, "No, se encontro")
            Eliminarcamara.eliminar.Checked = False
            Eliminarcamara.modificar.Checked = False
        End If

        If numero = 11 Then
            Principal.grilla.DataSource = Nothing
            MsgBox("Camara ya eliminada", MsgBoxStyle.Information, "No se puede eliminar")
            Eliminarcamara.eliminar.Checked = False
        End If

        If numero = 12 Then
            MsgBox("No puede eliminar una camara que tiene producto en su interior", MsgBoxStyle.Exclamation, "Prohibicion")
            Eliminarcamara.eliminar.Checked = False
        End If
        If numero = 13 Then
            MsgBox("No se pudo eliminar la camara", MsgBoxStyle.Exclamation, "Problemas")
        End If

        If numero = 14 Then
            MsgBox("La camara que indico no existe", MsgBoxStyle.Information, "Indicar camara al desplegar")
            Eliminarcamara.modificar.Checked = False
        End If

        If numero = 15 Then
            MsgBox("No se puede desabilitar la camara,hay producto dentro", MsgBoxStyle.Critical, "Favor retirar producto")
            Eliminarcamara.modificar.Checked = False
        End If

        If numero = 16 Then
            MsgBox("Finalizar los productos para luego cambiar el tipo camara", MsgBoxStyle.Critical, "Finalizar")
            Eliminarcamara.modificar.Checked = False
        End If
        If numero = 17 Then
            MsgBox("La camara seleccionada, no tiene cargado ningun producto", MsgBoxStyle.Information, "Favor cargar")

            If Principal.iniciar.Text = "Parar" Then
                Principal.iniciar.PerformClick()
            End If

        End If

        If numero = 18 Then
            MsgBox("Favor seleccionar algunos de los perfiles pre cargados", MsgBoxStyle.Exclamation, "Indicar")
            Agregar_usuario.tipo.SelectedIndex = 0
            Agregar_usuario.tipo.Focus()
        End If


        If numero = 19 Then
            MsgBox("Tipo de camara vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 20 Then
            MsgBox("estado de camara vacio", MsgBoxStyle.Exclamation, "verificar")
        End If

        If numero = 21 Then
            MsgBox("Estado camara no puede quedar vacio", MsgBoxStyle.Exclamation, "Verificar")
            Eliminarcamara.estado_camara.Focus()
        End If

        If numero = 22 Then
            MsgBox("Tipo de camara no puede quedar vacio", MsgBoxStyle.Exclamation, "Verificar")
            Eliminarcamara.tipo_camara.Focus()
        End If


        If numero = 23 Then
            MsgBox("Numero no puede estar vacio", MsgBoxStyle.Exclamation, "verificar")
        End If


        If numero = 24 Then
            MsgBox("Usuario no encontrado", MsgBoxStyle.Exclamation, "verificar")
        End If

        If numero = 25 Then
            MsgBox("El rut que ha ingresado ya se encuentra en la bdd", MsgBoxStyle.Exclamation, "verificar")
        End If


        If numero = 26 Then
            MsgBox("El rut que ha ingresado no se encuentra en la bdd", MsgBoxStyle.Exclamation, "verificar")
        End If


    End Sub

    Public Sub errores_verificacion_nuevo_producto(numero As Integer)

        If numero = 1 Then
            MsgBox("Numero de camara vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If
        If numero = 2 Then
            MsgBox("Tipo de camara esta vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If
        If numero = 3 Then
            MsgBox("Estado de camara vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If
        If numero = 4 Then
            MsgBox("Tipo producto vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 5 Then
            MsgBox("Temperatura_ideal esta vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 6 Then
            MsgBox("Temperatura ideal esta vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 7 Then
            MsgBox("Codigo producto esta vacio", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 8 Then
            MsgBox("La camara que desea ocupar, esta en pleno proceso", MsgBoxStyle.Critical, "Prohibido")
        End If
    End Sub

    Public Sub error_conectar_bd(numero As Integer)

        If numero = 1 Then
            MsgBox("Verifique que todo este correctamente escrito", MsgBoxStyle.Information, "Verificar")
        End If

        If numero = 2 Then
            MsgBox("Los campos no pueden estar vacios", MsgBoxStyle.Exclamation, "Verificar")
        End If

    End Sub


    Public Sub mensaje_exito_carga_producto(tipo_producto As String)
        MsgBox("Se Agrego correctamente el producto:  " + tipo_producto, MsgBoxStyle.Information, "Agregado")
    End Sub

    Public Sub pantalla_eliminar_camara()
        Eliminarcamara.numero_camara.Enabled = True
        Eliminarcamara.modificar.PerformClick()
        Eliminarcamara.modificar.Checked = False
        Eliminarcamara.numero_camara.Enabled = True
    End Sub

    Public Sub elimino_camara(numero_camara As Integer)
        Principal.grilla.DataSource = Nothing
        MsgBox("Se ha Eliminado la camara numero " & numero_camara, MsgBoxStyle.Information, "Eliminado")
        Eliminarcamara.eliminar.Checked = False
        Eliminarcamara.numero_camara.Enabled = True
    End Sub

    Public Sub actualizacion_nuevo_producto(numero_camara As Integer)
        Nuevo_tipo_producto.numero_camara.Text = numero_camara
        Nuevo_tipo_producto.numero_camara.Focus()
    End Sub

    Public Sub actualizar_modificacion_camara(num_camara As Integer)
        Nuevo_tipo_producto.numero_camara.Text = num_camara
        Nuevo_tipo_producto.numero_camara.Focus()
        Nuevo_tipo_producto.cofigo_del_producto.Focus()
        Nuevo_tipo_producto.numero_camara.Focus()
    End Sub

    Public Sub camara_agregada()
        MsgBox("Camara agregada", MsgBoxStyle.Information, "Agregada")
    End Sub

    Public Sub campos_vacios(bandera As Boolean, num As Integer)
        If bandera = True And num = 1 Then
            MsgBox("Nombre de usuario esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            inicio_seccion.nombre.Focus()
        End If
        If bandera = True And num = 2 Then
            MsgBox("Clave esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            inicio_seccion.contraseña.Focus()
        End If

        If bandera = True And num = 3 Then
            MsgBox("Debe llenar los campos indicados para continuar", MsgBoxStyle.Information, "Siga las siguientes indicaciones")
            inicio_seccion.nombre.Focus()
        End If



        If bandera = False Then
            MsgBox("Nombre de usuario/contraseña erroneos", MsgBoxStyle.Critical, "Reintente")
            inicio_seccion.nombre.Clear()
            inicio_seccion.contraseña.Clear()
            inicio_seccion.nombre.Focus()
        End If
    End Sub

    Public Sub problemas_al_buscar_camara(numero As Integer)
        If numero = 1 Then
            'cuando no hay problemas
            Nuevo_tipo_producto.camara_de_tipo.Enabled = False
            Nuevo_tipo_producto.Estado_de_proceso.Enabled = False

        End If

        If numero = 2 Then
            MsgBox("Ha indicado una camara que no se encuentra en el sistema", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 3 Then
            MsgBox("Ha indicado una camara que no se encuentra en el sistema", MsgBoxStyle.Exclamation, "Verificar")
        End If
    End Sub


    Public Sub abrir_ventana(aprobado As Boolean)
        If aprobado = True Then
            Principal.Visible = True
            inicio_seccion.Close()
        Else
            'Principal.grilla.Rows.Clear()
            ' Principal.grilla.DataSource = Nothing
        End If
    End Sub
    Public Sub Parar(bandera As Boolean)
        If bandera = True Then
            Principal.grabar.Enabled = False
            MsgBox("Se detiene el proceso de captura de datos", MsgBoxStyle.Information, "Finalizacion")
            'Principal.grilla.Rows.Clear()
            Principal.grilla.DataSource = Nothing
            Principal.iniciar.Text = "Iniciar Captura"
            Principal.Camara.Enabled = True
            Principal.iniciar.Enabled = False
            Principal.trabajando.Visible = False
        End If
    End Sub

    Public Sub vista_privilegios(nivel_privilegio As String, nombre As String)
        If nivel_privilegio = "alto" Then
            MsgBox("Esta iniciando como administrador bd ", MsgBoxStyle.Information, "Administrador BD")
            Principal.nom_usuario.Text = nombre
        End If
        If nivel_privilegio = "medio" Then
            MsgBox("Esta iniciando personal de administracion ", MsgBoxStyle.Information, "Personal admin")
            Principal.ActivadorPuertoToolStripMenuItem.Visible = False
            Principal.nom_usuario.Text = nombre
        End If

        If nivel_privilegio = "bajo" Then
            MsgBox("Esta inciando como operador", MsgBoxStyle.Information, "Personal Operador")
            Principal.ActivadorPuertoToolStripMenuItem.Visible = False
            Principal.InformesToolStripMenuItem.Visible = False
            Principal.nom_usuario.Text = nombre
        End If
    End Sub

    Public Sub estado_usuario(estado_usuario As String)
        If estado_usuario = "desabilitado" Then
            MsgBox("Ud. no esta autorisado para entrar en el sistema", MsgBoxStyle.Critical, "Prohibicion")
            Principal.Close()
        End If


        If estado_usuario = "desabilitada" Then
            MsgBox("Su empresa no esta habilitada en el sistema", MsgBoxStyle.Critical, "Prohibicion")
            Principal.Close()
        End If

    End Sub

    Public Sub caracteres_erroneos_mensaje(dato As Boolean, vari As String)
        If dato = True Then

        Else
            If vari = "nombre" Then
                Agregar_usuario.nombre.Text = ""
                MsgBox("Nombre esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If
            If vari = "apellido" Then
                Agregar_usuario.apellido.Text = ""
                MsgBox("Apellido esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If
            If vari = "usuario" Then
                Agregar_usuario.usuario.Text = ""
                MsgBox("Usuario esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If
            If vari = "clave" Then
                Agregar_usuario.clave.Text = ""
                MsgBox("clave esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If
            If vari = "tipo" Then
                Agregar_usuario.tipo.Text = ""
                MsgBox("Tipo esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If

            If vari = "rut_empresa" Then
                Agregar_usuario.tipo.Text = ""
                MsgBox("Rut empresa esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If

            If vari = "Nombre_empresa" Then
                Agregar_usuario.tipo.Text = ""
                MsgBox("Nombre empresa esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If
            If vari = "Dirección_empresa" Then
                Agregar_usuario.tipo.Text = ""
                MsgBox("Dirección empresa esta vacio", MsgBoxStyle.Exclamation, "Verificar")
            End If
            If vari = "estado" Then
                Agregar_usuario.tipo.Text = ""
                MsgBox("Estado empresa debe contener desa/habilitado", MsgBoxStyle.Exclamation, "Verificar")
            End If
        End If
    End Sub

    Public Sub agregado(usuario As String, bandera As Boolean)
        If bandera = True Then
            MsgBox("Se ha agregado correctamente al usuario :" & usuario, MsgBoxStyle.Information, "Agregado")
            Agregar_usuario.nombre.Text = ""
            Agregar_usuario.apellido.Text = ""
            Agregar_usuario.usuario.Text = ""
            Agregar_usuario.clave.Text = ""
            Agregar_usuario.tipo.Text = ""
            Agregar_usuario.nombre.Focus()
        Else
            MsgBox("Nombre de usuario no disponible", MsgBoxStyle.Information, "No disponible")
            Agregar_usuario.usuario.Text = ""
            Agregar_usuario.usuario.Focus()
        End If
    End Sub

    Public Sub error_numerico(bandera As Boolean)
        If bandera = True Then
            MsgBox("Solo puede marcar numero de camara", MsgBoxStyle.Information, "Verificar")
            Nuevo_tipo_producto.numero_camara.SelectedIndex = 0
            Nuevo_tipo_producto.numero_camara.Focus()
        End If
    End Sub


    Public Sub foto(tipo_producto As String)
        If tipo_producto = "Carnes" Then
            Nuevo_tipo_producto.foto1.Visible = True
            Nuevo_tipo_producto.foto2.Visible = False
            Nuevo_tipo_producto.foto3.Visible = False
        End If
        If tipo_producto = "Vegetales" Then
            Nuevo_tipo_producto.foto1.Visible = False
            Nuevo_tipo_producto.foto2.Visible = True
            Nuevo_tipo_producto.foto3.Visible = False
        End If

        If tipo_producto = "Pescado" Then
            Nuevo_tipo_producto.foto1.Visible = False
            Nuevo_tipo_producto.foto2.Visible = False
            Nuevo_tipo_producto.foto3.Visible = True
        End If
    End Sub

    Public Sub dato_vacio()
        MsgBox("No puede dejar vacio el tipo de camara a agregar", MsgBoxStyle.Information, "Verificar")
        Agregar_camara.tipo_de_camara.Focus()
    End Sub


    Public Sub dato_vacio(bandera As Boolean)
        If bandera = True Then
            MsgBox("Favor indicar la camara que desea eliminar", MsgBoxStyle.Exclamation, "Verificar")
            Eliminarcamara.numero_camara.Focus()
        End If
    End Sub


    Public Sub mostrar_camara_a_modificar(dr1 As DataRow)
        Eliminarcamara.c_numero_camara.Text = dr1("id_camara").ToString
        Eliminarcamara.tipo_camara.Text = dr1("tipo_camara").ToString
        Eliminarcamara.estado_camara.Text = dr1("estado_camara").ToString
        Eliminarcamara.modificar.Checked = False
        Eliminarcamara.realizar.Enabled = True
        Eliminarcamara.numero_camara.Enabled = False
        Principal.grilla.ClearSelection()
        Eliminar_usuario.grilla_usuario.ClearSelection()
        Principal.grilla.DataSource = Nothing
    End Sub


    Public Sub inicio_nuevo_producto()
        Nuevo_tipo_producto.foto1.Visible = False
        Nuevo_tipo_producto.foto2.Visible = False
        Nuevo_tipo_producto.foto3.Visible = False
        Nuevo_tipo_producto.numero_camara.Text = ""
        Nuevo_tipo_producto.camara_de_tipo.Text = ""
        Nuevo_tipo_producto.Estado_de_proceso.Text = ""
        Nuevo_tipo_producto.tipo_producto.Text = ""
        Nuevo_tipo_producto.bueno.Checked = True
        Nuevo_tipo_producto.cofigo_del_producto.Text = ""
        Nuevo_tipo_producto.numero_camara.SelectedIndex = 0
    End Sub

    Public Sub temperatura_ideal_error()
        MsgBox("Temperatura ideal solo acepta numeros", MsgBoxStyle.Exclamation, "Verificar")
        Nuevo_tipo_producto.numeric.Focus()
    End Sub


    Public Sub cambiar_estado_proceso(bandera As Boolean, numero_camara As Integer)
        Dim capa_datos As New capa_datos
        Dim respuesta As Object

        respuesta = MsgBox("¿Desea finalizar el proceso del producto?", MsgBoxStyle.YesNo, "Advertencia")
        If respuesta = vbYes Then
            capa_datos.cambiar_estado_camara(Val(numero_camara))
        End If

        If respuesta = vbNo Then

        End If
    End Sub

    Public Sub problemas_capa_negocio(numero As Integer)
        If numero = 1 Then
            MsgBox("Tiempo de espera agotado, no se establecio conexion", MsgBoxStyle.Critical, "Limite  de tiempo")
        End If

        If numero = 2 Then
            MsgBox("problemas en el timer en tiempo de ejecucion", MsgBoxStyle.Critical, "Problemas en timer interno")
        End If
    End Sub



    Public Sub modificaciones_visual_eliminar_camara(numero As Integer)
        If numero = 1 Then
            Eliminarcamara.grilla_eliminar.Visible = False
            Eliminarcamara.Label2.Visible = False
            Eliminarcamara.datos_a_modificar.Visible = False
            Eliminarcamara.Height = 154
        End If


        If numero = 2 Then

            MsgBox("Primero debe indicar la camara a modicar", MsgBoxStyle.Exclamation, "Verificar")
            Eliminarcamara.numero_camara.SelectedIndex = 0
            Eliminarcamara.eliminar.Checked = False
        End If

        If numero = 3 Then
            Eliminarcamara.Height = 154
            Eliminarcamara.grilla_eliminar.Visible = False
            Eliminarcamara.Label2.Visible = False
        End If


        If numero = 4 Then
            Eliminarcamara.Label2.Visible = True
            Eliminarcamara.grilla_eliminar.Visible = True
            Eliminarcamara.Height = 385
            Eliminarcamara.datos_a_modificar.Visible = True
        End If

        If numero = 5 Then
            MsgBox("Primero debe indicar la camara a modificar", MsgBoxStyle.Exclamation, "Verificar")
            Eliminarcamara.numero_camara.SelectedIndex = 0
            Eliminarcamara.modificar.Checked = False
        End If
    End Sub

    Public Sub load_eliminar_usuario()
        Eliminar_usuario.Height = 134
        Eliminar_usuario.grupo_dato_usuario.Visible = False
        Eliminar_usuario.grupo_que_hacer.Visible = False
        Eliminar_usuario.Visible = False
        Eliminar_usuario.grilla_usuario.Visible = False
    End Sub

    Public Sub modificar_con_checked()
        Eliminar_usuario.Height = 500
        Eliminar_usuario.grupo_dato_usuario.Visible = True
        Eliminar_usuario.realizar.Text = "Modificar"
    End Sub

    Public Sub eliminar_con_checked()
        Eliminar_usuario.Height = 500
        Eliminar_usuario.grupo_dato_usuario.Visible = True
        Eliminar_usuario.realizar.Text = "Modificar"
    End Sub


    Public Sub problemas_busqueda_principal(numero As Integer)

        If numero = 1 Then
            MsgBox("La camara seleccionada no esta disponible, favor elegir otra", MsgBoxStyle.Exclamation, "Verificar")
        End If

        If numero = 2 Then
            MsgBox("La camara esta finalizada favor cargar producto", MsgBoxStyle.Information, "Cargar...")
        End If

        If numero = 3 Then
            MsgBox("La camara que eligio aun no tiene cargado producto", MsgBoxStyle.Exclamation, "Cargar producto...")
        End If


        If numero = 4 Then
            MsgBox("Camara disponible para el inicio de captura", MsgBoxStyle.Information, "Inicializando")
        End If

        If numero = 5 Then
            Principal.ComboBox1.Enabled = False
            Principal.iniciar.Enabled = True
        End If
    End Sub



    Public Sub checked(numero As Integer)
        If numero = 1 Then
            Informes.Graficas_rendimiento_camara.Checked = False
        End If

        If numero = 2 Then
            Informes.Graficas_rendimiento_camara.Checked = False
            graficas_por_camara.Close()
            MsgBox("sql caido")
        End If

        If numero = 3 Then
            Informes.temp_prome_por_camara.Checked = False
        End If


        If numero = 4 Then
            Informes.temp_prome_por_camara.Checked = False
            Informe_promedio_por_camara.Close()
            MsgBox("sql caido")
        End If


        If numero = 5 Then
            Informes.listado_x_camara.Checked = False
        End If

        If numero = 6 Then
            Informes.listado_x_camara.Checked = False
            listado_por_camara.Close()
            MsgBox("sql caido")
        End If

        If numero = 7 Then
            Informes.Temp_actual.Checked = False
        End If

        If numero = 8 Then
            Informes.Temp_actual.Checked = False
            Temperatura_actual.Close()
            MsgBox("sql caido")
        End If

        If numero = 9 Then
            Informes.temp_product_y_cam.Checked = False
        End If

        If numero = 10 Then
            Informes.temp_product_y_cam.Checked = False
            Temperatura_tipo_producto_camara.Close()
            MsgBox("sql caido")
        End If

        If numero = 11 Then
            Informes.Trazabili.Checked = False
        End If

        If numero = 12 Then
            Informes.Trazabili.Checked = False
            Trazabilidad.Close()
            MsgBox("sql caido")
        End If

        If numero = 13 Then
            MsgBox("Favor indicar codigo producto antes de buscar")
        End If
    End Sub

    Public Sub empresa_agregada()
        MsgBox("empresa agregada correctamente")
    End Sub
    Public Sub modifi_empresa()
        MsgBox("Se ha modificado correctamente")
    End Sub
End Class
