Public Class PlayerClass
    ' A class which holds the information of a player in the game
    Property Name As String
    Property Money As Integer = 0
    Property Qansd As Integer = 0 ' the no. of questions correctly answered by a player
    Property Passes As Integer = 5

    ' placeholder constructor method
    Sub New()

    End Sub

    ' main constructor method
    Sub New(name As String)
        Me.Name = name
    End Sub
End Class