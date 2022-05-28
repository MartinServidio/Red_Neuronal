Public Class Registrar
    Dim tUsuario = New Usuario
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Hide()
        Ingresar.Show()
    End Sub

    Public Sub RegistraUsua()
        If tUsuario.CrearUsuario(Me.TBnom.Text, Me.TBapell.Text, Me.TBcontra.Text, Me.TBmail.Text) = True Then
            MsgBox("Usuario creado con exito")
            Me.Hide()
            Ingresar.Show()
        Else
            MsgBox("El usuario no se puede crear, ingrese otros datos")
        End If
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If TBmail.Text.Contains("@") And TBmail.Text.Contains(".com") = True Then
            RegistraUsua()
        Else
            MsgBox("Ingrese un correo valido")
        End If
    End Sub
End Class