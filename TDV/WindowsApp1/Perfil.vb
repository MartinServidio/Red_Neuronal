Public Class Perfil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Test.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Historiales.Show()
    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Text = Ingresar.TBnombre.Text
    End Sub
End Class