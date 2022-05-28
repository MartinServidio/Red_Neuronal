Public Class Encuesta
    Dim Repor As New Reporte

    Dim resuFin As String
    Public Primaria As Double
    Public Secundaria As Double
    Public Terciario As Double
    Public Deportes As Double
    Public Musica As Double
    Public Pasatiempo As Double
    Public Practicas As Double
    Public Cursos As Double
    Public Sab_Ingles As Double
    Public Sab_Manua As Double
    Public Sab_Mate As Double
    Public Cons_Labo As Double
    Public Cons_Fami As Double
    Public Cons_Ami As Double
    Public Ayudante As Double
    Public Grupo_Social As Double

    Public Property resulFin As String
        Get
            Return resuFin
        End Get
        Set(value As String)
            resuFin = resulFin
        End Set
    End Property

    Public Sub PedirDatosEncuesta(Pri As Double, Sec As Double, Ter As Double, Depor As Double, Musi As Double, Pasa As Double, Prac As Double, Cur As Double, SabI As Double, SabMN As Double, SabMT As Double, ConL As Double, ConF As Double, ConA As Double, Ayu As Double, GruP As Double)
        Primaria = Pri
        Secundaria = Sec
        Terciario = Ter
        Deportes = Depor
        Musica = Musi
        Pasatiempo = Pasa
        Practicas = Prac
        Cursos = Cur
        Sab_Ingles = SabI
        Sab_Manua = SabMN
        Sab_Mate = SabMT
        Cons_Labo = ConL
        Cons_Fami = ConF
        Cons_Ami = ConA
        Ayudante = Ayu
        Grupo_Social = GruP

        Repor.LevantarPesos()
    End Sub

    Public Function Prediccion()
        Dim W As Double(,,)
        Dim U As Double(,)
        Dim A As Double(,)
        Dim i As Integer = 0
        Dim j As Integer = 0

        Dim cont1 As Integer = 0
        Dim cont2 As Integer = 0
        Dim resultado As Double
        Dim TotalEntradas As Integer = 16
        Dim TotalSalidas As Integer = 1
        Dim TotalCapas As Integer = 3
        Dim neuronasporcapa As Integer() = New Integer(TotalCapas) {}
        neuronasporcapa(0) = TotalEntradas
        neuronasporcapa(1) = 5
        neuronasporcapa(2) = 2
        neuronasporcapa(3) = TotalSalidas
        Dim maximoregistros As Integer = 0


        Dim entrada As Double()() = New Double(maximoregistros)() {}
        entrada(0) = New Double() {Convert.ToDouble(Primaria), Convert.ToDouble(Secundaria), Convert.ToDouble(Terciario), Convert.ToDouble(Deportes), Convert.ToDouble(Musica), Convert.ToDouble(Pasatiempo), Convert.ToDouble(Practicas), Convert.ToDouble(Cursos), Convert.ToDouble(Sab_Ingles), Convert.ToDouble(Sab_Manua), Convert.ToDouble(Sab_Mate), Convert.ToDouble(Cons_Labo), Convert.ToDouble(Cons_Fami), Convert.ToDouble(Cons_Ami), Convert.ToDouble(Ayudante), Convert.ToDouble(Grupo_Social)}

        W = New Double(TotalCapas, 16, 16) {}
        U = New Double(TotalCapas, 16) {}
        A = New Double(TotalCapas, 16) {}

        For capa As Integer = 1 To TotalCapas

            For p As Integer = 0 To neuronasporcapa(capa) - 1
                U(capa, p) = Repor.Umbrales(cont1)
                cont1 += 1
            Next
        Next
        For capa As Integer = 0 To TotalCapas - 1

            For p As Integer = 0 To neuronasporcapa(capa) - 1
                For k As Integer = 0 To neuronasporcapa(capa + 1) - 1
                    W(capa, p, k) = Repor.Pesos(cont2)
                    cont2 += 1
                Next
            Next
        Next
        For copia As Integer = 0 To TotalEntradas - 1
            A(0, copia) = entrada(0)(copia)
        Next

        For capa As Integer = 1 To TotalCapas

            For neurona As Integer = 0 To neuronasporcapa(capa) - 1
                A(capa, neurona) = 0

                For entra As Integer = 0 To neuronasporcapa(capa - 1) - 1
                    A(capa, neurona) += A(capa - 1, entra) * W(capa - 1, entra, neurona) + 1 * U(capa, neurona)
                Next

                A(capa, neurona) = 1 / (1 + Math.Exp(-A(capa, neurona)))

                If capa = TotalCapas Then

                    resultado = A(capa, neurona)

                End If

            Next
        Next


        Return resultado
    End Function

    Public Sub guardaInd()
        Dim conex As New ConectarSQL
        Dim sql As String

        sql = "call tdv.sp_GuardarInd('" + Str(Convert.ToDouble(Primaria)) + "', '" + Str(Convert.ToDouble(Secundaria)) + "', '" + Str(Convert.ToDouble(Terciario)) + "', '" + Str(Convert.ToDouble(Deportes)) + "', '" + Str(Convert.ToDouble(Musica)) + "', '" + Str(Convert.ToDouble(Pasatiempo)) + "', '" + Str(Convert.ToDouble(Practicas)) + "', '" + Str(Convert.ToDouble(Cursos)) + "', '" + Str(Convert.ToDouble(Sab_Ingles)) + "', '" + Str(Convert.ToDouble(Sab_Manua)) + "', '" + Str(Convert.ToDouble(Sab_Mate)) + "', '" + Str(Convert.ToDouble(Cons_Labo)) + "', '" + Str(Convert.ToDouble(Cons_Fami)) + "', '" + Str(Convert.ToDouble(Cons_Ami)) + "', '" + Str(Convert.ToDouble(Ayudante)) + "', '" + Str(Convert.ToDouble(Grupo_Social)) + "');"
        conex.EjecutarSQL(sql)
        conex.Dispose()
    End Sub

    Public Function Pred(resulFin As String) As Boolean
        resuFin = resulFin
        Dim conex As New ConectarSQL
        Dim sql As String
        Dim resul As Integer

        sql = "use tdv;call tdv.sp_Prediccion('" + Str(resulFin) + "');"
        conex.EjecutarSQL(sql)
        resul = conex.Micomando.ExecuteScalar()

        If resul = 1 Then
            Return True
        Else
            Return False
        End If
        conex.Dispose()
    End Function
End Class
