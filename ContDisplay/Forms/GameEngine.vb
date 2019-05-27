Public Class GameEngine

    Private Sub SavingExperimentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavingExperimentToolStripMenuItem.Click
        FileWrite.Show()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
        GameEngine_Load(Me, EventArgs.Empty)
    End Sub


    '=========================Map====================
    Public CurrentMapFile = "null"
    Public PlayerTransport = "Foot"
    'Define each map
    Public MapSplash_Part1 As SplashMap = New SplashMap()
    ' Public MapSplash_Part2 As SplashMap_Part2 = New SplashMap_Part2()

    Public Sub reinstantiateMap()
        Dim MapSplash_Part1 As SplashMap = New SplashMap()
        '    Dim MapSplash_Part2 As SplashMap_Part2 = New SplashMap_Part2()
        Return
    End Sub

    Public displayArray(9, 9)
    Public currentMap


    Private Sub initMap(targetmap)
        currentMap = targetmap
        CurrentMapFile = targetmap.ToString
        targetmap.Initialise()
        My.Computer.Audio.Stop()
        Dim resourceFilePath As String
        If System.Diagnostics.Debugger.IsAttached() Then
            ResourceFilePath = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\resources\")
        Else
            ResourceFilePath = Application.StartupPath & "\resources\"

        End If
        bgplayer.close()
        bgplayer.URL = resourceFilePath & "\Music\" & currentMap.MapTrack & ".wav"
        currentMap.mapdrawn = currentMap.charset
        Try
            For rowcount = 0 To 9
                For columncount = 0 To 9
                    displayArray(rowcount, columncount) = currentMap.charset(rowcount, columncount)
                Next
            Next
        Catch
        End Try
        movedisplay(0, 0)

        PlacePixel("null", "null", "null", "initDrawn")
            CharacterCurrentX = currentMap.CharacterStartPositionX.ToString
            CharacterCurrentY = currentMap.CharacterStartPositionY.ToString
            DisplayPos.Text = CharToPos
            CursorUI(currentMap.CharSet(CharacterCurrentX - 1, CharacterCurrentY - 1))
            DisplayArea.Text = currentMap.MapName
            DisplayLevel.Text = currentMap.MapFamily
            DisplayID.Text = currentMap.MapPart
            PlacePixel(currentMap.CharacterStartPositionX.ToString, currentMap.CharacterStartPositionY.ToString, CharacterStyle, "null")


    End Sub

    Private totalofsetx, totalofsety
    Private Sub movedisplay(ofsetx, ofsety)
        totalofsetx += ofsetx
        totalofsety += ofsety

        If charactermapposy = 1 And ofsetx = -1 Then
            Exit Sub
        ElseIf charactermapposx = 1 And ofsetY = -1 Then
            Exit Sub
        ElseIf charactermapposx = currentMap.xres Then
            Exit Sub
        ElseIf charactermapposy = currentMap.yres Then
            Exit Sub
        End If

        For rowcount = 0 To 9 Step 1
            For columncount = 0 To 9 Step 1
                displayArray(rowcount, columncount) = currentMap.charset(totalofsetx + rowcount, totalofsety + columncount)
                Dim targetStyle = displayArray(rowcount, columncount)
                PlacePixel(rowcount + 1, columncount + 1, targetStyle, "NoOverdraw")
                PlacePixel(rowcount + 1, columncount + 1, targetStyle, "Background")
            Next
        Next
        currentMap.mapdrawn = displayArray

        If ofsety < 0 Then
            charactermapposy = CharacterCurrentY + totalofsety
        Else
            charactermapposy = CharacterCurrentY + totalofsety - 1
        End If

        'If ofsety > 0 Then
        '    charactermapposy = CharacterCurrentY + totalofsety - 1
        'Else
        '    charactermapposy = CharacterCurrentY + totalofsety
        'End If

        PlacePixel(CharacterCurrentX, CharacterCurrentY, CharacterStyle, "null")
    End Sub



    Private Sub GameEnging() Handles Me.Closing
        'FileWrite.WriteToTable(2, 3, currentMap.MapName)
        'FileWrite.WriteToTable(3, 3, CharacterCurrentX)
        'FileWrite.WriteToTable(4, 3, CharacterCurrentY)
        'FileWrite.SaveToFile()
    End Sub

    Private Sub SplashMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SplashMapToolStripMenuItem.Click
        initMap(MapSplash_Part1)
    End Sub
    '=========================Display Engine=========================
    'Public Variables
    Public CharacterStartX = "1", CharacterStartY = "5", CharacterStyle = "idle", CharacterCurrentX = 1, CharacterCurrentY = 5, CharacterPreviousX = 1, CharacterPreviousY = 5
    Dim CharToPos = "X" & CharacterStartX & "Y" & CharacterStartY
    Dim CharFromPos = "X" & CharacterStartX & "Y" & CharacterStartY
    Public charactermapposx, charactermapposy

    Private Sub AsciiToKeyCharToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsciiToKeyCharToolStripMenuItem.Click
        DebugKeyCharConverter.Show()
    End Sub


    Private storyline
    Public Sub GameEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Clear()
        Me.InitializeComponent()
        Dim tiledat As TileData = New TileData
        tiledat.Initialise()
        MapSplash_Part1.Initialise()
        'MapSplash_Part2.Initialise()
        'ALL_MAPS INITALISE
        FileWrite.LoadUser()
        Dim LoadMap = FileWrite.LoadWorld

        Me.KeyPreview = True
        CurrentHealth = 10
        DisplayHealth.Text = CurrentHealth & " / " & MaxHealth

        If LoadMap = "SplashMap" Then
            initMap(New SplashMap())
            'ElseIf LoadMap = "SplashMap_Part2" Then
            '    initMap(New SplashMap_Part2)
        Else
            DisplayNotification.Text = "Unable to load saved map"
            initMap(New SplashMap())
            PlayerTileDetect()
            Exit Sub
        End If

        Select Case FileWrite.ReadFromTable(1, 5)
            Case "SplashStory"
                storyline = New SplashStory()
            Case Else
                storyline = New SplashStory()
                DisplayNotification.Text = ("Unable to load story line from file")
        End Select
        storyline.progress = FileWrite.ReadFromTable(2, 5)
        Dim toX = FileWrite.ReadFromTable(3, 3)
            CharacterCurrentX = toX
        Dim toY = FileWrite.ReadFromTable(4, 3)
        CharacterCurrentY = toY
        DisplayPos.Text = CharToPos
        PlacePixel(toX, toY, CharacterStyle, "Null")
        DisplayNotification.Text = "Loaded map: " & LoadMap
        storyline.trigger("StartGame")
        If System.Diagnostics.Debugger.IsAttached() Then
            MenuStrip1.Show()
            DisplayNotification.Visible = True
            DebugMode = True
        End If
        charactermapposx = CharacterCurrentX
        charactermapposy = CharacterCurrentY
    End Sub

    Public draw10 = False
    Public Sub PlacePixel(toX, toY, Style, Special)
        Dim topos = "X" & toX & "Y" & toY
        Dim CharCursor As PictureBox = Me.Controls(CharFromPos)
        Try
            If Special = "NoOverdraw" Then
                Exit Try
            ElseIf Special = "Background" Then
                CharCursor = Me.Controls(topos)
                CharCursor.BackgroundImage = My.Resources.ResourceManager.GetObject(Style)
                Exit Sub
            ElseIf Special = "initDrawn" Then
                currentMap.MapDrawn = currentMap.Charset
                Exit Sub
            ElseIf Special = "UpdateDrawn" Then
                currentMap.Mapdrawn(toX - 1, toY - 1) = Style
                CharCursor = Me.Controls(topos)
                CharCursor.Image = My.Resources.ResourceManager.GetObject(Style)
                PlacePixel(toX, toY, Style, "Background")
                Exit Sub
            Else
                Dim targetStyle = currentMap.MapDrawn(CharacterPreviousX - 1, CharacterPreviousY - 1).ToString
                CharCursor = Me.Controls(CharFromPos)
                CharCursor.Image = My.Resources.ResourceManager.GetObject(targetStyle)
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        CharCursor = Me.Controls(topos)
        Try
            CharCursor.Image = My.Resources.ResourceManager.GetObject(Style)
            If Special = "NoOverdraw" Then
                Exit Sub
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        CharFromPos = topos

        CharacterPreviousX = CharacterCurrentX
        CharacterPreviousY = CharacterCurrentY
    End Sub
    '==========================Movement / Control Engine===========================
    Private Sub GameEngine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim key = e.KeyChar
        If key = "a" Or key = "A" Then
            PlayerLeft()
        ElseIf key = "d" Or key = "D" Then
            PlayerRight()
        ElseIf key = "s" Or key = "S" Then
            PlayerDown()
        ElseIf key = "w" Or key = "W" Then
            PlayerUp()
        ElseIf key = "1" Then
            PlayerAction(1)
        ElseIf key = "2" Then
            PlayerAction(2)
        ElseIf key = "3" Then
            PlayerAction(3)
        ElseIf key = "`" Then
            If DebugMode = True Then
                FileWrite.SaveToFile()
                DisplayNotification.Text = "Game Saved"
            End If
        ElseIf key = "+" Then
            If DebugMode Then
                ReloadToolStripMenuItem_Click(Me, EventArgs.Empty)
            End If
        ElseIf key = "_" Then
            If DebugMode = True Then
                MenuStrip1.Hide()
                DisplayNotification.Visible = True
                DebugMode = False
            Else
                MenuStrip1.Show()
                DisplayNotification.Visible = True
                DisplayNotification.Text = "Entered Debug Mode"
                DebugMode = True
            End If
        End If
        DisplayKey.Text = e.KeyChar
    End Sub
    Public DebugMode = False
    'Movement
    Public Sub PlayerGoTo(tox, toy)
        Try
            PlacePixel(tox, toy, "idle", "Null")
            DisplayPos.Text = CharFromPos
            CharacterCurrentX = tox
            CharacterCurrentY = toy
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TeleportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        DebugTeleport.ShowDialog()
    End Sub

    Private Sub PlayerUp()
        If Selectermode = True Then
            SelecterUI("Up", "null")
            Exit Sub
        End If

        If FileWrite.ReadFromTable(1, 5) = "SplashStory" Then
            If movecount < 5 Then
                movecount += 1
            ElseIf storyline.progress < 3 Then
                storyline.trigger("5Movement")
            End If
        End If
        If PlayerBoundCheck("Up") = False Then
            Exit Sub
        End If

        If CharacterCurrentX = 1 Then
            'movedisplay(0, -1)
            'charactermapposx += -1
            'PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
            Exit Sub
        End If
        charactermapposx += -1
        CharacterCurrentX += -1
        PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
        DisplayPos.Text = CharFromPos
        PlayerTileDetect()
    End Sub

    Private movecount
    Private Sub PlayerDown()
        If Selectermode = True Then
            SelecterUI("Down", "null")
            Exit Sub
        End If

        If PlayerBoundCheck("Down") = False Then
            Exit Sub
        End If

        If FileWrite.ReadFromTable(1, 5) = "SplashStory" Then
            If movecount < 5 Then
                movecount += 1
            ElseIf storyline.progress < 3 Then
                storyline.trigger("5Movement")
            End If
        End If

        If CharacterCurrentX = 10 Then
            movedisplay(1, 0)
            charactermapposx += 1
            PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
            Exit Sub
        End If
        charactermapposx += 1
        CharacterCurrentX += 1
        PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
        DisplayPos.Text = CharFromPos
        PlayerTileDetect()
    End Sub


    Private Sub PlayerLeft()
        If Selectermode = True Then
            SelecterUI("Left", "null")
            Exit Sub
        End If
        If PlayerBoundCheck("Left") = False Then
            Exit Sub
        End If

        If FileWrite.ReadFromTable(1, 5) = "SplashStory" Then
            If movecount < 5 Then
                movecount += 1
            ElseIf storyline.progress < 3 Then
                storyline.trigger("5Movement")
            End If
        End If
        If CharacterCurrentY = 1 Then
            movedisplay(-1, 0)
            charactermapposy += -1
            PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
            Exit Sub
        End If
        charactermapposy += -1
        CharacterCurrentY += -1
        PlacePixel(CharacterCurrentX, CharacterCurrentY, "idleLeft", "Null")
        DisplayPos.Text = CharFromPos
        PlayerTileDetect()
    End Sub

    Private Sub PlayerRight()
        If Selectermode = True Then
            SelecterUI("Right", "null")
            Exit Sub
        End If

        If FileWrite.ReadFromTable(1, 5) = "SplashStory" Then
            If movecount < 5 Then
                movecount += 1
            ElseIf storyline.progress < 3 Then
                storyline.trigger("5Movement")
            End If
        End If



        If PlayerBoundCheck("Right") = False Then
            Exit Sub
        End If

        If CharacterCurrentY = 10 Then
            'movedisplay(1, 0)
            charactermapposy += 1
            PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
            Exit Sub
        End If
        charactermapposy += 1
        CharacterCurrentY += 1
        PlacePixel(CharacterCurrentX, CharacterCurrentY, "idle", "Null")
        DisplayPos.Text = CharFromPos
        PlayerTileDetect()
    End Sub

    'Active Player
    Private Function PlayerBoundCheck(Dir)
        Select Case Dir
            Case "Right"
                Dim maptile = currentMap.charset(charactermapposx - 1, charactermapposy)
                If charactermapposy = currentMap.yres Then
                    Return (False)
                ElseIf CharacterCurrentY = 10 Then

                    movedisplay(0, 1)
                End If
                'moves before tile scheck
                If TileBoundCheck(maptile) = False Then
                    Return (False)
                End If
                Return (True)


            Case "Left"
                Try
                    Dim maptile = currentMap.charset(charactermapposx - 1, charactermapposy - 2)

                    If charactermapposy = 1 Then
                        Movementerr()
                        Return (False)
                    ElseIf CharacterCurrentY = 1 Then

                        movedisplay(0, -1)
                        If TileBoundCheck(maptile) = False Then
                            Return (False)
                        End If
                        Exit Function
                    End If



                    If TileBoundCheck(maptile) = False Then
                        Return (False)
                    End If
                Catch
                    Movementerr()
                End Try
                Return (True)
            Case "Up"

                If CharacterCurrentX = 1 Then
                    Movementerr()
                    Return (False)
                End If

                Dim maptile = currentMap.charset(charactermapposx - 2, charactermapposy - 1)
                If TileBoundCheck(maptile) = False Then
                    Return (False)
                End If
                Return (True)
            Case "Down"
                If CharacterCurrentX - 1 = currentMap.xres Then
                    Movementerr()
                    Return (False)
                End If

                Dim maptile = currentMap.charset(charactermapposx, charactermapposy - 1)
                If TileBoundCheck(maptile) = False Then
                    Return (False)
                End If
                Return (True)
        End Select
    End Function

    Private Sub Movementerr()
        My.Computer.Audio.Play(My.Resources.WallWalk, AudioPlayMode.Background)
    End Sub

    Public SelectedTile
    Private Function TileBoundCheck(TileToCheck)
        Dim tileDat As TileData = New TileData
        tileDat.Initialise()
        'XXX EFFICIENCY
        CursorUI(TileToCheck)
        Select Case PlayerTransport
            Case "Foot"
                Select Case TileToCheck
                    Case "PathBlack"
                        If tileDat.TileData(0, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "PathExit"
                        If tileDat.TileData(1, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "RockBig"
                        If tileDat.TileData(2, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "RockSmall"
                        If tileDat.TileData(3, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "TreeSmall"
                        SelectedTile = "TreeSmall"
                        CursorUI("TreeSmall")
                        If tileDat.TileData(4, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "WaterDown"
                        If tileDat.TileData(5, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "SandPlain"
                        If tileDat.TileData(6, 1) = False Then
                            Return (False)
                            Movementerr()
                        End If
                    Case "SandCactus"
                        PlayerHarm(1)
                        If tileDat.TileData(7, 1) = False Then
                            Return (False)
                        End If
                    Case "PathAxe"
                        SelectedTile = "PathAxe"
                        CursorUI("PathAxe")
                        If tileDat.TileData(8, 1) = False Then
                            Return (False)
                        End If
                    Case "SavePoint"
                        SelectedTile = "SavePoint"
                        CursorUI("SavePoint")
                        If tileDat.TileData(9, 1) = False Then
                            Return (False)
                        End If
                    Case "StoryPointerLeft"
                        storyline.trigger(TileToCheck)
                        If tileDat.TileData(10, 1) = False Then
                            Return (False)
                        End If
                        currentMap.initialise()
                        Dim style = currentMap.charset(CharacterCurrentX - 1, CharacterCurrentY - 2)
                        PlacePixel(CharacterCurrentX, CharacterCurrentY - 1, style, "UpdateDrawn")
                    Case "StoryPointerRight"
                        storyline.trigger(TileToCheck)
                        If tileDat.TileData(10, 1) = False Then
                            Return (False)
                        End If
                        storyline.trigger(TileToCheck)
                        currentMap.initialise()
                        Dim style = currentMap.charset(CharacterCurrentX - 1, CharacterCurrentY)
                        PlacePixel(CharacterCurrentX, CharacterCurrentY + 1, style, "UpdateDrawn")
                    Case "StoryPointerUp"
                        storyline.trigger(TileToCheck)
                        If tileDat.TileData(10, 1) = False Then
                            Return (False)
                        End If
                        storyline.trigger(TileToCheck)
                        currentMap.initialise()
                        Dim style = currentMap.charset(CharacterCurrentX - 2, CharacterCurrentY - 1)
                        PlacePixel(CharacterCurrentX - 1, CharacterCurrentY, style, "UpdateDrawn")
                    Case "StoryPointerDown"
                        storyline.trigger(TileToCheck)
                        If tileDat.TileData(10, 1) = False Then
                            Return (False)
                        End If
                        storyline.trigger(TileToCheck)
                        currentMap.initialise()
                        Dim style = currentMap.charset(CharacterCurrentX, CharacterCurrentY - 1)
                        PlacePixel(CharacterCurrentX - 1, CharacterCurrentY, style, "UpdateDrawn")
                End Select
            Case "Fly"
                If tileDat.TileData(0, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "PathExit"
                If tileDat.TileData(1, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "RockBig"
                If tileDat.TileData(2, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "RockSmall"
                If tileDat.TileData(3, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "TreeSmall"
                If tileDat.TileData(4, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "WaterDown"
                If tileDat.TileData(5, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "SandPlain"
                If tileDat.TileData(6, 0) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "SandCactus"

                If tileDat.TileData(7, 0) = False Then
                    Return (False)
                End If
            Case "Tank"
                If tileDat.TileData(0, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "PathExt"
                If tileDat.TileData(1, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "RockBig"
                If tileDat.TileData(2, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "RockSmall"
                If tileDat.TileData(3, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "TreeSmall"
                If tileDat.TileData(4, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "WaterDown"
                If tileDat.TileData(5, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "SandPlain"
                If tileDat.TileData(6, 2) = False Then
                    Return (False)
                    Movementerr()
                End If
            Case "SandCactus"
                If tileDat.TileData(7, 2) = False Then
                    Return (False)
                End If
        End Select
        Return (True)
    End Function

    Private Sub PlayerTileDetect()
        Try
            Dim MapTile = currentMap.charSet(charactermapposx - 1, charactermapposy - 1)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub PlayerAction(ActionChar)
        Try
            If Selectermode = True Then
                SelectedTile = currentMap.charset(SelecterX - 1, SelecterY - 1)
                Select Case SelecterItem
                    Case "Axe"
                        Select Case SelectedTile
                            Case "TreeSmall"
                                If ActionChar = 1 Then
                                    CursorUI("Apple")
                                    PlayerHarm(-1)
                                    SelecterUI("Disable", "null")
                                    PlacePixel(SelecterX, SelecterY, "PathBlack", "UpdateDrawn")

                                End If
                                Exit Sub
                            Case Else
                                SelecterUI("Disable", "null")
                        End Select
                    Case Else
                        SelecterUI("Disable", "null")
                End Select

            End If

            Select Case SelectedTile
                Case "PathExit"
                    If ActionChar = 1 Then
                        reinstantiateMap()
                        initMap(currentMap.exitSet(CharacterCurrentX - 1, CharacterCurrentY - 1))
                    End If
                Case "TreeSmall"
                    If ActionChar = 1 Then
                        CursorUI("Apple")
                        PlayerHarm(-1)
                    End If
                Case "PathAxe"
                    If ActionChar = 1 Then
                        FileWrite.WriteToTable(2, 2, True)
                        SelecterUI("Enable", "Axe")
                        CursorUI("Selecter")
                    End If
                Case "SavePoint"
                    If ActionChar = 1 Then
                        FileWrite.WriteToTable(2, 3, currentMap.MapName)
                        FileWrite.WriteToTable(3, 3, CharacterCurrentX)
                        FileWrite.WriteToTable(4, 3, CharacterCurrentY)
                        FileWrite.SaveToFile()
                        CursorUI("Saved")
                    End If
                Case Else
                    Exit Select
            End Select
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    '===========Active UI==========
    Private Selectermode = False
    Private SelecterItem = "null"
    Private SelecterX
    Private SelecterY

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TeleportToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TeleportToolStripMenuItem.Click
        DebugTeleport.ShowDialog()
    End Sub

    Private Sub btnMute_Click(sender As Object, e As EventArgs) Handles btnMute.Click
        bgplayer.close()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub SelecterUI(Mode, item)
        Try
            Dim selectCursor As PictureBox = Me.Controls("X" & SelecterX & "Y" & SelecterY)
            If Mode = "Enable" Then
                Selectermode = True
                SelecterItem = item
                SelecterY = CharacterCurrentY
                SelecterX = CharacterCurrentX
                selectCursor = Me.Controls("X" & CharacterCurrentX & "Y" & CharacterCurrentY)
                selectCursor.BorderStyle = BorderStyle.Fixed3D
                Exit Sub
            ElseIf Mode = "Disable" Then
                selectCursor.BorderStyle = BorderStyle.None
                Selectermode = False
                Exit Sub
            End If

            If Mode = "Action1" Then
                DisplayNotification.Text = "Action1"
                Selectermode = False
                selectCursor.BorderStyle = BorderStyle.None
                Exit Sub
            ElseIf Mode = "Action2" Then
                DisplayNotification.Text = "Action2"
                Selectermode = False
                selectCursor.BorderStyle = BorderStyle.None
                Exit Sub
            ElseIf Mode = "Action3" Then
                DisplayNotification.Text = "Action3"
                Selectermode = False
                selectCursor.BorderStyle = BorderStyle.None
                Exit Sub

            ElseIf Mode = "Up" Then
                selectCursor.BorderStyle = BorderStyle.None
                SelecterX += -1
                selectCursor = Me.Controls("X" & SelecterX & "Y" & SelecterY)
            ElseIf Mode = "Down" Then
                selectCursor.BorderStyle = BorderStyle.None
                SelecterX += 1
                selectCursor = Me.Controls("X" & SelecterX & "Y" & SelecterY)
            ElseIf Mode = "Left" Then
                selectCursor.BorderStyle = BorderStyle.None
                SelecterY += -1
                selectCursor = Me.Controls("X" & SelecterX & "Y" & SelecterY)
            ElseIf Mode = "Right" Then
                selectCursor.BorderStyle = BorderStyle.None
                SelecterY += 1
                selectCursor = Me.Controls("X" & SelecterX & "Y" & SelecterY)
            End If
            selectCursor.BorderStyle = BorderStyle.Fixed3D
        Catch
            Selectermode = False
        End Try
    End Sub


    Private Sub CursorUI(tile)
        SelectedTile = tile
        Try
            PicCursor.Image = My.Resources.ResourceManager.GetObject(tile)
        Catch
        End Try
        Select Case tile
            Case "Selecter"
                lblCursorTitle.Text = "Selecter"
                lblCursor1.Text = "1: Use item on"
                lblCursor2.ResetText()
                lblCursor3.Text = "3: Cancel"
            Case "PathExit"
                reinstantiateMap()
                lblCursorTitle.Text = "Exit to " & currentMap.exitName(CharacterCurrentX - 1, CharacterCurrentY - 1)
                lblCursor1.Text = "1: Exit"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "PathBlack"
                lblCursorTitle.Text = "Path"
                lblCursor1.Text = "Glad i'm"
                lblCursor2.Text = "wearing shoes!"
                lblCursor3.ResetText()
            Case "RockBig"
                lblCursorTitle.Text = "Boulder"
                lblCursor1.Text = "Too big to climb"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "RockSmall"
                lblCursorTitle.Text = "Pile Of Rocks"
                lblCursor1.Text = "To unstable"
                lblCursor2.Text = "To climb"
                lblCursor3.ResetText()
            Case "TreeSmall"
                lblCursorTitle.Text = "Tree"
                lblCursor1.Text = "1: Shake"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "WaterDown"
                lblCursorTitle.Text = "Water"
                lblCursor1.Text = "I can't swim!"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "SandCactus"
                lblCursorTitle.Text = "A cactus"
                lblCursor1.Text = "Ouch"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "SandPlain"
                lblCursorTitle.Text = "Beach"
                lblCursor1.Text = "How lovely!"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "Apple"
                lblCursorTitle.Text = "Apple"
                lblCursor1.Text = "+1 HP"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "PathAxe"
                lblCursorTitle.Text = "Axe"
                lblCursor1.Text = "1: Use"
                lblCursor2.Text = "2: Pick up"
                lblCursor3.ResetText()
            Case "SavePoint"
                lblCursorTitle.Text = "Save Point"
                lblCursor1.Text = "1: Use"
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "Saved"
                lblCursorTitle.Text = "Saved!"
                lblCursor1.ResetText()
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "StoryPointerLeft"
                lblCursorTitle.Text = "A quest!"
                lblCursor1.ResetText()
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "StoryPointerRight"
                lblCursorTitle.Text = "A quest!"
                lblCursor1.ResetText()
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "StoryPointerUp"
                lblCursorTitle.Text = "A quest!"
                lblCursor1.ResetText()
                lblCursor2.ResetText()
                lblCursor3.ResetText()
            Case "StoryPointerDown"
                lblCursorTitle.Text = "A quest!"
                lblCursor1.ResetText()
                lblCursor2.ResetText()
                lblCursor3.ResetText()
        End Select
    End Sub
    'XXX Array for cursor, seperate file
    '============Passive - Game=========
    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        'GameShop.ShowDialog()
    End Sub

    '============Active - Game==========
    'Public buildMode As Boolean = False
    'Public Sub Build(Item)
    '    buildMode = True
    '    Select Case Item
    '        Case "Cylo"
    '            PicCursor.Image = My.Resources.MisileCylo
    '            lblCursorTitle.Text = "Build"
    '            lblCursor1.Text = "Misile Cylo"
    '    End Select
    'End Sub

    Public MaxHealth = 10
    Public CurrentHealth = 10
    Private Sub PlayerHarm(Damage)
        If CurrentHealth > (CurrentHealth - Damage) Then
            DisplayHealth.Text = CurrentHealth - Damage & " / " & MaxHealth
            CurrentHealth += -Damage
            My.Computer.Audio.Play(My.Resources.Hurt, AudioPlayMode.Background)
            If CurrentHealth = 0 Then
                bgplayer.close()
                death.Show()
                death.death_Load(Me, EventArgs.Empty)
                Me.Controls.Clear()
                Me.Close()
            End If
        Else
            If CurrentHealth = 10 Then
                Exit Sub
            End If
            CurrentHealth += -Damage
            DisplayHealth.Text = CurrentHealth & " / " & MaxHealth
        End If
    End Sub
End Class
