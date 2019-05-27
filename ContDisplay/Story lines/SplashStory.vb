Public Class SplashStory
    Public progress = 1
    Public Sub Trigger(Trigger)
        Select Case progress
            Case 1
                If Trigger = "StartGame" Then
                    MessageEngine.display("Use the WASD keys to move your character!")
                    progwrite(1)
                End If
            Case 2
                If Trigger = "5Movement" Then
                    MessageEngine.display("Walk over to the axe, i got something cool to show you!")
                    GameEngine.PlacePixel(6, 2, "StoryPointerLeft", "UpdateDrawn")
                    progwrite(1)
                End If
            Case 3
                If Trigger = "StoryPointerLeft" Then
                    MessageEngine.display("Walk in to axe, then press 1 to use it!")
                    progwrite(1)
                End If
            Case 4
                If Trigger = "PathAxe" Then
                    MessageEngine.AddLine("Using an item enters you into selecter mode.", "cls")
                    MessageEngine.AddLine("In selecter mode, use the WASD keys to move the selecter to a target.", "null")
                    MessageEngine.AddLine("Then you can press action (1) to attempt to use the axe on an object,", "null")
                    MessageEngine.AddLine("Try cutting down a tree!", "null")
                    MessageEngine.display("null")
                    progwrite(1)
                End If
        End Select
    End Sub

    Private Sub progwrite(prog)
        progress += 1
        FileWrite.WriteToTable(2, 5, progress)
    End Sub
End Class
