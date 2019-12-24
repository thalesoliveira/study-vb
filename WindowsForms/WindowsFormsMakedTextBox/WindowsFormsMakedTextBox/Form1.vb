Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        MaskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        MaskedTextBox3.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        MaskedTextBox4.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        MaskedTextBox5.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        MaskedTextBox6.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals

        Label7.Text = MaskedTextBox1.Text
        Label8.Text = MaskedTextBox2.Text
        Label9.Text = MaskedTextBox3.Text
        Label10.Text = MaskedTextBox4.Text
        Label11.Text = MaskedTextBox5.Text
        Label12.Text = MaskedTextBox6.Text

    End Sub
End Class
