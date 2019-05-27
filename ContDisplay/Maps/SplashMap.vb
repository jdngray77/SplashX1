Public Class SplashMap
    '======Map info=====
    Public pixelcount = 100 'unused

    'from 1, not zero
    Public xRes = 9
    Public yRes = 19
    Public style As String = "dynamic"
    'Static MUST be 10*10

    'Stores the map thats actually drawn as it changes throughout the game.
    Public MapDrawn(10, 20)

    Public MapName = "SplashMap"
    Public MapFamily = "Splash"
    Public MapPart = "1"
    Public MapTrack = "CrimsonDrive"
    Public CharacterStartPositionX = 1
    Public characterStartPositionY = 5
    Public storyline = "SplashStory"
    'Active Components
    'Public exitSet(9, 9)
    'Public exitName(9, 9)

    Public charSet(10, 20) As Object

    Public Sub Initialise()
        'Exits
        '    exitSet(8, 9) = GameEngine.MapSplash_Part2
        '   exitSet(9, 9) = GameEngine.MapSplash_Part2

        'exitName(8, 9) = "Intro"
        'exitName(9, 9) = "Intro"

        'Character Set
        'Row One
        charSet(0, 0) = "TreeSmall"
        charSet(0, 1) = "TreeSmall"
        charSet(0, 2) = "TreeSmall"
        charSet(0, 3) = "RockSmall"
        charSet(0, 4) = "PathBlack"
        charSet(0, 5) = "PathBlack"
        charSet(0, 6) = "TreeSmall"
        charSet(0, 7) = "RockBig"
        charSet(0, 8) = "TreeSmall"
        charSet(0, 9) = "TreeSmall"
        charSet(0, 10) = "PathBlack"
        charSet(0, 11) = "PathBlack"
        charSet(0, 12) = "PathBlack"
        charSet(0, 13) = "PathBlack"
        charSet(0, 14) = "PathBlack"
        charSet(0, 15) = "PathBlack"
        charSet(0, 16) = "PathBlack"
        charSet(0, 17) = "PathBlack"
        charSet(0, 18) = "PathBlack"
        charSet(0, 19) = "PathBlack"

        'Row Two
        charSet(1, 0) = "TreeSmall"
        charSet(1, 1) = "TreeSmall"
        charSet(1, 2) = "TreeSmall"
        charSet(1, 3) = "TreeSmall"
        charSet(1, 4) = "TreeSmall"
        charSet(1, 5) = "PathBlack"
        charSet(1, 6) = "TreeSmall"
        charSet(1, 7) = "PathBlack"
        charSet(1, 8) = "TreeSmall"
        charSet(1, 9) = "TreeSmall"
        charSet(1, 10) = "PathBlack"
        charSet(1, 11) = "PathBlack"
        charSet(1, 12) = "PathBlack"
        charSet(1, 13) = "PathBlack"
        charSet(1, 14) = "PathBlack"
        charSet(1, 15) = "PathBlack"
        charSet(1, 16) = "PathBlack"
        charSet(1, 17) = "PathBlack"
        charSet(1, 18) = "PathBlack"
        charSet(1, 19) = "PathBlack"


        'Row Three
        charSet(2, 0) = "TreeSmall"
        charSet(2, 1) = "TreeSmall"
        charSet(2, 2) = "TreeSmall"
        charSet(2, 3) = "TreeSmall"
        charSet(2, 4) = "PathBlack"
        charSet(2, 5) = "PathBlack"
        charSet(2, 6) = "TreeSmall"
        charSet(2, 7) = "TreeSmall"
        charSet(2, 8) = "TreeSmall"
        charSet(2, 9) = "TreeSmall"
        charSet(2, 10) = "PathBlack"
        charSet(2, 11) = "PathBlack"
        charSet(2, 12) = "PathBlack"
        charSet(2, 13) = "PathBlack"
        charSet(2, 14) = "PathBlack"
        charSet(2, 15) = "PathBlack"
        charSet(2, 16) = "PathBlack"
        charSet(2, 17) = "PathBlack"
        charSet(2, 18) = "PathBlack"
        charSet(2, 19) = "PathBlack"


        'Row Four
        charSet(3, 0) = "TreeSmall"
        charSet(3, 1) = "TreeSmall"
        charSet(3, 2) = "TreeSmall"
        charSet(3, 3) = "TreeSmall"
        charSet(3, 4) = "PathBlack"
        charSet(3, 5) = "RockBig"
        charSet(3, 6) = "TreeSmall"
        charSet(3, 7) = "TreeSmall"
        charSet(3, 8) = "TreeSmall"
        charSet(3, 9) = "TreeSmall"
        charSet(3, 10) = "PathBlack"
        charSet(3, 11) = "PathBlack"
        charSet(3, 12) = "PathBlack"
        charSet(3, 13) = "PathBlack"
        charSet(3, 14) = "PathBlack"
        charSet(3, 15) = "PathBlack"
        charSet(3, 16) = "PathBlack"
        charSet(3, 17) = "PathBlack"
        charSet(3, 18) = "PathBlack"
        charSet(3, 19) = "PathBlack"



        'Row Five
        charSet(4, 0) = "TreeSmall"
        charSet(4, 1) = "TreeSmall"
        charSet(4, 2) = "TreeSmall"
        charSet(4, 3) = "PathBlack"
        charSet(4, 4) = "PathBlack"
        charSet(4, 5) = "PathBlack"
        charSet(4, 6) = "PathBlack"
        charSet(4, 7) = "PathBlack"
        charSet(4, 8) = "TreeSmall"
        charSet(4, 9) = "TreeSmall"
        charSet(4, 10) = "PathBlack"
        charSet(4, 11) = "PathBlack"
        charSet(4, 12) = "PathBlack"
        charSet(4, 13) = "PathBlack"
        charSet(4, 14) = "PathBlack"
        charSet(4, 15) = "PathBlack"
        charSet(4, 16) = "PathBlack"
        charSet(4, 17) = "PathBlack"
        charSet(4, 18) = "PathBlack"
        charSet(4, 19) = "PathBlack"


        'Row six
        charSet(5, 0) = "PathAxe"
        charSet(5, 1) = "PathBlack"
        charSet(5, 2) = "PathBlack"
        charSet(5, 3) = "PathBlack"
        charSet(5, 4) = "PathBlack"
        charSet(5, 5) = "PathBlack"
        charSet(5, 6) = "PathBlack"
        charSet(5, 7) = "PathBlack"
        charSet(5, 8) = "TreeSmall"
        charSet(5, 9) = "TreeSmall"
        charSet(5, 10) = "PathBlack"
        charSet(5, 11) = "PathBlack"
        charSet(5, 12) = "PathBlack"
        charSet(5, 13) = "PathBlack"
        charSet(5, 14) = "PathBlack"
        charSet(5, 15) = "PathBlack"
        charSet(5, 16) = "PathBlack"
        charSet(5, 17) = "PathBlack"
        charSet(5, 18) = "PathBlack"
        charSet(5, 19) = "PathBlack"

        'Row seven
        charSet(6, 0) = "PathBlack"
        charSet(6, 1) = "PathBlack"
        charSet(6, 2) = "PathBlack"
        charSet(6, 3) = "PathBlack"
        charSet(6, 4) = "PathBlack"
        charSet(6, 5) = "PathBlack"
        charSet(6, 6) = "PathBlack"
        charSet(6, 7) = "PathBlack"
        charSet(6, 8) = "TreeSmall"
        charSet(6, 9) = "TreeSmall"
        charSet(6, 10) = "PathBlack"
        charSet(6, 11) = "PathBlack"
        charSet(6, 12) = "PathBlack"
        charSet(6, 13) = "PathBlack"
        charSet(6, 14) = "PathBlack"
        charSet(6, 15) = "PathBlack"
        charSet(6, 16) = "PathBlack"
        charSet(6, 17) = "PathBlack"
        charSet(6, 18) = "PathBlack"
        charSet(6, 19) = "PathBlack"

        'Row Eight
        charSet(7, 0) = "SandPlain"
        charSet(7, 1) = "PathBlack"
        charSet(7, 2) = "PathBlack"
        charSet(7, 3) = "PathBlack"
        charSet(7, 4) = "PathBlack"
        charSet(7, 5) = "PathBlack"
        charSet(7, 6) = "PathBlack"
        charSet(7, 7) = "PathBlack"
        charSet(7, 8) = "TreeSmall"
        charSet(7, 9) = "TreeSmall"
        charSet(7, 10) = "PathBlack"
        charSet(7, 11) = "PathBlack"
        charSet(7, 12) = "PathBlack"
        charSet(7, 13) = "PathBlack"
        charSet(7, 14) = "PathBlack"
        charSet(7, 15) = "PathBlack"
        charSet(7, 16) = "PathBlack"
        charSet(7, 17) = "PathBlack"
        charSet(7, 18) = "PathBlack"
        charSet(7, 19) = "PathBlack"

        'Row Nine
        charSet(8, 0) = "SandPlain"
        charSet(8, 1) = "SandPlain"
        charSet(8, 2) = "PathBlack"
        charSet(8, 3) = "PathBlack"
        charSet(8, 4) = "PathBlack"
        charSet(8, 5) = "RockSmall"
        charSet(8, 6) = "PathBlack"
        charSet(8, 7) = "SavePoint"
        charSet(8, 8) = "PathBlack"
        charSet(8, 9) = "PathBlack"
        charSet(8, 10) = "PathBlack"
        charSet(8, 11) = "PathBlack"
        charSet(8, 12) = "PathBlack"
        charSet(8, 13) = "SavePoint"
        charSet(8, 14) = "PathBlack"
        charSet(8, 15) = "PathBlack"
        charSet(8, 16) = "PathBlack"
        charSet(8, 17) = "PathBlack"
        charSet(8, 18) = "PathBlack"
        charSet(8, 19) = "PathBlack"

        'Row ten
        charSet(9, 0) = "WaterDown"
        charSet(9, 1) = "SandCactus"
        charSet(9, 2) = "SandPlain"
        charSet(9, 3) = "PathBlack"
        charSet(9, 4) = "PathBlack"
        charSet(9, 5) = "PathBlack"
        charSet(9, 6) = "PathBlack"
        charSet(9, 7) = "PathBlack"
        charSet(9, 8) = "PathBlack"
        charSet(9, 9) = "PathBlack"
        charSet(9, 10) = "PathBlack"
        charSet(9, 11) = "PathBlack"
        charSet(9, 12) = "PathBlack"
        charSet(9, 13) = "PathBlack"
        charSet(9, 14) = "PathBlack"
        charSet(9, 15) = "PathBlack"
        charSet(9, 16) = "PathBlack"
        charSet(9, 17) = "PathBlack"
        charSet(9, 18) = "PathBlack"
        charSet(9, 19) = "PathBlack"

        '=====================================


        'Row Two

        'Row Three

        'Row Four

        'Row Five

        'Row six

        'Row seven

        'Row Eight

        'Row Nine

        'Row ten

    End Sub
End Class

'Public Class SplashMap_Part2
'    '======Map info=====
'    Public pixelcount = 100 'unused

'    'from 1, not zero
'    Public xRes = 9
'    Public yRes = 9
'    Public style As String = "static"
'    'Static MUST be 10*10

'    Public MapName = "SplashMap_Part2"
'    Public MapFamily = "Splash"
'    Public MapPart = "2"
'    Public MapTrack = "WavesInFlight"
'    Public CharacterStartPositionX = 9
'    Public characterStartPositionY = 1
'    Public storyline = "SplashStory"
'    '=====Active Components=====
'    'Crreate Arrays
'    Public exitSet(9, 9)
'    Public exitName(9, 9)
'    Public charSet(9, 9) As Object
'    Public MapDrawn(10, 10)

'    Public Sub Initialise()

'        'Exits
'        exitSet(8, 0) = GameEngine.MapSplash_Part1
'        exitName(8, 0) = "Splash"
'        exitSet(9, 0) = GameEngine.MapSplash_Part1
'        exitName(9, 0) = "Splash"

'        'Character Set
'        'Row One
'        charSet(0, 0) = "PathBlack"
'        charSet(0, 1) = "PathBlack"
'        charSet(0, 2) = "PathBlack"
'        charSet(0, 3) = "PathBlack"
'        charSet(0, 4) = "PathBlack"
'        charSet(0, 5) = "PathBlack"
'        charSet(0, 6) = "PathBlack"
'        charSet(0, 7) = "PathBlack"
'        charSet(0, 8) = "PathBlack"
'        charSet(0, 9) = "PathBlack"

'        'Row Two
'        charSet(1, 0) = "PathBlack"
'        charSet(1, 1) = "PathBlack"
'        charSet(1, 2) = "PathBlack"
'        charSet(1, 3) = "PathBlack"
'        charSet(1, 4) = "PathBlack"
'        charSet(1, 5) = "PathBlack"
'        charSet(1, 6) = "PathBlack"
'        charSet(1, 7) = "PathBlack"
'        charSet(1, 8) = "PathBlack"
'        charSet(1, 9) = "PathBlack"

'        'Row Three
'        charSet(2, 0) = "PathBlack"
'        charSet(2, 1) = "PathBlack"
'        charSet(2, 2) = "PathBlack"
'        charSet(2, 3) = "PathBlack"
'        charSet(2, 4) = "PathBlack"
'        charSet(2, 5) = "PathBlack"
'        charSet(2, 6) = "PathBlack"
'        charSet(2, 7) = "PathBlack"
'        charSet(2, 8) = "PathBlack"
'        charSet(2, 9) = "PathBlack"

'        'Row Four

'        charSet(3, 0) = "PathBlack"
'        charSet(3, 1) = "PathBlack"
'        charSet(3, 2) = "PathBlack"
'        charSet(3, 3) = "PathBlack"
'        charSet(3, 4) = "PathBlack"
'        charSet(3, 5) = "PathBlack"
'        charSet(3, 6) = "PathBlack"
'        charSet(3, 7) = "PathBlack"
'        charSet(3, 8) = "PathBlack"
'        charSet(3, 9) = "PathBlack"

'        'Row Five
'        charSet(4, 0) = "PathBlack"
'        charSet(4, 1) = "PathBlack"
'        charSet(4, 2) = "PathBlack"
'        charSet(4, 3) = "PathBlack"
'        charSet(4, 4) = "PathBlack"
'        charSet(4, 5) = "PathBlack"
'        charSet(4, 6) = "PathBlack"
'        charSet(4, 7) = "PathBlack"
'        charSet(4, 8) = "PathBlack"
'        charSet(4, 9) = "PathBlack"

'        'Row six
'        charSet(5, 0) = "PathBlack"
'        charSet(5, 1) = "PathBlack"
'        charSet(5, 2) = "PathBlack"
'        charSet(5, 3) = "PathBlack"
'        charSet(5, 4) = "PathBlack"
'        charSet(5, 5) = "PathBlack"
'        charSet(5, 6) = "PathBlack"
'        charSet(5, 7) = "PathBlack"
'        charSet(5, 8) = "PathBlack"
'        charSet(5, 9) = "PathBlack"

'        'Row seven
'        charSet(6, 0) = "PathBlack"
'        charSet(6, 1) = "PathBlack"
'        charSet(6, 2) = "PathBlack"
'        charSet(6, 3) = "PathBlack"
'        charSet(6, 4) = "PathBlack"
'        charSet(6, 5) = "PathBlack"
'        charSet(6, 6) = "PathBlack"
'        charSet(6, 7) = "PathBlack"
'        charSet(6, 8) = "PathBlack"
'        charSet(6, 9) = "PathBlack"

'        'Row Eight
'        charSet(7, 0) = "PathBlack"
'        charSet(7, 1) = "PathBlack"
'        charSet(7, 2) = "PathBlack"
'        charSet(7, 3) = "PathBlack"
'        charSet(7, 4) = "PathBlack"
'        charSet(7, 5) = "PathBlack"
'        charSet(7, 6) = "PathBlack"
'        charSet(7, 7) = "PathBlack"
'        charSet(7, 8) = "PathBlack"
'        charSet(7, 9) = "PathBlack"

'        'Row Nine
'        charSet(8, 0) = "PathBlack"
'        charSet(8, 1) = "PathBlack"
'        charSet(8, 2) = "PathBlack"
'        charSet(8, 3) = "SavePoint"
'        charSet(8, 4) = "PathBlack"
'        charSet(8, 5) = "PathBlack"
'        charSet(8, 6) = "PathBlack"
'        charSet(8, 7) = "PathBlack"
'        charSet(8, 8) = "PathBlack"
'        charSet(8, 9) = "PathBlack"

'        'Row ten
'        charSet(9, 0) = "PathBlack"
'        charSet(9, 1) = "PathBlack"
'        charSet(9, 2) = "PathBlack"
'        charSet(9, 3) = "PathBlack"
'        charSet(9, 4) = "PathBlack"
'        charSet(9, 5) = "PathBlack"
'        charSet(9, 6) = "PathBlack"
'        charSet(9, 7) = "PathBlack"
'        charSet(9, 8) = "PathBlack"
'        charSet(9, 9) = "PathBlack"
'    End Sub
'End Class