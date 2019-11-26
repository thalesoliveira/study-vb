Public Class Form1
    Dim db As New linqDataContext

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        db.Log = Console.Out

        ' Add any initialization after the InitializeComponent() call.

        Me.CategoryBindingSource.DataSource = db.Categories

    End Sub

End Class
