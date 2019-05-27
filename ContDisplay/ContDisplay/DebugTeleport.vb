Public Class DebugTeleport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim topos As String = "X" & txtVertical.Text & "Y" & txtHorizontal.Text
        GameEngine.PlayerGoTo(topos)
        Me.Hide()
    End Sub
End Class