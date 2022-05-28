Public Class Historiales
    Dim histo As New Gestor_de_Historiales

    Private Sub Historiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(histo.PedirHistorial)
    End Sub
End Class