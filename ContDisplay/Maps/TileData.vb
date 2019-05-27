Public Class TileData
    '===Buildings/entities===

    '=====Texture====
    Public TileData(10, 2)



    Public Sub Initialise()

        'PathBlack - Row 0 

        'Air Movement
        TileData(0, 0) = True
        'GroundMovement
        TileData(0, 1) = True
        'Oversized movement (i.e Tank - Tracks)
        TileData(0, 2) = True

        'PathExit - Row 1
        TileData(1, 0) = True
        TileData(1, 1) = True
        TileData(1, 2) = True

        'RockBig
        TileData(2, 0) = True
        TileData(2, 1) = False
        TileData(2, 2) = False

        'RockSmall
        TileData(3, 0) = True
        TileData(3, 1) = False
        TileData(3, 2) = True

        'TreeSmall
        TileData(4, 0) = True
        TileData(4, 1) = False
        TileData(4, 2) = False

        'WaterDown
        TileData(5, 0) = True
        TileData(5, 1) = False
        TileData(5, 2) = False
        'XXX Swim?

        'SandPlain
        TileData(6, 0) = True
        TileData(6, 1) = True
        TileData(6, 2) = False

        'SandCactus
        TileData(7, 0) = True
        TileData(7, 1) = False
        TileData(7, 2) = True

        'PathAxe
        TileData(8, 0) = True
        TileData(8, 1) = False
        TileData(8, 2) = True

        'SavePoint
        TileData(9, 0) = True
        TileData(9, 1) = False
        TileData(9, 2) = False

        'Quest Pointers
        TileData(10, 0) = True
        TileData(10, 1) = True
        TileData(10, 2) = True
    End Sub
End Class