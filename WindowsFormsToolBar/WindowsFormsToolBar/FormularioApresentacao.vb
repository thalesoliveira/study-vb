Public Class FormularioApresentacao
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.CenterToParent()
        Me.Opacity = 0.01
        Timer1.Interval = 50
        Timer1.Enabled = True

    End Sub

    Private Sub FormularioApresentacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.01

        If Me.Opacity = 1 Then
            Timer1.Enabled = False
            Visible = False
            Close()
        End If
    End Sub
End Class