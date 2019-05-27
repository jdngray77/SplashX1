Public Class DebugKeyCharConverter
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 1 Then
            Exit Sub
        ElseIf TextBox1.Textlength < 1 Then
            Exit Sub
        Else
            Label1.Text = Asc(TextBox1.Text)
        End If
    End Sub
End Class