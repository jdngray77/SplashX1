Public Class DebugTeleport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GameEngine.PlayerGoTo(txtVertical.Text, txtHorizontal.Text)
        Me.Hide()
    End Sub

    Private Sub DebugTeleport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class