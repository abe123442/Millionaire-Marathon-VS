Public Class PlayerClass
    ' A class which holds the information of a player in the game
    Property Name As String ' The input name of a player in "SetupForm"
    Property Money As Integer = 0 ' The earnings of a player
    Property Qansd As Integer = 0 ' The no. of questions correctly answered by a player
    Property Passes As Integer = 5 ' The total passes a player can have


    ' Constructor method used to instantiate this class
    Sub New(name As String)
        Me.Name = name
    End Sub
End Class