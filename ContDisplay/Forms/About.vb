Public Class About
    Private Sub About_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "1" Then
            Me.Close()
        End If
    End Sub
End Class