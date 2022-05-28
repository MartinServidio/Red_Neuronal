Public Class Usuario
    Private _Nombre As String
    Private _Apellido As String
    Private _Mail As String
    Private _Contraseña As String

    Public Property pNombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = pNombre
        End Set
    End Property
    Public Property pApellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = pApellido
        End Set
    End Property
    Public Property pMail As String
        Get
            Return _Mail
        End Get
        Set(value As String)
            _Mail = pMail
        End Set
    End Property
    Public Property pContraseña As String
        Get
            Return _Contraseña
        End Get
        Set(value As String)
            _Contraseña = pContraseña
        End Set
    End Property

    Public Function Loguear(Nombre As String, Mail As String, Contraseña As String) As Boolean
        Dim conex As New ConectarSQL
        Dim sql As String
        Dim resul As Integer


        sql = "use tdv;Call tdv.sp_Loguear('" + Nombre + "','" + Mail + "', '" + Contraseña + "');"
        conex.EjecutarSQL(sql)
        resul = conex.Micomando.ExecuteScalar()

        If resul = 1 Then
            Return True
        Else
            Return False
        End If
        conex.Dispose()
    End Function


    Public Function CrearUsuario(Nombre As String, Apellido As String, Contraseña As String, Mail As String) As Boolean
        Dim Validador As Boolean
        Dim resul As Boolean
        Dim Sql As String
        Dim Conex As New ConectarSQL
        pNombre = Nombre
        pApellido = Apellido
        pContraseña = Contraseña
        pMail = Mail

        Sql = "use tdv;Call tdv.sp_Val_Crear('" + Mail + "');"
        Conex.EjecutarSQL(Sql)
        resul = Conex.Micomando.ExecuteScalar()

        If resul = 0 Then
            Try
                Sql = "use tdv;Call tdv.sp_CrearUsuario('" + Nombre + "','" + Apellido + "','" + Contraseña + "','" + Mail + "');"
                Conex.EjecutarSQL(Sql)
                Conex.Dispose()
                Validador = True
            Catch ex As Exception
                Validador = False
            End Try
        Else
            Return False
        End If
        Return Validador
    End Function

    Public Function Val_Crear(Mail As String) As Boolean
        Dim Validador As Boolean
        Dim Sql As String
        Dim Conex As New ConectarSQL
        pMail = Mail

        Sql = "use tdv;Call tdv.sp_Val_Crear('" + Mail + "');"
        Conex.EjecutarSQL(Sql)
        Validador = Conex.Micomando.ExecuteScalar()

        If Validador = 1 Then
            Return True
        Else
            Return False
        End If
        Conex.Dispose()
    End Function
End Class
