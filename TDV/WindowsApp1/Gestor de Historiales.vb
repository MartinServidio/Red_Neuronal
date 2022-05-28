Public Class Gestor_de_Historiales
    Public Prediccion As Boolean
    Public Function PedirHistorial() As String
        Dim conex As New ConectarSQL
        Dim sql As String
        Dim resul As String

        sql = "Call tdv.sp_Pedir_Historial;"
        conex.EjecutarSQL(sql)
        resul = conex.Micomando.ExecuteScalar()
        conex.Dispose()
        Return resul
    End Function
End Class
