Public Class GameEngine
    '=========================Map====================
    Private Sub initMap(targetmap As SplashMap)

        targetmap.Initialise()

        Try

            For rowcount = 0 To targetmap.xRes Step 1
                'for each row on the map
                For columncount = 0 To targetmap.yRes Step 1
                    'place the pixel in each column
                    Dim pos = "X" & rowcount & "Y" & columncount
                    Dim targetStyle = targetmap.charSet(rowcount, columncount)
                    PlacePixel(pos, targetStyle, vbNull)
                Next
            Next

        Catch ex As Exception
            MsgBox("Failed to import map: " & ex.Message)
        End Try
    End Sub

    Private Sub SplashMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplashMapToolStripMenuItem.Click
                initMap(New SplashMap())
    End Sub
    '=========================Display Engine=========================
    'Public Variables
    Public CharacterStartX = "1", CharacterStartY = "5", CharacterStyle = "idle", CharacterCurrentX = 1, CharacterCurrentY = 5
    Dim CharToPos = "X" & CharacterStartX & "Y" & CharacterStartY
    Dim CharFromPos = "X" & CharacterStartX & "Y" & CharacterStartY

    Private Sub AsciiToKeyCharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsciiToKeyCharToolStripMenuItem.Click
        DebugKeyCharConverter.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlacePixel(CharToPos, CharacterStyle, vbNull)

    End Sub

    Public Sub PlacePixel(toPos, Style, Special)
        Dim CharCursor As PictureBox = Me.Controls(CharFromPos)
        Try
            CharCursor.Image = My.Resources.null
        Catch ex As Exception
        End Try
        CharCursor = Me.Controls(toPos)
        DisplayCharScreen.Text = "True"
        Try
            CharCursor.Image = My.Resources.ResourceManager.GetObject(Style)
        Catch ex As Exception
            DisplayCharScreen.Text = "False"
        End Try
        CharFromPos = CharToPos
    End Sub


    '==========================Movement Engine===========================
    Private Sub GameEngine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(97) Then
            PlayerLeft()
        ElseIf e.KeyChar = Chr(100) Then
            PlayerRight()
        ElseIf e.KeyChar = Chr(115) Then
            PlayerDown()
        ElseIf e.KeyChar = Chr(119) Then
            PlayerUp()
        End If
        DisplayKey.Text = e.KeyChar
    End Sub

    Public Sub PlayerGoTo(pos)
        Try
            PlacePixel(CharToPos, "idle", vbNull)
            DisplayPos.Text = CharToPos
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TeleportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeleportToolStripMenuItem.Click
        DebugTeleport.ShowDialog()
    End Sub

    Private Sub PlayerUp()
        CharacterCurrentX += -1
        CharToPos = "X" & CharacterCurrentX & "Y" & CharacterCurrentY
        PlacePixel(CharToPos, "idle", vbNull)
        DisplayPos.Text = CharToPos
    End Sub

    Private Sub PlayerDown()
        CharacterCurrentX += 1
        CharToPos = "X" & CharacterCurrentX & "Y" & CharacterCurrentY
        PlacePixel(CharToPos, "idle", vbNull)
        DisplayPos.Text = CharToPos
    End Sub


    Private Sub PlayerLeft()
        CharacterCurrentY += -1
        CharToPos = "X" & CharacterCurrentX & "Y" & CharacterCurrentY
        PlacePixel(CharToPos, "idle", vbNull)
        DisplayPos.Text = CharToPos
    End Sub

    Private Sub PlayerRight()
        CharacterCurrentY += 1
        CharToPos = "X" & CharacterCurrentX & "Y" & CharacterCurrentY
        PlacePixel(CharToPos, "idle", vbNull)
        DisplayPos.Text = CharToPos
    End Sub


End Class
