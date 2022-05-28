<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar))
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TBcontra = New System.Windows.Forms.TextBox()
        Me.TBmail = New System.Windows.Forms.TextBox()
        Me.TBapell = New System.Windows.Forms.TextBox()
        Me.TBnom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnConfirmar
        '
        resources.ApplyResources(Me.BtnConfirmar, "BtnConfirmar")
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TBcontra
        '
        resources.ApplyResources(Me.TBcontra, "TBcontra")
        Me.TBcontra.Name = "TBcontra"
        '
        'TBmail
        '
        resources.ApplyResources(Me.TBmail, "TBmail")
        Me.TBmail.Name = "TBmail"
        '
        'TBapell
        '
        resources.ApplyResources(Me.TBapell, "TBapell")
        Me.TBapell.Name = "TBapell"
        '
        'TBnom
        '
        resources.ApplyResources(Me.TBnom, "TBnom")
        Me.TBnom.Name = "TBnom"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Registrar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TBcontra)
        Me.Controls.Add(Me.TBmail)
        Me.Controls.Add(Me.TBapell)
        Me.Controls.Add(Me.TBnom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Registrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TBcontra As TextBox
    Friend WithEvents TBmail As TextBox
    Friend WithEvents TBapell As TextBox
    Friend WithEvents TBnom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
