Imports MySql.Data.MySqlClient
Public Class ConectarSQL
    Private Miconexion As New MySqlConnection
    Public Micomando As New MySqlCommand
    Public mydataset As New DataSet
    Public mydataAdapter As New MySqlDataAdapter

    Public Sub New()
        Try
            Miconexion.ConnectionString = "Server = localhost;Uid=root;Pwd=et24"
            Miconexion.Open()
            Micomando.Connection = Miconexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub EjecutarSQL(sentenciaSQL As String)
        Micomando.CommandText = sentenciaSQL
        Micomando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        Miconexion.Close()
        Miconexion.Dispose()
        Micomando.Dispose()
    End Sub
End Class

