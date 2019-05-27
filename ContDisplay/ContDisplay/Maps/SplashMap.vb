Public Class SplashMap
    'map info
    Public pixelcount = 30
    Public xRes = 9
    Public yRes = 1
    Public style As String = "static"
    'Static MUST be 10*10
    Public charSet(9, 9) As Object

    'Pixel Definitions
    Public Sub Initialise()

        charSet(0, 0) = "idle"
        charSet(0, 1) = "idle"
        charSet(0, 2) = "idle"
        charSet(0, 3) = "idle"
        charSet(0, 4) = "idle"
        charSet(0, 5) = "idle"
        charSet(0, 6) = "idle"
        charSet(0, 7) = "idle"
        charSet(0, 8) = "idle"
        charSet(0, 9) = "idle"

    End Sub


End Class
