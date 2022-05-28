Public Class Ingresar
    Dim tUsuario = New Usuario
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        If tUsuario.Loguear(TBnombre.Text, TBmail.Text, TBcontraseña.Text) = True Then
            MsgBox("Ingreso valido")
            Me.Hide()
            Perfil.Show()
        Else
            MsgBox("Ingrese un usuario existente")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Registrar.Show()
    End Sub

End Class
