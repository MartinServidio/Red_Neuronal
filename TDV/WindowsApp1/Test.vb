Public Class Test
    Dim resultado As Double
    Dim resultadoCate As String
    Dim TDV As New Encuesta

    Public Function ResulPredi() As String
        resultado = TDV.Prediccion
        If resultado > 0.01 And resultado < 0.06 Then
            MsgBox("Le recomendamos como vocacion ser: Arquitecto")
            resultadoCate = "Arquitecto"
        ElseIf resultado > 0.09 And resultado < 0.11 Then
            MsgBox("Le recomendamos como vocacion ser: Desarrollador de sistemas")
            resultadoCate = "Desarrollador de sistemas"
        ElseIf resultado > 0.14 And resultado < 0.16 Then
            MsgBox("Le recomendamos como vocacion ser: Desarrollador de sistemas o videojuegos")
            resultadoCate = "Desarrollador de sistemas o videojuegos"
        ElseIf resultado > 0.19 And resultado < 0.21 Then
            MsgBox("Le recomendamos como vocacion ser: Ser Administrador de Servicios turísticos y hoteleros")
            resultadoCate = "Ser Administrador de Servicios turísticos y hoteleros"
        ElseIf resultado > 0.24 And resultado < 0.26 Then
            MsgBox("Le recomendamos como vocacion ser: Ser bombero")
            resultadoCate = "Ser bombero"
        ElseIf resultado > 0.29 And resultado < 0.31 Then
            MsgBox("Le recomendamos como vocacion ser: Ser cantante de cumbia")
            resultadoCate = "Ser cantante de cumbia"
        ElseIf resultado > 0.34 And resultado < 0.36 Then
            MsgBox("Le recomendamos como vocacion ser: Ser cantante de rock")
            resultadoCate = "Ser cantante de rock"
        ElseIf resultado > 0.39 And resultado < 0.41 Then
            MsgBox("Le recomendamos como vocacion ser: Ser cantante de trap")
            resultadoCate = "Ser cantante de trap"
        ElseIf resultado > 0.44 And resultado < 0.46 Then
            MsgBox("Le recomendamos como vocacion ser: Ser jugador profesional del deporte que te guste")
            resultadoCate = "Ser jugador profesional del deporte que te guste"
        ElseIf resultado > 0.49 And resultado < 0.51 Then
            MsgBox("Le recomendamos como vocacion ser: Ser medico")
            resultadoCate = "Ser medico"
        ElseIf resultado > 0.54 And resultado < 0.56 Then
            MsgBox("Le recomendamos como vocacion ser: Ser musico")
            resultadoCate = "Ser musico"
        ElseIf resultado > 0.59 And resultado < 0.61 Then
            MsgBox("Le recomendamos como vocacion ser: Ser policia")
            resultadoCate = "Ser policia"
        ElseIf resultado > 0.64 And resultado < 0.66 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de educacion fisica")
            resultadoCate = "Ser profesor de educacion fisica"
        ElseIf resultado > 0.69 And resultado < 0.71 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de ingles")
            resultadoCate = "Ser profesor de ingles"
        ElseIf resultado > 0.74 And resultado < 0.76 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de manualidades")
            resultadoCate = "Ser profesor de manualidades"
        ElseIf resultado > 0.79 And resultado < 0.81 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de matematica")
            resultadoCate = "Ser profesor de matematica"
        ElseIf resultado > 0.84 And resultado < 0.86 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de primaria")
            resultadoCate = "Ser profesor de primaria"
        ElseIf resultado > 0.89 And resultado < 0.91 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de secundaria")
            resultadoCate = "Ser profesor de secundaria"
        ElseIf resultado > 0.94 And resultado < 0.96 Then
            MsgBox("Le recomendamos como vocacion ser: Ser profesor de terciario")
            resultadoCate = "Ser profesor de terciario"
        End If

        TDV.Pred(resultado)

        Return resultadoCate
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim CBDepor = ComboBox1.SelectedItem
        Dim ValorDepor As Double
        If CBDepor = "Ninguno" Then ValorDepor = 0
        If CBDepor = "Basket" Then ValorDepor = 1
        If CBDepor = "Futbol" Then ValorDepor = 2
        If CBDepor = "Natacion" Then ValorDepor = 3
        If CBDepor = "Tenis" Then ValorDepor = 4

        Dim CBMusi = ComboBox2.SelectedItem
        Dim ValorMusica As Double
        If CBMusi = "Ninguna" Then ValorMusica = 0
        If CBMusi = "Clasica" Then ValorMusica = 1
        If CBMusi = "Cumbia" Then ValorMusica = 2
        If CBMusi = "Electronica" Then ValorMusica = 3
        If CBMusi = "Rock" Then ValorMusica = 4
        If CBMusi = "Trap" Then ValorMusica = 5

        Dim CBPasa = ComboBox3.SelectedItem
        Dim ValorPasa As Double
        If CBPasa = "Aprender idiomas nuevos" Then ValorPasa = 1
        If CBPasa = "Aprender y estudiar cosas nuevas" Then ValorPasa = 2
        If CBPasa = "Cantar" Then ValorPasa = 3
        If CBPasa = "Dibujar" Then ValorPasa = 4
        If CBPasa = "Dibujar y hacer artes manuales" Then ValorPasa = 5
        If CBPasa = "Investigar el funcionammiento de la pc" Then ValorPasa = 6
        If CBPasa = "Jugar con la pc" Then ValorPasa = 7
        If CBPasa = "Practicar y mirar deportes" Then ValorPasa = 8
        If CBPasa = "Tocar un instrumento" Then ValorPasa = 9

        Dim CBConL = ComboBox4.SelectedItem
        Dim ValorConL As Double
        If CBConL = "No" Then ValorConL = 1
        If CBConL = "Ser bombero" Then ValorConL = 2
        If CBConL = "Ser cantante" Then ValorConL = 3
        If CBConL = "Ser jugador profesional" Then ValorConL = 4
        If CBConL = "Ser medico" Then ValorConL = 5
        If CBConL = "Ser policia" Then ValorConL = 6
        If CBConL = "Ser profesor" Then ValorConL = 7

        Dim CBConF = ComboBox5.SelectedItem
        Dim ValorConF As Double
        If CBConF = "No" Then ValorConF = 1
        If CBConF = "Ser cantante" Then ValorConF = 2
        If CBConF = "Ser medico" Then ValorConF = 3
        If CBConF = "Ser policia" Then ValorConF = 4
        If CBConF = "Ser profesor" Then ValorConF = 5

        Dim CBConA = ComboBox6.SelectedItem
        Dim ValorConA As Double
        If CBConA = "No" Then ValorConA = 1
        If CBConA = "Ser cantante" Then ValorConA = 2
        If CBConA = "Ser jugador profesional" Then ValorConA = 3
        If CBConA = "Ser medico" Then ValorConA = 4
        If CBConA = "Ser policia" Then ValorConA = 5
        If CBConA = "Ser profesor" Then ValorConA = 6


        Dim CBGru = ComboBox7.SelectedItem
        Dim ValorGru As Double
        If CBGru = "Niño" Then ValorGru = 1
        If CBGru = "Adolescente" Then ValorGru = 2
        If CBGru = "Adulto" Then ValorGru = 3

        Dim pri As Double
        If RbPri.Checked Then
            pri = 1
        Else
            pri = 0
        End If

        Dim sec As Double
        If RbSec.Checked Then
            sec = 1
        Else
            sec = 0
        End If

        Dim ter As Double
        If RbTer.Checked Then
            ter = 1
        Else
            ter = 0
        End If

        Dim pra As Double
        If RbPrac.Checked Then
            pra = 1
        Else
            pra = 0
        End If

        Dim cur As Double
        If RbCur.Checked Then
            cur = 1
        Else
            cur = 0
        End If

        Dim ing As Double
        If RbIng.Checked Then
            ing = 1
        Else
            ing = 0
        End If

        Dim man As Double
        If RbManu.Checked Then
            man = 1
        Else
            man = 0
        End If

        Dim mat As Double
        If RbMate.Checked Then
            mat = 1
        Else
            mat = 0
        End If

        Dim ayu As Double
        If RbAyu.Checked Then
            ayu = 1
        Else
            ayu = 0
        End If

        If MsgBox("No podra cambiar sus respuestas luego, desea continuar?", vbYesNo) = MsgBoxResult.Yes Then
            Dim contador As Integer = 15
            Dim respuestas(contador) As Boolean
            respuestas(0) = pri
            respuestas(1) = sec
            respuestas(2) = ter
            respuestas(3) = ValorDepor
            respuestas(4) = ValorMusica
            respuestas(5) = ValorPasa
            respuestas(6) = pra
            respuestas(7) = cur
            respuestas(8) = ing
            respuestas(9) = man
            respuestas(10) = mat
            respuestas(11) = ValorConL
            respuestas(12) = ValorConF
            respuestas(13) = ValorConA
            respuestas(14) = ayu
            respuestas(15) = ValorGru


            TDV.PedirDatosEncuesta(respuestas(0), respuestas(1), respuestas(2), respuestas(3), respuestas(4), respuestas(5), respuestas(6), respuestas(7), respuestas(8), respuestas(9), respuestas(10), respuestas(11), respuestas(12), respuestas(13), respuestas(14), respuestas(15))

            ResulPredi()
        Else
            MsgBox("Corriga los datos seleccionados")
        End If


        TDV.guardaInd()
    End Sub

    Private Sub RbAyu_CheckedChanged(sender As Object, e As EventArgs) Handles RbAyu.CheckedChanged
        If RbAyu.Checked = True Or RadioButton17.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Perfil.Show()
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = True
        End If
    End Sub
End Class