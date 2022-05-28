Public Class Reporte
    Private _pesos(91)
    Private _umbrales(7)

    Public Property Pesos(ByVal p As Integer) As Double
        Get
            Return _pesos(p)
        End Get
        Set(value As Double)
            _pesos(p) = value
        End Set
    End Property
    Public Property Umbrales(ByVal u As Integer) As Double
        Get
            Return _umbrales(u)
        End Get
        Set(value As Double)
            _umbrales(u) = value
        End Set
    End Property

    Public Sub LevantarPesos()
        Dim u As Integer = 0
        Dim p As Integer = 0
        Dim ArPesos As String = "D:\Tarea del cole 2021\red_entrenamiento\pesos.txt"
        Dim ArUmbrales As String = "D:\Tarea del cole 2021\red_entrenamiento\umbrales.txt"

        Dim MiArPesos As New System.IO.StreamReader(ArPesos)
        Dim MiArUmbrales As New System.IO.StreamReader(ArUmbrales)

        While MiArPesos.peek() <> -1
            Pesos(p) = MiArPesos.ReadLine
            p += 1
        End While
        While MiArUmbrales.Peek() <> -1
            Pesos(u) = MiArUmbrales.ReadLine
            u += 1
        End While
    End Sub
End Class
