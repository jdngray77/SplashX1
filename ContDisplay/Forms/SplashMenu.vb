Public Class SplashMenu
    'XXX MUSIC FROM JOHN SO
    Public Sub SplashMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Splashimg.Image = My.Resources.LegalSplash
        My.Computer.Audio.Play(My.Resources.Splash, AudioPlayMode.Background)
        MenuTimer.Start()
        Sel1.Hide()
        Sel2.Hide()
        Sel3.Hide()
        Sel4.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        menushow = False
    End Sub

    Private menushow = False
    Private Sub MenuTimer_Tick(sender As Object, e As EventArgs) Handles MenuTimer.Tick
        menushow = True
        Menudisplay()
        MenuTimer.Stop()
    End Sub


    Private Menuindex = 1
    Private Sub SplashMenu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If menushow = False Then
            If e.KeyChar = "3" Then
                Splashimg.Image = My.Resources.SplashLogo
                MenuTimer.Stop()
                Menudisplay()
                Exit Sub
            End If
        End If
        If e.KeyChar = "w" Or e.KeyChar = "W" Then
            MenuUpdate("Up")
        ElseIf e.KeyChar = "s" Or e.KeyChar = "W" Then
            MenuUpdate("Down")
        ElseIf e.keychar = "1" Then
            menuselect()
        ElseIf e.KeyChar = "+" Then
            Me.Controls.Clear()
            Me.InitializeComponent()
            SplashMenu_Load(Me, EventArgs.Empty)
        End If
    End Sub


    Private prevCursor = "Sel1"
    Private Sub MenuUpdate(Dir)
        Select Case Dir
            Case "Up"
                If Menuindex = 1 Then
                    Exit Sub
                End If

                Menuindex += -1
            Case "Down"

                If Menuindex = 4 Then
                    Exit Sub
                End If

                Menuindex += 1
        End Select
        Dim selcursor = "Sel" & Menuindex
        Dim cursor As Label = Me.Controls(prevCursor)
        cursor.ResetText()
        cursor = Me.Controls(selcursor)
        cursor.Text = "►"
        prevCursor = selcursor
    End Sub


    Private Sub Menudisplay()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Sel1.Show()
        Sel2.Show()
        Sel3.Show()
        Sel4.Show()
        Sel1.Text = "►"
        menushow = True
    End Sub

    Private Sub menuselect()
        Select Case Menuindex
            Case 1
                'Continue
                Me.Hide()
                GameEngine.Show()
            Case 2
                'New
                Dim intent = MsgBox("This will overwrite the current file, are you sure?", MessageBoxButtons.YesNo)
                Select Case intent
                    Case vbYes
                        Try
                            System.IO.File.Delete("CharData.csv")
                        Catch
                        End Try
                        Me.Hide()
                        GameEngine.Show()
                    Case vbNo
                        Exit Sub
                End Select
            Case 3
                options.show()
            Case 4
                End
        End Select
    End Sub

End Class